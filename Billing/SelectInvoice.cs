using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;
using JunX.NET8.WinForms;
using Real_Estate_Management_System.Payments;
using Real_Estate_Management_System.Billing.Helper;

namespace Real_Estate_Management_System.Billing
{
    public partial class SelectInvoice : Form
    {
        public SelectInvoice()
        {
            InitializeComponent();
        }

        private void SelectInvoice_Load(object sender, EventArgs e)
        {
            txtSearchTenant.Text = "";
            lstTenantsList.Items.Clear();
            dgvInvoices.DataSource = null;

            Forms.FillListBox(lstTenantsList, Internals.TenantsList);
            PreviewHelper.AllowProceed = false;
        }

        private void txtSearchTenant_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearchTenant.Text))
                Forms.FillListBox(lstTenantsList, Internals.SearchTenant(txtSearchTenant.Text));
            else
                Forms.FillListBox(lstTenantsList, Internals.TenantsList);
        }

        private void lstTenantsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstTenantsList.SelectedItems.Count > 0)
            {
                int tID = 0;

                new SelectCommand<tbtenants>()
                    .Select(tbtenants.TenantID)
                    .From
                    .StartWhere
                        .Where(tbtenants.FullName, SQLOperator.Equal, "@FullName")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@FullName", lstTenantsList.SelectedItem.ToString()));
                tID = Convert.ToInt32(Internals.DBC.Values[0]);

                new SelectCommand<tbinvoices>()
                    .Select(tbinvoices.InvoiceNumber).As("Invoice Number")
                    .Select(tbinvoices.InvoiceDate).As("Invoice Date")
                    .From
                    .StartWhere
                        .Where(tbinvoices.TenantID, SQLOperator.Equal, tID.ToString())
                    .EndWhere
                    .OrderBy(tbinvoices.InvoiceDate, OrderByModes.DESC)
                    .ExecuteDataSet(Internals.DBC);

                dgvInvoices.DataSource = null;
                dgvInvoices.DataSource = Internals.DBC.DataSet.Tables[0];
            }
        }

        private void dgvInvoices_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BHelper.InvoiceNumber = dgvInvoices.SelectedCells[0].Value.ToString();
            PreviewHelper.AllowProceed = true;
            Close();
        }
    }
}
