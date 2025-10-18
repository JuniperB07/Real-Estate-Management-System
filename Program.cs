using JunX.NETStandard.MySQL;
using JunX.NETStandard.Utility;
using Real_Estate_Management_System.Splash_Screen;
using System.Data;
using System.Security.Cryptography;

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
                SplashHelper.IsClosedPrematurely = true;
                await Task.Delay(2000);

                SplashHelper.Splash_LoadingText = "Checking Log file...";
                Internals.Logger = new Logger(Internals.LogPath);
                if (!Internals.Logger.LogFileExists())
                {
                    Internals.Logger.CreateLogFile();
                    await Task.Delay(500);
                }
                await Task.Delay(500);

                Internals.Logger.AddLog(DateTime.Now, LogCategories.SYSTEM.ToString(), "System Launched.");
                Internals.Logger.AddLog(DateTime.Now, LogCategories.SYSTEM.ToString(), "Connecting to Database...");
                SplashHelper.Splash_LoadingText = "Connecting to Database...";

                if (!DBConnect.ConfigGenerator.ConfigExists())
                {
                    SplashHelper.Splash_LoadingText = "Creating DB Config file...";
                    DBConnect.ConfigGenerator.GenerateDBConfig(Internals.CONN_STR);
                    await Task.Delay(500);
                }
                Internals.DBC = new DBConnect(DBConnect.ConfigGenerator.GetConnectionString());
                Internals.DBC.Open(out bool opened);
                if (!opened)
                {
                    MessageBox.Show("An error occured while trying to connect to database.");
                    Splash.Close();
                    Application.Exit();
                }
                await Task.Delay(500);

                Internals.Logger.AddLog(DateTime.Now, LogCategories.SYSTEM.ToString(), "Database connection established.");
                Internals.Logger.AddLog(DateTime.Now, LogCategories.SYSTEM.ToString(), "Retrieving table column metadata and creating enum files...");

                SplashHelper.Splash_LoadingText = "Checking && creating required enum files...";

                string folder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Tables");
                EnumGenerator EG = new EnumGenerator(Internals.SERVER_CONN_STR, out ConnectionState state);
                if (state == ConnectionState.Open)
                {
                    EG.DatabaseName = Internals.DB_NAME;
                    EG.GenerateEnumFiles(folder);
                    await Task.Delay(1000);
                }

                Internals.Logger.AddLog(DateTime.Now, LogCategories.SYSTEM.ToString(), "Enum files generated.");

                SplashHelper.Splash_LoadingText = "Checking RDLCs...";
                List<string> RDLCs = new List<string>
                {
                    "RDLCs\\Invoice.rdlc"
                };
                foreach(string file in RDLCs)
                {
                    await Task.Delay(500);

                    if(!File.Exists(file))
                    {
                        MessageBox.Show("Missing RDLC file: " + file);
                        Splash.Close();
                        Application.Exit();
                    }
                }

                SplashHelper.Splash_LoadingText = "Checking configuration files...";
                List<string> Configs = new List<string>
                {
                    "Configs\\Tenants.config"
                };
                foreach(string file in Configs)
                {
                    await Task.Delay(500);

                    if (!File.Exists(file))
                    {
                        MessageBox.Show("Missing configuration file: " + file);
                        Splash.Close();
                        Application.Exit();
                    }
                }

                SplashHelper.Splash_LoadingText = "Loading main forms...";
                await Task.Delay(500);
                List<Form> preLoadedForms = new List<Form>
                {
                    new Dashboard(),
                    new Login.Login(),
                    new Billing.NewBill(),
                    new Payments.PayBill(),
                    new Tenants.Tenants(),
                    new Rooms.RoomManagement()
                };
                Internals.Forms = preLoadedForms.ToDictionary(f => f.Name, f => f);
                foreach(Form form in Internals.Forms.Values)
                {
                    SplashHelper.Splash_LoadingText = "Loading " + form.Name + "...";
                    await Task.Delay(500);
                }

                SplashHelper.Splash_LoadingText = "Finalizing initializations...";
                SplashHelper.IsClosedPrematurely = false;
                await Task.Delay(2000);
                Splash.Close();
                Internals.Forms["Dashboard"].ShowDialog();
                Application.Exit();
            };

            Splash.FormClosed += async (s, e) =>
            {
                if (SplashHelper.IsClosedPrematurely)
                    Application.Exit();
            };

            Splash.Show();
        }
    }
}