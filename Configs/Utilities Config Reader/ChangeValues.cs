using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Management_System.Configs.Utilities
{
    internal static partial class UtilitiesConfig
    {
        internal static void Change_WaterUnit(string SetUnit)
        {
            var target = Doc
                .Descendants("add")
                .FirstOrDefault(x => x.Attribute("key")?.Value == "Utilities:Water_Unit");

            if(target != null)
            {
                target.SetAttributeValue("value", SetUnit);
                Doc.Save(configPath);
            }
        }
        internal static void Change_WaterUnitPrice(double SetUnitPrice)
        {
            var target = Doc
                .Descendants("add")
                .FirstOrDefault(x => x.Attribute("key")?.Value == "Utilities:Water_UnitPrice");

            if(target != null)
            {
                target.SetAttributeValue("value", SetUnitPrice.ToString("0.00"));
                Doc.Save(configPath);
            }
        }
        internal static void Change_ElectricityUnit(string SetUnit)
        {
            var target = Doc
                .Descendants("add")
                .FirstOrDefault(x => x.Attribute("key")?.Value == "Utilities:Electricity_Unit");

            if(target != null)
            {
                target.SetAttributeValue("value", SetUnit);
                Doc.Save(configPath);
            }
        }
        internal static void Change_ElectricityUnitPrice(double SetUnitPrice)
        {
            var target = Doc
                .Descendants("add")
                .FirstOrDefault(x => x.Attribute("key")?.Value == "Utilities:Electricity_UnitPrice");

            if(target != null)
            {
                target.SetAttributeValue("value", SetUnitPrice.ToString("0.00"));
                Doc.Save(configPath);
            }
        }
    }
}
