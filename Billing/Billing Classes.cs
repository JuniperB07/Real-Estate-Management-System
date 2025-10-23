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

        public string InvoiceNumber { get; set; }
        public int TenantID { get; set; }
        public double PreviousReading { get; set; }
        public double PresentReading { get; set; }

        public double Consumption
        {
            get
            {
                if (!(PreviousReading > 0) || !(PresentReading > 0))
                    return -1;

                if (PresentReading < PreviousReading)
                    return -1;

                return PresentReading - PreviousReading;
            }
        }
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
    }
}
