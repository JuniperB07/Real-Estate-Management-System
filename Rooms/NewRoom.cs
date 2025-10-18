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
    public partial class NewRoom : Form
    {
        public NewRoom()
        {
            InitializeComponent();
        }

        private void NewRoom_Load(object sender, EventArgs e)
        {
            new SelectCommand<tbbuilding>()
                .Select(tbbuilding.BuildingName)
                .From
                .StartWhere
                    .Where(tbbuilding.BuildingID, SQLOperator.Equal, RMHelper.BuildingID.ToString())
                .EndWhere
                .ExecuteReader(Internals.DBC);
            lblBuildingName.Text = "This new room will be added under Building Name:\n" + Internals.DBC.Values[0];

            txtRoomName.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Dialogs.MSGBox_OK MBOK;

            if (string.IsNullOrWhiteSpace(txtRoomName.Text))
            {
                MBOK = new Dialogs.MSGBox_OK(
                    "Room Management - Add New Room",
                    "Please fill all fields.", Dialogs.DialogIcons.Error);
                MBOK.ShowDialog();
                return;
            }

            //Check if Room already in database.
            new SelectCommand<tbrooms>()
                .SelectAll.From
                .StartWhere
                    .Where(tbrooms.BuildingID, SQLOperator.Equal, RMHelper.BuildingID.ToString())
                    .And(tbrooms.RoomName, SQLOperator.Equal, "@RoomName")
                .EndWhere
                .ExecuteReader(Internals.DBC, new ParametersMetadata("@RoomName", txtRoomName.Text));
            if (Internals.DBC.HasRows)
            {
                Internals.DBC.CloseReader();
                MBOK = new Dialogs.MSGBox_OK(
                    "Room Management - Add New Room",
                    "This room is already in records under this building.", Dialogs.DialogIcons.Error);
                MBOK.ShowDialog();
                return;
            }
            Internals.DBC.CloseReader();

            new InsertIntoCommand<tbrooms>()
                .Column(new tbrooms[]
                {
                    tbrooms.BuildingID,
                    tbrooms.RoomName,
                    tbrooms.Status })
                .Values(new ValuesMetadata[]
                {
                    new ValuesMetadata(RMHelper.BuildingID.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(txtRoomName.Text, DataTypes.NonNumeric),
                    new ValuesMetadata(RoomStatus.Vacant.ToString(), DataTypes.NonNumeric) })
                .ExecuteNonQuery(Internals.DBC);

            MBOK = new Dialogs.MSGBox_OK(
                "Room Management - Add New Room",
                "New room added.", Dialogs.DialogIcons.Information);
            MBOK.ShowDialog();
            Close();
        }
    }
}
