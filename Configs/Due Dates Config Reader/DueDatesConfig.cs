using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using JunX.NETStandard.XML;
using JunX.NETStandard.Utility;

namespace Real_Estate_Management_System.Configs.DueDates
{
    internal static partial class DueDatesConfig
    {
        private static readonly string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Configs\\DueDates.config");
        private static JunXML DueDates = new JunXML(configPath).Load();

        internal static DueDateModes DueDateMode_Utilities => EnumHelper<DueDateModes>.GetEnumValue(DueDates.ReadAdd("DueDateMode:Utilities"), ' ', '_');
        internal static int DueDate_Utilities
        {
            get
            {
                if (DueDateMode_Utilities == DueDateModes.User_Defined)
                    return int.TryParse(DueDates.ReadAdd("DueDateMode:Utilities_UserDefined"), out _)
                        ? Convert.ToInt32(DueDates.ReadAdd("DueDateMode:Utilities_UserDefined"))
                        : -1;
                else if (DueDateMode_Utilities == DueDateModes.First_Day_Of_The_Month)
                    return 1;
                else if (DueDateMode_Utilities == DueDateModes.Fifteenth_Day_Of_The_Month)
                    return 15;
                else if (DueDateMode_Utilities == DueDateModes.Last_Day_Of_The_Month)
                    return DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                else
                    return -1;
            }
        }

        internal static DueDateModes DueDateMode_Rental => EnumHelper<DueDateModes>.GetEnumValue(DueDates.ReadAdd("DueDateMode:Rental"), ' ', '_');
        internal static int DueDate_Rental
        {
            get
            {
                if (DueDateMode_Rental == DueDateModes.User_Defined)
                    return int.TryParse(DueDates.ReadAdd("DueDateMode:Rental_UserDefined"), out _)
                        ? Convert.ToInt32(DueDates.ReadAdd("DueDateMode:Rental_UserDefined"))
                        : -1;
                else if (DueDateMode_Rental == DueDateModes.First_Day_Of_The_Month)
                    return 1;
                else if (DueDateMode_Rental == DueDateModes.Fifteenth_Day_Of_The_Month)
                    return 15;
                else if (DueDateMode_Rental == DueDateModes.Last_Day_Of_The_Month)
                    return DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                else
                    return -1;
            }
        }

        internal static DueDateModes DueDateMode_Internet => EnumHelper<DueDateModes>.GetEnumValue(DueDates.ReadAdd("DueDateMode:Internet"), ' ', '_');
        internal static int DueDate_Internet
        {
            get
            {
                if (DueDateMode_Internet == DueDateModes.User_Defined)
                    return int.TryParse(DueDates.ReadAdd("DueDateMode:Internet_UserDefined"), out _)
                        ? Convert.ToInt32(DueDates.ReadAdd("DueDateMode:Internet_UserDefined"))
                        : -1;
                else if (DueDateMode_Internet == DueDateModes.First_Day_Of_The_Month)
                    return 1;
                else if (DueDateMode_Internet == DueDateModes.Fifteenth_Day_Of_The_Month)
                    return 15;
                else if (DueDateMode_Internet == DueDateModes.Last_Day_Of_The_Month)
                    return DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                else
                    return -1;
            }
        }
    }
}
