using Google.Protobuf.WellKnownTypes;
using JunX.NETStandard.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Management_System.Configs.DueDates
{
    internal static partial class DueDatesConfig
    {
        internal static void RestoreDefaults()
        {
            Restore_Utilities_DueDateMode();
            Restore_Rental_DueDateMode();
            Restore_Internet_DueDateMode();
        }

        #region Private Restores
        private static void Restore_Utilities_DueDateMode()
        {
            var target = Doc
                .Descendants("add")
                .FirstOrDefault(x => x.Attribute("key")?.Value == "DueDateMode:Utilities");
            if(target != null)
            {
                target.SetAttributeValue("value", EnumHelper<DueDateModes>.GetReadableValue(DEFAULT_DUE_DATE_MODE, '_'));
                Doc.Save(configPath);
            }

            target = Doc
                .Descendants("add")
                .FirstOrDefault(x => x.Attribute("key")?.Value == "DueDateMode:Utilities_UserDefined");
            if(target != null)
            {
                target.SetAttributeValue("value", DEFAULT_USER_DEFINED_VALUE.ToString());
                Doc.Save(configPath);
            }
        }
        private static void Restore_Rental_DueDateMode()
        {
            var target = Doc
                .Descendants("add")
                .FirstOrDefault(x => x.Attribute("key")?.Value == "DueDateMode:Rental");
            if (target != null)
            {
                target.SetAttributeValue("value", EnumHelper<DueDateModes>.GetReadableValue(DEFAULT_DUE_DATE_MODE, '_'));
                Doc.Save(configPath);
            }

            target = Doc
                .Descendants("add")
                .FirstOrDefault(x => x.Attribute("key")?.Value == "DueDateMode:Rental_UserDefined");
            if (target != null)
            {
                target.SetAttributeValue("value", DEFAULT_USER_DEFINED_VALUE.ToString());
                Doc.Save(configPath);
            }
        }
        private static void Restore_Internet_DueDateMode()
        {
            var target = Doc
                .Descendants("add")
                .FirstOrDefault(x => x.Attribute("key")?.Value == "DueDateMode:Internet");
            if (target != null)
            {
                target.SetAttributeValue("value", EnumHelper<DueDateModes>.GetReadableValue(DEFAULT_DUE_DATE_MODE, '_'));
                Doc.Save(configPath);
            }

            target = Doc
                .Descendants("add")
                .FirstOrDefault(x => x.Attribute("key")?.Value == "DueDateMode:Internet_UserDefined");
            if (target != null)
            {
                target.SetAttributeValue("value", DEFAULT_USER_DEFINED_VALUE.ToString());
                Doc.Save(configPath);
            }
        }
        #endregion
    }
}
