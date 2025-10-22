using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using JunX.NETStandard.Utility;

namespace Real_Estate_Management_System.Configs.Billing
{
    internal static partial class BillingConfig
    {
        private static readonly string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Configs\\Billing.config");
        private static readonly XDocument Doc = XDocument.Load(configPath);

        internal static bool IncludeInternet
        {
            get
            {
                string? include = Doc
                    .Descendants("add")?
                    .FirstOrDefault(x => x.Attribute("key")?.Value == "Billing:IncludeInternet")?
                    .Attribute("value")?.Value;

                if (include == "true")
                    return true;
                else
                    return false;
            }
        }
        internal static string? InvoiceNumberPrefix
        {
            get
            {
                return Doc
                    .Descendants("add")
                    .FirstOrDefault(x => x.Attribute("key")?.Value == "Billing:InvoiceNumberPrefix")?
                    .Attribute("value")?.Value;
            }
        }
    }
}
