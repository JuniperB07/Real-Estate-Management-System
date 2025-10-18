using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunX.NET8.WinForms;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;

namespace Real_Estate_Management_System.Rooms
{
    public partial class RoomManagement
    {
        private void ResetForm()
        {
            Forms.ClearControlText(new TextBox[]
            {
                txtBuildingAddress,
                txtBuildingName,
                txtOccupancyStatus,
                txtOccupyingTenant,
                txtRoomName
            });
            lstBuilding.Items.Clear();
            lstRooms.Items.Clear();
            RMHelper.RoomID = -1;
            RMHelper.BuildingID = -1;
        }

        private void RefreshBuildingsList()
        {
            new SelectCommand<tbbuilding>()
                .Select(tbbuilding.BuildingName).From
                .OrderBy(tbbuilding.BuildingName, OrderByModes.ASC)
                .ExecuteReader(Internals.DBC);
            Forms.FillListBox(lstBuilding, Internals.DBC.Values);
        }

        private void RefreshRoomsList()
        {
            new SelectCommand<tbrooms>()
                .Select(tbrooms.RoomName).From
                .StartWhere
                    .Where(tbrooms.BuildingID, SQLOperator.Equal, RMHelper.BuildingID.ToString())
                .EndWhere
                .OrderBy(tbrooms.RoomName, OrderByModes.ASC)
                .ExecuteReader(Internals.DBC);
            Forms.FillListBox(lstRooms, Internals.DBC.Values);
        }

        private void ResetRoomsPanel()
        {
            Forms.ClearControlText(new TextBox[]
            {
                txtRoomName,
                txtOccupyingTenant,
                txtOccupancyStatus
            });
            lstRooms.Items.Clear();
            RMHelper.RoomID = -1;
        }
    }
}
