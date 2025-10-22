using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Management_System.Billing
{
    internal static class BHelper
    {
        internal static bool IncludeInternet { get { return Configs.Billing.BillingConfig.IncludeInternet; } }
        internal static InvoiceMetadata NewInvoice { get; set; }
        internal static int TenantID { get; set; }
    }
}
