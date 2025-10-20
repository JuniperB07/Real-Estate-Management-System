using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_Management_System.Tenants.Edit
{
    public partial class EditEmergency : Form
    {
        EmergencyMetadata OriginalEM;
        EmergencyMetadata UpdatedEM;
        Dialogs.MSGBox_OK MBOK;

        public EditEmergency()
        {
            InitializeComponent();
            MBOK = new Dialogs.MSGBox_OK();
        }

        private void EditEmergency_Load(object sender, EventArgs e)
        {
            Text = EditHelper.FormTitle_EditEmergency;
            OriginalEM = THelper.EmergencyInfo.Value;

            ResetForm();
            FillForm();
        }

        private void txtEmergencyContact_TextChanged(object sender, EventArgs e)
        {
            UpdatedEM.EmergencyContact = txtEmergencyContact.Text;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            UpdatedEM.Phone = txtPhone.Text;
        }

        private void txtRelationship_TextChanged(object sender, EventArgs e)
        {
            UpdatedEM.Relationship = txtRelationship.Text;
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            UpdatedEM.Address = txtAddress.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateEmergencyInformation();
            Close();
        }
    }
}
