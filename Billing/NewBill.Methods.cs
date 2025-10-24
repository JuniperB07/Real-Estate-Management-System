using System;
using System.Collections.Generic;
using System.Configuration.Internal;
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
            ttNewBill.Active = false;

            Forms.SetControlVisible(new Panel[]
            {
                pnlReset,
                pnlSetDueDates,
                pnlSaveBill,
                pnlBillSummary,
                pnlElectricityBill,
                pnlInternetBill,
                pnlRentalBill,
                pnlWaterBill }, false);

            BHelper.NewInvoice = new Invoice();
            BHelper.NewWaterInvoice = new WaterInvoice();
            BHelper.NewElectricityInvoice = new ElectricityInvoice();
            BHelper.NewRentalInvoice = new RentalInvoice();
            BHelper.NewInternetInvoice = new InternetInvoice();
            BHelper.TenantID = 0;
            BHelper.IsSaved = false;
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
            DateTime firstDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            new SelectCommand<tbinvoices>()
                .SelectAll.From
                .StartWhere
                    .Where(tbinvoices.TenantID, SQLOperator.Equal, BHelper.TenantID.ToString())
                    .And()
                    .Between(tbinvoices.InvoiceDate, "'" + firstDate.ToString("yyyy-MM-dd") + "'", "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'")
                .EndWhere
                .ExecuteReader(Internals.DBC);
            if (Internals.DBC.HasRows)
            {
                Internals.DBC.CloseReader();
                MBOK = new Dialogs.MSGBox_OK(this.Text, "This tenant already have an existing bill.", Dialogs.DialogIcons.Error);
                MBOK.ShowDialog();
                NewBill_Load(this, EventArgs.Empty);
                return;
            }
            Internals.DBC.CloseReader();

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
            lblRentalBillTotal.Text = Internals.PESO + BHelper.NewRentalInvoice.Subtotal.ToString("0,0.00");


            lblTenantName.Text = BHelper.NewInvoice.TenantName;
            lblBillNumber.Text = BHelper.NewInvoice.InvoiceNumber;
            lblInvoiceDate.Text = BHelper.NewInvoice.InvoiceDate.ToString("MMMM d, yyyy");
            lblInvoiceTotal.Text = Internals.PESO + BHelper.NewInvoiceTotal.ToString("0,0.00");

            Forms.SetControlVisible(new Control[]
            {
                pnlReset,
                pnlSetDueDates,
                pnlSaveBill,
                pnlBillSummary,
                pnlWaterBill,
                pnlElectricityBill,
                pnlRentalBill,
                pnlInternetBill }, true);
            ActivateToolTip();
        }

        private void RefreshInvoicePanels()
        {
            lblWaterBillTotal.Text = Internals.PESO + BHelper.NewWaterInvoice.Subtotal.ToString("0,0.00");
            lblElectricityBillTotal.Text = Internals.PESO + BHelper.NewElectricityInvoice.Subtotal.ToString("0,0.00");
            lblInternetBillTotal.Text = Internals.PESO + BHelper.NewInternetInvoice.Subtotal.ToString("0,0.00");
            lblRentalBillTotal.Text = Internals.PESO + BHelper.NewRentalInvoice.Subtotal.ToString("0,0.00");
            lblInvoiceTotal.Text = Internals.PESO + BHelper.NewInvoiceTotal.ToString("0,0.00");

            ttNewBill.SetToolTip(lblWaterBillTotal,
                "Previous Reading: " + BHelper.NewWaterInvoice.PreviousReading.ToString() + "\n" +
                "Present Reading: " + BHelper.NewWaterInvoice.PresentReading.ToString() + "\n" +
                "Consumption: " + BHelper.NewWaterInvoice.Consumption.ToString() + Configs.Utilities.UtilitiesConfig.Water_Unit);
            ttNewBill.SetToolTip(lblElectricityBillTotal,
                "Previous Reading: " + BHelper.NewElectricityInvoice.PreviousReading.ToString() + "\n" +
                "Present Reading: " + BHelper.NewElectricityInvoice.PresentReading.ToString() + "\n" +
                "Consumption: " + BHelper.NewElectricityInvoice.Consumption.ToString() + Configs.Utilities.UtilitiesConfig.Electricity_Unit);
            ttNewBill.SetToolTip(lblRentalBillTotal,
                "Rental Bill Total: " + Internals.PESO + BHelper.NewRentalInvoice.Subtotal.ToString("0,0.00"));
            ttNewBill.SetToolTip(lblInternetBillTotal,
                "Plan: " + BHelper.NewInternetInvoice.PlanName + "\n" +
                "Subscription Plan: " + Internals.PESO + BHelper.NewInternetInvoice.SubscriptionFee.ToString("0,0.00"));

        }

        private void ActivateToolTip()
        {
            string bName = "", rName = "";
            int rID, bID;

            new SelectCommand<tbtenants>()
                .Select(tbtenants.RoomID)
                .From
                .StartWhere
                    .Where(tbtenants.TenantID, SQLOperator.Equal, BHelper.TenantID.ToString())
                .EndWhere
                .ExecuteReader(Internals.DBC);
            rID = Convert.ToInt32(Internals.DBC.Values[0]);

            new SelectCommand<tbrooms>()
                .Select(tbrooms.BuildingID)
                .Select(tbrooms.RoomName)
                .From
                .StartWhere
                    .Where(tbrooms.RoomID, SQLOperator.Equal, rID.ToString())
                .EndWhere
                .ExecuteReader(Internals.DBC);
            bID = Convert.ToInt32(Internals.DBC.Values[0]);
            rName = Internals.DBC.Values[1];

            new SelectCommand<tbbuilding>()
                .Select(tbbuilding.BuildingName)
                .From
                .StartWhere
                    .Where(tbbuilding.BuildingID, SQLOperator.Equal, bID.ToString())
                .EndWhere
                .ExecuteReader(Internals.DBC);
            bName = Internals.DBC.Values[0];

            ttNewBill.Active = true;
            ttNewBill.SetToolTip(lblTenantName, "Building Name: " + bName + "\nRoom Name: " + rName);

            ttNewBill.SetToolTip(lblWaterBillTotal,
                "Previous Reading: " + BHelper.NewWaterInvoice.PreviousReading.ToString() + "\n" +
                "Present Reading: " + BHelper.NewWaterInvoice.PresentReading.ToString() + "\n" +
                "Consumption: " + BHelper.NewWaterInvoice.Consumption.ToString() + Configs.Utilities.UtilitiesConfig.Water_Unit);
            ttNewBill.SetToolTip(lblElectricityBillTotal,
                "Previous Reading: " + BHelper.NewElectricityInvoice.PreviousReading.ToString() + "\n" +
                "Present Reading: " + BHelper.NewElectricityInvoice.PresentReading.ToString() + "\n" +
                "Consumption: " + BHelper.NewElectricityInvoice.Consumption.ToString() + Configs.Utilities.UtilitiesConfig.Electricity_Unit);
            ttNewBill.SetToolTip(lblRentalBillTotal,
                "Rental Bill Total: " + Internals.PESO + BHelper.NewRentalInvoice.Subtotal.ToString("0,0.00"));
            ttNewBill.SetToolTip(lblInternetBillTotal,
                "Plan: " + BHelper.NewInternetInvoice.PlanName + "\n" +
                "Subscription Plan: " + Internals.PESO + BHelper.NewInternetInvoice.SubscriptionFee.ToString("0,0.00"));
        }
    }
}
