using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Management_System.Configs.InvoiceRDLC
{
    internal static partial class InvoiceRDLC_Config
    {
        private const string DEFAULT_BUSINESS_NAME = "REAL ESTATE MANAGEMENT SYSTEM";
        private const string DEFAULT_BUSINESS_ADDRESS = "Your Business Address Here";
        private const string DEFAULT_BUSINESS_CONTACT_INFO_MOBILE = "+639123456789";
        private const string DEFAULT_BUSINESS_CONTACT_INFO_EMAIL = "businessemail@email.com";
        private const bool DEFAULT_INCLUDE_TELEPHONE = true;
        private const string DEFAULT_BUSINESS_CONTACT_INFO_TELEPHONE = "(000)000-0000";
        private const bool DEFAULT_INCLUDE_BIR_INFO = true;
        private const string DEFAULT_BUSINESS_BIR_INFO = "000-000-00000";

        internal static void RestoreDefault_BusinessName() => Change_BusinessName(DEFAULT_BUSINESS_NAME);
        internal static void RestoreDefault_BusinessAddress() => Change_BusinessAddress(DEFAULT_BUSINESS_ADDRESS);
        internal static void RestoreDefault_BusinessContactInfo_Mobile() => Change_BusinessContact_Mobile(DEFAULT_BUSINESS_CONTACT_INFO_MOBILE);
        internal static void RestoreDefault_BusinessContactInfo_Email() => Change_BusinessContact_Email(DEFAULT_BUSINESS_CONTACT_INFO_EMAIL);
        internal static void RestoreDefault_IncludeTelephone() => Change_IncludeTelephone(DEFAULT_INCLUDE_TELEPHONE);
        internal static void RestoreDefault_BusinessContactInfo_Telephone() => Change_BusinessContact_Telephone(DEFAULT_BUSINESS_CONTACT_INFO_TELEPHONE);
        internal static void RestoreDefault_IncludeBIRInfo() => Change_IncludeBIRInfo(DEFAULT_INCLUDE_BIR_INFO);
        internal static void RestoreDefault_BusinessBIRInfo() => Change_BusinessBIRInfo(DEFAULT_BUSINESS_BIR_INFO);
    }
}
