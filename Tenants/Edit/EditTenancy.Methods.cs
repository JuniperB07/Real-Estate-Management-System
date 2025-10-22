using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunX.NET8.WinForms;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;
using JunX.NETStandard.Utility;

namespace Real_Estate_Management_System.Tenants.Edit
{
    partial class EditTenancy
    {
        private void ResetForm()
        {
            Forms.ClearComboBox(Forms.ControlType<ComboBox>.Extract(this));
            Forms.SetDateTimePickerMaxDate(Forms.ControlType<DateTimePicker>.Extract(this), DateTime.Now.AddYears(1));
            Forms.SetDateTimePickerValue(Forms.ControlType<DateTimePicker>.Extract(this), DateTime.Now);
            Forms.SetControlVisible(new Control[]
            {
                lblEndDate, dtpEndDate,
                lblRoom, cmbRoom,
                lblInternetPlan, cmbInternetPlan
            }, false);
        }

        private void FillCMB_RentType()
        {
            Forms.FillComboBox(cmbRentType, EnumHelper<RentType>.GetReadableValues('_'));
            cmbRentType.Items.Remove("None");
        }

        private void FillCMB_Building()
        {
            new SelectCommand<tbbuilding>()
                .Select(tbbuilding.BuildingName)
                .From
                .OrderBy(tbbuilding.BuildingName, OrderByModes.ASC)
                .ExecuteReader(Internals.DBC);
            Forms.FillComboBox(cmbBuilding, Internals.DBC.Values);
        }

        private void FillCMB_TenancyStatus()
        {
            Forms.FillComboBox(cmbStatus, EnumHelper<TenancyStatuses>.GetReadableValues('_'));
            cmbStatus.Items.Remove("None");
        }

        private void FillCMB_Rooms()
        {
            cmbRoom.Items.Clear();

            if (!string.IsNullOrWhiteSpace(cmbBuilding.Text))
            {
                int bID = 0;

                new SelectCommand<tbbuilding>()
                    .Select(tbbuilding.BuildingID)
                    .From
                    .StartWhere
                        .Where(tbbuilding.BuildingName, SQLOperator.Equal, "@BuildingName")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@BuildingName", cmbBuilding.Text));
                bID = Convert.ToInt32(Internals.DBC.Values[0]);

                new SelectCommand<tbrooms>()
                    .Select(tbrooms.RoomName)
                    .From
                    .StartWhere
                        .Where(tbrooms.BuildingID, SQLOperator.Equal, bID.ToString())
                    .EndWhere
                    .OrderBy(tbrooms.RoomName, OrderByModes.ASC)
                    .ExecuteReader(Internals.DBC);
                Forms.FillComboBox(cmbRoom, Internals.DBC.Values);
            }
        }

        private void FillCMB_InternetPlans()
        {
            cmbInternetPlan.Items.Clear();

            if (!string.IsNullOrWhiteSpace(cmbBuilding.Text))
            {
                int bID = 0;

                new SelectCommand<tbbuilding>()
                    .Select(tbbuilding.BuildingID)
                    .From
                    .StartWhere
                        .Where(tbbuilding.BuildingName, SQLOperator.Equal, "@BuildingName")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@BuildingName", cmbBuilding.Text));
                bID = Convert.ToInt32(Internals.DBC.Values[0]);

                new SelectCommand<tbinternetplans>()
                    .Select(tbinternetplans.PlanName)
                    .From
                    .StartWhere
                        .Where(tbinternetplans.BuildingID, SQLOperator.Equal, bID.ToString())
                    .EndWhere
                    .OrderBy(tbinternetplans.PlanName, OrderByModes.ASC)
                    .ExecuteReader(Internals.DBC);

                cmbInternetPlan.Items.Add("None");
                Forms.AppendComboBox(cmbInternetPlan, Internals.DBC.Values);
            }
        }

        private void FillForm()
        {
            cmbRentType.Text = EnumHelper<RentType>.GetReadableValue(THelper.TenancyInfo.Value.RentType, '_');
            dtpStartDate.Value = THelper.TenancyInfo.Value.StartDate;

            if (THelper.TenancyInfo.Value.RentType == RentType.Fixed)
            {
                dtpEndDate.Value = THelper.TenancyInfo.Value.EndDate;
                Forms.SetControlVisible(new Control[] { lblEndDate, dtpEndDate }, true);
            }
            else
                Forms.SetControlVisible(new Control[] { lblEndDate, dtpEndDate }, false);

            cmbBuilding.Text = THelper.TenancyInfo.Value.BuildingName;
            cmbRoom.Text = THelper.TenancyInfo.Value.RoomName;
            cmbInternetPlan.Text = THelper.TenancyInfo.Value.InternetPlan;
            cmbStatus.Text = EnumHelper<TenancyStatuses>.GetReadableValue(THelper.TenancyInfo.Value.Status, '_');

            UpdatedTM = THelper.TenancyInfo.Value;
        }

        private void UpdateTenancyInformation()
        {
            //---VALIDATE UPDATED TENANCY INFORMATION---
            //If at least 1 missing/invalid field is detected:
            //1. Notify User
            //2. Return to caller
            if (!UpdatedTM.IsValid())
            {
                MBOK = new Dialogs.MSGBox_OK(this.Text, "Please fill all fields and make sure all inputs are valid.", Dialogs.DialogIcons.Error);
                MBOK.ShowDialog();
                return;
            }

            //---CHECK IF CHANGES WERE MADE---
            //If no changes were made:
            //1. Close form.
            if (UpdatedTM == OriginalTM)
                goto Close;

            //---CHECK FOR TENANCY STATUS CHANGES---
            /*
             * If Tenancy Status changed:
             * 1) Check new tenancy status:
             *      -New Tenancy Status == ACTIVE --> This means that the tenant's tenancy status was reactivated.
             *      1.1) Retrieve selected room's status.
             *      1.2) Check selected room's status:
             *          -Selected Room's Status == VACANT
             *          1.2.1) Set selected room's status to OCCUPIED and Tenant ID = THelper.TenantID
             *          -Selected Room's Status == OCCUPIED
             *          1.2.2) Notify user.
             *          1.2.3) Close form.
             *      -New Tenancy Status != ACTIVE --> This means that the tenant's tenancy status is deactivated.
             *      1.3) Set selected room's status to VACANT and Tenant ID = -1
            */
            if(UpdatedTM.Status != OriginalTM.Status) //Tenancy Status changed
            {
                //1) -New Tenancy Status == ACTIVE
                if(UpdatedTM.Status == TenancyStatuses.Active)
                {
                    //1.1)
                    new SelectCommand<tbrooms>()
                        .Select(tbrooms.Status).From
                        .StartWhere.Where(tbrooms.RoomID, SQLOperator.Equal, UpdatedTM.RoomID.ToString()).EndWhere
                        .ExecuteReader(Internals.DBC);

                    //1.2) -Selected Room's Status == VACANT
                    if (Internals.DBC.Values[0] == Rooms.AvailabilityStatus.Vacant.ToString())
                    {
                        //1.2.1
                        new UpdateCommand<tbrooms>()
                            .Set(new UpdateMetadata<tbrooms>[]
                            {
                                new UpdateMetadata<tbrooms>(tbrooms.Status, Rooms.AvailabilityStatus.Occupied.ToString(), DataTypes.NonNumeric),
                                new UpdateMetadata<tbrooms>(tbrooms.TenantID, THelper.TenantID.ToString(), DataTypes.Numeric)
                            })
                            .StartWhere
                                .Where(tbrooms.RoomID, SQLOperator.Equal, UpdatedTM.RoomID.ToString())
                            .EndWhere
                            .ExecuteNonQuery(Internals.DBC);
                    }
                    else //1.2) -Selected Room's Status == OCCUPIED
                    {
                        //1.2.2)
                        MBOK = new Dialogs.MSGBox_OK(this.Text, "Selected room is currently occupied\nUnable to activate tenant.", Dialogs.DialogIcons.Error);
                        MBOK.ShowDialog();
                        goto Close;
                        //Close(); //1.2.3)
                    }
                }
                else //1) -New Tenancy Status != ACTIVE
                {
                    //1.3)
                    new UpdateCommand<tbrooms>()
                        .Set(new UpdateMetadata<tbrooms>[]
                        {
                            new UpdateMetadata<tbrooms>(tbrooms.Status, Rooms.AvailabilityStatus.Vacant.ToString(), DataTypes.NonNumeric),
                            new UpdateMetadata<tbrooms>(tbrooms.TenantID, "-1", DataTypes.Numeric)
                        })
                        .StartWhere
                            .Where(tbrooms.RoomID, SQLOperator.Equal, UpdatedTM.RoomID.ToString())
                        .EndWhere
                        .ExecuteNonQuery(Internals.DBC);
                }
            }


            //---CHECK FOR CHANGES IN BUILDING & ROOM---
            /*
            If Building and/or Room was changed: --> If building changed then room also changed.
            1) Check Tenancy Status
                -Tenancy Status == ACTIVE
                1.1) Retrieve selected room's status
                1.2) Check if selected room is vacant
                    -Selected Room is VACANT
                    1.2.1) Set Selected Room's Status to OCCUPIED and Tenant ID = THelper.TenantID
                    1.2.2) Set Original Room's Status to VACANT and reset Tenant ID = -1
                    -Selected Room is OCCUPIED
                    1.2.3) Notify User.
                    1.2.4) Return to caller.
                -Tenancy Status != ACTIVE --> Tenancy status is not active or was deactivated.
                1.3) Set Original Room's Status to VACANT and reset Tenant ID = -1
            */
            //If Building and/or Room changed:
            if (UpdatedTM.BuildingID != OriginalTM.BuildingID ||
                (UpdatedTM.BuildingID == OriginalTM.BuildingID && UpdatedTM.RoomID != OriginalTM.RoomID))
            {
                //1) -Tenancy Status == ACTIVE
                if(UpdatedTM.Status == TenancyStatuses.Active)
                {
                    //1.1)
                    new SelectCommand<tbrooms>()
                        .Select(tbrooms.Status).From
                        .StartWhere.Where(tbrooms.RoomID, SQLOperator.Equal, UpdatedTM.RoomID.ToString()).EndWhere
                        .ExecuteReader(Internals.DBC);

                    //1.2) -Selected Room is VACANT
                    if (Internals.DBC.Values[0] == Rooms.AvailabilityStatus.Vacant.ToString())
                    {
                        //1.2.1)
                        new UpdateCommand<tbrooms>()
                            .Set(new UpdateMetadata<tbrooms>[]
                            {
                                new UpdateMetadata<tbrooms>(tbrooms.Status, Rooms.AvailabilityStatus.Occupied.ToString(), DataTypes.NonNumeric),
                                new UpdateMetadata<tbrooms>(tbrooms.TenantID, THelper.TenantID.ToString(), DataTypes.Numeric)
                            })
                            .StartWhere
                                .Where(tbrooms.RoomID, SQLOperator.Equal, UpdatedTM.RoomID.ToString())
                            .EndWhere
                            .ExecuteNonQuery(Internals.DBC);

                        //1.2.2)
                        new UpdateCommand<tbrooms>()
                            .Set(new UpdateMetadata<tbrooms>[]
                            {
                                new UpdateMetadata<tbrooms>(tbrooms.Status, Rooms.AvailabilityStatus.Vacant.ToString(), DataTypes.NonNumeric),
                                new UpdateMetadata<tbrooms>(tbrooms.TenantID, "-1", DataTypes.Numeric)
                            })
                            .StartWhere
                                .Where(tbrooms.RoomID, SQLOperator.Equal, OriginalTM.RoomID.ToString())
                            .EndWhere
                            .ExecuteNonQuery(Internals.DBC);
                    }
                    else //1.2) -Selected Room is OCCUPIED
                    {
                        //1.2.3)
                        MBOK = new Dialogs.MSGBox_OK(this.Text, "The selected room is already occupied.", Dialogs.DialogIcons.Error);
                        MBOK.ShowDialog();
                        return; //1.2.4)
                    }
                }
                else //1) -Tenancy Status != ACTIVE
                {
                    //1.3)
                    new UpdateCommand<tbrooms>()
                        .Set(new UpdateMetadata<tbrooms>[]
                        {
                            new UpdateMetadata<tbrooms>(tbrooms.Status, Rooms.AvailabilityStatus.Vacant.ToString(), DataTypes.NonNumeric),
                            new UpdateMetadata<tbrooms>(tbrooms.TenantID, "-1", DataTypes.Numeric)
                        })
                        .StartWhere
                            .Where(tbrooms.RoomID, SQLOperator.Equal, OriginalTM.RoomID.ToString())
                        .EndWhere
                        .ExecuteNonQuery(Internals.DBC);
                }
            } //End of ---CHECK FOR CHANGES IN BUILDING & ROOM---

            //---UPDATE TENANCY INFORMATION
            new UpdateCommand<tbtenants>()
                .Set(new UpdateMetadata<tbtenants>[]
                {
                    new UpdateMetadata<tbtenants>(tbtenants.RentType, EnumHelper<RentType>.GetReadableValue(UpdatedTM.RentType, '_'), DataTypes.NonNumeric),
                    new UpdateMetadata<tbtenants>(tbtenants.StartDate, UpdatedTM.StartDate.ToString("yyyy-MM-dd"), DataTypes.NonNumeric),
                    new UpdateMetadata<tbtenants>(tbtenants.EndDate, UpdatedTM.EndDate.ToString("yyyy-MM-dd"), DataTypes.NonNumeric),
                    new UpdateMetadata<tbtenants>(tbtenants.RoomID, UpdatedTM.RoomID.ToString(), DataTypes.Numeric),
                    new UpdateMetadata<tbtenants>(tbtenants.ISPlanID, UpdatedTM.PlanID.ToString(), DataTypes.Numeric),
                    new UpdateMetadata<tbtenants>(tbtenants.TenancyStatus, EnumHelper<TenancyStatuses>.GetReadableValue(UpdatedTM.Status, '_'), DataTypes.NonNumeric)
                })
                .StartWhere
                    .Where(tbtenants.TenantID, SQLOperator.Equal, THelper.TenantID.ToString())
                .EndWhere
                .ExecuteNonQuery(Internals.DBC);

            //---NOTIFY THEN CLOSE---
            MBOK = new Dialogs.MSGBox_OK(this.Text, "Changes saved.", Dialogs.DialogIcons.Information);
            MBOK.ShowDialog();
            goto Close;

        Close:
            Close();
        }
    }
}
