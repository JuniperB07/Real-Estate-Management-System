using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunX.NET8.WinForms;
using JunX.NETStandard.Utility;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;

namespace Real_Estate_Management_System.Tenants.New
{
    partial class NewTenancy
    {
        private void ResetForm()
        {
            Forms.ClearComboBox(new ComboBox[]
            {
                cmbBuilding,
                cmbInternetPlan,
                cmbRentType,
                cmbRoomName,
                cmbStatus });

            dtpStartDate.MaxDate = DateTime.Now.AddYears(1);
            dtpEndDate.MaxDate = DateTime.Now.AddYears(1);

            Forms.SetDateTimePickerValue(new DateTimePicker[]
            {
                dtpStartDate,
                dtpEndDate, }, DateTime.Now);
            Forms.SetControlVisible(new Control[]
            {
                lblEndDate,
                lblRoomName,
                lblInternetPlan,
                dtpEndDate,
                cmbRoomName,
                cmbInternetPlan }, false);

            dtpStartDate.Value = DateTime.Now.Date;
            dtpEndDate.Value = DateTime.Now.Date;
        }

        private void FillRentTypeCMB()
        {
            Forms.FillComboBox(cmbRentType, EnumHelper<RentType>.ToList());
            cmbRentType.Items.Remove("None");
        }

        private void FillBuildingCMB()
        {
            new SelectCommand<tbbuilding>()
                .Select(tbbuilding.BuildingName)
                .From
                .OrderBy(tbbuilding.BuildingName, OrderByModes.ASC)
                .ExecuteReader(Internals.DBC);
            Forms.FillComboBox(cmbBuilding, Internals.DBC.Values);
        }

        private void FillStatusCMB()
        {
            Forms.FillComboBox(cmbStatus, EnumHelper<TenancyStatuses>.ToList());
            cmbStatus.Items.Remove("None");
        }

        private void FillRoomNameCMB()
        {
            cmbRoomName.Items.Clear();

            if(tenancyInfo.BuildingID != -1)
            {
                new SelectCommand<tbrooms>()
                    .Select(tbrooms.RoomName)
                    .From
                    .StartWhere
                        .Where(tbrooms.BuildingID, SQLOperator.Equal, tenancyInfo.BuildingID.ToString())
                    .EndWhere
                    .OrderBy(tbrooms.RoomName, OrderByModes.ASC)
                    .ExecuteReader(Internals.DBC);
                Forms.FillComboBox(cmbRoomName, Internals.DBC.Values);
            }
        }

        private void FillInternetPlanCMB()
        {
            cmbInternetPlan.Items.Clear();

            if(tenancyInfo.BuildingID != -1)
            {
                cmbInternetPlan.Items.Add("None");

                new SelectCommand<tbinternetplans>()
                    .Select(tbinternetplans.PlanName)
                    .From
                    .StartWhere
                        .Where(tbinternetplans.BuildingID, SQLOperator.Equal, tenancyInfo.BuildingID.ToString())
                    .EndWhere
                    .OrderBy(tbinternetplans.PlanName, OrderByModes.ASC)
                    .ExecuteReader(Internals.DBC);
                Forms.AppendComboBox(cmbInternetPlan, Internals.DBC.Values);
            }
        }
    }
}
