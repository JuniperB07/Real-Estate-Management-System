using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Management_System.Billing
{
    internal static class Methods
    {
        internal static string GenerateInvoiceNumber(int TenantID)
        {
            return Configs.Billing.BillingConfig.InvoiceNumberPrefix +
                TenantID.ToString() + 
                DateTime.Now.ToString("MMddyyyyHHmmss");
        }
    }
}
