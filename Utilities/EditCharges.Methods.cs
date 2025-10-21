using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunX.NET8.WinForms;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;

namespace Real_Estate_Management_System.Utilities
{
    partial class EditCharges
    {
        private void ResetForm()
        {
            Forms.ClearControlText(Forms.ControlType<TextBox>.Extract(this));
        }

        private void FillForm()
        {
            txtWaterCharge.Text = OriginalUCM.WaterCharge.ToString("0,0.00");
            txtElectricityCharge.Text = OriginalUCM.ElectricityCharge.ToString("0,0.00");

            UpdatedUCM = UHelper.UtilityChargeInfo.Value;
        }

        private void UpdateUtilityChargeInformation()
        {
            //---VALIDATE INPUT---
            if(!UpdatedUCM.IsValid())
            {
                MBOK = new Dialogs.MSGBox_OK(this.Text, "Please fill all fields and make sure all inputs are valid.", Dialogs.DialogIcons.Error);
                MBOK.ShowDialog();
                return;
            }

            //---CHECK FOR CHANGES---
            //If no changes detected: Close form
            if (UpdatedUCM == OriginalUCM)
                Close();

            //---PERFORM UPDATE---
            new UpdateCommand<tbutilities_settings>()
                .Set(new UpdateMetadata<tbutilities_settings>[]
                {
                    new UpdateMetadata<tbutilities_settings>(tbutilities_settings.WaterCCPU, UpdatedUCM.WaterCharge.ToString(), DataTypes.Numeric),
                    new UpdateMetadata<tbutilities_settings>(tbutilities_settings.ElectricityCCPU, UpdatedUCM.ElectricityCharge.ToString(), DataTypes.Numeric)
                })
                .StartWhere
                    .Where(tbutilities_settings.BuildingID, SQLOperator.Equal, UHelper.BuildingID.ToString())
                .EndWhere
                .ExecuteNonQuery(Internals.DBC);

            MBOK = new Dialogs.MSGBox_OK(this.Text, "Changes saved.", Dialogs.DialogIcons.Information);
            MBOK.ShowDialog();
            Close();
        }
    }
}
