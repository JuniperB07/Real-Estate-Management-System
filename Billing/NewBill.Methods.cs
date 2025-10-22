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

            BHelper.NewInvoice = new InvoiceMetadata();
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
            BHelper.NewInvoice = new InvoiceMetadata(
                SetTenantID: BHelper.TenantID,
                SetInvoiceNumber: Methods.GenerateInvoiceNumber(BHelper.TenantID),
                SetInvoiceDate: DateTime.Now,
                SetIncludeInternet: Convert.ToInt32(Configs.Billing.BillingConfig.IncludeInternet),
                SetStatus: InvoiceStatuses.UNPAID);
        }

        private void RefreshBillingSummary()
        {

        }
    }
}
