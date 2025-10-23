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

namespace Real_Estate_Management_System.Billing
{
    public partial class NewBill : Form
    {
        private const string DEFAULT_FORM_TEXT = "Real Estate Management System - New Bill";

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
        }

        private void btnManage_WaterBill_Click(object sender, EventArgs e)
        {
            Manage.WaterBill MWB = new Manage.WaterBill();
            MWB.ShowDialog();
        }

        private void btnManage_ElectricityBill_Click(object sender, EventArgs e)
        {
            Manage.ElectricityBill MEB = new Manage.ElectricityBill();
            MEB.ShowDialog();
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
            FunctionButtons.SetDueDates SDD = new FunctionButtons.SetDueDates();
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
                //save Tenant id
            }
        }
    }
}
