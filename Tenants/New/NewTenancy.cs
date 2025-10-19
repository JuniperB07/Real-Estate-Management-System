using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JunX.NETStandard.Utility;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;
using JunX.NET8.WinForms;

namespace Real_Estate_Management_System.Tenants.New
{
    public partial class NewTenancy : Form
    {
        Dialogs.MSGBox_OK MBOK;
        TenancyMetadata tenancyInfo;

        public NewTenancy()
        {
            InitializeComponent();
        }

        private void NewTenancy_Load(object sender, EventArgs e)
        {
            NewTenantHelper.AllowProceed = false;
            tenancyInfo = new TenancyMetadata();

            ResetForm();
            FillRentTypeCMB();
            FillBuildingCMB();
            FillStatusCMB();
        }

        private void cmbRentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbRentType.Text))
            {
                tenancyInfo.RentType = EnumHelper<RentType>.GetEnumValue(cmbRentType.Text, ' ', '_');

                if (tenancyInfo.RentType == RentType.Fixed)
                    Forms.SetControlVisible(new Control[] { lblEndDate, dtpEndDate }, true);
                else
                    Forms.SetControlVisible(new Control[] { lblEndDate, dtpEndDate }, false);
            }
            else
            {
                tenancyInfo.RentType = RentType.None;
                Forms.SetControlVisible(new Control[] { lblEndDate, dtpEndDate }, false);
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            tenancyInfo.StartDate = dtpStartDate.Value;
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (tenancyInfo.RentType == RentType.Fixed)
                tenancyInfo.EndDate = dtpEndDate.Value;
            else
                tenancyInfo.EndDate = default;
        }

        private void cmbBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbBuilding.Text))
            {
                tenancyInfo.BuildingName = cmbBuilding.Text;

                FillRoomNameCMB();
                FillInternetPlanCMB();

                Forms.SetControlVisible(new Control[]
                {
                    lblRoomName, cmbRoomName,
                    lblInternetPlan, cmbInternetPlan }, true);
            }
            else
            {
                tenancyInfo.BuildingName = "";

                Forms.SetControlVisible(new Control[]
                {
                    lblRoomName, cmbRoomName,
                    lblInternetPlan, cmbInternetPlan }, false);
            }
        }

        private void cmbRoomName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbRoomName.Text))
                tenancyInfo.RoomName = cmbRoomName.Text;
            else
                tenancyInfo.RoomName = "";
        }

        private void cmbInternetPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbInternetPlan.Text))
                tenancyInfo.InternetPlan = cmbInternetPlan.Text;
            else
                tenancyInfo.InternetPlan = "";
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbStatus.Text))
                tenancyInfo.Status = EnumHelper<TenancyStatuses>.GetEnumValue(cmbStatus.Text, ' ', '_');
            else
                tenancyInfo.Status = TenancyStatuses.None;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Validate fields
            if(!tenancyInfo.IsValid())
            {
                MBOK = new Dialogs.MSGBox_OK(this.Text, "Please fill all fields.", Dialogs.DialogIcons.Error);
                MBOK.ShowDialog();
                return;
            }

            //Check if selected room is vacant
            new SelectCommand<tbrooms>()
                .Select(tbrooms.Status)
                .From
                .StartWhere
                    .Where(tbrooms.RoomID, SQLOperator.Equal, tenancyInfo.RoomID.ToString())
                    .And(tbrooms.Status, SQLOperator.Equal, "'" +  Rooms.AvailabilityStatus.Vacant.ToString() + "'")
                .EndWhere
                .ExecuteReader(Internals.DBC);
            if (!Internals.DBC.HasRows)
            {
                Internals.DBC.CloseReader();

                MBOK = new Dialogs.MSGBox_OK(this.Text, "The selected room is already occupied.\nPlease select another room.", Dialogs.DialogIcons.Error);
                MBOK.ShowDialog();
                return;
            }
            Internals.DBC.CloseReader();

            NewTenantHelper.NewTenancyInformation = tenancyInfo;
            NewTenantHelper.AllowProceed = true;
            Close();
        }
    }
}
