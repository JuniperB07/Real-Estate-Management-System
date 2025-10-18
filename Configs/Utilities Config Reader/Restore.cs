using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Management_System.Configs.Utilities
{
    internal static partial class UtilitiesConfig
    {
        internal static void RestoreDefaults()
        {
            Restore_Default_Electricity_Unit();
            Restore_Default_Water_Unit();
        }

        #region Private Restores
        private static void Restore_Default_Electricity_Unit()
        {
            var target = Doc
                .Descendants("add")
                .FirstOrDefault(x => x.Attribute("key")?.Value == "Utilities:Electricity_Unit");

            if(target != null)
            {
                target.SetAttributeValue("value", DEFAULT_ELECTRICITY_UNIT);
                Doc.Save(configPath);
            }
        }
        private static void Restore_Default_Water_Unit()
        {
            var target = Doc
                .Descendants("add")
                .FirstOrDefault(x => x.Attribute("key")?.Value == "Utilities:Water_Unit");

            if(target != null)
            {
                target.SetAttributeValue("value", DEFAULT_WATER_UNIT);
                Doc.Save(configPath);
            }
        }
        #endregion
    }
}
