using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Management_System.Configs
{
    internal enum DueDateModes
    {
        Start_Date_Dependent,
        First_Day_Of_The_Month,
        Fifteenth_Day_Of_The_Month,
        Last_Day_Of_The_Month,
        User_Defined = -1
    }
}
