using JunX.NETStandard.MySQL;
using JunX.NETStandard.Utility;
using Real_Estate_Management_System.Splash_Screen;
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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Splash splash = new Splash();

            Application.Run(new SplashHost(splash));
        }
    }

    public class SplashHost : ApplicationContext
    {
        public SplashHost(Form Splash)
        {
            Splash.Shown += async (s, e) =>
            {
                SplashHelper.Splash_LoadingText = "Initializing System Startup Process...";
                await Task.Delay(2000);

                SplashHelper.Splash_LoadingText = "Checking Log file...";
                Internals.Logger = new Logger(Internals.LogPath);
                if (!Internals.Logger.LogFileExists())
                    Internals.Logger.CreateLogFile();
                await Task.Delay(1000);

                Internals.Logger.AddLog(DateTime.Now, LogCategories.SYSTEM.ToString(), "System Launched.");
                Internals.Logger.AddLog(DateTime.Now, LogCategories.SYSTEM.ToString(), "Connecting to Database...");
                SplashHelper.Splash_LoadingText = "Connecting to Database...";

                if (!DBConnect.ConfigGenerator.ConfigExists())
                    DBConnect.ConfigGenerator.GenerateDBConfig(Internals.CONN_STR);
                Internals.DBC = new DBConnect(DBConnect.ConfigGenerator.GetConnectionString());
                Internals.DBC.Open();

                Internals.Logger.AddLog(DateTime.Now, LogCategories.SYSTEM.ToString(), "Database connection established.");
                Internals.Logger.AddLog(DateTime.Now, LogCategories.SYSTEM.ToString(), "Retrieving table column metadata and creating enum files...");
                await Task.Delay(4000);

                SplashHelper.Splash_LoadingText = "Checking & creating required files...";

                string folder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Tables");
                EnumGenerator EG = new EnumGenerator(Internals.SERVER_CONN_STR, out ConnectionState state);
                if (state == ConnectionState.Open)
                {
                    EG.DatabaseName = Internals.DB_NAME;
                    EG.GenerateEnumFiles(folder);
                }

                Internals.Logger.AddLog(DateTime.Now, LogCategories.SYSTEM.ToString(), "Enum files generated.");
                await Task.Delay(1000);

                SplashHelper.Splash_LoadingText = "Initializing application configuration...";
                await Task.Delay(1000);

                Splash.Close();
                Dashboard DB = new Dashboard();
                DB.ShowDialog();
                Application.Exit();
            };

            Splash.Show();
        }
    }
}