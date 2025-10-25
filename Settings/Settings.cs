using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_Management_System.Settings
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void tsmiBilling_Utilities_Water_Click(object sender, EventArgs e)
        {
            Billing.WaterUtilitySettings WUS = new Billing.WaterUtilitySettings();
            WUS.MdiParent = this;
            WUS.Show();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void tsmiBilling_Utilities_Electricity_Click(object sender, EventArgs e)
        {
            Billing.ElectricityUtilitySettings EUS = new Billing.ElectricityUtilitySettings();
            EUS.MdiParent = this;
            EUS.Show();
        }

        private void tsmiBilling_DueDates_Utilities_Click(object sender, EventArgs e)
        {
            Due_Dates.UtilityDueDateSettings UDDS = new Due_Dates.UtilityDueDateSettings();
            UDDS.MdiParent = this;
            UDDS.Show();
        }
    }
}
