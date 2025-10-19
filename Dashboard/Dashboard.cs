using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JunX.NETStandard.Utility;
using JunX.NET8.WinForms;
using Real_Estate_Management_System.Dialogs;

namespace Real_Estate_Management_System
{
    public partial class Dashboard : Form
    {
        private const string SUMMARY_HEADER = "SUMMARY FOR THE MONTH OF ";

        public Dashboard()
        {
            Internals.Logger.AddLog(DateTime.Now, LogCategories.DASHBOARD.ToString(), "Initializing Dashboard...");

            InitializeComponent();
            Internals.SetFormColors(this);
            WindowState = FormWindowState.Maximized;
            Forms.SetControlForeColor(Forms.ControlType<Label>.Extract(this), Internals.SandDune);

            pnlHeader.BackColor = Internals.Cyprus;
            pnlSidebar.BackColor = Internals.Cyprus;
            lblSummaryHeader.ForeColor = Internals.Cyprus;


            Forms.SetControlBackColor(Forms.ControlType<Button>.Extract(pnlSidebar), Internals.Cyprus);
            Forms.SetControlForeColor(Forms.ControlType<Button>.Extract(pnlSidebar), Internals.SandDune);

            Internals.Logger.AddLog(DateTime.Now, LogCategories.DASHBOARD.ToString(), "Dashboard initialized.");
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblSummaryHeader.Text = SUMMARY_HEADER + DateTime.Now.ToString("MMMM yyyy").ToUpper();
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("MMMM d, yyyy - hh:mm tt");
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            Hide();
            Internals.Forms["NewBill"].ShowDialog();
            Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            Internals.Forms["Login"].ShowDialog();
            Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            Hide();
            Internals.Forms["PayBill"].ShowDialog();
            Show();
        }

        private void btnTenants_Click(object sender, EventArgs e)
        {
            Hide();
            Internals.Forms["Tenants"].ShowDialog();
            Show();
        }

        private void btnViewAllTenants_Click(object sender, EventArgs e)
        {
            btnTenants.PerformClick();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            Hide();
            Rooms.RoomManagement RM = new Rooms.RoomManagement();
            RM.ShowDialog();
            Show();
        }

        private void btnInternetPlans_Click(object sender, EventArgs e)
        {
            Hide();
            Internet.InternetManagement IM = new Internet.InternetManagement();
            IM.ShowDialog();
            Show();
        }
    }
}
