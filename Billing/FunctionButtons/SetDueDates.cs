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

namespace Real_Estate_Management_System.Billing.FunctionButtons
{
    public partial class SetDueDates : Form
    {
        public SetDueDates()
        {
            InitializeComponent();
            Internals.SetFormColors(this);
            Forms.SetControlForeColor(Forms.ControlType<Label>.Extract(this), Internals.Cyprus);
        }
    }
}
