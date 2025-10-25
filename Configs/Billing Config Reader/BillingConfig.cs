using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using JunX.NETStandard.Utility;
using JunX.NETStandard.XML;

namespace Real_Estate_Management_System.Configs.Billing
{
    internal static partial class BillingConfig
    {
        private static readonly string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Configs\\Billing.config");
        private static readonly JunXML Billing = new JunXML(configPath).Load();

        internal static string InvoiceNumberPrefix => Billing.ReadAdd("Billing:InvoiceNumberPrefix");
        internal static string ExportToPDFPath => Billing.ReadAdd("ExportToPDFPath");
    }
}
