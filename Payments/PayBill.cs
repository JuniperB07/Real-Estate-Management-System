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

namespace Real_Estate_Management_System.Payments
{
    public partial class PayBill : Form
    {
        private const string DEFAULT_TEXT = "Real Estate Management System - Pay Bill";

        public PayBill()
        {
            InitializeComponent();
            Internals.SetFormColors(this);
            Forms.SetControlForeColor(Forms.ControlType<Label>.Extract(this), Internals.SandDune);

            pnlHeader.BackColor = Internals.Cyprus;
            Forms.SetControlBackColor(new Panel[]
            {
                pnlSelectTenant,
                pnlTransactionInformation,
                pnlOverallInvoiceInformation,
                pnlSidebar
            }, Internals.BrunswickGreen);

            lstTenantsList.BackColor = Internals.BrunswickGreen;
            lstTenantsList.ForeColor = Internals.SandDune;
            txtSearchTenant.BackColor = Internals.SandDune;
            txtSearchTenant.ForeColor = Internals.BrunswickGreen;

            Forms.SetControlBackColor(new Control[]
            {
                txtORNumber,
                btnGenerateOR,
                btnStartTransaction
            }, Internals.BrunswickGreen);

            Forms.SetControlForeColor(new Control[]
            {
                txtORNumber,
                btnStartTransaction,
                btnGenerateOR
            }, Internals.SandDune);
        }

        private void PayBill_Load(object sender, EventArgs e)
        {
            Text = DEFAULT_TEXT;
        }
    }
}
