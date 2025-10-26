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
        private const int DEFAULT_USER_DEFINED_VALUE = -1;
        private const DueDateModes DEFAULT_DUE_DATE_MODE = DueDateModes.Start_Date_Dependent;

        internal static void Restore_Utilities_DueDateConfig() => ChangeDueDateMode_Utilities(DEFAULT_DUE_DATE_MODE);
        internal static void Restore_Rental_DueDateConfig() => ChangeDueDateMode_Rental(DEFAULT_DUE_DATE_MODE);
        internal static void Restore_Internet_DueDateConfig() => ChangeDueDateMode_Internet(DEFAULT_DUE_DATE_MODE);
    }
}
