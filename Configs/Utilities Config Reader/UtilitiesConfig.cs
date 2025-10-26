using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using JunX.NETStandard.XML;

namespace Real_Estate_Management_System.Configs.Utilities
{
    internal static partial class UtilitiesConfig
    {
        private static string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Configs\\Utilities.config");
        private static JunXML Utilities = new JunXML(configPath).Load();

        internal static string Water_Unit => Utilities.ReadAdd("Utilities:Water_Unit");
        internal static double Water_UnitPrice => Convert.ToDouble(Utilities.ReadAdd("Utilities:Water_UnitPrice"));
        internal static string Electricity_Unit => Utilities.ReadAdd("Utilities:Electricity_Unit");
        internal static double Electricity_UnitPrice => Convert.ToDouble(Utilities.ReadAdd("Utilities:Electricity_UnitPrice"));
    }
}
