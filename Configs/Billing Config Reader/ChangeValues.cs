using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Real_Estate_Management_System.Configs.Billing
{
    internal static partial class BillingConfig
    {
        internal static void Change_InvoiceNumberPrefix(string SetPrefix) => Billing.ChangeAddValue("Billing:InvoiceNumberPrefix", SetPrefix);
        internal static void Change_ExportToPDFPath(string ExportPath) => Billing.ChangeAddValue("ExportToPDFPath", ExportPath);
    }
}
