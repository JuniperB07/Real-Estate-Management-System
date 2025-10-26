using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Real_Estate_Management_System.Configs.Tenants
{
    internal static partial class DefaultValues
    {
        private const string DEFAULT_ID_LOCATION = "Resources\\REMS_TENANTS_DEFAULT_ID.png";
        private const string DEFAULT_INTERNET_PLAN = "None";

        internal static void Restore_IDLocationConfig() => Change_IDLocation(DEFAULT_ID_LOCATION);
        internal static void Restore_DefaultInternetPlanConfig() => Change_DefaultInternetPlan(DEFAULT_INTERNET_PLAN);
    }
}
