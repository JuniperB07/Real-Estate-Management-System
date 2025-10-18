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
    public partial class NewEmergency : Form
    {
        private EmergencyInformation NewEmergencyInfo;

        public NewEmergency()
        {
            InitializeComponent();
        }

        private void NewEmergency_Load(object sender, EventArgs e)
        {
            NewEmergencyInfo = new EmergencyInformation();
            NewTenantHelper.AllowProceed = false;

            ClearForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NewEmergencyInfo.EmergencyContact = txtEmergencyContact.Text;
            NewEmergencyInfo.Phone = txtPhone.Text;
            NewEmergencyInfo.Relationship = txtRelationship.Text;
            NewEmergencyInfo.Address = txtAddress.Text;

            if(!NewEmergencyInfo.IsValid())
            {
                Dialogs.MSGBox_OK MBOK = new Dialogs.MSGBox_OK(Dialogs.Dialogs.DEFAULT_MBTEXT, "Please fill all fields.", Dialogs.DialogIcons.Error);
                MBOK.ShowDialog();
                return;
            }

            NewTenantHelper.NewEmergencyInformation = NewEmergencyInfo;
            NewTenantHelper.AllowProceed = true;
            Close();
        }
    }
}
