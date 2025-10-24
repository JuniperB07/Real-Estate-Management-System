using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using JunX.NETStandard.XML;

namespace Real_Estate_Management_System.Configs.InvoiceRDLC
{
    internal static partial class InvoiceRDLC_Config
    {
        private static readonly string ConfigPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Configs\\InvoiceRDLC.config");
        private static readonly JunXML InvoiceRDLC = new JunXML(ConfigPath).Load();

        internal static string BusinessName => InvoiceRDLC.ReadAdd("BusinessName");
        internal static string BusinessAddress => InvoiceRDLC.ReadAdd("BusinessAddress");
        internal static string BusinessContact_Mobile => InvoiceRDLC.ReadAdd("BusinessContactInfo:Mobile");
        internal static string BusinessContact_Email => InvoiceRDLC.ReadAdd("BusinessContactInfo:Email");
        internal static bool IncludeTelephone => Convert.ToBoolean(InvoiceRDLC.ReadAdd("Include:Telephone"));
        internal static string BusinessContact_Telephone => InvoiceRDLC.ReadAdd("BusinessContactInfo:Telephone");
        internal static bool IncludeBIRInfo => Convert.ToBoolean(InvoiceRDLC.ReadAdd("Include:BIRInfo"));
        internal static string BusinessBIRInfo => InvoiceRDLC.ReadAdd("BusinessBIRInfo");
    }
}
