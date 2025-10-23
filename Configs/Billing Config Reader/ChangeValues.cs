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
        internal static void Change_InvoiceNumberPrefix(string SetPrefix)
        {
            XElement? target;

            target = Doc
                .Descendants("add")
                .FirstOrDefault(x => x.Attribute("key")?.Value == "Billing:InvoiceNumberPrefix");

            if(target != null)
            {
                target?.SetAttributeValue("value", SetPrefix);
                Doc.Save(configPath);
            }
        }
    }
}
