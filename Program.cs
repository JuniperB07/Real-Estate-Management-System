using JunX.NETStandard.MySQL;
using JunX.NETStandard.Utility;
using System.Data;

namespace Real_Estate_Management_System
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Internals.Logger = new Logger(Internals.LogPath);

            if (!Internals.Logger.LogFileExists())
                Internals.Logger.CreateLogFile();

            Internals.Logger.AddLog(DateTime.Now, LogCategories.SYSTEM.ToString(), "System Launched.");
            Internals.Logger.AddLog(DateTime.Now, LogCategories.SYSTEM.ToString(), "Connecting to Database...");

            if (!DBConnect.ConfigGenerator.ConfigExists())
                DBConnect.ConfigGenerator.GenerateDBConfig(Internals.CONN_STR);
            Internals.DBC = new DBConnect(DBConnect.ConfigGenerator.GetConnectionString());
            Internals.DBC.Open();

            Internals.Logger.AddLog(DateTime.Now, LogCategories.SYSTEM.ToString(), "Database connection established.");
            Internals.Logger.AddLog(DateTime.Now, LogCategories.SYSTEM.ToString(), "Retrieving table column metadata and creating enum files...");

            string folder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Tables");
            EnumGenerator EG = new EnumGenerator(Internals.SERVER_CONN_STR, out ConnectionState state);
            if(state == ConnectionState.Open)
            {
                EG.DatabaseName = Internals.DB_NAME;
                EG.GenerateEnumFiles(folder);
            }

            Internals.Logger.AddLog(DateTime.Now, LogCategories.SYSTEM.ToString(), "Enum files generated.");

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Dashboard());
        }
    }
}