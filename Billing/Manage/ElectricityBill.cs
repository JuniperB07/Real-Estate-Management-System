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
using JunX.NET8.WinForms;

namespace Real_Estate_Management_System.Billing.Manage
{
    public partial class ElectricityBill : Form
    {
        public ElectricityBill()
        {
            InitializeComponent();
            Internals.SetFormColors(this);
            Forms.SetControlBackColor(Forms.ControlType<Button>.Extract(this), Color.FromArgb(102, 79, 1));
            Forms.SetControlForeColor(Forms.ControlType<Button>.Extract(this), Internals.SandDune);
            Forms.SetControlForeColor(Forms.ControlType<Label>.Extract(this), Color.FromArgb(102, 79, 1));
            Forms.SetControlBackColor(Forms.ControlType<TextBox>.Extract(this), Internals.SandDune);
            Forms.SetControlForeColor(Forms.ControlType<TextBox>.Extract(this), Color.FromArgb(102, 79, 1));

            Forms.SetControlForeColor(Forms.ControlType<Label>.Extract(pnlHeader), Internals.SandDune);
        }

        private void ElectricityBill_Load(object sender, EventArgs e)
        {

        }
    }
}
