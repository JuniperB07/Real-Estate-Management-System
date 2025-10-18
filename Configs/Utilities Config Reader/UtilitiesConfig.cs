using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Real_Estate_Management_System.Configs.Utilities
{
    internal static partial class UtilitiesConfig
    {
        private static string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Configs\\Utilities.config");
        private static readonly XDocument Doc = XDocument.Load(configPath);

        internal static string Water_Unit
        {
            get
            {
                return Doc
                    .Descendants("add")
                    .FirstOrDefault(x => x.Attribute("key")?.Value == "Utilities:Water_Unit")
                    .Attribute("value")?.Value;
            }
        }
        internal static double Water_UnitPrice
        {
            get
            {
                string UP = Doc
                    .Descendants("add")
                    .FirstOrDefault(x => x.Attribute("key")?.Value == "Utilities:Water_UnitPrice")
                    .Attribute("value")?.Value;

                return Convert.ToDouble(UP);
            }
        }
        internal static string Electricity_Unit
        {
            get
            {
                return Doc
                    .Descendants("add")
                    .FirstOrDefault(x => x.Attribute("key")?.Value == "Utilities:Electricity_Unit")
                    .Attribute("value")?.Value;
            }
        }
        internal static double Electricity_UnitPrice
        {
            get
            {
                string UP = Doc
                    .Descendants("add")
                    .FirstOrDefault(x => x.Attribute("key")?.Value == "Utilities:Electricity_UnitPrice")
                    .Attribute("value")?.Value;

                return Convert.ToDouble(UP);
            }
        }
    }
}
