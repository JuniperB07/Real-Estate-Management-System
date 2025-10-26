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
            DueDates.ChangeAddValue("DueDateMode:Utilities", EnumHelper<DueDateModes>.GetReadableValue(DueDateMode, '_'));
            DueDates.ChangeAddValue("DueDateMode:Utilities_UserDefined", UserDefinedValue.ToString());
        }
        internal static void ChangeDueDateMode_Rental(DueDateModes DueDateMode, int UserDefinedValue = DEFAULT_USER_DEFINED_VALUE)
        {
            DueDates.ChangeAddValue("DueDateMode:Rental", EnumHelper<DueDateModes>.GetReadableValue(DueDateMode, '_'));
            DueDates.ChangeAddValue("DueDateMode:Rental_UserDefined", UserDefinedValue.ToString());
        }
        internal static void ChangeDueDateMode_Internet(DueDateModes DueDateMode, int UserDefinedValue = DEFAULT_USER_DEFINED_VALUE)
        {
            DueDates.ChangeAddValue("DueDateMode:Internet", EnumHelper<DueDateModes>.GetReadableValue(DueDateMode, '_'));
            DueDates.ChangeAddValue("DueDateMode:Internet_UserDefined", UserDefinedValue.ToString());
        }
    }
}
