using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Management_System.Configs.Tenants
{
    internal static partial class DefaultValues
    {
        internal static void Change_IDLocation(string Location) => TenantsConfig.ChangeAddValue("Tenants:Default_IDLocation", Location);
        internal static void Change_DefaultInternetPlan(string InternetPlan) => TenantsConfig.ChangeAddValue("Tenants:Default_InternetPlan", InternetPlan);
    }
}
