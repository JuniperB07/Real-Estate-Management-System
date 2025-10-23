using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;

namespace Real_Estate_Management_System.Billing
{
    internal static class BHelper
    {
        internal static Invoice NewInvoice;
        internal static WaterInvoice NewWaterInvoice;
        internal static ElectricityInvoice NewElectricityInvoice;
        internal static RentalInvoice NewRentalInvoice;
        internal static InternetInvoice NewInternetInvoice;

        internal static int TenantID { get; set; }
        internal static DateTime DueDate_Utility { get; set; }
        internal static DateTime DueDate_Rental { get; set; }
        internal static DateTime DueDate_Internet { get; set; }

        internal static double NewInvoiceTotal
        {
            get
            {
                return
                    NewWaterInvoice.Subtotal +
                    NewElectricityInvoice.Subtotal +
                    NewRentalInvoice.Subtotal +
                    NewInternetInvoice.Subtotal +
                    NewInvoice.TotalPenalties;
            }
        }
        internal static bool InvoicesValid
        {
            get
            {
                return
                    NewWaterInvoice.IsValid() &&
                    NewElectricityInvoice.IsValid() &&
                    NewRentalInvoice.IsValid() &&
                    NewInternetInvoice.IsValid() &&
                    NewInvoice.IsValid();
            }
        }

        internal static Configs.DueDateModes DueDateMode_Utility => Configs.DueDates.DueDatesConfig.DueDateMode_Utilities;
        internal static Configs.DueDateModes DueDateMode_Rental => Configs.DueDates.DueDatesConfig.DueDateMode_Rental;
        internal static Configs.DueDateModes DueDateMode_Internet => Configs.DueDates.DueDatesConfig.DueDateMode_Internet;
    }
}
