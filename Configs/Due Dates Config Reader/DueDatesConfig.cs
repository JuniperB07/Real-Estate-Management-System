using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using JunX.NETStandard.Utility;

namespace Real_Estate_Management_System.Configs.DueDates
{
    internal static partial class DueDatesConfig
    {
        private static readonly string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Configs\\DueDates.config");
        private static readonly XDocument Doc = XDocument.Load(configPath);

        internal static DueDateModes DueDateMode_Utilities
        {
            get
            {
                var mode = Doc
                    .Descendants("add")
                    .FirstOrDefault(x => x.Attribute("key")?.Value == "DueDateMode:Utilities")?
                    .Attribute("value")?.Value;

                return EnumHelper<DueDateModes>.GetEnumValue(mode?.ToString(), ' ', '_');
            }
        }
        internal static int DueDate_Utilities
        {
            get
            {
                if (DueDateMode_Utilities == DueDateModes.User_Defined)
                {
                    var value = Doc
                        .Descendants("add")
                        .FirstOrDefault(x => x.Attribute("key")?.Value == "DueDateMode:Utilities_UserDefined")?
                        .Attribute("value")?.Value;

                    return Convert.ToInt32(value);
                }
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

        internal static DueDateModes DueDateMode_Rental
        {
            get
            {
                var mode = Doc
                    .Descendants("add")
                    .FirstOrDefault(x => x.Attribute("key")?.Value == "DueDateMode:Rental")?
                    .Attribute("value")?.Value;

                return EnumHelper<DueDateModes>.GetEnumValue(mode?.ToString(), ' ', '_');
            }
        }
        internal static int DueDate_Rental
        {
            get
            {
                if (DueDateMode_Rental == DueDateModes.User_Defined)
                {
                    var value = Doc
                        .Descendants("add")
                        .FirstOrDefault(x => x.Attribute("key")?.Value == "DueDateMode:Rental_UserDefined")?
                        .Attribute("value")?.Value;

                    return Convert.ToInt32(value);
                }
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

        internal static DueDateModes DueDateMode_Internet
        {
            get
            {
                var mode = Doc
                    .Descendants("add")
                    .FirstOrDefault(x => x.Attribute("key")?.Value == "DueDateMode:Internet")?
                    .Attribute("value")?.Value;

                return EnumHelper<DueDateModes>.GetEnumValue(mode?.ToString(), ' ', '_');
            }
        }
        internal static int DueDate_Internet
        {
            get
            {
                if (DueDateMode_Internet == DueDateModes.User_Defined)
                {
                    var value = Doc
                        .Descendants("add")
                        .FirstOrDefault(x => x.Attribute("key")?.Value == "DueDateMode:Internet_UserDefined")?
                        .Attribute("value")?.Value;

                    return Convert.ToInt32(value);
                }
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
