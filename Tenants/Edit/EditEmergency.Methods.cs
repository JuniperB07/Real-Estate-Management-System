using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunX.NET8.WinForms;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;

namespace Real_Estate_Management_System.Tenants.Edit
{
    partial class EditEmergency
    {
        private void ResetForm()
        {
            Forms.ClearControlText(Forms.ControlType<TextBox>.Extract(this));
        }
        
        private void FillForm()
        {
            txtEmergencyContact.Text = OriginalEM.EmergencyContact;
            txtPhone.Text = OriginalEM.Phone;
            txtRelationship.Text = OriginalEM.Relationship;
            txtAddress.Text = OriginalEM.Address;

            UpdatedEM = THelper.EmergencyInfo.Value;
        }

        private void UpdateEmergencyInformation()
        {
            //---PERFORM VALIDATION---
            //If there is at least 1 missing field:
            //1. Notify user and return to caller.
            if(!UpdatedEM.IsValid())
            {
                MBOK = new Dialogs.MSGBox_OK(this.Text, "Please fill all fields.", Dialogs.DialogIcons.Error);
                MBOK.ShowDialog();
                return;
            }

            //---CHECK IF CHANGES WERE MADE---
            //If no changes were made:
            //1. Return to caller.
            if (UpdatedEM == OriginalEM)
                return;

            //---SAVE CHANGES TO DATABASE---
            //1. Perform parameterized SQL Update command to save changes.
            //2. Notify user.
            new UpdateCommand<tbtenants>()
                .Set(new UpdateMetadata<tbtenants>[]
                {
                    new UpdateMetadata<tbtenants>(tbtenants.EmergencyContact, "@EmergencyContact", DataTypes.Numeric),
                    new UpdateMetadata<tbtenants>(tbtenants.EmergencyPhone, "@Phone", DataTypes.Numeric),
                    new UpdateMetadata<tbtenants>(tbtenants.EmergencyRelationship, "@Relationship", DataTypes.Numeric),
                    new UpdateMetadata<tbtenants>(tbtenants.EmergencyAddress, "@Address", DataTypes.Numeric)
                })
                .StartWhere
                    .Where(tbtenants.TenantID, SQLOperator.Equal, THelper.TenantID.ToString())
                .EndWhere
                .ExecuteNonQuery(Internals.DBC, new ParametersMetadata[]
                {
                    new ParametersMetadata("@EmergencyContact", UpdatedEM.EmergencyContact),
                    new ParametersMetadata("@Phone", UpdatedEM.Phone),
                    new ParametersMetadata("@Relationship", UpdatedEM.Relationship),
                    new ParametersMetadata("@Address", UpdatedEM.Address)
                });

            MBOK = new Dialogs.MSGBox_OK(this.Text, "Changes saved.", Dialogs.DialogIcons.Information);
            MBOK.ShowDialog();
        }
    }
}
