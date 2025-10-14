using JunX.NET8.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_Management_System.Billing.Manage
{
    public partial class InternetBill : Form
    {
        public InternetBill()
        {
            InitializeComponent();
            Internals.SetFormColors(this);
            Forms.SetControlForeColor(Forms.ControlType<Label>.Extract(this), Color.FromArgb(0, 90, 90));

            Forms.SetControlForeColor(Forms.ControlType<Label>.Extract(pnlHeader), Internals.SandDune);
        }

        private void InternetBill_Load(object sender, EventArgs e)
        {

        }

        private void InternetBill_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
