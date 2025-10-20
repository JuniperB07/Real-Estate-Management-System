using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JunX.NETStandard.Utility;

namespace Real_Estate_Management_System.Tenants
{
    public partial class EditTenant : Form
    {
        TenantMetadata OriginalTM;
        TenantMetadata UpdatedTM;
        Dialogs.MSGBox_OK MBOK;

        public EditTenant()
        {
            InitializeComponent();
            MBOK = new Dialogs.MSGBox_OK();
        }

        private void EditTenant_Load(object sender, EventArgs e)
        {
            this.Text = EditHelper.FormTitle_EditTenant;
            OriginalTM = THelper.TenantInfo.Value;

            ResetForm();
            FillCMB_ValidID();
            FillForm();
        }

        private void EditTenant_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            UpdatedTM.FirstName = txtFirstName.Text;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            UpdatedTM.LastName = txtLastName.Text;
        }

        private void dtpDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            UpdatedTM.DateOfBirth = dtpDateOfBirth.Value;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            UpdatedTM.Phone = txtPhone.Text;
        }

        private void cmbValidID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbValidID.Text))
                UpdatedTM.ValidID = EnumHelper<ValidIDList>.GetEnumValue(cmbValidID.Text, ' ', '_');
            else
                UpdatedTM.ValidID = ValidIDList.None;
        }

        private void txtIDNumber_TextChanged(object sender, EventArgs e)
        {
            if (UpdatedTM.ValidID == ValidIDList.None)
            {
                UpdatedTM.IDNumber = "N/A";
                return;
            }

            UpdatedTM.IDNumber = txtIDNumber.Text;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (ofdUpload.ShowDialog() == DialogResult.OK)
                UpdatedTM.IDLocation = ofdUpload.FileName;

            pcbIDPhoto.ImageLocation = UpdatedTM.IDLocation;
        }

        private void btnRemoveID_Click(object sender, EventArgs e)
        {
            UpdatedTM.IDLocation = Internals.DEFAULT_ID_LOCATION;
            pcbIDPhoto.ImageLocation = UpdatedTM.IDLocation;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateTenantInformation();
            Close();
        }
    }
}
