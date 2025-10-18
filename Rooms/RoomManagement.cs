using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;
using REMS.Room;

namespace Real_Estate_Management_System.Rooms
{
    public partial class RoomManagement : Form
    {
        private BuildingInformation BuildingInfo;

        public RoomManagement()
        {
            InitializeComponent();
            BuildingInfo = new BuildingInformation("", "");
        }

        private void RoomManagement_Load(object sender, EventArgs e)
        {
            ResetForm();
            RefreshBuildingsList();
        }

        private void btnBuilding_New_Click(object sender, EventArgs e)
        {
            NewBuilding NB = new NewBuilding();
            NB.ShowDialog();
            RefreshBuildingsList();
        }

        private void lstBuilding_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string buildingName = lstBuilding.SelectedItem.ToString();
            txtBuildingName.Text = buildingName;

            new SelectCommand<tbbuilding>()
                .Select(new tbbuilding[] { tbbuilding.BuildingID, tbbuilding.BuildingAddress })
                .From
                .StartWhere
                    .Where(tbbuilding.BuildingName, SQLOperator.Equal, "@BuildingName")
                .EndWhere
                .ExecuteReader(Internals.DBC, new ParametersMetadata("@BuildingName", buildingName));
            RMHelper.BuildingID = Convert.ToInt32(Internals.DBC.Values[0]);
            txtBuildingAddress.Text = Internals.DBC.Values[1];

            ResetRoomsPanel();
            RefreshRoomsList();
        }

        private void lstRooms_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int tenantID = -1;
            string roomName = lstRooms.SelectedItem.ToString();
            txtRoomName.Text = roomName;

            new SelectCommand<tbrooms>()
                .Select(new tbrooms[] { tbrooms.RoomID, tbrooms.TenantID, tbrooms.Status })
                .From
                .StartWhere
                    .Where(tbrooms.RoomName, SQLOperator.Equal, "@RoomName")
                    .And(tbrooms.BuildingID, SQLOperator.Equal, RMHelper.BuildingID.ToString())
                .EndWhere
                .ExecuteReader(Internals.DBC, new ParametersMetadata("@RoomName", roomName));
            RMHelper.RoomID = Convert.ToInt32(Internals.DBC.Values[0]);
            tenantID = Convert.ToInt32(Internals.DBC.Values[1]);
            txtOccupancyStatus.Text = Internals.DBC.Values[2];

            if (tenantID > 0)
            {
                new SelectCommand<tbtenants>()
                    .Select(tbtenants.FullName)
                    .From
                    .StartWhere
                        .Where(tbtenants.TenantID, SQLOperator.Equal, tenantID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                txtOccupyingTenant.Text = Internals.DBC.Values[0];
            }
            else
                txtOccupyingTenant.Text = "None";
        }

        private void RoomManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
