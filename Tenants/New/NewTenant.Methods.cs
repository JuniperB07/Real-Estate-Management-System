using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunX.NET8.WinForms;
using JunX.NETStandard.Utility;
using Real_Estate_Management_System.Configs.Tenants;

namespace Real_Estate_Management_System.Tenants.New
{
    public partial class NewTenant 
    {
        private void ClearForm()
        {
            Forms.ClearControlText(new TextBox[]
            {
                txtFirstName,
                txtIDNumber,
                txtLastName,
                txtPhone 
            });
            dtpDateOfBirth.Value = DateTime.Now.AddDays(-1);
            cmbValidID.SelectedIndex = 0;
            pcbIDPhoto.ImageLocation = NewTenantInfo.IDLocation;
        }

        private void ResetForm()
        {
            dtpDateOfBirth.MinDate = Convert.ToDateTime("1900-01-01");
            dtpDateOfBirth.MaxDate = DateTime.Now;

            cmbValidID.Items.Clear();
            foreach (string VID in EnumHelper<REMS.Tenants.ValidIDs>.ToList())
            {
                if(VID != REMS.Tenants.ValidIDs.Unknown.ToString())
                    cmbValidID.Items.Add(VID.Replace("_", " "));
            }

            NewTenantInfo.IDLocation = DefaultValues.Default_IDLocation;

            ofdUploadID = new OpenFileDialog();
            ofdUploadID.Title = "Select a Valid ID to upload...";
            ofdUploadID.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
            ofdUploadID.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }
    }
}
