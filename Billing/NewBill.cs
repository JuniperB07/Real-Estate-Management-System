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
        }

        private void NewBill_Load(object sender, EventArgs e)
        {

        }

        private void btnManage_WaterBill_Click(object sender, EventArgs e)
        {
            WaterBill MWB = new WaterBill();
            MWB.ShowDialog();
        }

        private void btnManage_ElectricityBill_Click(object sender, EventArgs e)
        {
            Manage.ElectricityBill MEB = new Manage.ElectricityBill();
            MEB.ShowDialog();
        }
    }
}
