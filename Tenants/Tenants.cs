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
using Real_Estate_Management_System.Tenants.Edit;

namespace Real_Estate_Management_System.Tenants
{
    public partial class Tenants : Form
    {
        public Tenants()
        {
            InitializeComponent();
            Forms.SetControlForeColor(Forms.ControlType<Label>.Extract(this), Internals.SandDune);
            pnlHeader.BackColor = Internals.Cyprus;

            lstTenantsList.BackColor = Internals.BrunswickGreen;
            lstTenantsList.ForeColor = Internals.SandDune;
            txtSearchTenant.BackColor = Internals.SandDune;
            txtSearchTenant.ForeColor = Internals.BrunswickGreen;

            Forms.SetControlBackColor(new Panel[]
            {
                pnlSelectTenant,
                pnlButtons
            }, Internals.BrunswickGreen);

            pcbIDPhoto.Image = Properties.Resources.REMS_TENANTS_DEFAULT_ID;
        }

        private void Tenants_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "ACTIVE";
        }

        private void lblStatus_TextChanged(object sender, EventArgs e)
        {
            switch (lblStatus.Text)
            {
                case "ACTIVE":
                    lblStatus.ForeColor = Color.LimeGreen;
                    break;
                case "INACTIVE":
                case "TERMINATED":
                    lblStatus.ForeColor = Color.Red;
                    break;
                case "PENDING":
                    lblStatus.ForeColor = Color.Yellow;
                    break;
                default:
                    lblStatus.ForeColor = Color.Black;
                    break;
            }
        }

        private void btnTenant_Edit_Click(object sender, EventArgs e)
        {
            EditHelper.FormTitle_EditTenant = lblTenantName.Text;
            EditTenant ET = new EditTenant();
            ET.ShowDialog();
        }

        private void btnEmergency_Edit_Click(object sender, EventArgs e)
        {
            EditHelper.FormTitle_EditEmergency = lblTenantName.Text;
            EditEmergency EE = new EditEmergency();
            EE.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditHelper.FormTitle_EditTenancy = lblTenantName.Text;
            EditTenancy ET = new EditTenancy();
            ET.ShowDialog();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            New.NewTenant NT = new New.NewTenant();
            NT.ShowDialog();

            New.NewEmergency NE = new New.NewEmergency();
            NE.ShowDialog();

            New.NewTenancy NTC = new New.NewTenancy();
            NTC.ShowDialog();
        }

        private void btnViewActivity_Click(object sender, EventArgs e)
        {
            Activity.ViewActivity VA = new Activity.ViewActivity(this);
            VA.ShowDialog();

        }
    }
}
