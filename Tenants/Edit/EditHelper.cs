using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Management_System.Tenants
{
    internal static class EditHelper
    {
        private const string FORM_TITLE_DEFAULT = "Real Estate Management System";
        private static string TName = "";

        internal static string FormTitle_EditTenant
        {
            get
            {
                if (string.IsNullOrWhiteSpace(TName))
                    return FORM_TITLE_DEFAULT + " - View/Edit Tenant Info";
                else
                    return FORM_TITLE_DEFAULT + " - View/Edit Tenant Info" + " [" + TName.ToUpper() + "]";
            }
            set {  TName = value; }
        }
        internal static string FormTitle_EditEmergency
        {
            get
            {
                if (string.IsNullOrWhiteSpace(TName))
                    return FORM_TITLE_DEFAULT + " - Edit Emergency Info";
                else
                    return FORM_TITLE_DEFAULT + " - Edit Emergency Info" + " [" + TName.ToUpper() + "]";
            }
            set { TName = value; }
        }
        internal static string FormTitle_EditTenancy
        {
            get
            {
                if (string.IsNullOrWhiteSpace(TName))
                    return FORM_TITLE_DEFAULT + " - Edit Tenancy Info";
                else
                    return FORM_TITLE_DEFAULT + " - Edit Tenancy Info" + " [" + TName.ToUpper() + "]";
            }
            set { TName = value; }
        }
    }
}
