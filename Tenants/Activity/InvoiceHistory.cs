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
    public partial class InvoiceHistory : Form
    {
        private readonly Form Parent;
        private readonly Button ButtonOpener;

        public InvoiceHistory(Form parent, Button buttonOpener)
        {
            InitializeComponent();
            Parent = parent;
            ButtonOpener = buttonOpener;

            Parent.LocationChanged += (s, e) =>
            {
                Location = new Point(Parent.Left, Parent.Bottom - 10);
            };
        }

        private void InvoiceHistory_Load(object sender, EventArgs e)
        {
            Owner = Parent;
            Location = new Point(Parent.Left, Parent.Bottom - 10);
            rdbThisMonth.Checked = true;
            pnlDateRange.Visible = false;
        }

        private void InvoiceHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            ButtonOpener.BackColor = Internals.Cyprus;
        }

        private void InvoiceHistory_Shown(object sender, EventArgs e)
        {
            ButtonOpener.BackColor = Internals.Cyprus_Active;
        }

        private void InvoiceHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
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
