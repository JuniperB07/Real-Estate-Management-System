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
            Forms.FillComboBox(cmbRentType, EnumHelper<RoomTypes>.ToList());
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
        }
    }
}
