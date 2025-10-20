using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunX.NET8.WinForms;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;
using JunX.NETStandard.Utility;

namespace Real_Estate_Management_System.Tenants
{
    partial class EditTenant
    {
        private void ResetForm()
        {
            Forms.ClearControlText(new TextBox[]
            {
                txtFirstName,
                txtIDNumber,
                txtLastName,
                txtPhone
            });

            dtpDateOfBirth.MaxDate = DateTime.Now;
            dtpDateOfBirth.Value = DateTime.Now.AddDays(-1);

            cmbValidID.Items.Clear();
            pcbIDPhoto.Image = null;
            pcbIDPhoto.ImageLocation = null;

            ofdUpload = new OpenFileDialog();
            ofdUpload.Title = "Select a Valid ID to upload...";
            ofdUpload.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
            ofdUpload.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private void FillCMB_ValidID()
        {
            List<string> rawValidIDList = EnumHelper<ValidIDList>.ToList();

            cmbValidID.Items.Clear();
            foreach (string VID in rawValidIDList)
                cmbValidID.Items.Add(VID.Replace('_', ' '));

            cmbValidID.Items.Remove("Unknown");
        }

        private void FillForm()
        {
            txtFirstName.Text = OriginalTM.FirstName;
            txtLastName.Text = OriginalTM.LastName;
            dtpDateOfBirth.Value = OriginalTM.DateOfBirth;
            txtPhone.Text = OriginalTM.Phone;
            txtIDNumber.Text = OriginalTM.IDNumber;
            cmbValidID.Text = EnumHelper<ValidIDList>.GetReadableValue(OriginalTM.ValidID, '_');
            pcbIDPhoto.ImageLocation = OriginalTM.IDLocation;

            UpdatedTM = THelper.TenantInfo.Value;
        }

        private void UpdateTenantInformation()
        {
            //---IF VALIDATION FAILED---
            //This means that a field is missing.
            //Notify user and return to caller.
            if (!UpdatedTM.IsValid())
            {
                MBOK = new Dialogs.MSGBox_OK(this.Text, "Please fill all fields and make sure all inputs are valid.", Dialogs.DialogIcons.Error);
                MBOK.ShowDialog();
                return;
            }

            //---IF NO CHANGES WERE MADE---
            //Return to caller.
            if (UpdatedTM == OriginalTM)
                return;

            //---IF CHANGES WERE MADE---
            //Perform SQL UPDATE command to update selected tenant's Tenant Information
            new UpdateCommand<tbtenants>()
                .Set(new UpdateMetadata<tbtenants>[]
                {
                    new UpdateMetadata<tbtenants>(tbtenants.FirstName, "@FirstName", DataTypes.Numeric),
                    new UpdateMetadata<tbtenants>(tbtenants.LastName, "@LastName", DataTypes.Numeric),
                    new UpdateMetadata<tbtenants>(tbtenants.FullName, "@FullName", DataTypes.Numeric),
                    new UpdateMetadata<tbtenants>(tbtenants.DateOfBirth, UpdatedTM.DateOfBirth.ToString("yyyy-MM-dd"), DataTypes.NonNumeric),
                    new UpdateMetadata<tbtenants>(tbtenants.Phone, "@Phone", DataTypes.Numeric),
                    new UpdateMetadata<tbtenants>(tbtenants.ValidID, EnumHelper<ValidIDList>.GetReadableValue(UpdatedTM.ValidID, '_'), DataTypes.NonNumeric),
                    new UpdateMetadata<tbtenants>(tbtenants.IDNumber, "@IDNumber", DataTypes.Numeric),
                    new UpdateMetadata<tbtenants>(tbtenants.IDLocation, "@IDLocation", DataTypes.Numeric)
                })
                .StartWhere
                    .Where(tbtenants.TenantID, SQLOperator.Equal, THelper.TenantID.ToString())
                .EndWhere
                .ExecuteNonQuery(Internals.DBC, new ParametersMetadata[]
                {
                    new ParametersMetadata("@FirstName", UpdatedTM.FirstName),
                    new ParametersMetadata("@LastName", UpdatedTM.LastName),
                    new ParametersMetadata("@FullName", UpdatedTM.FullName),
                    new ParametersMetadata("@Phone", UpdatedTM.Phone),
                    new ParametersMetadata("@IDNumber", UpdatedTM.IDNumber),
                    new ParametersMetadata("@IDLocation", UpdatedTM.IDLocation)
                });

            MBOK = new Dialogs.MSGBox_OK(this.Text, "Changes saved.", Dialogs.DialogIcons.Information);
            MBOK.ShowDialog();
        }
    }
}
