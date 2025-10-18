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
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;

namespace Real_Estate_Management_System.Rooms
{
    public partial class EditRoom : Form
    {
        private RoomInformation OriginalRI;
        private RoomInformation UpdatedRI;
        private Dialogs.MSGBox_OK MBOK;

        public EditRoom()
        {
            InitializeComponent();
        }

        #region Methods
        private void ResetForm()
        {
            cmbBuilding.Items.Clear();
            txtRoomName.Text = "";
        }

        private void FillBuildingList()
        {
            new SelectCommand<tbbuilding>()
                .Select(tbbuilding.BuildingName)
                .From
                .OrderBy(tbbuilding.BuildingName, OrderByModes.ASC)
                .ExecuteReader(Internals.DBC);
            Forms.FillComboBox(cmbBuilding, Internals.DBC.Values);
        }

        private void SetFormValues()
        {
            new SelectCommand<tbbuilding>()
                .Select(tbbuilding.BuildingName)
                .From
                .StartWhere
                    .Where(tbbuilding.BuildingID, SQLOperator.Equal, RMHelper.BuildingID.ToString())
                .EndWhere
                .ExecuteReader(Internals.DBC);
            cmbBuilding.Text = Internals.DBC.Values[0];

            new SelectCommand<tbrooms>()
                .Select(tbrooms.RoomName)
                .From
                .StartWhere
                    .Where(tbrooms.RoomID, SQLOperator.Equal, RMHelper.RoomID.ToString())
                .EndWhere
                .ExecuteReader(Internals.DBC);
            txtRoomName.Text = Internals.DBC.Values[0];

            OriginalRI = new RoomInformation(cmbBuilding.Text, txtRoomName.Text);
            UpdatedRI = new RoomInformation(cmbBuilding.Text, txtRoomName.Text);
        }
        #endregion

        private void EditRoom_Load(object sender, EventArgs e)
        {
            ResetForm();
            FillBuildingList();
            SetFormValues();
        }

        private void cmbBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatedRI.BuildingName = cmbBuilding.Text;
        }

        private void txtRoomName_TextChanged(object sender, EventArgs e)
        {
            UpdatedRI.RoomName = txtRoomName.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!UpdatedRI.IsValid())
            {
                MBOK = new Dialogs.MSGBox_OK(
                    "Room Management - Edit Room Information",
                    "Please fill all fields.", Dialogs.DialogIcons.Error);
                MBOK.ShowDialog();
                return;
            }

            if(UpdatedRI != OriginalRI)
            {
                //Room is assigned to a new building.
                if(UpdatedRI.BuildingName != OriginalRI.BuildingName && UpdatedRI.RoomName == OriginalRI.RoomName)
                {
                    //Get new building's Building ID
                    int buildingID = -1;
                    new SelectCommand<tbbuilding>()
                        .Select(tbbuilding.BuildingID)
                        .From
                        .StartWhere
                            .Where(tbbuilding.BuildingName, SQLOperator.Equal, "@BuildingName")
                        .EndWhere
                        .ExecuteReader(Internals.DBC, new ParametersMetadata("@BuildingName", UpdatedRI.BuildingName));
                    buildingID = Convert.ToInt32(Internals.DBC.Values[0]);

                    //Check if a room with the same name exists under the new building.
                    new SelectCommand<tbrooms>()
                        .SelectAll.From
                        .StartWhere
                            .Where(tbrooms.BuildingID, SQLOperator.Equal, buildingID.ToString())
                            .And(tbrooms.RoomName, SQLOperator.Equal, "@RoomName")
                        .EndWhere
                        .ExecuteReader(Internals.DBC, new ParametersMetadata("@RoomName", UpdatedRI.RoomName));
                    if (Internals.DBC.HasRows)
                    {
                        Internals.DBC.CloseReader();
                        MBOK = new Dialogs.MSGBox_OK(
                            "Room Management - Edit Room Information",
                            "The selected building already have this room.", Dialogs.DialogIcons.Error);
                        MBOK.ShowDialog();
                        return;
                    }
                    Internals.DBC.CloseReader();

                    //Update Record
                    new UpdateCommand<tbrooms>()
                        .Set(new UpdateMetadata<tbrooms>(
                            tbrooms.BuildingID,
                            buildingID.ToString(),
                            DataTypes.Numeric))
                        .StartWhere
                            .Where(tbrooms.RoomName, SQLOperator.Equal, "@RoomName")
                        .EndWhere
                        .ExecuteNonQuery(Internals.DBC, new ParametersMetadata("@RoomName", OriginalRI.RoomName));

                    MBOK = new Dialogs.MSGBox_OK(
                        "Room Management - Edit Room Information",
                        "Room information successfully updated.", Dialogs.DialogIcons.Information);
                    MBOK.ShowDialog();
                }
                //Room Name is changed
                else if(UpdatedRI.RoomName != OriginalRI.RoomName && UpdatedRI.BuildingName == OriginalRI.BuildingName)
                {
                    //Get Room ID
                    int roomID = -1;
                    new SelectCommand<tbrooms>()
                        .Select(tbrooms.RoomID)
                        .From
                        .StartWhere
                            .Where(tbrooms.RoomName, SQLOperator.Equal, "@RoomName")
                        .EndWhere
                        .ExecuteReader(Internals.DBC, new ParametersMetadata("@RoomName", OriginalRI.RoomName));
                    roomID = Convert.ToInt32(Internals.DBC.Values[0]);

                    //Get Building ID
                    int buildingID = -1;
                    new SelectCommand<tbrooms>()
                        .Select(tbrooms.BuildingID)
                        .From
                        .StartWhere
                            .Where(tbrooms.RoomName, SQLOperator.Equal, "@RoomName")
                        .EndWhere
                        .ExecuteReader(Internals.DBC, new ParametersMetadata("@RoomName", OriginalRI.RoomName));
                    buildingID = Convert.ToInt32(Internals.DBC.Values[0]);

                    //Check if a room with the same name exists in under the building ID.
                    new SelectCommand<tbrooms>()
                        .SelectAll.From
                        .StartWhere
                            .Where(tbrooms.BuildingID, SQLOperator.Equal, buildingID.ToString())
                            .And(tbrooms.RoomName, SQLOperator.Equal, "@RoomName")
                        .EndWhere
                        .ExecuteReader(Internals.DBC, new ParametersMetadata("@RoomName", UpdatedRI.RoomName));
                    if (Internals.DBC.HasRows)
                    {
                        Internals.DBC.CloseReader();
                        MBOK = new Dialogs.MSGBox_OK(
                            "Room Management - Edit Room Information",
                            "This room already exists in the selected building.", Dialogs.DialogIcons.Error);
                        MBOK.ShowDialog();
                        return;
                    }
                    Internals.DBC.CloseReader();

                    //Update Record
                    new UpdateCommand<tbrooms>()
                        .Set(new UpdateMetadata<tbrooms>(
                            tbrooms.RoomName,
                            "@RoomName", DataTypes.Numeric))
                        .StartWhere
                            .Where(tbrooms.RoomID, SQLOperator.Equal, roomID.ToString())
                        .EndWhere
                        .ExecuteNonQuery(Internals.DBC, new ParametersMetadata("@RoomName", UpdatedRI.RoomName));

                    MBOK = new Dialogs.MSGBox_OK(
                        "Room Management - Edit Room Information",
                        "Room information successfully updated.", Dialogs.DialogIcons.Information);
                    MBOK.ShowDialog();
                }
                //Both Building and Room Name is changed
                else
                {
                    //Get Room ID
                    int roomID = -1;
                    new SelectCommand<tbrooms>()
                        .Select(tbrooms.RoomID).From
                        .StartWhere
                            .Where(tbrooms.RoomName, SQLOperator.Equal, "@RoomName")
                        .EndWhere
                        .ExecuteReader(Internals.DBC, new ParametersMetadata("@RoomName", OriginalRI.RoomName));
                    roomID = Convert.ToInt32(Internals.DBC.Values[0]);

                    //Get Building ID where the room is reassigned.
                    int updatedBuildingID = -1;
                    new SelectCommand<tbbuilding>()
                        .Select(tbbuilding.BuildingID).From
                        .StartWhere
                            .Where(tbbuilding.BuildingName, SQLOperator.Equal, "@BuildingName")
                        .EndWhere
                        .ExecuteReader(Internals.DBC, new ParametersMetadata("@BuildingName", UpdatedRI.BuildingName));
                    updatedBuildingID = Convert.ToInt32(Internals.DBC.Values[0]);

                    //Check if a room with the same name exists in the new building reassigned.
                    new SelectCommand<tbrooms>()
                        .SelectAll.From
                        .StartWhere
                            .Where(tbrooms.BuildingID, SQLOperator.Equal, updatedBuildingID.ToString())
                            .And(tbrooms.RoomName, SQLOperator.Equal, "@RoomName")
                        .EndWhere
                        .ExecuteReader(Internals.DBC, new ParametersMetadata("@RoomName", UpdatedRI.RoomName));
                    if (Internals.DBC.HasRows)
                    {
                        Internals.DBC.CloseReader();
                        MBOK = new Dialogs.MSGBox_OK(
                            "Room Management - Edit Room Information",
                            "This room already exists in the selected building.", Dialogs.DialogIcons.Error);
                        MBOK.ShowDialog();
                        return;
                    }
                    Internals.DBC.CloseReader();

                    //Update records
                    new UpdateCommand<tbrooms>()
                        .Set(new UpdateMetadata<tbrooms>[]
                        {
                            new UpdateMetadata<tbrooms>(tbrooms.BuildingID, updatedBuildingID.ToString(), DataTypes.Numeric),
                            new UpdateMetadata<tbrooms>(tbrooms.RoomName, "@RoomName", DataTypes.Numeric) })
                        .StartWhere
                            .Where(tbrooms.RoomID, SQLOperator.Equal, roomID.ToString())
                        .EndWhere
                        .ExecuteNonQuery(Internals.DBC, new ParametersMetadata("@RoomName", UpdatedRI.RoomName));

                    MBOK = new Dialogs.MSGBox_OK(
                        "Room Management - Edit Room Information",
                        "Room information successfully updated.", Dialogs.DialogIcons.Information);
                    MBOK.ShowDialog();
                }
            }
            Close();
        }
    }
}
