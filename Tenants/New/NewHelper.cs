using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using REMS.Tenants;

namespace Real_Estate_Management_System.Tenants.New
{
    internal static class NewTenantHelper
    {
        /// <summary>
        /// New Tenant instance.
        /// </summary>
        internal static REMS.Tenants.NewTenant NT { get; set; }
        internal static bool AllowProceed { get; set; }
        internal static TenantInformation NewTenantInformation { get; set; }
        internal static EmergencyInformation NewEmergencyInformation { get; set; }
        internal static TenancyMetadata NewTenancyInformation { get; set; }
    }
}
