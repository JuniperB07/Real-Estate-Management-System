using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_Management_System.Tenants.Activity
{
    public partial class PaymentHistory : Form
    {
        private readonly Form Parent;
        private readonly Button Opener;

        public PaymentHistory(Form parent, Button opener)
        {
            InitializeComponent();
            Parent = parent;
            Opener = opener;

            Parent.LocationChanged += (s, e) =>
            {
                Location = new Point(Parent.Left, Parent.Bottom - 10);
            };
        }

        private void PaymentHistory_Load(object sender, EventArgs e)
        {
            Owner = Parent;
            Location = new Point(Parent.Left, Parent.Bottom - 10);
            rdbThisMonth.Checked = true;
            pnlDateRange.Visible = false;
        }

        private void PaymentHistory_Shown(object sender, EventArgs e)
        {
            Opener.BackColor = Internals.Cyprus_Active;
        }

        private void PaymentHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void PaymentHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Opener.BackColor = Internals.Cyprus;
        }

        private void rdbDateRange_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDateRange.Checked)
                pnlDateRange.Visible = true;
            else
                pnlDateRange.Visible = false;
        }
    }
}
