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
        public Dashboard()
        {
            Internals.Logger.AddLog(DateTime.Now, LogCategories.DASHBOARD.ToString(), "Initializing Dashboard...");

            InitializeComponent();
            Internals.SetFormColors(this);
            WindowState = FormWindowState.Maximized;

            pnlHeader.BackColor = Internals.Cyprus;
            pnlSidebar.BackColor = Internals.Cyprus;

            Forms.SetControlForeColor(Forms.ControlType<Label>.Extract(pnlHeader), Internals.SandDune);
            Forms.SetControlForeColor(Forms.ControlType<Label>.Extract(pnlUnpaid), Internals.SandDune);
            Forms.SetControlForeColor(Forms.ControlType<Label>.Extract(pnlOverdue), Internals.SandDune);
            Forms.SetControlForeColor(Forms.ControlType<Label>.Extract(pnlActiveTenants), Internals.SandDune);

            Forms.SetControlBackColor(Forms.ControlType<Button>.Extract(pnlSidebar), Internals.Cyprus);
            Forms.SetControlForeColor(Forms.ControlType<Button>.Extract(pnlSidebar), Internals.SandDune);

            Internals.Logger.AddLog(DateTime.Now, LogCategories.DASHBOARD.ToString(), "Dashboard initialized.");
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Internals.MSG_Processing = new ProcessingRequest();
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("MMMM d, yyyy - hh:mm tt");
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            Hide();
            Billing.NewBill BN = new Billing.NewBill();
            BN.ShowDialog();
            Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            Login.Login L = new Login.Login();
            L.ShowDialog();
            Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Dialogs.MSGBox_OK MBOK = new Dialogs.MSGBox_OK(SetIcon: DialogIcons.Question);
            MBOK.ShowDialog();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
