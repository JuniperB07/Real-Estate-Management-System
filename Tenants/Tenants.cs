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
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;
using Real_Estate_Management_System.Tenants.Edit;
using Real_Estate_Management_System.Tenants.New;

namespace Real_Estate_Management_System.Tenants
{
    public partial class Tenants : Form
    {
        Dialogs.MSGBox_OK MBOK;

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
        }

        private void Tenants_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "ACTIVE";
            pcbIDPhoto.ImageLocation = Configs.Tenants.DefaultValues.Default_IDLocation;
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
            NewTenantHelper.NT = new REMS.Tenants.NewTenant(Internals.DBC);

            New.NewTenant NT = new New.NewTenant();
            NT.ShowDialog();

            if (!NewTenantHelper.AllowProceed)
                return;

            New.NewEmergency NE = new New.NewEmergency();
            NE.ShowDialog();

            if (!NewTenantHelper.AllowProceed)
                return;

            New.NewTenancy NTC = new New.NewTenancy();
            NTC.ShowDialog();

            if (!NewTenantHelper.AllowProceed)
                return;

            Dialogs.ProcessingRequest PR = new Dialogs.ProcessingRequest();
            PR.Show();
            Application.DoEvents();

            SaveNewTenant();

            PR.Close();
        }

        private void btnViewActivity_Click(object sender, EventArgs e)
        {
            Activity.ViewActivity VA = new Activity.ViewActivity(this);
            VA.ShowDialog();

        }
    }
}
