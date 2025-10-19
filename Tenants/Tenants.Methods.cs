using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunX.NET8.WinForms;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;
using JunX.NETStandard.Utility;
using Real_Estate_Management_System.Tenants.New;
using REMS.Tenants;

namespace Real_Estate_Management_System.Tenants
{
    partial class Tenants
    {
        private void ResetForm()
        {
            Forms.ClearControlText(new Label[]
            {
                lblTenantName,
                lblDateOfBirth,
                lblIDType,
                lblTenant_ContactInformation,

                lblEmergencyName,
                lblEmergency_ContactInformation,
                lblRelationship,
                lblEmergencyAddress,

                lblRoom,
                lblBuilding,
                lblRentType,
                lblStatus,
                lblStartDate,
                lblEndDate
            });
            Forms.SetControlVisible(new Panel[]
            {
                pnlViewActivity,
                pnlMoreActions,
                pnlTenantInformation,
                pnlEmergencyInformation,
                pnlTenancyInformation }, false);

            lstTenantsList.Items.Clear();
            txtSearchTenant.Text = "";
        }

        private void SaveNewTenant()
        {
            if(NewTenantHelper.NewTenancyInformation.RentType != RentType.Fixed)
            {
                new InsertIntoCommand<tbtenants>()
                .Column(new tbtenants[]
                {
                    tbtenants.LastName,
                    tbtenants.FirstName,
                    tbtenants.FullName,
                    tbtenants.DateOfBirth,
                    tbtenants.Phone,
                    tbtenants.ValidID,
                    tbtenants.IDNumber,
                    tbtenants.IDLocation,

                    tbtenants.EmergencyContact,
                    tbtenants.EmergencyPhone,
                    tbtenants.EmergencyRelationship,
                    tbtenants.EmergencyAddress,

                    tbtenants.RentType,
                    tbtenants.StartDate,
                    tbtenants.RoomID,
                    tbtenants.ISPlanID,
                    tbtenants.TenancyStatus })
                .Values(new ValuesMetadata[]
                {
                    new ValuesMetadata("@LastName", DataTypes.Numeric),
                    new ValuesMetadata("@FirstName", DataTypes.Numeric),
                    new ValuesMetadata("@FullName", DataTypes.Numeric),
                    new ValuesMetadata(NewTenantHelper.NewTenantInformation.DateOfBirth.ToString("yyyy-MM-dd"), DataTypes.NonNumeric),
                    new ValuesMetadata("@Phone", DataTypes.Numeric),
                    new ValuesMetadata(EnumHelper<ValidIDs>.GetReadableValue(NewTenantHelper.NewTenantInformation.ValidID, '_'), DataTypes.NonNumeric),
                    new ValuesMetadata("@IDNumber", DataTypes.Numeric),
                    new ValuesMetadata(NewTenantHelper.NewTenantInformation.IDLocation.Replace("\\", "\\\\"), DataTypes.NonNumeric),

                    new ValuesMetadata("@EmergencyContact", DataTypes.Numeric),
                    new ValuesMetadata("@EmergencyPhone", DataTypes.Numeric),
                    new ValuesMetadata("@EmergencyRelationship", DataTypes.Numeric),
                    new ValuesMetadata("@EmergencyAddress", DataTypes.Numeric),

                    new ValuesMetadata(NewTenantHelper.NewTenancyInformation.RentType.ToString(), DataTypes.NonNumeric),
                    new ValuesMetadata(NewTenantHelper.NewTenancyInformation.StartDate.ToString("yyyy-MM-dd"), DataTypes.NonNumeric),
                    new ValuesMetadata(NewTenantHelper.NewTenancyInformation.RoomID.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(NewTenantHelper.NewTenancyInformation.PlanID.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(NewTenantHelper.NewTenancyInformation.Status.ToString(), DataTypes.NonNumeric) })
                .ExecuteNonQuery(Internals.DBC, new ParametersMetadata[]
                {
                    new ParametersMetadata("@LastName", NewTenantHelper.NewTenantInformation.LastName),
                    new ParametersMetadata("@FirstName", NewTenantHelper.NewTenantInformation.FirstName),
                    new ParametersMetadata("@FullName", NewTenantHelper.NewTenantInformation.FullName),
                    new ParametersMetadata("@Phone", NewTenantHelper.NewTenantInformation.Phone),
                    new ParametersMetadata("@IDNumber", NewTenantHelper.NewTenantInformation.IDNumber),

                    new ParametersMetadata("@EmergencyContact", NewTenantHelper.NewEmergencyInformation.EmergencyContact),
                    new ParametersMetadata("@EmergencyPhone", NewTenantHelper.NewEmergencyInformation.Phone),
                    new ParametersMetadata("@EmergencyRelationship", NewTenantHelper.NewEmergencyInformation.Relationship),
                    new ParametersMetadata("@EmergencyAddress", NewTenantHelper.NewEmergencyInformation.Address), });
            }
            else
            {
                new InsertIntoCommand<tbtenants>()
                .Column(new tbtenants[]
                {
                    tbtenants.LastName,
                    tbtenants.FirstName,
                    tbtenants.FullName,
                    tbtenants.DateOfBirth,
                    tbtenants.Phone,
                    tbtenants.ValidID,
                    tbtenants.IDNumber,
                    tbtenants.IDLocation,

                    tbtenants.EmergencyContact,
                    tbtenants.EmergencyPhone,
                    tbtenants.EmergencyRelationship,
                    tbtenants.EmergencyAddress,

                    tbtenants.RentType,
                    tbtenants.StartDate,
                    tbtenants.EndDate,
                    tbtenants.RoomID,
                    tbtenants.ISPlanID,
                    tbtenants.TenancyStatus })
                .Values(new ValuesMetadata[]
                {
                    new ValuesMetadata("@LastName", DataTypes.Numeric),
                    new ValuesMetadata("@FirstName", DataTypes.Numeric),
                    new ValuesMetadata("@FullName", DataTypes.Numeric),
                    new ValuesMetadata(NewTenantHelper.NewTenantInformation.DateOfBirth.ToString("yyyy-MM-dd"), DataTypes.NonNumeric),
                    new ValuesMetadata("@Phone", DataTypes.Numeric),
                    new ValuesMetadata(EnumHelper<ValidIDs>.GetReadableValue(NewTenantHelper.NewTenantInformation.ValidID, '_'), DataTypes.NonNumeric),
                    new ValuesMetadata("@IDNumber", DataTypes.Numeric),
                    new ValuesMetadata(NewTenantHelper.NewTenantInformation.IDLocation.Replace("\\", "\\\\"), DataTypes.NonNumeric),

                    new ValuesMetadata("@EmergencyContact", DataTypes.Numeric),
                    new ValuesMetadata("@EmergencyPhone", DataTypes.Numeric),
                    new ValuesMetadata("@EmergencyRelationship", DataTypes.Numeric),
                    new ValuesMetadata("@EmergencyAddress", DataTypes.Numeric),

                    new ValuesMetadata(NewTenantHelper.NewTenancyInformation.RentType.ToString(), DataTypes.NonNumeric),
                    new ValuesMetadata(NewTenantHelper.NewTenancyInformation.StartDate.ToString("yyyy-MM-dd"), DataTypes.NonNumeric),
                    new ValuesMetadata(NewTenantHelper.NewTenancyInformation.EndDate.ToString("yyyy-MM-dd"), DataTypes.NonNumeric),
                    new ValuesMetadata(NewTenantHelper.NewTenancyInformation.RoomID.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(NewTenantHelper.NewTenancyInformation.PlanID.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(NewTenantHelper.NewTenancyInformation.Status.ToString(), DataTypes.NonNumeric) })
                .ExecuteNonQuery(Internals.DBC, new ParametersMetadata[]
                {
                    new ParametersMetadata("@LastName", NewTenantHelper.NewTenantInformation.LastName),
                    new ParametersMetadata("@FirstName", NewTenantHelper.NewTenantInformation.FirstName),
                    new ParametersMetadata("@FullName", NewTenantHelper.NewTenantInformation.FullName),
                    new ParametersMetadata("@Phone", NewTenantHelper.NewTenantInformation.Phone),
                    new ParametersMetadata("@IDNumber", NewTenantHelper.NewTenantInformation.IDNumber),

                    new ParametersMetadata("@EmergencyContact", NewTenantHelper.NewEmergencyInformation.EmergencyContact),
                    new ParametersMetadata("@EmergencyPhone", NewTenantHelper.NewEmergencyInformation.Phone),
                    new ParametersMetadata("@EmergencyRelationship", NewTenantHelper.NewEmergencyInformation.Relationship),
                    new ParametersMetadata("@EmergencyAddress", NewTenantHelper.NewEmergencyInformation.Address), });
            }

            MBOK = new Dialogs.MSGBox_OK(this.Text, "New tenant added.", Dialogs.DialogIcons.Information);
            MBOK.ShowDialog();
        }
    }
}
