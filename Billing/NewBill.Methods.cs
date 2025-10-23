using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunX.NET8.WinForms;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;
using JunX.NETStandard.Utility;

namespace Real_Estate_Management_System.Billing
{
    partial class NewBill
    {
        private void ResetForm()
        {
            Forms.ClearControlText(Forms.ControlType<Label>.Extract(this, "lbl"));
            txtSearchTenant.Text = "";
            lstTenantsList.Items.Clear();

            Forms.SetControlVisible(new Panel[]
            {
                pnlBillSummary,
                pnlElectricityBill,
                pnlInternetBill,
                pnlRentalBill,
                pnlWaterBill }, false);
        }

        private void FillTenantsList()
        {
            Forms.FillListBox(lstTenantsList, Internals.TenantsList);
        }

        private void SetupSearchTenant_AutoCompleteSource()
        {
            txtSearchTenant.AutoCompleteCustomSource.Clear();

            foreach (string TN in Internals.TenantsList)
                txtSearchTenant.AutoCompleteCustomSource.Add(TN);
        }

        private void InitiateNewInvoice()
        { 
            BHelper.NewInvoice = new Invoice(
                BHelper.TenantID,
                Methods.GenerateInvoiceNumber(BHelper.TenantID),
                DateTime.Now,
                InvoiceStatuses.UNPAID);

            BHelper.NewWaterInvoice = new WaterInvoice(
                BHelper.NewInvoice.InvoiceNumber,
                Methods.DueDate(BHelper.DueDateMode_Utility, BHelper.NewInvoice.InvoiceDate, BHelper.TenantID, InvoiceTypes.WATER),
                BHelper.TenantID,
                SetStatus: InvoiceStatuses.UNPAID);

            BHelper.NewElectricityInvoice = new ElectricityInvoice(
                BHelper.NewInvoice.InvoiceNumber,
                Methods.DueDate(BHelper.DueDateMode_Utility, BHelper.NewInvoice.InvoiceDate, BHelper.TenantID, InvoiceTypes.ELECTRICITY),
                BHelper.TenantID,
                SetStatus: InvoiceStatuses.UNPAID);

            BHelper.NewRentalInvoice = new RentalInvoice(
                BHelper.NewInvoice.InvoiceNumber,
                Methods.DueDate(BHelper.DueDateMode_Rental, BHelper.NewInvoice.InvoiceDate, BHelper.TenantID, InvoiceTypes.RENTAL),
                BHelper.TenantID,
                SetStatus: InvoiceStatuses.UNPAID);

            BHelper.NewInternetInvoice = new InternetInvoice(
                BHelper.NewInvoice.InvoiceNumber,
                Methods.DueDate(BHelper.DueDateMode_Internet, BHelper.NewInvoice.InvoiceDate, BHelper.TenantID, InvoiceTypes.INTERNET),
                BHelper.TenantID,
                SetStatus: InvoiceStatuses.UNPAID);

            lblWaterBillTotal.Text = Internals.PESO + BHelper.NewWaterInvoice.Subtotal.ToString("0,0.00");
            lblElectricityBillTotal.Text = Internals.PESO + BHelper.NewElectricityInvoice.Subtotal.ToString("0,0.00");
            lblInternetBillTotal.Text = Internals.PESO + BHelper.NewInternetInvoice.Subtotal.ToString("0,0.00");
            lblRentalBillTotal.Text = Internals.PESO + (BHelper.NewRentalInvoice.Subtotal + BHelper.NewInvoice.TotalPenalties).ToString("0,0.00");


            lblTenantName.Text = BHelper.NewInvoice.TenantName;
            lblBillNumber.Text = BHelper.NewInvoice.InvoiceNumber;
            lblInvoiceDate.Text = BHelper.NewInvoice.InvoiceDate.ToString("MMMM d, yyyy");
            lblInvoiceTotal.Text = Internals.PESO + BHelper.NewInvoiceTotal.ToString("0,0.00");

            Forms.SetControlVisible(new Control[]
            {
                pnlBillSummary,
                pnlWaterBill,
                pnlElectricityBill,
                pnlRentalBill,
                pnlInternetBill }, true);
        }
    }
}
