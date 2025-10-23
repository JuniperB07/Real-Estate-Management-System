using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;
using System.ComponentModel.Design;
using Org.BouncyCastle.Asn1.Mozilla;

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
        /// Gets a comma-separated string of penalty IDs associated with the tenant that are either unpaid or partially paid.
        /// </summary>
        /// <remarks>
        /// This property queries the <c>tbpenalties</c> table using the current <c>TenantID</c> and filters by <c>Status</c> values <c>UNPAID</c> and <c>PARTIAL</c>.
        /// It returns a string of matching <c>PenaltyID</c> values separated by commas, with a trailing comma included.
        /// </remarks>
        /// <returns>
        /// A comma-separated list of penalty IDs if any exist; otherwise, an empty string.
        /// </returns>
        public string PenaltyIDs
        {
            get
            {
                List<int> pIDs = new List<int>();
                string pIDString = "";

                new SelectCommand<tbpenalties>()
                    .Select(tbpenalties.PenaltyID)
                    .From
                    .StartWhere
                        .Where(tbpenalties.TenantID, SQLOperator.Equal, TenantID.ToString())
                        .And()
                        .StartGroup(tbpenalties.Status, SQLOperator.Equal, "'" + PenaltyStatuses.UNPAID.ToString() + "'")
                            .Or(tbpenalties.Status, SQLOperator.Equal, "'" + PenaltyStatuses.PARTIAL.ToString() + "'")
                        .EndGroup
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                if (Internals.DBC.HasRows)
                    foreach (string PID in Internals.DBC.Values)
                        pIDs.Add(Convert.ToInt32(PID));
                Internals.DBC.CloseReader();

                foreach (int PID in pIDs)
                    pIDString += PID.ToString() + ",";

                return pIDString;
            }
        }
        /// <summary>
        /// Calculates the total outstanding penalty amount for the tenant based on unpaid and partially paid penalties.
        /// </summary>
        /// <remarks>
        /// This property parses the <c>PenaltyIDs</c> string into a list of penalty identifiers, then queries the <c>tbpenalties</c> table for each.
        /// If a penalty is marked as <c>UNPAID</c>, the full <c>PenaltyAmount</c> is added to the total.
        /// If marked as <c>PARTIAL</c>, only the remaining balance (<c>PenaltyAmount - AmountPaid</c>) is added.
        /// </remarks>
        /// <returns>
        /// The total penalty amount due for the tenant.
        /// </returns>
        public double TotalPenalties
        {
            get
            {
                MySqlDataReader reader;
                double TP = 0;

                if (!string.IsNullOrWhiteSpace(PenaltyIDs))
                {
                    List<int> pIDs = PenaltyIDs.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                    foreach(int PID in pIDs)
                    {
                        new SelectCommand<tbpenalties>()
                            .Select(new tbpenalties[]
                            {
                                tbpenalties.PenaltyAmount,
                                tbpenalties.AmountPaid,
                                tbpenalties.Status
                            })
                            .From
                            .StartWhere
                                .Where(tbpenalties.PenaltyID, SQLOperator.Equal, PID.ToString())
                            .EndWhere
                            .ExecuteReader(Internals.DBC);
                        reader = Internals.DBC.Reader;

                        while (reader.Read())
                        {
                            if (reader[2].ToString() == PenaltyStatuses.UNPAID.ToString())
                                TP += Convert.ToDouble(reader[0].ToString());
                            else
                            {
                                double pa = Convert.ToDouble(reader[0].ToString());
                                double ap = Convert.ToDouble(reader[1].ToString());

                                TP += pa - ap;
                            }
                        }

                        reader.Close();
                        Internals.DBC.CloseReader();
                    }
                }

                return TP;
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

                InvT += TotalPenalties;

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
        /// Initializes a new instance of the <c>WaterInvoice</c> class with specified invoice metadata and meter readings.
        /// </summary>
        /// <param name="SetInvoiceNumber">The invoice number used to identify the billing record.</param>
        /// <param name="SetTenantID">The tenant ID associated with the invoice.</param>
        /// <param name="SetPreviousReading">The previous water meter reading.</param>
        /// <param name="SetPresentReading">The present water meter reading.</param>
        /// <param name="SetStatus">The status of the invoice, such as <c>Unpaid</c>, <c>Partial</c>, or <c>Paid</c>.</param>
        /// <remarks>
        /// This constructor sets the initial state of the invoice, including readings and status, without performing any validation or computation.
        /// Use <c>IsValid()</c> to verify that the constructed invoice meets minimum requirements for processing.
        /// </remarks>
        public WaterInvoice(
            string SetInvoiceNumber = "",
            int SetTenantID = 0,
            double SetPreviousReading = 0,
            double SetPresentReading = 0,
            InvoiceStatuses SetStatus = InvoiceStatuses.Unknown)
        {
            InvoiceNumber = SetInvoiceNumber;
            TenantID = SetTenantID;
            PreviousReading = SetPreviousReading;
            PresentReading = SetPresentReading;
            Status = SetStatus;
        }

        /// <summary>
        /// Determines whether the current water invoice contains valid metadata and meter readings.
        /// </summary>
        /// <remarks>
        /// This method checks that:
        /// <list type="bullet">
        ///   <item><description><c>InvoiceNumber</c> is not null or whitespace.</description></item>
        ///   <item><description><c>TenantID</c> is greater than 0.</description></item>
        ///   <item><description><c>Consumption</c> is non-negative.</description></item>
        ///   <item><description><c>Status</c> is not <c>InvoiceStatuses.Unknown</c>.</description></item>
        /// </list>
        /// It is used to validate invoice readiness before processing, saving, or billing.
        /// </remarks>
        /// <returns>
        /// <c>true</c> if the invoice is structurally valid; otherwise, <c>false</c>.
        /// </returns>
        public bool IsValid()
        {
            return
                !string.IsNullOrWhiteSpace(InvoiceNumber) &&
                TenantID > 0 &&
                Consumption >= 0 &&
                Status != InvoiceStatuses.Unknown;
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
        /// Initializes a new instance of the <c>ElectricityInvoice</c> class with specified invoice metadata and meter readings.
        /// </summary>
        /// <param name="SetInvoiceNumber">The invoice number used to identify the billing record.</param>
        /// <param name="SetTenantID">The tenant ID associated with the invoice.</param>
        /// <param name="SetPreviousReading">The previous electricity meter reading.</param>
        /// <param name="SetPresentReading">The present electricity meter reading.</param>
        /// <param name="SetStatus">The status of the invoice, such as <c>Unpaid</c>, <c>Partial</c>, or <c>Paid</c>.</param>
        /// <remarks>
        /// This constructor sets the initial state of the invoice, including readings and status, without performing any validation or computation.
        /// Use <c>IsValid()</c> to verify that the constructed invoice meets minimum requirements for processing.
        /// </remarks>
        public ElectricityInvoice(
            string SetInvoiceNumber = "",
            int SetTenantID = 0,
            double SetPreviousReading = 0,
            double SetPresentReading = 0,
            InvoiceStatuses SetStatus = InvoiceStatuses.Unknown)
        {
            InvoiceNumber = SetInvoiceNumber;
            TenantID = SetTenantID;
            PreviousReading = SetPreviousReading;
            PresentReading = SetPresentReading;
            Status = SetStatus;
        }

        /// <summary>
        /// Determines whether the current electricity invoice contains valid metadata and meter readings.
        /// </summary>
        /// <remarks>
        /// This method checks that:
        /// <list type="bullet">
        ///   <item><description><c>InvoiceNumber</c> is not null or whitespace.</description></item>
        ///   <item><description><c>TenantID</c> is greater than 0.</description></item>
        ///   <item><description><c>Consumption</c> is non-negative.</description></item>
        ///   <item><description><c>Status</c> is not <c>InvoiceStatuses.Unknown</c>.</description></item>
        /// </list>
        /// It is used to validate invoice readiness before processing, saving, or billing.
        /// </remarks>
        /// <returns>
        /// <c>true</c> if the invoice is structurally valid; otherwise, <c>false</c>.
        /// </returns>
        public bool IsValid()
        {
            return
                !string.IsNullOrWhiteSpace(InvoiceNumber) &&
                TenantID > 0 &&
                Consumption >= 0 &&
                Status != InvoiceStatuses.Unknown;
        }
    }

    internal class RentalInvoice
    {

    }
}
