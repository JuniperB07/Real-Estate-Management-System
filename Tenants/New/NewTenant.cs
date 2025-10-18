using REMS.Tenants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_Management_System.Tenants.New
{
    public partial class NewTenant : Form
    {
        private REMS.Tenants.TenantInformation NewTenantInfo;

        public NewTenant()
        {
            InitializeComponent();
        }

        private void NewTenant_Load(object sender, EventArgs e)
        {
            NewTenantInfo = new REMS.Tenants.TenantInformation();
            NewTenantHelper.AllowProceed = false;

            ResetForm();
            ClearForm();
        }

        private void btnUploadID_Click(object sender, EventArgs e)
        {
            if (ofdUploadID.ShowDialog() == DialogResult.OK)
                NewTenantInfo.IDLocation = ofdUploadID.FileName;

            pcbIDPhoto.ImageLocation = NewTenantInfo.IDLocation;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NewTenantInfo.FirstName = txtFirstName.Text;
            NewTenantInfo.LastName = txtLastName.Text;
            NewTenantInfo.DateOfBirth = dtpDateOfBirth.Value;
            NewTenantInfo.Phone = txtPhone.Text;
            NewTenantInfo.IDNumber = txtIDNumber.Text;

            if (NewTenantInfo.ValidID == ValidIDs.None)
            {
                NewTenantInfo.IDNumber = "N/A";
                NewTenantInfo.IDLocation = Configs.Tenants.DefaultValues.Default_IDLocation;
            }

            if (!NewTenantInfo.IsValid())
            {
                Dialogs.MSGBox_OK MBOK = new Dialogs.MSGBox_OK(Dialogs.Dialogs.DEFAULT_MBTEXT, "Please fill all fields.", Dialogs.DialogIcons.Error);
                MBOK.ShowDialog();
                return;
            }

            NewTenantHelper.NewTenantInformation = NewTenantInfo;
            NewTenantHelper.AllowProceed = true;
            Close();
        }

        private void cmbValidID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbValidID.Text != "")
                NewTenantInfo.ValidID = cmbValidID.Text.ToValidIDsEnum();
            else
                NewTenantInfo.ValidID = ValidIDs.None;
        }
    }
}
