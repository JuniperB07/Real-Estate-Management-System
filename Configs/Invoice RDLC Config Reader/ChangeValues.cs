using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Management_System.Configs.InvoiceRDLC
{
    internal static partial class InvoiceRDLC_Config
    {
        internal static void Change_InvoiceLogoPath(string LogoPath) => InvoiceRDLC.ChangeAddValue("InvoiceLogoPath", LogoPath);
        internal static void Change_BusinessName(string BusinessName) => InvoiceRDLC.ChangeAddValue("BusinessName", BusinessName);
        internal static void Change_BusinessAddress(string BusinessAddress) => InvoiceRDLC.ChangeAddValue("BusinessAddress", BusinessAddress);
        internal static void Change_BusinessContact_Mobile(string MobileNumber) => InvoiceRDLC.ChangeAddValue("BusinessContactInfo:Mobile", MobileNumber);
        internal static void Change_BusinessContact_Email(string Email) => InvoiceRDLC.ChangeAddValue("BusinessContactInfo:Email", Email);
        internal static void Change_IncludeTelephone(bool IncludeTelephone) => InvoiceRDLC.ChangeAddValue("Include:Telephone", IncludeTelephone.ToString());
        internal static void Change_BusinessContact_Telephone(string Telephone) => InvoiceRDLC.ChangeAddValue("BusinessContactInfo:Telephone", Telephone);
        internal static void Change_IncludeBIRInfo(bool BIRInfo) => InvoiceRDLC.ChangeAddValue("Include:BIRInfo", BIRInfo.ToString());
        internal static void Change_BusinessBIRInfo(string BIRInfo) => InvoiceRDLC.ChangeAddValue("BusinessBIRInfo", BIRInfo);
    }
}
