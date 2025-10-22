using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Management_System.Billing
{
    internal struct InvoiceMetadata
    {
        public int TenantID { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int WaterInvoiceID { get; set; }
        public int ElectricityInvoiceID { get; set; }
        public int RentalInvoiceID { get; set; }
        public int InternetInvoiceID { get; set; }
        public int IncludeInternet { get; set; }
        public double InvoiceTotal { get; set; }
        public InvoiceStatuses Status { get; set; }

        public InvoiceMetadata(
            int SetTenantID = -1,
            string SetInvoiceNumber = "",
            DateTime SetInvoiceDate = default,
            int SetWaterInvoiceID = -1,
            int SetElectricityInvoiceID = -1,
            int SetRentalInvoiceID = -1,
            int SetInternetInvoiceID = -1,
            int SetIncludeInternet = 0,
            double SetInvoiceTotal = -1,
            InvoiceStatuses SetStatus = InvoiceStatuses.Unknown)
        {
            TenantID = SetTenantID;
            InvoiceNumber = SetInvoiceNumber;
            InvoiceDate = SetInvoiceDate;
            WaterInvoiceID = SetWaterInvoiceID;
            ElectricityInvoiceID = SetElectricityInvoiceID;
            RentalInvoiceID = SetRentalInvoiceID;
            InternetInvoiceID = SetInternetInvoiceID;
            IncludeInternet = SetIncludeInternet;
            InvoiceTotal = SetInvoiceTotal;
            Status = SetStatus;
        }

        public bool IsValid()
        {
            return
                TenantID > 0 &&
                !string.IsNullOrWhiteSpace(InvoiceNumber) &&
                InvoiceDate != default &&
                WaterInvoiceID >= 0 &&
                ElectricityInvoiceID >= 0 &&
                RentalInvoiceID >= 0 &&
                InternetInvoiceID >= 0 &&
                InvoiceTotal >= 0 &&
                Status != InvoiceStatuses.Unknown;
        }
        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    internal struct DueDatesMetadata
    {
        public DateTime UtilitiesDueDate { get; set; }
        public DateTime RentalDueDate { get; set; }
        public DateTime InternetDueDate { get; set; }

        public DueDatesMetadata(
            DateTime SetUtilitiesDueDate = default,
            DateTime SetRentalDueDate = default,
            DateTime SetInternetDueDate = default)
        {
            UtilitiesDueDate = SetUtilitiesDueDate;
            RentalDueDate = SetRentalDueDate;
            InternetDueDate = SetInternetDueDate;
        }

        public bool IsValid()
        {
            if (BHelper.IncludeInternet == true)
                return
                    UtilitiesDueDate != default &&
                    RentalDueDate != default &&
                    InternetDueDate != default;
            else
                return
                    UtilitiesDueDate != default &&
                    RentalDueDate != default;
        }
    }
}
