using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Real_Estate_Management_System.Billing.Helper;
using JunX.NET8.WinForms;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;
using System.Windows.Markup;

namespace Real_Estate_Management_System.Billing
{
    public partial class NewBill : Form
    {
        private const string DEFAULT_FORM_TEXT = "Real Estate Management System - New Bill";
        Dialogs.MSGBox_OK MBOK;

        public NewBill()
        {
            InitializeComponent();
            Internals.SetFormColors(this);
            Text = DEFAULT_FORM_TEXT;
            Forms.SetControlForeColor(Forms.ControlType<Label>.Extract(this), Internals.SandDune);

            pnlHeader.BackColor = Internals.Cyprus;

            pnlSelectTenant.BackColor = Internals.BrunswickGreen;
            lstTenantsList.BackColor = Internals.BrunswickGreen;
            lstTenantsList.ForeColor = Internals.SandDune;
            txtSearchTenant.BackColor = Internals.SandDune;
            txtSearchTenant.ForeColor = Internals.BrunswickGreen;

            pnlButtons.BackColor = Internals.BrunswickGreen;
            pnlBillSummary.BackColor = Internals.BrunswickGreen;
            Forms.SetControlForeColor(Forms.ControlType<Button>.Extract(pnlBillSummary), Internals.SandDune);
            Forms.SetControlBackColor(Forms.ControlType<Button>.Extract(pnlBillSummary), Internals.BrunswickGreen);

            txtSearchTenant.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void NewBill_Load(object sender, EventArgs e)
        {
            ResetForm();
            FillTenantsList();
            SetupSearchTenant_AutoCompleteSource();

            MBOK = new Dialogs.MSGBox_OK();
        }

        private void btnManage_WaterBill_Click(object sender, EventArgs e)
        {
            Manage.WaterBill MWB = new Manage.WaterBill();
            MWB.ShowDialog();

            RefreshInvoicePanels();
        }

        private void btnManage_ElectricityBill_Click(object sender, EventArgs e)
        {
            Manage.ElectricityBill MEB = new Manage.ElectricityBill();
            MEB.ShowDialog();

            RefreshInvoicePanels();
        }

        private void btnManage_RentalBill_Click(object sender, EventArgs e)
        {
            Manage.RentalBill MRB = new Manage.RentalBill();
            MRB.ShowDialog();
        }

        private void btnManage_InternetBill_Click(object sender, EventArgs e)
        {
            Manage.InternetBill MIB = new Manage.InternetBill();
            MIB.ShowDialog();
        }

        private void btnSetDueDates_Click(object sender, EventArgs e)
        {
            SetDueDates SDD = new SetDueDates();
            SDD.ShowDialog();
        }

        private void NewBill_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void btnBillPreview_Click(object sender, EventArgs e)
        {
            PreviewHelper.PreviewMode = PreviewHelperMode.Preview;
            BillPreview BP = new BillPreview();
            BP.ShowDialog();
        }

        private void btnExportToPDF_Click(object sender, EventArgs e)
        {
            PreviewHelper.PreviewMode = PreviewHelperMode.ExportToPDF;
            BillPreview BP = new BillPreview();
            BP.ShowDialog();
        }

        private void txtSearchTenant_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearchTenant.Text))
                Forms.FillListBox(lstTenantsList, Internals.SearchTenant(txtSearchTenant.Text));
            else
                FillTenantsList();
        }

        private void lstTenantsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string? tName = lstTenantsList.SelectedItem?.ToString();

            if (!string.IsNullOrWhiteSpace(tName))
            {
                new SelectCommand<tbtenants>()
                    .Select(tbtenants.TenantID)
                    .From
                    .StartWhere
                        .Where(tbtenants.FullName, SQLOperator.Equal, "@FullName")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@FullName", tName));
                BHelper.TenantID = Convert.ToInt32(Internals.DBC.Values[0]);

                new SelectCommand<tbtenants>()
                    .Select(tbtenants.TenancyStatus)
                    .From
                    .StartWhere
                        .Where(tbtenants.TenantID, SQLOperator.Equal, BHelper.TenantID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                if (Internals.DBC.Values[0] != Tenants.TenancyStatuses.Active.ToString())
                {
                    MBOK = new Dialogs.MSGBox_OK(this.Text, "The selected tenant is not active.\nUnable to proceed.", Dialogs.DialogIcons.Error);
                    MBOK.ShowDialog();
                    NewBill_Load(this, EventArgs.Empty);
                    return;
                }

                InitiateNewInvoice();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            NewBill_Load(this, EventArgs.Empty);
        }

        private void btnSaveBill_Click(object sender, EventArgs e)
        {
            if(!BHelper.InvoicesValid)
            {
                MBOK = new Dialogs.MSGBox_OK(this.Text, "An invalid sub-invoice detected.\nPlease check all inputs to sub-invoices (Water/Electricity/Rental/Internet) are valid.", Dialogs.DialogIcons.Error);
                MBOK.ShowDialog();
                return;
            }

            DialogResult confirm = MessageBox.Show("Saved invoice information can no longer be edited.\nProceed?", "Real Estate Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
                return;

            //--- SAVE WATER SUB-INVOICE ---
            new InsertIntoCommand<tbwaterinvoice>()
                .Column(new tbwaterinvoice[]
                {
                    tbwaterinvoice.InvoiceNumber,
                    tbwaterinvoice.DueDate,
                    tbwaterinvoice.TenantID,
                    tbwaterinvoice.PreviousReading,
                    tbwaterinvoice.PresentReading,
                    tbwaterinvoice.Consumption,
                    tbwaterinvoice.CurrentCharge,
                    tbwaterinvoice.RemainingBalance,
                    tbwaterinvoice.Deductions,
                    tbwaterinvoice.Subtotal,
                    tbwaterinvoice.BillBalance,
                    tbwaterinvoice.Status,
                    tbwaterinvoice.AdvanceIDs
                })
                .Values(new ValuesMetadata[]
                {
                    new ValuesMetadata(BHelper.NewWaterInvoice.InvoiceNumber, DataTypes.NonNumeric),
                    new ValuesMetadata(BHelper.NewWaterInvoice.DueDate.ToString("yyyy-MM-dd"), DataTypes.NonNumeric),
                    new ValuesMetadata(BHelper.NewWaterInvoice.TenantID.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewWaterInvoice.PreviousReading.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewWaterInvoice.PresentReading.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewWaterInvoice.Consumption.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewWaterInvoice.CurrentCharge.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewWaterInvoice.RemainingBalance.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewWaterInvoice.Deductions.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewWaterInvoice.Subtotal.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewWaterInvoice.Subtotal.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewWaterInvoice.Status.ToString(), DataTypes.NonNumeric),
                    new ValuesMetadata(BHelper.NewWaterInvoice.AdvanceIDs, DataTypes.NonNumeric)
                })
                .ExecuteNonQuery(Internals.DBC);

            //--- SAVE ELECTRICITY SUB-INVOICE ---
            new InsertIntoCommand<tbelectricityinvoice>()
                .Column(new tbelectricityinvoice[]
                {
                    tbelectricityinvoice.InvoiceNumber,
                    tbelectricityinvoice.DueDate,
                    tbelectricityinvoice.TenantID,
                    tbelectricityinvoice.PreviousReading,
                    tbelectricityinvoice.PresentReading,
                    tbelectricityinvoice.Consumption,
                    tbelectricityinvoice.CurrentCharge,
                    tbelectricityinvoice.RemainingBalance,
                    tbelectricityinvoice.Deductions,
                    tbelectricityinvoice.Subtotal,
                    tbelectricityinvoice.BillBalance,
                    tbelectricityinvoice.Status,
                    tbelectricityinvoice.AdvanceIDs
                })
                .Values(new ValuesMetadata[]
                {
                    new ValuesMetadata(BHelper.NewElectricityInvoice.InvoiceNumber, DataTypes.NonNumeric),
                    new ValuesMetadata(BHelper.NewElectricityInvoice.DueDate.ToString("yyyy-MM-dd"), DataTypes.NonNumeric),
                    new ValuesMetadata(BHelper.NewElectricityInvoice.TenantID.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewElectricityInvoice.PreviousReading.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewElectricityInvoice.PresentReading.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewElectricityInvoice.Consumption.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewElectricityInvoice.CurrentCharge.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewElectricityInvoice.RemainingBalance.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewElectricityInvoice.Deductions.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewElectricityInvoice.Subtotal.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewElectricityInvoice.Subtotal.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewElectricityInvoice.Status.ToString(), DataTypes.NonNumeric),
                    new ValuesMetadata(BHelper.NewElectricityInvoice.AdvanceIDs, DataTypes.NonNumeric)
                })
                .ExecuteNonQuery(Internals.DBC);

            //--- SAVE RENTAL SUB-INVOICE ---
            new InsertIntoCommand<tbrentalinvoice>()
                .Column(new tbrentalinvoice[]
                {
                    tbrentalinvoice.InvoiceNumber,
                    tbrentalinvoice.DueDate,
                    tbrentalinvoice.TenantID,
                    tbrentalinvoice.MonthlyRent,
                    tbrentalinvoice.RemainingBalance,
                    tbrentalinvoice.Deductions,
                    tbrentalinvoice.Subtotal,
                    tbrentalinvoice.BillBalance,
                    tbrentalinvoice.Status,
                    tbrentalinvoice.AdvanceIDs
                })
                .Values(new ValuesMetadata[]
                {
                    new ValuesMetadata(BHelper.NewRentalInvoice.InvoiceNumber, DataTypes.NonNumeric),
                    new ValuesMetadata(BHelper.NewRentalInvoice.DueDate.ToString("yyyy-MM-dd"), DataTypes.NonNumeric),
                    new ValuesMetadata(BHelper.NewRentalInvoice.TenantID.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewRentalInvoice.MonthlyRent.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewRentalInvoice.RemainingBalance.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewRentalInvoice.Deductions.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewRentalInvoice.Subtotal.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewRentalInvoice.Subtotal.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewRentalInvoice.Status.ToString(), DataTypes.NonNumeric),
                    new ValuesMetadata(BHelper.NewRentalInvoice.AdvanceIDs, DataTypes.NonNumeric)
                })
                .ExecuteNonQuery(Internals.DBC);

            //--- SAVE INTERNET SUB-INVOICE ---
            new InsertIntoCommand<tbinternetinvoice>()
                .Column(new tbinternetinvoice[]
                {
                    tbinternetinvoice.InvoiceNumber,
                    tbinternetinvoice.DueDate,
                    tbinternetinvoice.TenantID,
                    tbinternetinvoice.PlanName,
                    tbinternetinvoice.SubscriptionFee,
                    tbinternetinvoice.RemainingBalance,
                    tbinternetinvoice.Deductions,
                    tbinternetinvoice.Subtotal,
                    tbinternetinvoice.BillBalance,
                    tbinternetinvoice.Status,
                    tbinternetinvoice.AdvanceIDs
                })
                .Values(new ValuesMetadata[]
                {
                    new ValuesMetadata(BHelper.NewInternetInvoice.InvoiceNumber, DataTypes.NonNumeric),
                    new ValuesMetadata(BHelper.NewInternetInvoice.Deductions.ToString("yyyy-MM-dd"), DataTypes.NonNumeric),
                    new ValuesMetadata(BHelper.NewInternetInvoice.TenantID.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewInternetInvoice.PlanName, DataTypes.NonNumeric),
                    new ValuesMetadata(BHelper.NewInternetInvoice.SubscriptionFee.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewInternetInvoice.RemainingBalance.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewInternetInvoice.Deductions.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewInternetInvoice.Subtotal.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewInternetInvoice.Subtotal.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewInternetInvoice.Status.ToString(), DataTypes.NonNumeric),
                    new ValuesMetadata(BHelper.NewInternetInvoice.AdvanceIDs, DataTypes.NonNumeric)
                })
                .ExecuteNonQuery(Internals.DBC);

            //--- SAVE INVOICE ---
            new InsertIntoCommand<tbinvoices>()
                .Column(new tbinvoices[]
                {
                    tbinvoices.TenantID,
                    tbinvoices.InvoiceNumber,
                    tbinvoices.InvoiceDate,
                    tbinvoices.WaterInvoiceID,
                    tbinvoices.ElectricityInvoiceID,
                    tbinvoices.RentalInvoiceID,
                    tbinvoices.InternetInvoiceID,
                    tbinvoices.PenaltyIDs,
                    tbinvoices.InvoiceTotal,
                    tbinvoices.Status
                })
                .Values(new ValuesMetadata[]
                {
                    new ValuesMetadata(BHelper.NewInvoice.TenantID.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewInvoice.InvoiceNumber, DataTypes.NonNumeric),
                    new ValuesMetadata(BHelper.NewInvoice.InvoiceDate.ToString("yyyy-MM-dd"), DataTypes.NonNumeric),
                    new ValuesMetadata(BHelper.NewInvoice.WaterInvoiceID.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewInvoice.ElectricityInvoiceID.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewInvoice.RentalInvoiceID.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewInvoice.InternetInvoiceID.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewInvoice.PenaltyIDs, DataTypes.NonNumeric),
                    new ValuesMetadata(BHelper.NewInvoice.InvoiceTotal.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(BHelper.NewInvoice.Status.ToString(), DataTypes.NonNumeric)
                })
                .ExecuteNonQuery(Internals.DBC);

            MBOK = new Dialogs.MSGBox_OK(this.Text, "Invoice saved.", Dialogs.DialogIcons.Information);
            MBOK.ShowDialog();
        }
    }
}
