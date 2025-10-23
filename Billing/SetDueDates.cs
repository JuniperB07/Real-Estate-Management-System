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

namespace Real_Estate_Management_System.Billing
{
    public partial class SetDueDates : Form
    {
        Dialogs.MSGBox_OK MBOK;

        public SetDueDates()
        {
            InitializeComponent();
        }

        private void SetDueDates_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void SetDueDates_Load(object sender, EventArgs e)
        {
            ResetForm();
            FillForm();

            MBOK = new Dialogs.MSGBox_OK();
        }

        private void btnSaveUtilitiesDueDate_Click(object sender, EventArgs e)
        {
            BHelper.NewWaterInvoice.DueDate = dtpUtilitiesDueDate.Value;
            BHelper.NewElectricityInvoice.DueDate = dtpUtilitiesDueDate.Value;

            dtpUtilitiesDueDate.Value = BHelper.NewWaterInvoice.DueDate;

            MBOK = new Dialogs.MSGBox_OK(this.Text, "Utilities due dates updated.", Dialogs.DialogIcons.Information);
            MBOK.ShowDialog();
        }

        private void btnSaveRentalDueDate_Click(object sender, EventArgs e)
        {
            BHelper.NewRentalInvoice.DueDate = dtpRentalDueDate.Value;

            dtpRentalDueDate.Value = BHelper.NewRentalInvoice.DueDate;

            MBOK = new Dialogs.MSGBox_OK(this.Text, "Rental due date updated.", Dialogs.DialogIcons.Information);
            MBOK.ShowDialog();
        }

        private void btnSaveInternetDueDate_Click(object sender, EventArgs e)
        {
            BHelper.NewInternetInvoice.DueDate = dtpInternetDueDate.Value;

            dtpInternetDueDate.Value = BHelper.NewInternetInvoice.DueDate;

            MBOK = new Dialogs.MSGBox_OK(this.Text, "Internet due date updated.", Dialogs.DialogIcons.Information);
            MBOK.ShowDialog();
        }

        private void pcbResetUtilities_Click(object sender, EventArgs e)
        {
            BHelper.NewWaterInvoice.DueDate = Methods.DueDate(
                BHelper.DueDateMode_Utility,
                BHelper.NewInvoice.InvoiceDate,
                BHelper.TenantID,
                InvoiceTypes.WATER);

            BHelper.NewElectricityInvoice.DueDate = Methods.DueDate(
                BHelper.DueDateMode_Utility,
                BHelper.NewInvoice.InvoiceDate,
                BHelper.TenantID,
                InvoiceTypes.ELECTRICITY);

            dtpUtilitiesDueDate.Value = BHelper.NewWaterInvoice.DueDate;

            MBOK = new Dialogs.MSGBox_OK(this.Text, "Utilities due date reset successful.", Dialogs.DialogIcons.Information);
            MBOK.ShowDialog();
        }

        private void pcbResetRental_Click(object sender, EventArgs e)
        {
            BHelper.NewRentalInvoice.DueDate = Methods.DueDate(
                BHelper.DueDateMode_Rental,
                BHelper.NewInvoice.InvoiceDate,
                BHelper.TenantID,
                InvoiceTypes.RENTAL);

            MBOK = new Dialogs.MSGBox_OK(this.Text, "Rental due date reset successful.", Dialogs.DialogIcons.Information);
            MBOK.ShowDialog();
        }

        private void pcbResetInternet_Click(object sender, EventArgs e)
        {
            BHelper.NewInternetInvoice.DueDate = Methods.DueDate(
                BHelper.DueDateMode_Internet,
                BHelper.NewInvoice.InvoiceDate,
                BHelper.TenantID,
                InvoiceTypes.INTERNET);

            MBOK = new Dialogs.MSGBox_OK(this.Text, "Internet due date reset successful.", Dialogs.DialogIcons.Information);
            MBOK.ShowDialog();
        }
    }
}
