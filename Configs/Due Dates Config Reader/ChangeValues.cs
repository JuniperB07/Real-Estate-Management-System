using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunX.NETStandard.Utility;

namespace Real_Estate_Management_System.Configs.DueDates
{
    internal static partial class DueDatesConfig
    {
        internal static void ChangeDueDateMode_Utilities(DueDateModes DueDateMode, int UserDefinedValue = DEFAULT_USER_DEFINED_VALUE)
        {
            var target = Doc
                .Descendants("add")
                .FirstOrDefault(x => x.Attribute("key")?.Value == "DueDateMode:Utilities");
            if(target != null)
            {
                target.SetAttributeValue("value", EnumHelper<DueDateModes>.GetReadableValue(DueDateMode, '_'));
                Doc.Save(configPath);
            }

            target = Doc
                .Descendants("add")
                .FirstOrDefault(x => x.Attribute("key")?.Value == "DueDateMode:Utilities_UserDefined");
            if( target != null)
            {
                target.SetAttributeValue("value", UserDefinedValue.ToString());
                Doc.Save(configPath);
            }
        }
        internal static void ChangeDueDateMode_Rental(DueDateModes DueDateMode, int UserDefinedValue = DEFAULT_USER_DEFINED_VALUE)
        {
            var target = Doc
                .Descendants("add")
                .FirstOrDefault(x => x.Attribute("key")?.Value == "DueDateMode:Rental");
            if (target != null)
            {
                target.SetAttributeValue("value", EnumHelper<DueDateModes>.GetReadableValue(DueDateMode, '_'));
                Doc.Save(configPath);
            }

            target = Doc
                .Descendants("add")
                .FirstOrDefault(x => x.Attribute("key")?.Value == "DueDateMode:Rental_UserDefined");
            if (target != null)
            {
                target.SetAttributeValue("value", UserDefinedValue.ToString());
                Doc.Save(configPath);
            }
        }
        internal static void ChangeDueDateMode_Internet(DueDateModes DueDateMode, int UserDefinedValue = DEFAULT_USER_DEFINED_VALUE)
        {
            var target = Doc
                .Descendants("add")
                .FirstOrDefault(x => x.Attribute("key")?.Value == "DueDateMode:Internet");
            if (target != null)
            {
                target.SetAttributeValue("value", EnumHelper<DueDateModes>.GetReadableValue(DueDateMode, '_'));
                Doc.Save(configPath);
            }

            target = Doc
                .Descendants("add")
                .FirstOrDefault(x => x.Attribute("key")?.Value == "DueDateMode:Internet_UserDefined");
            if (target != null)
            {
                target.SetAttributeValue("value", UserDefinedValue.ToString());
                Doc.Save(configPath);
            }
        }
    }
}
