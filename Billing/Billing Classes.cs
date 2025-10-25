using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Configuration.Internal;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Management_System.Billing
{
    /// <summary>
    /// Represents a tenant invoice in the Real Estate Management System (REMS), encapsulating metadata,
    /// utility invoice references, penalties, and total billing logic.
    /// </summary>
    /// <remarks>
    /// This class dynamically resolves invoice IDs and aggregates balances across water, electricity,
    /// rental, internet, and penalties. It supports validation, penalty breakdowns, and total computation
    /// based on invoice number and tenant ID.
    /// </remarks>
    internal class Invoice
    {
        /// <summary>
        /// Gets or sets the unique identifier of the tenant associated with this invoice.
        /// </summary>
        /// <remarks>
        /// This value is used to query tenant-specific data such as name, penalties, and utility invoices.
        /// A value of 0 or less typically indicates an uninitialized or invalid tenant reference.
        /// </remarks>
        public int TenantID { get; set; }
        /// <summary>
        /// Gets or sets the unique invoice number used to identify and query invoice records across utility and penalty tables.
        /// </summary>
        /// <remarks>
        /// This value serves as the primary lookup key for retrieving invoice-related data such as balances, statuses, and linked utility IDs.
        /// It must be non-empty to enable invoice resolution.
        /// </remarks>
        public string InvoiceNumber { get; set; }
        /// <summary>
        /// Gets or sets the date when the invoice was issued.
        /// </summary>
        /// <remarks>
        /// This value is used to timestamp the invoice and may be referenced for aging, reporting, or due date calculations.
        /// A default value typically indicates an uninitialized invoice.
        /// </remarks>
        public DateTime InvoiceDate { get; set; }
        /// <summary>
        /// Gets or sets the current status of the invoice, indicating its payment state.
        /// </summary>
        /// <remarks>
        /// Common values include <c>UNPAID</c>, <c>PAID</c>, <c>PARTIAL</c>, and <c>TRANSFERRED</c>.  
        /// This status is used to determine billing progress and may affect reporting, reminders, or eligibility for penalties.
        /// </remarks>
        public InvoiceStatuses Status { get; set; }

        /// <summary>
        /// Gets the full name of the tenant associated with this invoice.
        /// </summary>
        /// <remarks>
        /// This property queries the <c>tbtenants</c> table using the current <c>TenantID</c> and returns the corresponding <c>FullName</c>.
        /// If the <c>TenantID</c> is invalid or no match is found, an empty string is returned.
        /// </remarks>
        /// <returns>
        /// The tenant's full name if found; otherwise, an empty string.
        /// </returns>
        public string TenantName
        {
            get
            {
                if (TenantID <= 0)
                    return "";

                new SelectCommand<tbtenants>()
                    .Select(tbtenants.FullName)
                    .From
                    .StartWhere
                        .Where(tbtenants.TenantID, SQLOperator.Equal, TenantID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                return Internals.DBC.Values[0] ?? "";
            }
        }
        /// <summary>
        /// Gets the unique identifier of the water invoice associated with the current invoice number.
        /// </summary>
        /// <remarks>
        /// This property queries the <see cref="tbwaterinvoice"/> table using the <c>InvoiceNumber</c> to retrieve the corresponding <c>WaterInvoiceID</c>.
        /// If no match is found or the invoice number is blank, it returns 0.
        /// </remarks>
        /// <returns>
        /// The water invoice ID if found; otherwise, 0.
        /// </returns>
        public int WaterInvoiceID
        {
            get
            {
                if (string.IsNullOrWhiteSpace(InvoiceNumber))
                    return 0;

                new SelectCommand<tbwaterinvoice>()
                    .Select(tbwaterinvoice.WaterInvoiceID)
                    .From
                    .StartWhere
                        .Where(tbwaterinvoice.InvoiceNumber, SQLOperator.Equal, "'" + InvoiceNumber + "'")
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                if (Internals.DBC.HasRows)
                    return Convert.ToInt32(Internals.DBC.Values[0]);
                Internals.DBC.CloseReader();
                return 0;
            }
        }
        /// <summary>
        /// Gets the unique identifier of the electricity invoice associated with the current invoice number.
        /// </summary>
        /// <remarks>
        /// This property queries the <c>tbelectricityinvoice</c> table using the <c>InvoiceNumber</c> to retrieve the corresponding <c>ElectricityInvoiceID</c>.
        /// If no match is found or the invoice number is blank, it returns 0.
        /// </remarks>
        /// <returns>
        /// The electricity invoice ID if found; otherwise, 0.
        /// </returns>
        public int ElectricityInvoiceID
        {
            get
            {
                if (string.IsNullOrWhiteSpace(InvoiceNumber))
                    return 0;

                new SelectCommand<tbelectricityinvoice>()
                    .Select(tbelectricityinvoice.ElectricityInvoiceID)
                    .From
                    .StartWhere
                        .Where(tbelectricityinvoice.InvoiceNumber, SQLOperator.Equal, "'" + InvoiceNumber + "'")
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                if (Internals.DBC.HasRows)
                    return Convert.ToInt32(Internals.DBC.Values[0]);
                Internals.DBC.CloseReader();
                return 0;
            }
        }
        /// <summary>
        /// Gets the unique identifier of the rental invoice associated with the current invoice number.
        /// </summary>
        /// <remarks>
        /// This property queries the <c>tbrentalinvoice</c> table using the <c>InvoiceNumber</c> to retrieve the corresponding <c>RentalInvoiceID</c>.
        /// If no match is found or the invoice number is blank, it returns 0.
        /// </remarks>
        /// <returns>
        /// The rental invoice ID if found; otherwise, 0.
        /// </returns>
        public int RentalInvoiceID
        {
            get
            {
                if (string.IsNullOrWhiteSpace(InvoiceNumber))
                    return 0;

                new SelectCommand<tbrentalinvoice>()
                    .Select(tbrentalinvoice.RentalInvoiceID)
                    .From
                    .StartWhere
                        .Where(tbrentalinvoice.InvoiceNumber, SQLOperator.Equal, "'" + InvoiceNumber + "'")
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                if (Internals.DBC.HasRows)
                    return Convert.ToInt32(Internals.DBC.Values[0]);
                Internals.DBC.CloseReader();
                return 0;
            }
        }
        /// <summary>
        /// Gets the unique identifier of the internet invoice associated with the current invoice number.
        /// </summary>
        /// <remarks>
        /// This property queries the <c>tbinternetinvoice</c> table using the <c>InvoiceNumber</c> to retrieve the corresponding <c>InternetInvoiceID</c>.
        /// If no match is found or the invoice number is blank, it returns 0.
        /// </remarks>
        /// <returns>
        /// The internet invoice ID if found; otherwise, 0.
        /// </returns>
        public int InternetInvoiceID
        {
            get
            {
                if (string.IsNullOrWhiteSpace(InvoiceNumber))
                    return 0;

                new SelectCommand<tbinternetinvoice>()
                    .Select(tbinternetinvoice.InternetInvoiceID)
                    .From
                    .StartWhere
                        .Where(tbinternetinvoice.InvoiceNumber, SQLOperator.Equal, "'" + InvoiceNumber + "'")
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                if (Internals.DBC.HasRows)
                    return Convert.ToInt32(Internals.DBC.Values[0]);
                Internals.DBC.CloseReader();
                return 0;
            }
        }
        /// <summary>
        /// Calculates the total amount due for the invoice, including all utility balances and applicable penalties.
        /// </summary>
        /// <remarks>
        /// This property aggregates the <c>BillBalance</c> values from the water, electricity, rental, and internet invoice tables
        /// based on the current <c>InvoiceNumber</c>. It also includes the result of <c>TotalPenalties</c> to reflect any unpaid or
        /// partially paid penalties associated with the tenant. Each utility is queried conditionally based on the presence of a valid invoice ID.
        /// </remarks>
        /// <returns>
        /// The total outstanding amount for the invoice, including utilities and penalties.
        /// </returns>
        public double InvoiceTotal
        {
            get
            {
                double InvT = 0;

                if(WaterInvoiceID > 0)
                {
                    new SelectCommand<tbwaterinvoice>()
                        .Select(tbwaterinvoice.BillBalance)
                        .From
                        .StartWhere
                            .Where(tbwaterinvoice.InvoiceNumber, SQLOperator.Equal, "'" + InvoiceNumber + "'")
                        .EndWhere
                        .ExecuteReader(Internals.DBC);
                    if (Internals.DBC.HasRows)
                        InvT += Convert.ToDouble(Internals.DBC.Values[0]);
                    Internals.DBC.CloseReader();
                }

                if(ElectricityInvoiceID > 0)
                {
                    new SelectCommand<tbelectricityinvoice>()
                        .Select(tbelectricityinvoice.BillBalance)
                        .From
                        .StartWhere
                            .Where(tbelectricityinvoice.InvoiceNumber, SQLOperator.Equal, "'" + InvoiceNumber + "'")
                        .EndWhere
                        .ExecuteReader(Internals.DBC);
                    if (Internals.DBC.HasRows)
                        InvT += Convert.ToDouble(Internals.DBC.Values[0]);
                    Internals.DBC.CloseReader();
                }

                if(RentalInvoiceID > 0)
                {
                    new SelectCommand<tbrentalinvoice>()
                        .Select(tbrentalinvoice.BillBalance)
                        .From
                        .StartWhere
                            .Where(tbrentalinvoice.InvoiceNumber, SQLOperator.Equal, "'" + InvoiceNumber + "'")
                        .EndWhere
                        .ExecuteReader(Internals.DBC);
                    if (Internals.DBC.HasRows)
                        InvT += Convert.ToDouble(Internals.DBC.Values[0]);
                    Internals.DBC.CloseReader();
                }

                if(InternetInvoiceID > 0)
                {
                    new SelectCommand<tbinternetinvoice>()
                        .Select(tbinternetinvoice.BillBalance)
                        .From
                        .StartWhere
                            .Where(tbinternetinvoice.InvoiceNumber, SQLOperator.Equal, "'" + InvoiceNumber + "'")
                        .EndWhere
                        .ExecuteReader(Internals.DBC);
                    if (Internals.DBC.HasRows)
                        InvT += Convert.ToDouble(Internals.DBC.Values[0]);
                    Internals.DBC.CloseReader();
                }

                return InvT;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <c>Invoice</c> class with specified tenant ID, invoice number, invoice date, and status.
        /// </summary>
        /// <param name="SetTenantID">The unique identifier of the tenant associated with the invoice.</param>
        /// <param name="SetInvoiceNumber">The invoice number used to identify and query invoice records.</param>
        /// <param name="SetInvoiceDate">The date the invoice was issued.</param>
        /// <param name="SetStatus">The current status of the invoice, such as <c>Unpaid</c>, <c>Partial</c>, or <c>Paid</c>.</param>
        /// <remarks>
        /// This constructor sets the foundational metadata required for invoice resolution and validation.
        /// Default values are applied when parameters are omitted.
        /// </remarks>
        public Invoice(
            int SetTenantID = 0,
            string SetInvoiceNumber = "",
            DateTime SetInvoiceDate = default,
            InvoiceStatuses SetStatus = InvoiceStatuses.Unknown)
        {
            TenantID = SetTenantID;
            InvoiceNumber = SetInvoiceNumber;
            InvoiceDate = SetInvoiceDate;
            Status = SetStatus;
        }

        /// <summary>
        /// Determines whether the current invoice instance contains valid metadata and identifiers.
        /// </summary>
        /// <remarks>
        /// An invoice is considered valid if it has a positive <c>TenantID</c>, a non-empty <c>InvoiceNumber</c>,
        /// a non-default <c>InvoiceDate</c>, and a defined <c>Status</c> other than <c>Unknown</c>.
        /// This method is typically used to verify readiness for processing or persistence.
        /// </remarks>
        /// <returns>
        /// <c>true</c> if the invoice is valid; otherwise, <c>false</c>.
        /// </returns>
        public bool IsValid()
        {
            return
                TenantID > 0 &&
                !string.IsNullOrWhiteSpace(InvoiceNumber) &&
                InvoiceDate != default &&
                Status != InvoiceStatuses.Unknown;
        }
        /// <summary>
        /// Creates a deep copy of the current <c>Invoice</c> instance.
        /// </summary>
        /// <returns>
        /// A new <see cref="Invoice"/> object with the same <c>TenantID</c>, <c>InvoiceNumber</c>, <c>InvoiceDate</c>, and <c>Status</c> as the original.
        /// </returns>
        /// <remarks>
        /// This method is used to duplicate invoice metadata without sharing references.
        /// Changes made to the cloned invoice will not affect the original instance.
        /// </remarks>
        public Invoice Clone()
        {
            return new Invoice(
                this.TenantID,
                this.InvoiceNumber,
                this.InvoiceDate,
                this.Status);
        }
    }

    /// <summary>
    /// Represents a water billing record for a tenant, including meter readings, charges, deductions, and invoice status.
    /// </summary>
    /// <remarks>
    /// This class encapsulates all logic required to compute water consumption, charges, remaining balances, and applicable deductions.
    /// It dynamically queries tenant, room, building, and billing data to ensure accurate computation and validation.
    /// Designed for modular reuse in billing workflows, reporting modules, and SDK-level integration.
    /// </remarks>
    internal class WaterInvoice
    {
        private int BuildingID
        {
            get
            {
                if (!(TenantID > 0))
                    return 0;

                int rID = 0;

                new SelectCommand<tbtenants>()
                    .Select(tbtenants.RoomID)
                    .From
                    .StartWhere
                        .Where(tbtenants.TenantID, SQLOperator.Equal, TenantID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                rID = Convert.ToInt32(Internals.DBC.Values[0]);

                new SelectCommand<tbrooms>()
                    .Select(tbrooms.BuildingID)
                    .From
                    .StartWhere
                        .Where(tbrooms.RoomID, SQLOperator.Equal, rID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                return Convert.ToInt32(Internals.DBC.Values[0]);
            }
        }

        /// <summary>
        /// Gets or sets the invoice number used to uniquely identify this billing record.
        /// </summary>
        /// <remarks>
        /// This value serves as a lookup key across utility, rental, and penalty tables.  
        /// It must be non-empty to enable invoice resolution and aggregation.
        /// </remarks>
        public string InvoiceNumber { get; set; }
        /// <summary>
        /// Gets or sets the due date for the water invoice payment.
        /// </summary>
        /// <remarks>
        /// This value indicates the deadline by which the tenant must settle the water bill.
        /// It is used in billing logic, reporting, and penalty computation for overdue invoices.
        /// A default or uninitialized value may indicate that the invoice is not yet finalized or scheduled.
        /// </remarks>
        public DateTime DueDate { get; set; }
        /// <summary>
        /// Gets or sets the tenant ID associated with this water invoice.
        /// </summary>
        /// <remarks>
        /// This value links the invoice to a specific tenant record and is used to resolve room, building, balance, and credit data.
        /// A value of 0 or less typically indicates an uninitialized or invalid tenant reference.
        /// </remarks>
        public int TenantID { get; set; }
        /// <summary>
        /// Gets or sets the previous water meter reading for the tenant.
        /// </summary>
        /// <remarks>
        /// This value represents the last recorded reading before the current billing cycle.
        /// It is used in conjunction with <c>PresentReading</c> to calculate consumption.
        /// A negative value indicates invalid input and will result in a failed consumption calculation.
        /// </remarks>
        public double PreviousReading { get; set; }
        /// <summary>
        /// Gets or sets the present water meter reading for the tenant.
        /// </summary>
        /// <remarks>
        /// This value represents the latest recorded reading for the current billing cycle.
        /// It is used alongside <c>PreviousReading</c> to calculate consumption.
        /// A negative value or one lower than the previous reading will invalidate the consumption calculation.
        /// </remarks>
        public double PresentReading { get; set; }
        /// <summary>
        /// Gets or sets the current status of the invoice.
        /// </summary>
        /// <remarks>
        /// This value indicates the payment state of the invoice.
        /// It is used in validation, filtering, and billing logic to determine invoice eligibility and processing behavior.
        /// </remarks>
        public InvoiceStatuses Status { get; set; }

        /// <summary>
        /// Gets the calculated water consumption based on the difference between present and previous meter readings.
        /// </summary>
        /// <remarks>
        /// This property returns <c>-1</c> if either reading is negative or if the present reading is less than the previous reading.
        /// Otherwise, it returns the difference: <c>PresentReading - PreviousReading</c>.
        /// This value is used to compute charges and validate invoice integrity.
        /// </remarks>
        /// <returns>
        /// The consumption value if readings are valid; otherwise, -1.
        /// </returns>
        public double Consumption
        {
            get
            {
                if (PreviousReading < 0 || PresentReading < 0)
                    return -1;

                if (PresentReading < PreviousReading)
                    return -1;

                return PresentReading - PreviousReading;
            }
        }
        /// <summary>
        /// Gets the computed water charge based on consumption and building-specific water cost per unit.
        /// </summary>
        /// <remarks>
        /// This property multiplies the valid <c>Consumption</c> value by the <c>WaterCCPU</c> (cost per cubic unit) retrieved from <c>tbutilities_settings</c>
        /// using the resolved <c>BuildingID</c>. If either <c>Consumption</c> or <c>BuildingID</c> is invalid, the result is 0.
        /// </remarks>
        /// <returns>
        /// The calculated water charge if inputs are valid; otherwise, 0.
        /// </returns>
        public double CurrentCharge
        {
            get
            {
                if (Consumption < 0)
                    return 0;

                if (BuildingID < 0)
                    return 0;

                new SelectCommand<tbutilities_settings>()
                    .Select(tbutilities_settings.WaterCCPU)
                    .From
                    .StartWhere
                        .Where(tbutilities_settings.BuildingID, SQLOperator.Equal, BuildingID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);

                return Consumption * Convert.ToDouble(Internals.DBC.Values[0]);
            }
        }
        /// <summary>
        /// Gets the total remaining balance from unpaid or partially paid water invoices for the tenant.
        /// </summary>
        /// <remarks>
        /// This property queries the <c>tbwaterinvoice</c> table using the current <c>TenantID</c> and filters by <c>Status</c> values <c>UNPAID</c> and <c>PARTIAL</c>.
        /// It iterates through all matching records and sums their <c>BillBalance</c> values.
        /// If the tenant ID is invalid or no matching records are found, the result is 0.
        /// </remarks>
        /// <returns>
        /// The aggregated remaining balance for the tenant's water invoices.
        /// </returns>
        public double RemainingBalance
        {
            get
            {
                MySqlDataReader reader;
                double rb = 0;

                if (!(TenantID > 0))
                    return rb;

                new SelectCommand<tbwaterinvoice>()
                    .Select(tbwaterinvoice.BillBalance)
                    .From
                    .StartWhere
                        .Where(tbwaterinvoice.TenantID, SQLOperator.Equal, TenantID.ToString())
                        .And(tbwaterinvoice.InvoiceNumber, SQLOperator.NotEqual, "'" + InvoiceNumber + "'")
                        .And()
                        .StartGroup(tbwaterinvoice.Status, SQLOperator.Equal, "'" + InvoiceStatuses.UNPAID.ToString() + "'")
                            .Or(tbwaterinvoice.Status, SQLOperator.Equal, "'" + InvoiceStatuses.PARTIAL.ToString() + "'")
                        .EndGroup
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                reader = Internals.DBC.Reader;
                while (reader.Read())
                    rb += Convert.ToDouble(reader[0].ToString());
                reader.Close();
                Internals.DBC.CloseReader();

                return rb;
            }
        }
        /// <summary>
        /// Gets a comma-separated list of unused advance payment IDs available for application to this invoice.
        /// </summary>
        /// <remarks>
        /// This property queries the <c>tbadvances</c> table for all records with a status of <c>UNUSED</c>.
        /// It returns a string of matching <c>AdvanceID</c> values separated by commas, with a trailing comma if any are found.
        /// If the <c>TenantID</c> is invalid or no advances are available, the result is an empty string.
        /// </remarks>
        /// <returns>
        /// A comma-separated list of unused advance IDs; otherwise, an empty string.
        /// </returns>
        public string AdvanceIDs
        {
            get
            {
                string aIDs = "";

                if (!(TenantID > 0))
                    return aIDs;

                new SelectCommand<tbadvances>()
                    .Select(tbadvances.AdvanceID)
                    .From
                    .StartWhere
                        .Where(tbadvances.Status, SQLOperator.Equal, "'" + AdvancesStatuses.UNUSED.ToString() + "'")
                        .And(tbadvances.BillType, SQLOperator.Equal, "'" + InvoiceTypes.WATER.ToString() + "'")
                        .And(tbadvances.TenantID, SQLOperator.Equal, TenantID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                if (Internals.DBC.HasRows)
                    foreach (string AID in Internals.DBC.Values)
                        aIDs += AID + ",";
                Internals.DBC.CloseReader();

                return aIDs;
            }
        }
        /// <summary>
        /// Gets the total amount from unused advance payments applicable to this water invoice.
        /// </summary>
        /// <remarks>
        /// This property parses the <c>AdvanceIDs</c> string into a list of advance identifiers, then queries the <c>tbadvances</c> table for each.
        /// It sums the <c>AmountPaid</c> values of all matching records.  
        /// If the tenant ID is invalid or no advance IDs are available, the result is 0.
        /// </remarks>
        /// <returns>
        /// The total value of unused advances for the tenant.
        /// </returns>
        public double TotalAdvances
        {
            get
            {
                double ta = 0;

                if (!(TenantID > 0))
                    return 0;

                if (string.IsNullOrWhiteSpace(AdvanceIDs))
                    return 0;

                List<int> AIDs = AdvanceIDs.Split(',').Select(int.Parse).ToList();

                foreach(int AID in AIDs)
                {
                    new SelectCommand<tbadvances>()
                        .Select(tbadvances.AmountPaid)
                        .From
                        .StartWhere
                            .Where(tbadvances.AdvanceID, SQLOperator.Equal, AID.ToString())
                        .EndWhere
                        .ExecuteReader(Internals.DBC);
                    ta += Convert.ToDouble(Internals.DBC.Values[0]);
                }

                return ta;
            }
        }
        /// <summary>
        /// Gets the total credit amount applied to this water invoice for the tenant.
        /// </summary>
        /// <remarks>
        /// This property queries the <c>tbcredits</c> table using the current <c>TenantID</c> and filters by <c>BillType</c> set to <c>WATER</c>.
        /// If a matching credit record is found, its <c>CreditAmount</c> is returned.  
        /// If no credit is available or the tenant ID is invalid, the result is 0.
        /// </remarks>
        /// <returns>
        /// The credit amount available for this water invoice; otherwise, 0.
        /// </returns>
        public double Credits
        {
            get
            {
                if(!(TenantID > 0)) 
                    return 0;

                new SelectCommand<tbcredits>()
                    .Select(tbcredits.CreditAmount)
                    .From
                    .StartWhere
                        .Where(tbcredits.TenantID, SQLOperator.Equal, TenantID.ToString())
                        .And(tbcredits.BillType, SQLOperator.Equal, "'" + InvoiceTypes.WATER.ToString() + "'")
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                if (Internals.DBC.HasRows)
                    return Convert.ToDouble(Internals.DBC.Values[0]);
                Internals.DBC.CloseReader();
                return 0;
            }
        }
        /// <summary>
        /// Gets the present reading value from the tenant's water invoice issued one month prior to the current due date.
        /// </summary>
        /// <remarks>
        /// This property queries the <c>tbwaterinvoice</c> table for the <c>PresentReading</c> value where:
        /// <list type="bullet">
        ///   <item><description><c>TenantID</c> matches the current invoice.</description></item>
        ///   <item><description><c>DueDate</c> equals one month before the current invoice's <c>DueDate</c>.</description></item>
        /// </list>
        /// If a matching record is found, its present reading is returned; otherwise, the value defaults to <c>0</c>.
        /// </remarks>
        /// <returns>
        /// The present reading from the previous month's water invoice, or <c>0</c> if unavailable.
        /// </returns>
        public double LastPresentReading
        {
            get
            {
                DateTime lastDueDate = DueDate.AddMonths(-1);

                new SelectCommand<tbwaterinvoice>()
                    .Select(tbwaterinvoice.PresentReading)
                    .From
                    .StartWhere
                        .Where(tbwaterinvoice.TenantID, SQLOperator.Equal, TenantID.ToString())
                        .And(tbwaterinvoice.DueDate, SQLOperator.Equal, "'" + lastDueDate.ToString("yyyy-MM-dd") + "'")
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                if (Internals.DBC.HasRows)
                    return Convert.ToDouble(Internals.DBC.Values[0]);
                Internals.DBC.CloseReader();
                return 0;
            }
        }
        /// <summary>
        /// Gets the total deductions applied to the invoice, combining unused advances and available credits.
        /// </summary>
        /// <remarks>
        /// This value is the sum of <c>TotalAdvances</c> and <c>Credits</c>, representing all applicable reductions to the tenant's water billing subtotal.
        /// It is used in final charge computation and reporting.
        /// </remarks>
        public double Deductions => TotalAdvances + Credits;
        /// <summary>
        /// Gets the subtotal amount due for the water invoice after applying all deductions.
        /// </summary>
        /// <remarks>
        /// This value is computed as the sum of <c>CurrentCharge</c> and <c>RemainingBalance</c>, minus <c>Deductions</c>.
        /// It reflects the net payable amount before any penalties or additional adjustments.
        /// </remarks>
        public double Subtotal => (CurrentCharge + RemainingBalance) - Deductions;

        /// <summary>
        /// Initializes a new instance of the <c>WaterInvoice</c> class with specified invoice metadata, meter readings, and due date.
        /// </summary>
        /// <param name="SetInvoiceNumber">The invoice number used to identify the water billing record.</param>
        /// <param name="SetDueDate">The due date by which the water bill must be paid.</param>
        /// <param name="SetTenantID">The tenant ID associated with the invoice.</param>
        /// <param name="SetPreviousReading">The previous water meter reading.</param>
        /// <param name="SetPresentReading">The present water meter reading.</param>
        /// <param name="SetStatus">The status of the invoice, such as <c>Unpaid</c>, <c>Partial</c>, or <c>Paid</c>.</param>
        /// <remarks>
        /// This constructor sets the initial state of the water invoice, including readings, due date, and status.
        /// Use <c>IsValid()</c> to verify that the constructed invoice meets minimum requirements for processing.
        /// </remarks>
        public WaterInvoice(
            string SetInvoiceNumber = "",
            DateTime SetDueDate = default,
            int SetTenantID = 0,
            double SetPreviousReading = 0,
            double SetPresentReading = 0,
            InvoiceStatuses SetStatus = InvoiceStatuses.Unknown)
        {
            InvoiceNumber = SetInvoiceNumber;
            DueDate = SetDueDate;
            TenantID = SetTenantID;
            PreviousReading = SetPreviousReading;
            PresentReading = SetPresentReading;
            Status = SetStatus;
        }

        /// <summary>
        /// Determines whether the current water invoice contains valid metadata, meter readings, and due date.
        /// </summary>
        /// <remarks>
        /// This method validates the invoice by checking:
        /// <list type="bullet">
        ///   <item><description><c>InvoiceNumber</c> is not null or whitespace.</description></item>
        ///   <item><description><c>DueDate</c> is not the default value.</description></item>
        ///   <item><description><c>TenantID</c> is greater than 0.</description></item>
        ///   <item><description><c>Consumption</c> is non-negative.</description></item>
        ///   <item><description><c>Status</c> is not <c>InvoiceStatuses.Unknown</c>.</description></item>
        /// </list>
        /// It ensures the invoice is complete and eligible for billing, reporting, or payment processing.
        /// </remarks>
        /// <returns>
        /// <c>true</c> if the invoice is structurally valid; otherwise, <c>false</c>.
        /// </returns>
        public bool IsValid()
        {
            return
                !string.IsNullOrWhiteSpace(InvoiceNumber) &&
                DueDate != default &&
                TenantID > 0 &&
                Consumption >= 0 &&
                Status != InvoiceStatuses.Unknown;
        }
        /// <summary>
        /// Creates a deep copy of the current <c>WaterInvoice</c> instance.
        /// </summary>
        /// <returns>
        /// A new <see cref="WaterInvoice"/> object with the same <c>InvoiceNumber</c>, <c>DueDate</c>, <c>TenantID</c>,
        /// <c>PreviousReading</c>, <c>PresentReading</c>, and <c>Status</c> as the original.
        /// </returns>
        /// <remarks>
        /// This method is used to duplicate water invoice data for editing or simulation purposes without affecting the original instance.
        /// Changes made to the cloned invoice will not impact the source object.
        /// </remarks>
        public WaterInvoice Clone()
        {
            return new WaterInvoice(
                this.InvoiceNumber,
                this.DueDate,
                this.TenantID,
                this.PreviousReading,
                this.PresentReading,
                this.Status);
        }
    }

    /// <summary>
    /// Represents an electricity billing record for a tenant, including meter readings, charges, deductions, and invoice status.
    /// </summary>
    /// <remarks>
    /// This class encapsulates all logic required to compute electricity consumption, charges, remaining balances, and applicable deductions.
    /// It dynamically resolves building context from tenant and room data, and integrates with utility settings, advances, and credits.
    /// Designed for modular reuse in billing workflows, reporting modules, and SDK-level integration.
    /// </remarks>
    internal class ElectricityInvoice
    {
        private int BuildingID
        {
            get
            {
                if (!(TenantID > 0))
                    return 0;

                int rID = 0;

                new SelectCommand<tbtenants>()
                    .Select(tbtenants.RoomID)
                    .From
                    .StartWhere
                        .Where(tbtenants.TenantID, SQLOperator.Equal, TenantID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                rID = Convert.ToInt32(Internals.DBC.Values[0]);

                new SelectCommand<tbrooms>()
                    .Select(tbrooms.BuildingID)
                    .From
                    .StartWhere
                        .Where(tbrooms.RoomID, SQLOperator.Equal, rID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                return Convert.ToInt32(Internals.DBC.Values[0]);
            }
        }

        /// <summary>
        /// Gets or sets the invoice number used to uniquely identify this electricity billing record.
        /// </summary>
        /// <remarks>
        /// This value serves as a reference key for tracking, validation, and linking across billing, reporting, and payment modules.
        /// It must be non-empty to ensure the invoice is considered valid and processable.
        /// </remarks>
        public string InvoiceNumber { get; set; }
        /// <summary>
        /// Gets or sets the due date for the electricity invoice payment.
        /// </summary>
        /// <remarks>
        /// This value specifies the deadline by which the tenant must settle the electricity bill.
        /// It is used in billing workflows, reporting, and penalty logic for overdue invoices.
        /// A default or uninitialized value may indicate that the invoice is not yet finalized or scheduled.
        /// </remarks>
        public DateTime DueDate { get; set; }
        /// <summary>
        /// Gets or sets the tenant ID associated with this electricity invoice.
        /// </summary>
        /// <remarks>
        /// This value links the invoice to a specific tenant record and is used to resolve room, building, balance, and credit data.
        /// A value of 0 or less typically indicates an uninitialized or invalid tenant reference, which will invalidate consumption and charge calculations.
        /// </remarks>
        public int TenantID { get; set; }
        /// <summary>
        /// Gets or sets the previous electricity meter reading for the tenant.
        /// </summary>
        /// <remarks>
        /// This value represents the last recorded reading before the current billing cycle.
        /// It is used in conjunction with <c>PresentReading</c> to calculate electricity consumption.
        /// A negative value indicates invalid input and will result in a failed consumption calculation.
        /// </remarks>
        public double PreviousReading { get; set; }
        /// <summary>
        /// Gets or sets the present electricity meter reading for the tenant.
        /// </summary>
        /// <remarks>
        /// This value represents the most recent reading recorded for the current billing cycle.
        /// It is used alongside <c>PreviousReading</c> to calculate electricity consumption.
        /// A negative value or one lower than the previous reading will invalidate the consumption calculation and result in a value of -1.
        /// </remarks>
        public double PresentReading { get; set; }
        /// <summary>
        /// Gets or sets the current status of the electricity invoice.
        /// </summary>
        /// <remarks>
        /// This value indicates the payment state of the invoice.
        /// It is used in validation, filtering, and billing logic to determine whether the invoice is eligible for processing, aggregation, or settlement.
        /// </remarks>
        public InvoiceStatuses Status { get; set; }

        /// <summary>
        /// Gets the calculated electricity consumption based on meter readings.
        /// </summary>
        /// <remarks>
        /// This value is computed as the difference between <c>PresentReading</c> and <c>PreviousReading</c>.
        /// If either reading is negative or the present reading is less than the previous, the result is <c>-1</c> to indicate invalid input.
        /// </remarks>
        /// <returns>
        /// The electricity consumption in kilowatt-hours, or <c>-1</c> if the readings are invalid.
        /// </returns>
        public double Consumption
        {
            get
            {
                if ((PreviousReading < 0 || PresentReading < 0) || PresentReading < PreviousReading)
                    return -1;

                return PresentReading - PreviousReading;
            }
        }
        /// <summary>
        /// Gets the computed electricity charge based on consumption and building-specific cost settings.
        /// </summary>
        /// <remarks>
        /// This value is calculated by multiplying <c>Consumption</c> by the <c>ElectricityCCPU</c> (cost per unit) retrieved from <c>tbutilities_settings</c>.
        /// If consumption is invalid or the building context cannot be resolved, the result is 0.
        /// </remarks>
        /// <returns>
        /// The total electricity charge for the current billing cycle.
        /// </returns>
        public double CurrentCharge
        {
            get
            {
                if (Consumption < 0 || BuildingID < 0)
                    return 0;

                new SelectCommand<tbutilities_settings>()
                    .Select(tbutilities_settings.ElectricityCCPU)
                    .From
                    .StartWhere
                        .Where(tbutilities_settings.BuildingID, SQLOperator.Equal, BuildingID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);

                return Consumption * Convert.ToDouble(Internals.DBC.Values[0]);
            }
        }
        /// <summary>
        /// Gets the total remaining balance from unpaid or partially paid electricity invoices for the tenant.
        /// </summary>
        /// <remarks>
        /// This property queries the <c>tbelectricityinvoice</c> table using the current <c>TenantID</c> and filters by <c>Status</c> values <c>UNPAID</c> and <c>PARTIAL</c>.
        /// It iterates through all matching records and sums their <c>BillBalance</c> values.
        /// If the tenant ID is invalid or no matching records are found, the result is 0.
        /// </remarks>
        /// <returns>
        /// The aggregated remaining balance for the tenant's electricity invoices.
        /// </returns>
        public double RemainingBalance
        {
            get
            {
                MySqlDataReader reader;
                double rb = 0;

                if (!(TenantID > 0))
                    return rb;

                new SelectCommand<tbelectricityinvoice>()
                    .Select(tbelectricityinvoice.BillBalance)
                    .From
                    .StartWhere
                        .Where(tbelectricityinvoice.TenantID, SQLOperator.Equal, TenantID.ToString())
                        .And(tbelectricityinvoice.InvoiceNumber, SQLOperator.NotEqual, "'" + InvoiceNumber + "'")
                        .And()
                        .StartGroup(tbelectricityinvoice.Status, SQLOperator.Equal, "'" + InvoiceStatuses.UNPAID.ToString() + "'")
                            .Or(tbelectricityinvoice.Status, SQLOperator.Equal, "'" + InvoiceStatuses.PARTIAL.ToString() + "'")
                        .EndGroup
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                reader = Internals.DBC.Reader;
                while (reader.Read())
                    rb += Convert.ToDouble(reader[0].ToString());
                reader.Close();
                Internals.DBC.CloseReader();

                return rb;
            }
        }
        /// <summary>
        /// Gets a comma-separated list of unused advance payment IDs applicable to this electricity invoice.
        /// </summary>
        /// <remarks>
        /// This property queries the <c>tbadvances</c> table for records with a status of <c>UNUSED</c> and a <c>BillType</c> of <c>ELECTRICITY</c>.
        /// It returns a string of matching <c>AdvanceID</c> values separated by commas, with a trailing comma if any are found.
        /// If the <c>TenantID</c> is invalid or no advances are available, the result is an empty string.
        /// </remarks>
        /// <returns>
        /// A comma-separated list of unused advance IDs; otherwise, an empty string.
        /// </returns>
        public string AdvanceIDs
        {
            get
            {
                string aIDs = "";

                if (!(TenantID > 0))
                    return aIDs;

                new SelectCommand<tbadvances>()
                    .Select(tbadvances.AdvanceID)
                    .From
                    .StartWhere
                        .Where(tbadvances.Status, SQLOperator.Equal, "'" + AdvancesStatuses.UNUSED.ToString() + "'")
                        .And(tbadvances.BillType, SQLOperator.Equal, "'" + InvoiceTypes.ELECTRICITY.ToString() + "'")
                        .And(tbadvances.TenantID, SQLOperator.Equal, TenantID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                if (Internals.DBC.HasRows)
                    foreach (string AID in Internals.DBC.Values)
                        aIDs += AID + ",";
                Internals.DBC.CloseReader();

                return aIDs;
            }
        }
        /// <summary>
        /// Gets the total amount from unused advance payments applicable to this electricity invoice.
        /// </summary>
        /// <remarks>
        /// This property parses the <c>AdvanceIDs</c> string into a list of advance identifiers, then queries the <c>tbadvances</c> table for each.
        /// It sums the <c>AmountPaid</c> values of all matching records.
        /// If the tenant ID is invalid or no advance IDs are available, the result is 0.
        /// </remarks>
        /// <returns>
        /// The total value of unused advances for the tenant's electricity billing.
        /// </returns>
        public double TotalAdvances
        {
            get
            {
                double ta = 0;

                if (!(TenantID > 0) || string.IsNullOrWhiteSpace(AdvanceIDs))
                    return 0;

                List<int> AIDs = AdvanceIDs.Split(',').Select(int.Parse).ToList();

                foreach (int AID in AIDs)
                {
                    new SelectCommand<tbadvances>()
                        .Select(tbadvances.AmountPaid)
                        .From
                        .StartWhere
                            .Where(tbadvances.AdvanceID, SQLOperator.Equal, AID.ToString())
                        .EndWhere
                        .ExecuteReader(Internals.DBC);
                    ta += Convert.ToDouble(Internals.DBC.Values[0]);
                }

                return ta;
            }
        }
        /// <summary>
        /// Gets the total credit amount applied to this electricity invoice for the tenant.
        /// </summary>
        /// <remarks>
        /// This property queries the <c>tbcredits</c> table using the current <c>TenantID</c> and filters by <c>BillType</c> set to <c>ELECTRICITY</c>.
        /// If a matching credit record is found, its <c>CreditAmount</c> is returned.
        /// If no credit is available or the tenant ID is invalid, the result is 0.
        /// </remarks>
        /// <returns>
        /// The credit amount available for this electricity invoice; otherwise, 0.
        /// </returns>
        public double Credits
        {
            get
            {
                if (!(TenantID > 0))
                    return 0;

                new SelectCommand<tbcredits>()
                    .Select(tbcredits.CreditAmount)
                    .From
                    .StartWhere
                        .Where(tbcredits.TenantID, SQLOperator.Equal, TenantID.ToString())
                        .And(tbcredits.BillType, SQLOperator.Equal, "'" + InvoiceTypes.ELECTRICITY.ToString() + "'")
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                if (Internals.DBC.HasRows)
                    return Convert.ToDouble(Internals.DBC.Values[0]);
                Internals.DBC.CloseReader();
                return 0;
            }
        }
        /// <summary>
        /// Gets the present reading value from the tenant's electricity invoice issued one month prior to the current due date.
        /// </summary>
        /// <remarks>
        /// This property queries the <c>tbelectricityinvoice</c> table for the <c>PresentReading</c> value where:
        /// <list type="bullet">
        ///   <item><description><c>TenantID</c> matches the current invoice.</description></item>
        ///   <item><description><c>DueDate</c> equals one month before the current invoice's <c>DueDate</c>.</description></item>
        /// </list>
        /// If a matching record is found, its present reading is returned; otherwise, the value defaults to <c>0</c>.
        /// </remarks>
        /// <returns>
        /// The present reading from the previous month's electricity invoice, or <c>0</c> if unavailable.
        /// </returns>
        public double LastPresentReading
        {
            get
            {
                DateTime lastDueDate = DueDate.AddMonths(-1);

                new SelectCommand<tbelectricityinvoice>()
                    .Select(tbelectricityinvoice.PresentReading)
                    .From
                    .StartWhere
                        .Where(tbelectricityinvoice.TenantID, SQLOperator.Equal, TenantID.ToString())
                        .And(tbelectricityinvoice.DueDate, SQLOperator.Equal, "'" + lastDueDate.ToString("yyyy-MM-dd") + "'")
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                if (Internals.DBC.HasRows)
                    return Convert.ToDouble(Internals.DBC.Values[0]);
                Internals.DBC.CloseReader();
                return 0;
            }
        }
        /// <summary>
        /// Gets the total deductions applied to the electricity invoice, combining unused advances and available credits.
        /// </summary>
        /// <remarks>
        /// This value is computed as the sum of <c>TotalAdvances</c> and <c>Credits</c>, representing all applicable reductions to the tenant's electricity billing subtotal.
        /// It is used in final charge computation and reporting.
        /// </remarks>
        /// <returns>
        /// The total deduction amount for the current electricity invoice.
        /// </returns>
        public double Deductions => TotalAdvances + Credits;
        /// <summary>
        /// Gets the subtotal amount due for the electricity invoice after applying all deductions.
        /// </summary>
        /// <remarks>
        /// This value is calculated by summing <c>CurrentCharge</c> and <c>RemainingBalance</c>, then subtracting <c>Deductions</c>.
        /// It represents the net payable amount before any penalties, surcharges, or final adjustments.
        /// </remarks>
        /// <returns>
        /// The subtotal amount due for the current electricity billing cycle.
        /// </returns>
        public double Subtotal => (CurrentCharge + RemainingBalance) - Deductions;

        /// <summary>
        /// Initializes a new instance of the <c>ElectricityInvoice</c> class with specified invoice metadata, meter readings, and due date.
        /// </summary>
        /// <param name="SetInvoiceNumber">The invoice number used to identify the electricity billing record.</param>
        /// <param name="SetDueDate">The due date by which the electricity bill must be paid.</param>
        /// <param name="SetTenantID">The tenant ID associated with the invoice.</param>
        /// <param name="SetPreviousReading">The previous electricity meter reading.</param>
        /// <param name="SetPresentReading">The present electricity meter reading.</param>
        /// <param name="SetStatus">The status of the invoice, such as <c>Unpaid</c>, <c>Partial</c>, or <c>Paid</c>.</param>
        /// <remarks>
        /// This constructor sets the initial state of the electricity invoice, including readings, due date, and status.
        /// Use <c>IsValid()</c> to verify that the constructed invoice meets minimum requirements for processing.
        /// </remarks>
        public ElectricityInvoice(
            string SetInvoiceNumber = "",
            DateTime SetDueDate = default,
            int SetTenantID = 0,
            double SetPreviousReading = 0,
            double SetPresentReading = 0,
            InvoiceStatuses SetStatus = InvoiceStatuses.Unknown)
        {
            InvoiceNumber = SetInvoiceNumber;
            DueDate = SetDueDate;
            TenantID = SetTenantID;
            PreviousReading = SetPreviousReading;
            PresentReading = SetPresentReading;
            Status = SetStatus;
        }

        /// <summary>
        /// Determines whether the current electricity invoice contains valid metadata, meter readings, and due date.
        /// </summary>
        /// <remarks>
        /// This method validates the invoice by checking:
        /// <list type="bullet">
        ///   <item><description><c>InvoiceNumber</c> is not null or whitespace.</description></item>
        ///   <item><description><c>DueDate</c> is not the default value.</description></item>
        ///   <item><description><c>TenantID</c> is greater than 0.</description></item>
        ///   <item><description><c>Consumption</c> is non-negative.</description></item>
        ///   <item><description><c>Status</c> is not <c>InvoiceStatuses.Unknown</c>.</description></item>
        /// </list>
        /// It ensures the invoice is complete and eligible for billing, reporting, or payment processing.
        /// </remarks>
        /// <returns>
        /// <c>true</c> if the invoice is structurally valid; otherwise, <c>false</c>.
        /// </returns>
        public bool IsValid()
        {
            return
                !string.IsNullOrWhiteSpace(InvoiceNumber) &&
                DueDate != default &&
                TenantID > 0 &&
                Consumption >= 0 &&
                Status != InvoiceStatuses.Unknown;
        }
        /// <summary>
        /// Creates a deep copy of the current <c>ElectricityInvoice</c> instance.
        /// </summary>
        /// <returns>
        /// A new <see cref="ElectricityInvoice"/> object with the same <c>InvoiceNumber</c>, <c>DueDate</c>, <c>TenantID</c>,
        /// <c>PreviousReading</c>, <c>PresentReading</c>, and <c>Status</c> as the original.
        /// </returns>
        /// <remarks>
        /// This method is used to duplicate electricity invoice data for editing, simulation, or rollback purposes without affecting the original instance.
        /// Changes made to the cloned invoice will not impact the source object.
        /// </remarks>
        public ElectricityInvoice Clone()
        {
            return new ElectricityInvoice(
                this.InvoiceNumber,
                this.DueDate,
                this.TenantID,
                this.PreviousReading,
                this.PresentReading,
                this.Status);
        }
    }

    /// <summary>
    /// Represents a rental invoice containing billing details, tenant metadata, and financial computations for monthly rent.
    /// </summary>
    /// <remarks>
    /// This class encapsulates logic for retrieving rental rates, computing remaining balances, applying advances and credits,
    /// and calculating the final subtotal. It integrates with tenant, room, building, and invoice tables to dynamically resolve
    /// context-specific values. Use <c>IsValid()</c> to verify structural integrity before processing or saving.
    /// </remarks>
    internal class RentalInvoice
    {
        private int BuildingID
        {
            get
            {
                if (!(TenantID > 0))
                    return 0;

                int rID = 0;

                new SelectCommand<tbtenants>()
                    .Select(tbtenants.RoomID)
                    .From
                    .StartWhere
                        .Where(tbtenants.TenantID, SQLOperator.Equal, TenantID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                rID = Convert.ToInt32(Internals.DBC.Values[0]);

                new SelectCommand<tbrooms>()
                    .Select(tbrooms.BuildingID)
                    .From
                    .StartWhere
                        .Where(tbrooms.RoomID, SQLOperator.Equal, rID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                return Convert.ToInt32(Internals.DBC.Values[0]);
            }
        }

        /// <summary>
        /// Gets or sets the unique identifier assigned to the invoice.
        /// </summary>
        /// <remarks>
        /// This value distinguishes the invoice record across billing modules and is used in reporting, validation, and payment tracking.
        /// It must be non-empty to ensure the invoice is considered valid.
        /// </remarks>
        public string InvoiceNumber { get; set; }
        /// <summary>
        /// Gets or sets the due date for the invoice payment.
        /// </summary>
        /// <remarks>
        /// This value specifies the deadline by which the tenant must settle the bill.
        /// It is used in billing workflows, reporting, and penalty logic for overdue invoices.
        /// A default or uninitialized value may indicate that the invoice is not yet finalized or scheduled.
        /// </remarks>
        public DateTime DueDate { get; set; }
        /// <summary>
        /// Gets or sets the unique identifier of the tenant associated with the invoice.
        /// </summary>
        /// <remarks>
        /// This value links the invoice to a specific tenant record and is used to resolve billing context, balances, and applicable advances or credits.
        /// A valid tenant ID must be greater than zero for the invoice to be considered valid.
        /// </remarks>
        public int TenantID { get; set; }
        /// <summary>
        /// Gets or sets the current status of the invoice.
        /// </summary>
        /// <remarks>
        /// This value indicates the payment state of the invoice.
        /// It is used in billing workflows, reporting, and validation logic.
        /// A value of <c>Unknown</c> typically signifies an uninitialized or invalid invoice state.
        /// </remarks>
        public InvoiceStatuses Status { get; set; }

        /// <summary>
        /// Gets the monthly rental rate for the tenant's assigned building.
        /// </summary>
        /// <remarks>
        /// This property resolves the tenant's <c>RoomID</c> via <c>tbtenants</c>, then queries <c>tbrooms</c> to determine the <c>BuildingID</c>.
        /// It finally retrieves the <c>RentalRate</c> from <c>tbbuilding</c>.
        /// If the tenant ID is invalid or no matching records are found, the result is 0.
        /// </remarks>
        /// <returns>
        /// The monthly rental rate for the tenant's building; otherwise, 0.
        /// </returns>
        public double MonthlyRent
        {
            get
            {
                if (!(TenantID > 0))
                    return 0;

                new SelectCommand<tbbuilding>()
                    .Select(tbbuilding.RentalRate)
                    .From
                    .StartWhere
                        .Where(tbbuilding.BuildingID, SQLOperator.Equal, BuildingID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                if (Internals.DBC.HasRows)
                    return Convert.ToDouble(Internals.DBC.Values[0]);
                Internals.DBC.CloseReader();
                return 0;
            }
        }
        /// <summary>
        /// Gets the total remaining balance from unpaid or partially paid rental invoices for the tenant.
        /// </summary>
        /// <remarks>
        /// This property queries the <c>tbrentalinvoice</c> table using the current <c>TenantID</c> and filters by <c>Status</c> values <c>UNPAID</c> and <c>PARTIAL</c>.
        /// It iterates through all matching records and sums their <c>BillBalance</c> values.
        /// If the tenant ID is invalid or no matching records are found, the result is 0.
        /// </remarks>
        /// <returns>
        /// The aggregated remaining balance for the tenant's rental invoices.
        /// </returns>
        public double RemainingBalance
        {
            get
            {
                double rb = 0;

                if (!(TenantID > 0))
                    return 0;

                new SelectCommand<tbrentalinvoice>()
                    .Select(tbrentalinvoice.BillBalance)
                    .From
                    .StartWhere
                        .Where(tbrentalinvoice.TenantID, SQLOperator.Equal, TenantID.ToString())
                        .And(tbrentalinvoice.InvoiceNumber, SQLOperator.NotEqual, "'" + InvoiceNumber + "'")
                        .And()
                        .StartGroup(tbrentalinvoice.Status, SQLOperator.Equal, "'" + InvoiceStatuses.UNPAID.ToString() + "'")
                            .Or(tbrentalinvoice.Status, SQLOperator.Equal, "'" + InvoiceStatuses.PARTIAL.ToString() + "'")
                        .EndGroup
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                if (Internals.DBC.HasRows)
                    foreach (string bb in Internals.DBC.Values)
                        rb += Convert.ToDouble(bb);
                Internals.DBC.CloseReader();

                return rb;
            }
        }
        /// <summary>
        /// Gets a comma-separated list of unused advance payment IDs associated with the tenant.
        /// </summary>
        /// <remarks>
        /// This property queries the <c>tbadvances</c> table for records where <c>Status</c> is <c>UNUSED</c> and matches the current <c>TenantID</c>.
        /// It returns a string of matching <c>AdvanceID</c> values separated by commas, with a trailing comma if any are found.
        /// If the tenant ID is invalid or no advances are available, the result is an empty string.
        /// </remarks>
        /// <returns>
        /// A comma-separated list of unused advance IDs; otherwise, an empty string.
        /// </returns>
        public string AdvanceIDs
        {
            get
            {
                string AIDs = "";

                if (!(TenantID > 0))
                    return AIDs;

                new SelectCommand<tbadvances>()
                    .Select(tbadvances.AdvanceID)
                    .From
                    .StartWhere
                        .Where(tbadvances.TenantID, SQLOperator.Equal, TenantID.ToString())
                        .And(tbadvances.Status, SQLOperator.Equal, "'" + AdvancesStatuses.UNUSED.ToString() + "'")
                        .And(tbadvances.BillType, SQLOperator.Equal, "'" + InvoiceTypes.RENTAL.ToString() + "'")
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                if (Internals.DBC.HasRows)
                    foreach (string AID in Internals.DBC.Values)
                        AIDs = AID + ",";
                Internals.DBC.CloseReader();

                return AIDs;
            }
        }
        /// <summary>
        /// Gets the total amount of unused advance payments associated with the tenant.
        /// </summary>
        /// <remarks>
        /// This property parses the <c>AdvanceIDs</c> string into a list of integers, then queries the <c>tbadvances</c> table
        /// to retrieve the <c>AmountPaid</c> for each matching <c>AdvanceID</c>. The values are summed to compute the total.
        /// If the tenant ID is invalid or no advance IDs are available, the result is 0.
        /// </remarks>
        /// <returns>
        /// The total value of unused advances for the tenant; otherwise, 0.
        /// </returns>
        public double TotalAdvances
        {
            get
            {
                double ta = 0;

                if (!(TenantID > 0) || string.IsNullOrWhiteSpace(AdvanceIDs))
                    return ta;

                List<int> AIDs = AdvanceIDs.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                foreach(int AID in AIDs)
                {
                    new SelectCommand<tbadvances>()
                        .Select(tbadvances.AmountPaid)
                        .From
                        .StartWhere
                            .Where(tbadvances.AdvanceID, SQLOperator.Equal, AID.ToString())
                        .EndWhere
                        .ExecuteReader(Internals.DBC);
                    ta += Convert.ToDouble(Internals.DBC.Values[0]);
                }

                return ta;
            }
        }
        /// <summary>
        /// Gets the total credit amount available to the tenant.
        /// </summary>
        /// <remarks>
        /// This property queries the <c>tbcredits</c> table for records matching the current <c>TenantID</c>
        /// and retrieves the <c>CreditAmount</c>. If a valid tenant ID is provided and matching records exist,
        /// the first credit value is returned. If no records are found or the tenant ID is invalid, the result is 0.
        /// </remarks>
        /// <returns>
        /// The available credit amount for the tenant; otherwise, 0.
        /// </returns>
        public double Credits
        {
            get
            {
                if (!(TenantID > 0))
                    return 0;

                new SelectCommand<tbcredits>()
                    .Select(tbcredits.CreditAmount)
                    .From
                    .StartWhere
                        .Where(tbcredits.TenantID, SQLOperator.Equal, TenantID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                if (Internals.DBC.HasRows)
                    return Convert.ToDouble(Internals.DBC.Values[0]);
                Internals.DBC.CloseReader();
                return 0;
            }
        }
        /// <summary>
        /// Gets the total deductions applied to the tenant's rental invoice.
        /// </summary>
        /// <remarks>
        /// This value is computed by summing <c>TotalAdvances</c> and <c>Credits</c>, representing all applicable prepayments and credit adjustments.
        /// It is subtracted from the combined rent and balance to determine the final subtotal.
        /// </remarks>
        /// <returns>
        /// The total deduction amount applied to the invoice.
        /// </returns>
        public double Deductions => TotalAdvances + Credits;
        /// <summary>
        /// Gets the computed subtotal for the tenant's rental invoice.
        /// </summary>
        /// <remarks>
        /// This value is calculated by adding <c>MonthlyRent</c> and <c>RemainingBalance</c>, then subtracting <c>Deductions</c>.
        /// It represents the net amount due before any final adjustments or penalties.
        /// </remarks>
        /// <returns>
        /// The subtotal amount for the rental invoice.
        /// </returns>
        public double Subtotal => (MonthlyRent + RemainingBalance) - Deductions;

        /// <summary>
        /// Initializes a new instance of the <c>RentalInvoice</c> class with specified invoice metadata and tenant association.
        /// </summary>
        /// <param name="SetInvoiceNumber">The invoice number used to identify the rental billing record.</param>
        /// <param name="SetDueDate">The due date by which the rental bill must be paid.</param>
        /// <param name="SetTenantID">The tenant ID associated with the invoice.</param>
        /// <param name="SetStatus">The status of the invoice, such as <c>Unpaid</c>, <c>Partial</c>, or <c>Paid</c>.</param>
        /// <remarks>
        /// This constructor sets the initial state of the rental invoice, including due date, tenant linkage, and payment status.
        /// Use <c>IsValid()</c> to verify that the constructed invoice meets minimum requirements for processing.
        /// </remarks>
        public RentalInvoice(
            string SetInvoiceNumber = "",
            DateTime SetDueDate = default,
            int SetTenantID = 0,
            InvoiceStatuses SetStatus = InvoiceStatuses.Unknown)
        {
            InvoiceNumber = SetInvoiceNumber;
            DueDate = SetDueDate;
            TenantID = SetTenantID;
            Status = SetStatus;
        }

        /// <summary>
        /// Determines whether the current rental invoice contains valid metadata and tenant association.
        /// </summary>
        /// <remarks>
        /// This method validates the invoice by checking:
        /// <list type="bullet">
        ///   <item><description><c>InvoiceNumber</c> is not null or whitespace.</description></item>
        ///   <item><description><c>DueDate</c> is not the default value.</description></item>
        ///   <item><description><c>TenantID</c> is greater than 0.</description></item>
        ///   <item><description><c>Status</c> is not <c>InvoiceStatuses.Unknown</c>.</description></item>
        /// </list>
        /// It ensures the invoice is structurally complete and eligible for billing, reporting, or payment processing.
        /// </remarks>
        /// <returns>
        /// <c>true</c> if the invoice is structurally valid; otherwise, <c>false</c>.
        /// </returns>
        public bool IsValid()
        {
            return
                !string.IsNullOrWhiteSpace(InvoiceNumber) &&
                DueDate != default &&
                TenantID > 0 &&
                Status != InvoiceStatuses.Unknown;
        }
        /// <summary>
        /// Creates a deep copy of the current <c>RentalInvoice</c> instance.
        /// </summary>
        /// <returns>
        /// A new <see cref="RentalInvoice"/> object with the same <c>InvoiceNumber</c>, <c>DueDate</c>, <c>TenantID</c>, and <c>Status</c> as the original.
        /// </returns>
        /// <remarks>
        /// This method is used to duplicate rental invoice metadata for editing, simulation, or rollback purposes without affecting the original instance.
        /// Changes made to the cloned invoice will not impact the source object.
        /// </remarks>
        public RentalInvoice Clone()
        {
            return new RentalInvoice(
                this.InvoiceNumber,
                this.DueDate,
                this.TenantID,
                this.Status);
        }
    }

    /// <summary>
    /// Represents an internet billing invoice linked to a tenant's subscribed internet plan.
    /// </summary>
    /// <remarks>
    /// This class encapsulates logic for retrieving internet plan details, computing outstanding balances,
    /// applying unused advances and credits, and calculating the final payable subtotal.
    /// It integrates with tenant, internet plan, advance, and invoice tables to dynamically resolve billing context.
    /// Use <c>IsValid()</c> to verify structural integrity before processing or saving.
    /// </remarks>
    internal class InternetInvoice
    {
        private int InternetPlanID
        {
            get
            {
                new SelectCommand<tbtenants>()
                    .Select(tbtenants.ISPlanID)
                    .From
                    .StartWhere
                        .Where(tbtenants.TenantID, SQLOperator.Equal, TenantID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                if (Internals.DBC.HasRows)
                    return Convert.ToInt32(Internals.DBC.Values[0]);
                Internals.DBC.CloseReader();
                return 0;
            }
        }

        /// <summary>
        /// Gets or sets the unique identifier assigned to the internet invoice.
        /// </summary>
        /// <remarks>
        /// This value serves as the primary reference for the internet billing record. It is used in tracking, validation,
        /// reporting, and reconciliation processes. A non-empty invoice number is required for the invoice to be considered valid.
        /// </remarks>
        public string InvoiceNumber { get; set; }
        /// <summary>
        /// Gets or sets the due date for the internet invoice payment.
        /// </summary>
        /// <remarks>
        /// This value defines the deadline by which the tenant must settle the internet subscription bill.
        /// It is used in billing workflows, overdue detection, and reporting logic.
        /// A default value may indicate that the invoice is not yet scheduled or finalized.
        /// </remarks>
        public DateTime DueDate { get; set; }
        /// <summary>
        /// Gets or sets the unique identifier of the tenant associated with the internet invoice.
        /// </summary>
        /// <remarks>
        /// This value links the invoice to a specific tenant record and is used to resolve internet plan details,
        /// billing context, and applicable advances or credits. A valid tenant ID must be greater than zero for the invoice to be considered valid.
        /// </remarks>
        public int TenantID { get; set; }
        /// <summary>
        /// Gets or sets the current status of the internet invoice.
        /// </summary>
        /// <remarks>
        /// This value indicates the payment state of the invoice, such as <c>Unpaid</c>, <c>Partial</c>, <c>Paid</c>, or <c>Unknown</c>.
        /// It is used to determine billing eligibility, balance computation, and reporting logic.
        /// A value of <c>Unknown</c> typically signifies an uninitialized or invalid invoice state.
        /// </remarks>
        public InvoiceStatuses Status { get; set; }

        /// <summary>
        /// Gets the name of the internet plan associated with the tenant.
        /// </summary>
        /// <remarks>
        /// This property resolves the tenant’s <c>InternetPlanID</c> via the <c>tbtenants</c> table,
        /// then queries the <c>tbinternetplans</c> table to retrieve the corresponding <c>PlanName</c>.
        /// If the tenant ID is invalid or no matching plan is found, the result is an empty string.
        /// </remarks>
        /// <returns>
        /// The name of the tenant’s subscribed internet plan; otherwise, an empty string.
        /// </returns>
        public string PlanName
        {
            get
            {
                if (!(TenantID > 0))
                    return "";

                new SelectCommand<tbinternetplans>()
                    .Select(tbinternetplans.PlanName)
                    .From
                    .StartWhere
                        .Where(tbinternetplans.PlanID, SQLOperator.Equal, InternetPlanID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                return Internals.DBC.Values[0];
            }
        }
        /// <summary>
        /// Gets the monthly subscription fee for the tenant's internet plan.
        /// </summary>
        /// <remarks>
        /// This property resolves the tenant’s <c>InternetPlanID</c> via the <c>tbtenants</c> table,
        /// then queries the <c>tbinternetplans</c> table to retrieve the corresponding <c>PlanPrice</c>.
        /// If the tenant ID is invalid or no matching plan is found, the result is 0.
        /// </remarks>
        /// <returns>
        /// The monthly fee for the tenant’s subscribed internet plan; otherwise, 0.
        /// </returns>
        public double SubscriptionFee
        {
            get
            {
                if (!(TenantID > 0))
                    return 0;

                new SelectCommand<tbinternetplans>()
                    .Select(tbinternetplans.PlanPrice)
                    .From
                    .StartWhere
                        .Where(tbinternetplans.PlanID, SQLOperator.Equal, InternetPlanID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                return Convert.ToDouble(Internals.DBC.Values[0]);
            }
        }
        /// <summary>
        /// Gets the total remaining balance from unpaid or partially paid internet invoices for the tenant.
        /// </summary>
        /// <remarks>
        /// This property queries the <c>tbinternetinvoice</c> table using the current <c>TenantID</c> and filters by <c>Status</c> values <c>UNPAID</c> and <c>PARTIAL</c>.
        /// It iterates through all matching records and sums their <c>BillBalance</c> values.
        /// If the tenant ID is invalid or no matching records are found, the result is 0.
        /// </remarks>
        /// <returns>
        /// The aggregated remaining balance for the tenant’s internet invoices.
        /// </returns>
        public double RemainingBalance
        {
            get
            {
                double rb = 0;

                if (!(TenantID > 0))
                    return rb;

                new SelectCommand<tbinternetinvoice>()
                    .Select(tbinternetinvoice.BillBalance)
                    .From
                    .StartWhere
                        .Where(tbinternetinvoice.TenantID, SQLOperator.Equal, TenantID.ToString())
                        .And(tbinternetinvoice.InvoiceNumber, SQLOperator.NotEqual, "'" + InvoiceNumber + "'")
                        .And()
                        .StartGroup(tbinternetinvoice.Status, SQLOperator.Equal, "'" + InvoiceStatuses.UNPAID.ToString() + "'")
                            .Or(tbinternetinvoice.Status, SQLOperator.Equal, "'" + InvoiceStatuses.PARTIAL.ToString() + "'")
                        .EndGroup
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                if (Internals.DBC.HasRows)
                    foreach (string bb in Internals.DBC.Values)
                        rb += Convert.ToDouble(bb);
                Internals.DBC.CloseReader();

                return rb;
            }
        }
        /// <summary>
        /// Gets a comma-separated list of unused advance payment IDs associated with the tenant's internet billing.
        /// </summary>
        /// <remarks>
        /// This property queries the <c>tbadvances</c> table for records where <c>Status</c> is <c>UNUSED</c>,
        /// <c>BillType</c> is <c>INTERNET</c>, and the <c>TenantID</c> matches the current invoice.
        /// It returns a string of matching <c>AdvanceID</c> values separated by commas, with a trailing comma if any are found.
        /// If the tenant ID is invalid or no advances are available, the result is an empty string.
        /// </remarks>
        /// <returns>
        /// A comma-separated list of unused advance IDs for internet billing; otherwise, an empty string.
        /// </returns>
        public string AdvanceIDs
        {
            get
            {
                string AIDs = "";
                
                if(!(TenantID > 0))
                    return AIDs;

                new SelectCommand<tbadvances>()
                    .Select(tbadvances.AdvanceID)
                    .From
                    .StartWhere
                        .Where(tbadvances.TenantID, SQLOperator.Equal, TenantID.ToString())
                        .And(tbadvances.Status, SQLOperator.Equal, "'" + AdvancesStatuses.UNUSED.ToString() + "'")
                        .And(tbadvances.BillType, SQLOperator.Equal, "'" + InvoiceTypes.INTERNET.ToString() + "'")
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                if (Internals.DBC.HasRows)
                    foreach (string AID in Internals.DBC.Values)
                        AIDs += AID + ",";
                Internals.DBC.CloseReader();

                return AIDs;
            }
        }
        /// <summary>
        /// Gets the total amount of unused advance payments associated with the tenant's internet billing.
        /// </summary>
        /// <remarks>
        /// This property parses the <c>AdvanceIDs</c> string into a list of integers, then queries the <c>tbadvances</c> table
        /// to retrieve the <c>AmountPaid</c> for each matching <c>AdvanceID</c>. The values are summed to compute the total.
        /// If the tenant ID is invalid or no advance IDs are available, the result is 0.
        /// </remarks>
        /// <returns>
        /// The total value of unused advances for the tenant’s internet billing; otherwise, 0.
        /// </returns>
        public double TotalAdvances
        {
            get
            {
                double ta = 0;

                if (!(TenantID > 0) || string.IsNullOrWhiteSpace(AdvanceIDs))
                    return ta;

                List<int> AIDs = AdvanceIDs.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                foreach(int AID in AIDs)
                {
                    new SelectCommand<tbadvances>()
                        .Select(tbadvances.AmountPaid)
                        .From
                        .StartWhere
                            .Where(tbadvances.AdvanceID, SQLOperator.Equal, AID.ToString())
                        .EndWhere
                        .ExecuteReader(Internals.DBC);
                    ta += Convert.ToDouble(Internals.DBC.Values[0]);
                }

                return ta;
            }
        }
        /// <summary>
        /// Gets the total credit amount available to the tenant for internet billing.
        /// </summary>
        /// <remarks>
        /// This property queries the <c>tbcredits</c> table for records matching the current <c>TenantID</c>
        /// and where <c>BillType</c> is <c>INTERNET</c>. If matching records exist, the first <c>CreditAmount</c>
        /// is returned. If no records are found or the tenant ID is invalid, the result is 0.
        /// </remarks>
        /// <returns>
        /// The available credit amount for the tenant’s internet billing; otherwise, 0.
        /// </returns>
        public double Credits
        {
            get
            {
                if (!(TenantID > 0))
                    return 0;

                new SelectCommand<tbcredits>()
                    .Select(tbcredits.CreditAmount)
                    .From
                    .StartWhere
                        .Where(tbcredits.TenantID, SQLOperator.Equal, TenantID.ToString())
                        .And(tbcredits.BillType, SQLOperator.Equal, "'" + InvoiceTypes.INTERNET.ToString() + "'")
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                if (Internals.DBC.HasRows)
                    return Convert.ToDouble(Internals.DBC.Values[0]);
                Internals.DBC.CloseReader();
                return 0;
            }
        }
        /// <summary>
        /// Gets the total deductions applied to the tenant's internet invoice.
        /// </summary>
        /// <remarks>
        /// This value is computed by summing <c>TotalAdvances</c> and <c>Credits</c>, representing all applicable prepayments and credit adjustments.
        /// It is subtracted from the combined subscription fee and remaining balance to determine the final subtotal.
        /// </remarks>
        /// <returns>
        /// The total deduction amount applied to the internet invoice.
        /// </returns>
        public double Deductions => TotalAdvances + Credits;
        /// <summary>
        /// Gets the computed subtotal for the tenant's internet invoice.
        /// </summary>
        /// <remarks>
        /// This value is calculated by adding <c>SubscriptionFee</c> and <c>RemainingBalance</c>, then subtracting <c>Deductions</c>.
        /// It represents the net amount due before any final adjustments or penalties.
        /// </remarks>
        /// <returns>
        /// The subtotal amount for the internet invoice.
        /// </returns>
        public double Subtotal => (SubscriptionFee + RemainingBalance) - Deductions;

        /// <summary>
        /// Initializes a new instance of the <c>InternetInvoice</c> class with specified invoice metadata and tenant association.
        /// </summary>
        /// <param name="SetInvoiceNumber">The invoice number used to identify the internet billing record.</param>
        /// <param name="SetDueDate">The due date by which the internet bill must be paid.</param>
        /// <param name="SetTenantID">The tenant ID associated with the invoice.</param>
        /// <param name="SetStatus">The status of the invoice, such as <c>Unpaid</c>, <c>Partial</c>, or <c>Paid</c>.</param>
        /// <remarks>
        /// This constructor sets the initial state of the internet invoice, including due date, tenant linkage, and payment status.
        /// Use <c>IsValid()</c> to verify that the constructed invoice meets minimum requirements for processing.
        /// </remarks>
        public InternetInvoice(
            string SetInvoiceNumber = "",
            DateTime SetDueDate = default,
            int SetTenantID = 0,
            InvoiceStatuses SetStatus = InvoiceStatuses.Unknown)
        {
            InvoiceNumber = SetInvoiceNumber;
            DueDate = SetDueDate;
            TenantID = SetTenantID;
            Status = SetStatus;
        }

        /// <summary>
        /// Determines whether the current internet invoice contains valid metadata and tenant association.
        /// </summary>
        /// <remarks>
        /// This method validates the invoice by checking:
        /// <list type="bullet">
        ///   <item><description><c>InvoiceNumber</c> is not null or whitespace.</description></item>
        ///   <item><description><c>DueDate</c> is not the default value.</description></item>
        ///   <item><description><c>TenantID</c> is greater than 0.</description></item>
        ///   <item><description><c>Status</c> is not <c>InvoiceStatuses.Unknown</c>.</description></item>
        /// </list>
        /// It ensures the invoice is structurally complete and eligible for billing, reporting, or payment processing.
        /// </remarks>
        /// <returns>
        /// <c>true</c> if the invoice is structurally valid; otherwise, <c>false</c>.
        /// </returns>
        public bool IsValid()
        {
            return
                !string.IsNullOrWhiteSpace(InvoiceNumber) &&
                DueDate != default &&
                TenantID > 0 &&
                Status != InvoiceStatuses.Unknown;
        }
        /// <summary>
        /// Creates a deep copy of the current <c>InternetInvoice</c> instance.
        /// </summary>
        /// <returns>
        /// A new <see cref="InternetInvoice"/> object with the same <c>InvoiceNumber</c>, <c>DueDate</c>, <c>TenantID</c>, and <c>Status</c> as the original.
        /// </returns>
        /// <remarks>
        /// This method is used to duplicate internet invoice metadata for editing, simulation, or rollback purposes without affecting the original instance.
        /// Changes made to the cloned invoice will not impact the source object.
        /// </remarks>
        public InternetInvoice Clone()
        {
            return new InternetInvoice(
                this.InvoiceNumber,
                this.DueDate,
                this.TenantID,
                this.Status);
        }
    }

    internal static class InvoiceHeader
    {
        internal static string BusinessName => Configs.InvoiceRDLC.InvoiceRDLC_Config.BusinessName;
        internal static string BusinessAddress => Configs.InvoiceRDLC.InvoiceRDLC_Config.BusinessAddress;
        internal static string BusinessContactInfo
        {
            get
            {
                StringBuilder CI = new StringBuilder();

                CI.Append("Mobile: " + Configs.InvoiceRDLC.InvoiceRDLC_Config.BusinessContact_Mobile + " | ");
                CI.Append("Email: " + Configs.InvoiceRDLC.InvoiceRDLC_Config.BusinessContact_Email);

                return Configs.InvoiceRDLC.InvoiceRDLC_Config.IncludeTelephone 
                    ? CI.Append(" | Telephone: " + Configs.InvoiceRDLC.InvoiceRDLC_Config.BusinessContact_Telephone).ToString()
                    : CI.ToString();
            }
        }
        internal static string BusinessBIRInfo => Configs.InvoiceRDLC.InvoiceRDLC_Config.IncludeBIRInfo 
            ? Configs.InvoiceRDLC.InvoiceRDLC_Config.BusinessBIRInfo 
            : "";
    }
    
    internal static class InvoicePage1
    {
        private static int TenantID
        {
            get
            {
                new SelectCommand<tbinvoices>()
                    .Select(tbinvoices.TenantID)
                    .From
                    .StartWhere
                        .Where(tbinvoices.InvoiceNumber, SQLOperator.Equal, "'" + BHelper.InvoiceNumber + "'")
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                return Convert.ToInt32(Internals.DBC.Values[0]);
            }
        }
        private static string PreviousInvoiceNumber
        {
            get
            {
                DateTime prevMonthDay1 = new DateTime(InvoiceDate.AddMonths(-1).Year, InvoiceDate.AddMonths(-1).Month, 1);
                DateTime prevMonthLastDay = new DateTime(prevMonthDay1.Year, prevMonthDay1.Month, DateTime.DaysInMonth(prevMonthDay1.Year, prevMonthDay1.Month));

                new SelectCommand<tbinvoices>()
                    .Select(tbinvoices.InvoiceNumber)
                    .From
                    .StartWhere
                        .Where(tbinvoices.TenantID, SQLOperator.Equal, TenantID.ToString())
                        .And()
                        .Between(tbinvoices.InvoiceDate, prevMonthDay1.ToString("yyyy-MM-dd"), prevMonthLastDay.ToString("yyyy-MM-dd"))
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                if (Internals.DBC.HasRows)
                    return Internals.DBC.Values[0];
                Internals.DBC.CloseReader();
                return "";
            }
        }

        internal static string TenantName
        {
            get
            {
                new SelectCommand<tbtenants>()
                    .Select(tbtenants.FullName)
                    .From
                    .StartWhere
                        .Where(tbtenants.TenantID, SQLOperator.Equal, TenantID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                return Internals.DBC.Values[0];
            }
        }
        internal static string RoomName
        {
            get
            {
                int rID = 0;

                new SelectCommand<tbtenants>()
                    .Select(tbtenants.RoomID)
                    .From
                    .StartWhere
                        .Where(tbtenants.TenantID, SQLOperator.Equal, TenantID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                rID = Convert.ToInt32(Internals.DBC.Values[0]);

                new SelectCommand<tbrooms>()
                    .Select(tbrooms.RoomName)
                    .From
                    .StartWhere
                        .Where(tbrooms.RoomID, SQLOperator.Equal, rID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                return Internals.DBC.Values[0];
            }
        }
        internal static string Building
        {
            get
            {
                int bID = 0, rID = 0;

                new SelectCommand<tbtenants>()
                    .Select(tbtenants.RoomID)
                    .From
                    .StartWhere
                        .Where(tbtenants.TenantID, SQLOperator.Equal, TenantID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                rID = Convert.ToInt32(Internals.DBC.Values[0]);

                new SelectCommand<tbrooms>()
                    .Select(tbrooms.BuildingID)
                    .From
                    .StartWhere
                        .Where(tbrooms.RoomID, SQLOperator.Equal, rID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                bID = Convert.ToInt32(Internals.DBC.Values[0]);

                new SelectCommand<tbbuilding>()
                    .Select(tbbuilding.BuildingName)
                    .From
                    .StartWhere
                        .Where(tbbuilding.BuildingID, SQLOperator.Equal, bID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                return Internals.DBC.Values[0];
            }
        }
        internal static string BuildingAddress
        {
            get
            {
                int bID = 0, rID = 0;

                new SelectCommand<tbtenants>()
                    .Select(tbtenants.RoomID)
                    .From
                    .StartWhere
                        .Where(tbtenants.TenantID, SQLOperator.Equal, TenantID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                rID = Convert.ToInt32(Internals.DBC.Values[0]);

                new SelectCommand<tbrooms>()
                    .Select(tbrooms.BuildingID)
                    .From
                    .StartWhere
                        .Where(tbrooms.RoomID, SQLOperator.Equal, rID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                bID = Convert.ToInt32(Internals.DBC.Values[0]);

                new SelectCommand<tbbuilding>()
                    .Select(tbbuilding.BuildingAddress)
                    .From
                    .StartWhere
                        .Where(tbbuilding.BuildingID, SQLOperator.Equal, bID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                return Internals.DBC.Values[0];
            }
        }
        internal static DateTime InvoiceDate
        {
            get
            {
                new SelectCommand<tbinvoices>()
                    .Select(tbinvoices.InvoiceDate)
                    .From
                    .StartWhere
                        .Where(tbinvoices.InvoiceNumber, SQLOperator.Equal, "'" + BHelper.InvoiceNumber + "'")
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                return Convert.ToDateTime(Internals.DBC.Values[0]);
            }
        }
        internal static double BalanceFromPreviousInvoice
        {
            get
            {
                if (string.IsNullOrWhiteSpace(PreviousInvoiceNumber))
                    return 0;

                new SelectCommand<tbinvoices>()
                    .Select(tbinvoices.InvoiceTotal)
                    .From
                    .StartWhere
                        .Where(tbinvoices.InvoiceNumber, SQLOperator.Equal, "'" + PreviousInvoiceNumber + "'")
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                return Convert.ToDouble(Internals.DBC.Values[0]);
            }
        }
        internal static double PaymentsReceived
        {
            get
            {
                double PR = 0;

                if (string.IsNullOrWhiteSpace(PreviousInvoiceNumber))
                    return PR;

                new SelectCommand<tbinvoicepayments>()
                    .Select(tbinvoicepayments.AmountPaid)
                    .From
                    .StartWhere
                        .Where(tbinvoicepayments.InvoiceNumber, SQLOperator.Equal, "'" + PreviousInvoiceNumber + "'")
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                if (Internals.DBC.HasRows)
                    foreach (string ap in Internals.DBC.Values)
                        PR += Convert.ToDouble(ap);
                Internals.DBC.CloseReader();
                return 0;
            }
        }
        internal static double RemainingBalance
        {
            get
            {
                double RB = 0;

                if (string.IsNullOrWhiteSpace(PreviousInvoiceNumber))
                    return RB;

                new SelectCommand<tbwaterinvoice>()
                    .Select(tbwaterinvoice.BillBalance)
                    .From
                    .StartWhere
                        .Where(tbwaterinvoice.InvoiceNumber, SQLOperator.Equal, "'" + PreviousInvoiceNumber + "'")
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                RB += Convert.ToDouble(Internals.DBC.Values[0]);

                new SelectCommand<tbelectricityinvoice>()
                    .Select(tbelectricityinvoice.BillBalance)
                    .From
                    .StartWhere
                        .Where(tbelectricityinvoice.InvoiceNumber, SQLOperator.Equal, "'" + PreviousInvoiceNumber + "'")
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                RB += Convert.ToDouble(Internals.DBC.Values[0]);

                new SelectCommand<tbrentalinvoice>()
                    .Select(tbrentalinvoice.BillBalance)
                    .From
                    .StartWhere
                        .Where(tbrentalinvoice.InvoiceNumber, SQLOperator.Equal, "'" + PreviousInvoiceNumber + "'")
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                RB += Convert.ToDouble(Internals.DBC.Values[0]);

                new SelectCommand<tbinternetinvoice>()
                    .Select(tbinternetinvoice.BillBalance)
                    .From
                    .StartWhere
                        .Where(tbinternetinvoice.InvoiceNumber, SQLOperator.Equal, "'" + PreviousInvoiceNumber + "'")
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                if (Internals.DBC.HasRows)
                    RB += Convert.ToDouble(Internals.DBC.Values[0]);
                Internals.DBC.CloseReader();
                return RB;
            }
        }
        internal static DateTime UtilitiesDueDate
        {
            get
            {
                DateTime WDD;
                DateTime EDD;

                new SelectCommand<tbwaterinvoice>()
                    .Select(tbwaterinvoice.DueDate)
                    .From
                    .StartWhere
                        .Where(tbwaterinvoice.InvoiceNumber, SQLOperator.Equal, "@InvoiceNumber")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvoiceNumber", BHelper.InvoiceNumber));
                WDD = Convert.ToDateTime(Internals.DBC.Values[0]);

                new SelectCommand<tbelectricityinvoice>()
                    .Select(tbelectricityinvoice.DueDate)
                    .From
                    .StartWhere
                        .Where(tbelectricityinvoice.InvoiceNumber, SQLOperator.Equal, "@InvoiceNumber")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvoiceNumber", BHelper.InvoiceNumber));
                EDD = Convert.ToDateTime(Internals.DBC.Values[0]);

                if (WDD == EDD)
                    return WDD;
                else
                    throw new Exception("An error occurred while retrieving Utilities Due Date.");
            }
        }
        internal static DateTime RentalDueDate
        {
            get
            {
                new SelectCommand<tbrentalinvoice>()
                    .Select(tbrentalinvoice.DueDate)
                    .From
                    .StartWhere
                        .Where(tbrentalinvoice.InvoiceNumber, SQLOperator.Equal, "@InvoiceNumber")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvoiceNumber", BHelper.InvoiceNumber));
                return Convert.ToDateTime(Internals.DBC.Values[0]);
            }
        }
        internal static DateTime InternetDueDate
        {
            get
            {
                new SelectCommand<tbinternetinvoice>()
                    .Select(tbinternetinvoice.DueDate)
                    .From
                    .StartWhere
                        .Where(tbinternetinvoice.InvoiceNumber, SQLOperator.Equal, "@InvoiceNumber")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvoiceNumber", BHelper.InvoiceNumber));
                return Convert.ToDateTime(Internals.DBC.Values[0]);
            }
        }
        internal static double UtilitiesCurrentCharges
        {
            get
            {
                double UCC = 0;

                new SelectCommand<tbwaterinvoice>()
                    .Select(tbwaterinvoice.CurrentCharge)
                    .Select(tbwaterinvoice.Deductions)
                    .From
                    .StartWhere
                        .Where(tbwaterinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", BHelper.InvoiceNumber));
                UCC += Convert.ToDouble(Internals.DBC.Values[0]) - Convert.ToDouble(Internals.DBC.Values[1]);

                new SelectCommand<tbelectricityinvoice>()
                    .Select(tbelectricityinvoice.CurrentCharge)
                    .Select(tbelectricityinvoice.Deductions)
                    .From
                    .StartWhere
                        .Where(tbelectricityinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", BHelper.InvoiceNumber));
                UCC += Convert.ToDouble(Internals.DBC.Values[0]) - Convert.ToDouble(Internals.DBC.Values[1]);

                return UCC;
            }
        }
        internal static double RentalCurrentCharges
        {
            get
            {
                new SelectCommand<tbrentalinvoice>()
                    .Select(tbrentalinvoice.Subtotal)
                    .Select(tbrentalinvoice.Deductions)
                    .From
                    .StartWhere
                        .Where(tbrentalinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", BHelper.InvoiceNumber));
                return Convert.ToDouble(Internals.DBC.Values[0]) - Convert.ToDouble(Internals.DBC.Values[1]);
            }
        }
        internal static double InternetCurrentCharges
        {
            get
            {
                new SelectCommand<tbinternetinvoice>()
                    .Select(tbinternetinvoice.Subtotal)
                    .Select(tbinternetinvoice.Deductions)
                    .From
                    .StartWhere
                        .Where(tbinternetinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", BHelper.InvoiceNumber));
                return Convert.ToDouble(Internals.DBC.Values[0]) - Convert.ToDouble(Internals.DBC.Values[1]);
            }
        }
        internal static double TotalCurrentCharges => UtilitiesCurrentCharges + RentalCurrentCharges + InternetCurrentCharges;
        internal static double TotalAmountDue
        {
            get
            {
                new SelectCommand<tbinvoices>()
                    .Select(tbinvoices.InvoiceTotal)
                    .From
                    .StartWhere
                        .Where(tbinvoices.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", BHelper.InvoiceNumber));
                return Convert.ToDouble(Internals.DBC.Values[0]);
            }
        }
    }

    internal static class InvoicePage2
    {
        private static int TenantID
        {
            get
            {
                new SelectCommand<tbinvoices>()
                    .Select(tbinvoices.TenantID)
                    .From
                    .StartWhere
                        .Where(tbinvoices.InvoiceNumber, SQLOperator.Equal, "'" + BHelper.InvoiceNumber + "'")
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                return Convert.ToInt32(Internals.DBC.Values[0]);
            }
        }
        private static string PreviousInvoiceNumber
        {
            get
            {
                DateTime prevMonthDay1 = new DateTime(InvoicePage1.InvoiceDate.AddMonths(-1).Year, InvoicePage1.InvoiceDate.AddMonths(-1).Month, 1);
                DateTime prevMonthLastDay = new DateTime(prevMonthDay1.Year, prevMonthDay1.Month, DateTime.DaysInMonth(prevMonthDay1.Year, prevMonthDay1.Month));

                new SelectCommand<tbinvoices>()
                    .Select(tbinvoices.InvoiceNumber)
                    .From
                    .StartWhere
                        .Where(tbinvoices.TenantID, SQLOperator.Equal, TenantID.ToString())
                        .And()
                        .Between(tbinvoices.InvoiceDate, prevMonthDay1.ToString("yyyy-MM-dd"), prevMonthLastDay.ToString("yyyy-MM-dd"))
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                if (Internals.DBC.HasRows)
                    return Internals.DBC.Values[0];
                Internals.DBC.CloseReader();
                return "";
            }
        }

        internal static double WaterPreviousBalance
        {
            get
            {
                if (string.IsNullOrWhiteSpace(PreviousInvoiceNumber))
                    return 0;

                new SelectCommand<tbwaterinvoice>()
                    .Select(tbwaterinvoice.Subtotal)
                    .From
                    .StartWhere
                        .Where(tbwaterinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", PreviousInvoiceNumber));
                if (Internals.DBC.HasRows)
                    return Convert.ToDouble(Internals.DBC.Values[0]);
                Internals.DBC.CloseReader();
                return 0;
            }
        }
        internal static double WaterPaymentsReceived
        {
            get
            {
                double WPR = 0;

                if (string.IsNullOrWhiteSpace(PreviousInvoiceNumber))
                    return WPR;

                new SelectCommand<tbinvoicepayments>()
                    .Select(tbinvoicepayments.AmountPaid)
                    .From
                    .StartWhere
                        .Where(tbinvoicepayments.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                        .And(tbinvoicepayments.InvoiceType, SQLOperator.Equal, "'" + InvoiceTypes.WATER.ToString() + "'")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", PreviousInvoiceNumber));
                if (Internals.DBC.HasRows)
                    foreach (string ap in Internals.DBC.Values)
                        WPR += Convert.ToDouble(ap);
                Internals.DBC.CloseReader();
                return WPR;
            }
        }
        internal static double WaterRemainingBalance
        {
            get
            {
                if (string.IsNullOrWhiteSpace(PreviousInvoiceNumber))
                    return 0;

                new SelectCommand<tbwaterinvoice>()
                    .Select(tbwaterinvoice.BillBalance)
                    .From
                    .StartWhere
                        .Where(tbwaterinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", PreviousInvoiceNumber));
                if (Internals.DBC.HasRows)
                    return Convert.ToDouble(Internals.DBC.Values[0]);
                Internals.DBC.CloseReader();
                return 0;
            }
        }
        internal static double WaterPrevious
        {
            get
            {
                new SelectCommand<tbwaterinvoice>()
                    .Select(tbwaterinvoice.PreviousReading)
                    .From
                    .StartWhere
                        .Where(tbwaterinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", BHelper.InvoiceNumber));
                return Convert.ToDouble(Internals.DBC.Values[0]);
            }
        }
        internal static double WaterPresent
        {
            get
            {
                new SelectCommand<tbwaterinvoice>()
                    .Select(tbwaterinvoice.PresentReading)
                    .From
                    .StartWhere
                        .Where(tbwaterinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", BHelper.InvoiceNumber));
                return Convert.ToDouble(Internals.DBC.Values[0]);
            }
        }
        internal static string WaterConsumption
        {
            get
            {
                new SelectCommand<tbwaterinvoice>()
                    .Select(tbwaterinvoice.Consumption)
                    .From
                    .StartWhere
                        .Where(tbwaterinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", BHelper.InvoiceNumber));
                return Internals.DBC.Values[0] + Configs.Utilities.UtilitiesConfig.Water_Unit;
            }
        }
        internal static double WaterConsumptionCharge
        {
            get
            {
                new SelectCommand<tbwaterinvoice>()
                    .Select(tbwaterinvoice.CurrentCharge)
                    .From
                    .StartWhere
                        .Where(tbwaterinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", BHelper.InvoiceNumber));
                return Convert.ToDouble(Internals.DBC.Values[0]);
            }
        }
        internal static double WaterDeductions
        {
            get
            {
                new SelectCommand<tbwaterinvoice>()
                    .Select(tbwaterinvoice.Deductions)
                    .From
                    .StartWhere
                        .Where(tbwaterinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", BHelper.InvoiceNumber));
                return Convert.ToDouble(Internals.DBC.Values[0]);
            }
        }
        internal static double WaterCurrentCharges
        {
            get
            {
                new SelectCommand<tbwaterinvoice>()
                    .Select(tbwaterinvoice.Subtotal)
                    .From
                    .StartWhere
                        .Where(tbwaterinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", BHelper.InvoiceNumber));
                return Convert.ToDouble(Internals.DBC.Values[0]);
            }
        }

        internal static double ElectricityPreviousBalance
        {
            get
            {
                if (string.IsNullOrWhiteSpace(PreviousInvoiceNumber))
                    return 0;

                new SelectCommand<tbelectricityinvoice>()
                    .Select(tbelectricityinvoice.Subtotal)
                    .From
                    .StartWhere
                        .Where(tbelectricityinvoice.InvoiceNumber, SQLOperator.Equal, "@PrevInvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@PrevInvNum", PreviousInvoiceNumber));
                if (Internals.DBC.HasRows)
                    return Convert.ToDouble(Internals.DBC.Values[0]);
                Internals.DBC.CloseReader();
                return 0;
            }
        }
        internal static double ElectricityPaymentsReceived
        {
            get
            {
                double EPR = 0;

                if (string.IsNullOrWhiteSpace(PreviousInvoiceNumber))
                    return EPR;

                new SelectCommand<tbinvoicepayments>()
                    .Select(tbinvoicepayments.AmountPaid)
                    .From
                    .StartWhere
                        .Where(tbinvoicepayments.InvoiceNumber, SQLOperator.Equal, "@PrevInvNum")
                        .And(tbinvoicepayments.InvoiceType, SQLOperator.Equal, "'" + InvoiceTypes.ELECTRICITY.ToString() + "'")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@PrevInvNum", PreviousInvoiceNumber));
                if (Internals.DBC.HasRows)
                    foreach (string ap in Internals.DBC.Values)
                        EPR += Convert.ToDouble(ap);
                Internals.DBC.CloseReader();
                return EPR;
            }
        }
        internal static double ElectricityRemainingBalance
        {
            get
            {
                if (string.IsNullOrWhiteSpace(PreviousInvoiceNumber))
                    return 0;

                new SelectCommand<tbelectricityinvoice>()
                    .Select(tbelectricityinvoice.BillBalance)
                    .From
                    .StartWhere
                        .Where(tbelectricityinvoice.InvoiceNumber, SQLOperator.Equal, "@PrevInvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@PrevInvNum", PreviousInvoiceNumber));
                if (Internals.DBC.HasRows)
                    return Convert.ToDouble(Internals.DBC.Values[0]);
                Internals.DBC.CloseReader();
                return 0;
            }
        }
        internal static double ElectricityPrevious
        {
            get
            {
                new SelectCommand<tbelectricityinvoice>()
                    .Select(tbelectricityinvoice.PreviousReading)
                    .From
                    .StartWhere
                        .Where(tbelectricityinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", BHelper.InvoiceNumber));
                return Convert.ToDouble(Internals.DBC.Values[0]);
            }
        }
        internal static double ElectricityPresent
        {
            get
            {
                new SelectCommand<tbelectricityinvoice>()
                    .Select(tbelectricityinvoice.PresentReading)
                    .From
                    .StartWhere
                        .Where(tbelectricityinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", BHelper.InvoiceNumber));
                return Convert.ToDouble(Internals.DBC.Values[0]);
            }
        }
        internal static string ElectricityConsumption
        {
            get
            {
                new SelectCommand<tbelectricityinvoice>()
                    .Select(tbelectricityinvoice.Consumption)
                    .From
                    .StartWhere
                        .Where(tbelectricityinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", BHelper.InvoiceNumber));
                return Internals.DBC.Values[0] + Configs.Utilities.UtilitiesConfig.Electricity_Unit;
            }
        }
        internal static double ElectricityConsumptionCharge
        {
            get
            {
                new SelectCommand<tbelectricityinvoice>()
                    .Select(tbelectricityinvoice.CurrentCharge)
                    .From
                    .StartWhere
                        .Where(tbelectricityinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", BHelper.InvoiceNumber));
                return Convert.ToDouble(Internals.DBC.Values[0]);
            }
        }
        internal static double ElectricityDeductions
        {
            get
            {
                new SelectCommand<tbelectricityinvoice>()
                    .Select(tbelectricityinvoice.Deductions)
                    .From
                    .StartWhere
                        .Where(tbelectricityinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", BHelper.InvoiceNumber));
                return Convert.ToDouble(Internals.DBC.Values[0]);
            }
        }
        internal static double ElectricityCurrentCharges
        {
            get
            {
                new SelectCommand<tbelectricityinvoice>()
                    .Select(tbelectricityinvoice.Subtotal)
                    .From
                    .StartWhere
                        .Where(tbelectricityinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", BHelper.InvoiceNumber));
                return Convert.ToDouble(Internals.DBC.Values[0]);
            }
        }
    }

    internal static class InvoicePage3
    {
        private static int TenantID
        {
            get
            {
                new SelectCommand<tbinvoices>()
                    .Select(tbinvoices.TenantID)
                    .From
                    .StartWhere
                        .Where(tbinvoices.InvoiceNumber, SQLOperator.Equal, "'" + BHelper.InvoiceNumber + "'")
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                return Convert.ToInt32(Internals.DBC.Values[0]);
            }
        }
        private static string PreviousInvoiceNumber
        {
            get
            {
                DateTime prevMonthDay1 = new DateTime(InvoicePage1.InvoiceDate.AddMonths(-1).Year, InvoicePage1.InvoiceDate.AddMonths(-1).Month, 1);
                DateTime prevMonthLastDay = new DateTime(prevMonthDay1.Year, prevMonthDay1.Month, DateTime.DaysInMonth(prevMonthDay1.Year, prevMonthDay1.Month));

                new SelectCommand<tbinvoices>()
                    .Select(tbinvoices.InvoiceNumber)
                    .From
                    .StartWhere
                        .Where(tbinvoices.TenantID, SQLOperator.Equal, TenantID.ToString())
                        .And()
                        .Between(tbinvoices.InvoiceDate, prevMonthDay1.ToString("yyyy-MM-dd"), prevMonthLastDay.ToString("yyyy-MM-dd"))
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                if (Internals.DBC.HasRows)
                    return Internals.DBC.Values[0];
                Internals.DBC.CloseReader();
                return "";
            }
        }

        internal static double RentalPreviousBalance
        {
            get
            {
                if (string.IsNullOrWhiteSpace(PreviousInvoiceNumber))
                    return 0;

                new SelectCommand<tbrentalinvoice>()
                    .Select(tbrentalinvoice.Subtotal)
                    .From
                    .StartWhere
                        .Where(tbrentalinvoice.InvoiceNumber, SQLOperator.Equal, "@PrevInvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@PrevInvNum", PreviousInvoiceNumber));
                if (Internals.DBC.HasRows)
                    return Convert.ToDouble(Internals.DBC.Values[0]);
                Internals.DBC.CloseReader();
                return 0;
            }
        }
        internal static double RentalPaymentsReceived
        {
            get
            {
                double RPR = 0;

                if (string.IsNullOrWhiteSpace(PreviousInvoiceNumber))
                    return RPR;

                new SelectCommand<tbinvoicepayments>()
                    .Select(tbinvoicepayments.AmountPaid)
                    .From
                    .StartWhere
                        .Where(tbinvoicepayments.InvoiceNumber, SQLOperator.Equal, "@PrevInvNum")
                        .And(tbinvoicepayments.InvoiceType, SQLOperator.Equal, "'" + InvoiceTypes.RENTAL.ToString() + "'")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@PrevInvNum", PreviousInvoiceNumber));
                if (Internals.DBC.HasRows)
                    foreach (string ap in Internals.DBC.Values)
                        RPR += Convert.ToDouble(ap);
                Internals.DBC.CloseReader();
                return RPR;
            }
        }
        internal static double RentalRemainingBalance
        {
            get
            {
                if (string.IsNullOrWhiteSpace(PreviousInvoiceNumber))
                    return 0;

                new SelectCommand<tbrentalinvoice>()
                    .Select(tbrentalinvoice.BillBalance)
                    .From
                    .StartWhere
                        .Where(tbrentalinvoice.InvoiceNumber, SQLOperator.Equal, "@PrevInvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@PrevInvNum", PreviousInvoiceNumber));
                if (Internals.DBC.HasRows)
                    return Convert.ToDouble(Internals.DBC.Values[0]);
                Internals.DBC.CloseReader();
                return 0;
            }
        }
        internal static double RentalMonthlyRent
        {
            get
            {
                new SelectCommand<tbrentalinvoice>()
                    .Select(tbrentalinvoice.MonthlyRent)
                    .From
                    .StartWhere
                        .Where(tbrentalinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", BHelper.InvoiceNumber));
                return Convert.ToDouble(Internals.DBC.Values[0]);
            }
        }
        internal static double RentalDeductions
        {
            get
            {
                new SelectCommand<tbrentalinvoice>()
                    .Select(tbrentalinvoice.Deductions)
                    .From
                    .StartWhere
                        .Where(tbrentalinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", BHelper.InvoiceNumber));
                return Convert.ToDouble(Internals.DBC.Values[0]);
            }
        }
        internal static double RentalCurrentCharges
        {
            get
            {
                new SelectCommand<tbrentalinvoice>()
                    .Select(tbrentalinvoice.Subtotal)
                    .From
                    .StartWhere
                        .Where(tbrentalinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", BHelper.InvoiceNumber));
                return Convert.ToDouble(Internals.DBC.Values[0]);
            }
        }

        internal static double InternetPreviousBalance
        {
            get
            {
                if (string.IsNullOrWhiteSpace(PreviousInvoiceNumber))
                    return 0;

                new SelectCommand<tbinternetinvoice>()
                    .Select(tbinternetinvoice.Subtotal)
                    .From
                    .StartWhere
                        .Where(tbinternetinvoice.InvoiceNumber, SQLOperator.Equal, "@PrevInvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@PrevInvNum", PreviousInvoiceNumber));
                if (Internals.DBC.HasRows)
                    return Convert.ToDouble(Internals.DBC.Values[0]);
                Internals.DBC.CloseReader();
                return 0;
            }
        }
        internal static double InternetPaymentsReceived
        {
            get
            {
                double IPR = 0;

                if (string.IsNullOrWhiteSpace(PreviousInvoiceNumber))
                    return IPR;

                new SelectCommand<tbinvoicepayments>()
                    .Select(tbinvoicepayments.AmountPaid)
                    .From
                    .StartWhere
                        .Where(tbinvoicepayments.InvoiceNumber, SQLOperator.Equal, "@PrevInvNum")
                        .And(tbinvoicepayments.InvoiceType, SQLOperator.Equal, "'" + InvoiceTypes.INTERNET.ToString() + "'")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@PrevInvNum", PreviousInvoiceNumber));
                if (Internals.DBC.HasRows)
                    foreach (string ap in Internals.DBC.Values)
                        IPR += Convert.ToDouble(ap);
                Internals.DBC.CloseReader();
                return IPR;
            }
        }
        internal static double InternetRemainingBalance
        {
            get
            {
                if (string.IsNullOrWhiteSpace(PreviousInvoiceNumber))
                    return 0;

                new SelectCommand<tbinternetinvoice>()
                    .Select(tbinternetinvoice.BillBalance)
                    .From
                    .StartWhere
                        .Where(tbinternetinvoice.InvoiceNumber, SQLOperator.Equal, "@PrevInvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@PrevInvNum", PreviousInvoiceNumber));
                if (Internals.DBC.HasRows)
                    return Convert.ToDouble(Internals.DBC.Values[0]);
                Internals.DBC.CloseReader();
                return 0;
            }
        }
        internal static string InternetPlanAvailed
        {
            get
            {
                new SelectCommand<tbinternetinvoice>()
                    .Select(tbinternetinvoice.PlanName)
                    .From
                    .StartWhere
                        .Where(tbinternetinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", BHelper.InvoiceNumber));
                return Internals.DBC.Values[0];
            }
        }
        internal static double InternetSubscriptionCharge
        {
            get
            {
                new SelectCommand<tbinternetinvoice>()
                    .Select(tbinternetinvoice.SubscriptionFee)
                    .From
                    .StartWhere
                        .Where(tbinternetinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", BHelper.InvoiceNumber));
                return Convert.ToDouble(Internals.DBC.Values[0]);
            }
        }
        internal static double InternetDeductions
        {
            get
            {
                new SelectCommand<tbinternetinvoice>()
                    .Select(tbinternetinvoice.Deductions)
                    .From
                    .StartWhere
                        .Where(tbinternetinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", BHelper.InvoiceNumber));
                return Convert.ToDouble(Internals.DBC.Values[0]);
            }
        }
        internal static double InternetCurrentCharges
        {
            get
            {
                new SelectCommand<tbinternetinvoice>()
                    .Select(tbinternetinvoice.Subtotal)
                    .From
                    .StartWhere
                        .Where(tbinternetinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", BHelper.InvoiceNumber));
                return Convert.ToDouble(Internals.DBC.Values[0]);
            }
        }
    }

    internal static class InvoicePage4
    {
        internal static double TotalUtilitiesCharges
        {
            get
            {
                double TUC = 0;

                new SelectCommand<tbwaterinvoice>()
                    .Select(tbwaterinvoice.Subtotal)
                    .From
                    .StartWhere
                        .Where(tbwaterinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", BHelper.InvoiceNumber));
                TUC += Convert.ToDouble(Internals.DBC.Values[0]);

                new SelectCommand<tbelectricityinvoice>()
                    .Select(tbelectricityinvoice.Subtotal)
                    .From
                    .StartWhere
                        .Where(tbelectricityinvoice.InvoiceNumber, SQLOperator.Equal, "@InvNum")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@InvNum", BHelper.InvoiceNumber));
                TUC += Convert.ToDouble(Internals.DBC.Values[0]);

                return TUC;
            }
        }

    }
}