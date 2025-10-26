using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using JunX.NETStandard.XML;

namespace Real_Estate_Management_System.Configs.Tenants
{
    internal static partial class DefaultValues
    {
        private static string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Configs\\Tenants.config");
        private static JunXML TenantsConfig = new JunXML(configPath).Load();

        internal static string Default_IDLocation => TenantsConfig.ReadAdd("Tenants:Default_IDLocation");
        internal static string Default_InternetPlan => TenantsConfig.ReadAdd("Tenants:Default_InternetPlan");
    }
}
