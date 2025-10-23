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
        }

        private void RentalBill_Load(object sender, EventArgs e)
        {
            lblDueDate.Text = BHelper.NewRentalInvoice.DueDate.ToString("MMMM d, yyyy");
            lblMonthlyRent.Text = BHelper.NewRentalInvoice.MonthlyRent.ToString("0,0.00");
            lblRemainingBalance.Text = BHelper.NewRentalInvoice.RemainingBalance.ToString("0,0.00");
            lblDeductions.Text = BHelper.NewRentalInvoice.Deductions.ToString("0,0.00");
            lblPenalties.Text = BHelper.NewInvoice.TotalPenalties.ToString("0,0.00");
            lblTotal.Text = (BHelper.NewRentalInvoice.Subtotal + BHelper.NewInvoice.TotalPenalties).ToString("0,0.00");
        }

        private void RentalBill_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
