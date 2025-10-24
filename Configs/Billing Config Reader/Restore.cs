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
        private const string DEFAULT_EXPORT_TO_PDF_PATH = "C:\\";

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
        internal static void Restore_ExportToPDFPath() => Change_ExportToPDFPath(DEFAULT_EXPORT_TO_PDF_PATH);
    }
}
