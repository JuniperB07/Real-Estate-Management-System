using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Real_Estate_Management_System.Configs.Tenants
{
    internal static class ConfigReader
    {
        private static string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Configs\\Tenants.config");

        internal static string Default_IDLocation
        {
            get
            {
                XDocument doc = XDocument.Load(configPath);

                return doc
                    .Descendants("add")
                    .FirstOrDefault(x => x.Attribute("key")?.Value == "Tenants:Default_IDLocation")?
                    .Attribute("value")?.Value;
            }
        }
    }
}
