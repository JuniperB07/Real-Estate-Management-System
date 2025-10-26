using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Management_System.Configs.Utilities
{
    internal static partial class UtilitiesConfig
    {
        internal static void Change_WaterUnit(string SetUnit) => Utilities.ChangeAddValue("Utilities:Water_Unit", SetUnit);
        internal static void Change_WaterUnitPrice(double SetUnitPrice) => Utilities.ChangeAddValue("Utilities:Water_UnitPrice", SetUnitPrice.ToString("0.00"));
        internal static void Change_ElectricityUnit(string SetUnit) => Utilities.ChangeAddValue("Utilities:Electricity_Unit", SetUnit);
        internal static void Change_ElectricityUnitPrice(double SetUnitPrice) => Utilities.ChangeAddValue("Utilities:Electricity_UnitPrice", SetUnitPrice.ToString("0.00"));
    }
}
