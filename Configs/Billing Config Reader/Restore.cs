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
        private const string DEFAULT_INVOICE_NUMBER_PREFIX = "REMS-B";

        internal static void Restore_InvoiceNumberPrefix()
        {
            XElement? target = Doc
                .Descendants("add")?
                .FirstOrDefault(x => x.Attribute("key")?.Value == "Billing:InvoiceNumberPrefix");

            if(target != null)
            {
                target?.SetAttributeValue("value", DEFAULT_INVOICE_NUMBER_PREFIX);
                Doc.Save(configPath);
            }
        }
    }
}
