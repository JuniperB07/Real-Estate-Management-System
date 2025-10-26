using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Management_System.Configs.Utilities
{
    internal static partial class UtilitiesConfig
    {
        private const string DEFAULT_WATER_UNIT = "m^3";
        private const string DEFAULT_ELECTRICITY_UNIT = "kWh";
        private const double DEFAULT_UTILITY_UNIT_PRICE = 0;

        internal static void Restore_WaterUtilityConfig()
        {
            Change_WaterUnit(DEFAULT_WATER_UNIT);
            Change_WaterUnitPrice(DEFAULT_UTILITY_UNIT_PRICE);
        }
        internal static void Restore_ElectricityUtilityConfig()
        {
            Change_ElectricityUnit(DEFAULT_ELECTRICITY_UNIT);
            Change_ElectricityUnitPrice(DEFAULT_UTILITY_UNIT_PRICE);
        }
    }
}
