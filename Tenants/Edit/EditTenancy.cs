using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JunX.NET8.WinForms;
using JunX.NETStandard.Utility;

namespace Real_Estate_Management_System.Tenants.Edit
{
    public partial class EditTenancy : Form
    {
        TenancyMetadata OriginalTM;
        TenancyMetadata UpdatedTM;
        Dialogs.MSGBox_OK MBOK;

        public EditTenancy()
        {
            InitializeComponent();
            MBOK = new Dialogs.MSGBox_OK();
        }

        private void EditTenancy_Load(object sender, EventArgs e)
        {
            Text = EditHelper.FormTitle_EditTenancy;
            OriginalTM = THelper.TenancyInfo.Value;

            ResetForm();
            FillCMB_RentType();
            FillCMB_Building();
            FillCMB_TenancyStatus();
            FillForm();
        }

        private void cmbRentType_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbRentType.Text))
            {
                UpdatedTM.RentType = EnumHelper<RentType>.GetEnumValue(cmbRentType.Text, ' ', '_');

                if (EnumHelper<RentType>.GetEnumValue(cmbRentType.Text, ' ', '_') == RentType.Fixed)
                    Forms.SetControlVisible(new Control[] { lblEndDate, dtpEndDate }, true);
                else
                    Forms.SetControlVisible(new Control[] { lblEndDate, dtpEndDate }, false);
            }
            else
            {
                UpdatedTM.RentType = RentType.None;
                Forms.SetControlVisible(new Control[] { lblEndDate, dtpEndDate }, false);
            }
        }

        private void cmbBuilding_TextChanged(object sender, EventArgs e)
        {
            UpdatedTM.BuildingName = cmbBuilding.Text;

            if (!string.IsNullOrWhiteSpace(cmbBuilding.Text))
            {
                FillCMB_Rooms();
                FillCMB_InternetPlans();
                Forms.SetControlVisible(new Control[]
                {
                    lblRoom, cmbRoom,
                    lblInternetPlan, cmbInternetPlan }, true);
            }
            else
                Forms.SetControlVisible(new Control[]
                {
                    lblRoom, cmbRoom,
                    lblInternetPlan, cmbInternetPlan }, false);

        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            UpdatedTM.StartDate = dtpStartDate.Value;
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbRentType.Text))
            {
                if (EnumHelper<RentType>.GetEnumValue(cmbRentType.Text, ' ', '_') == RentType.Fixed)
                    UpdatedTM.EndDate = dtpEndDate.Value;
                else
                    UpdatedTM.EndDate = THelper.DEFAULT_END_DATE;
            }
        }

        private void cmbRoom_TextChanged(object sender, EventArgs e)
        {
            UpdatedTM.RoomName = cmbRoom.Text;
        }

        private void cmbInternetPlan_TextChanged(object sender, EventArgs e)
        {
            UpdatedTM.InternetPlan = cmbInternetPlan.Text;
        }

        private void cmbStatus_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(cmbStatus.Text))
                UpdatedTM.Status = EnumHelper<TenancyStatuses>.GetEnumValue(cmbStatus.Text, ' ', '_');
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateTenancyInformation();
        }
    }
}
