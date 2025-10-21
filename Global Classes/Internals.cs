using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Real_Estate_Management_System.Dialogs;
using JunX.NETStandard.Utility;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;

namespace Real_Estate_Management_System
{
    /// <summary>
    /// Contains components necessary for the functionality of forms within REMS.
    /// </summary>
    internal static class Internals
    {
        internal const string CONN_STR = "server=localhost; user=root; sslmode=none; database=dbREMS";
        internal const string SERVER_CONN_STR = "server=localhost; user=root; sslmode=none;";
        internal const string DB_NAME = "dbREMS";
        internal const string PESO = "₱";
        internal const string DEFAULT_ID_LOCATION = @"Resources\REMS_TENANTS_DEFAULT_ID.png";
        internal static readonly ConnectionStringMetadata CONN_STR_METADATA = new ConnectionStringMetadata("localhost", "dbREMS", "root", SetSSLMode: SSLModes.None);

        internal static readonly Color Cyprus = Utility.HexToRGB("#004643");
        internal static readonly Color SandDune = Utility.HexToRGB("#F0EDE5");
        internal static readonly Color BrunswickGreen = Utility.HexToRGB("#235347");
        internal static readonly Color Dive = Utility.HexToRGB("#1F3F74"); //Water Theme
        internal static readonly Color DijonYellow = Utility.HexToRGB("#C49102"); //Electricity Theme
        internal static readonly Color RoyalPurple = Utility.HexToRGB("#643B9F"); //Rental Theme
        internal static readonly Color Cyprus_Active = Utility.HexToRGB("#00b9b1");
        internal static readonly string LogPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "REMSLog.csv");


        internal static DBConnect DBC { get; set; }
        internal static Logger Logger;

        internal static Dictionary<string, Form> Forms { get; set; } = new();

        internal static List<string> TenantsList
        {
            get
            {
                new SelectCommand<tbtenants>()
                    .Select(tbtenants.FullName)
                    .From
                    .OrderBy(tbtenants.FullName, OrderByModes.ASC)
                    .ExecuteReader(DBC);
                return DBC.Values;
            }
        }

        /// <summary>
        /// Sets the BackColor property of the specified form to <c><see cref="Internals.Cyprus"/></c> and the ForeColor property to
        /// <c><see cref="Internals.SandDune"/></c>.
        /// </summary>
        /// <param name="ThisForm">The <see cref="Form"/> instance to style.</param>
        internal static void SetFormColors(Form ThisForm)
        {
            ThisForm.BackColor = SandDune;
            ThisForm.ForeColor = Cyprus;
        }
        internal static List<string> SearchTenant(string SearchString)
        {
            new SelectCommand<tbtenants>()
                .Select(tbtenants.FullName)
                .From
                .StartWhere
                    .Where(tbtenants.FullName, SQLOperator.Like, "@SearchTenant")
                .EndWhere
                .OrderBy(tbtenants.FullName, OrderByModes.ASC)
                .ExecuteReader(DBC, new ParametersMetadata("@SearchTenant", "%" + SearchString + "%"));
            return DBC.Values;
        }
    }

    #region ENUMS
    internal enum LogCategories
    {
        SYSTEM,
        DASHBOARD
    }
    #endregion
}
