using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JunX.NET8.WinForms;

namespace Real_Estate_Management_System.Billing.Manage
{
    public partial class RentalBill : Form
    {
        public RentalBill()
        {
            InitializeComponent();
            Internals.SetFormColors(this);
            Forms.SetControlForeColor(Forms.ControlType<Label>.Extract(this), Color.FromArgb(65, 38, 102));

            Forms.SetControlForeColor(Forms.ControlType<Label>.Extract(pnlHeader), Internals.SandDune);
        }

        private void RentalBill_Load(object sender, EventArgs e)
        {

        }

        private void RentalBill_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
