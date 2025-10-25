using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JunX.NETStandard.SQLBuilder;
using JunX.NETStandard.MySQL;
using REMS.Room;
using System.Configuration.Internal;

namespace Real_Estate_Management_System.Rooms
{
    public partial class NewBuilding : Form
    {
        private BuildingInformation BuildingInfo;
        private Dialogs.MSGBox_OK MBOK;

        public NewBuilding()
        {
            InitializeComponent();
            BuildingInfo = new BuildingInformation("", "");
            MBOK = new Dialogs.MSGBox_OK();
        }

        private void NewBuilding_Load(object sender, EventArgs e)
        {

        }

        private void txtBuildingName_TextChanged(object sender, EventArgs e)
        {
            BuildingInfo.Name = txtBuildingName.Text;
        }

        private void txtBuildingAddress_TextChanged(object sender, EventArgs e)
        {
            BuildingInfo.Address = txtBuildingAddress.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!BuildingInfo.IsValid())
            {
                MBOK = new Dialogs.MSGBox_OK(
                    "Room Management - Add New Building",
                    "Please fill all fields.",
                    Dialogs.DialogIcons.Error);
                MBOK.ShowDialog();
                return;
            }

            if(!string.IsNullOrWhiteSpace(txtRentalRate.Text) || !double.TryParse(txtRentalRate.Text, out _))
            {
                MBOK = new Dialogs.MSGBox_OK(this.Text, "Please enter a valid Rental Rate.", Dialogs.DialogIcons.Error);
                MBOK.ShowDialog();
                return;
            }

            //Check if Building Name already in Database
            new SelectCommand<tbbuilding>()
                .SelectAll.From
                .StartWhere
                    .Where(tbbuilding.BuildingName, SQLOperator.Equal, "@BuildingName")
                .EndWhere
                .ExecuteReader(Internals.DBC, new ParametersMetadata("@BuildingName", BuildingInfo.Name));
            if (Internals.DBC.HasRows)
            {
                Internals.DBC.CloseReader();
                MBOK = new Dialogs.MSGBox_OK(
                    "Room Management - Add New Building",
                    "This building is already on record.", Dialogs.DialogIcons.Error);
                MBOK.ShowDialog();
                return;
            }
            Internals.DBC.CloseReader();

            new InsertIntoCommand<tbbuilding>()
                .Column(new tbbuilding[]
                {
                    tbbuilding.BuildingName,
                    tbbuilding.BuildingAddress,
                    tbbuilding.RentalRate
                })
                .Values(new ValuesMetadata[]
                {
                    new ValuesMetadata(BuildingInfo.Name, DataTypes.NonNumeric),
                    new ValuesMetadata(BuildingInfo.Address, DataTypes.NonNumeric),
                    new ValuesMetadata(txtRentalRate.Text, DataTypes.Numeric)
                })
                .ExecuteNonQuery(Internals.DBC);

            //---GET NEW BUILDING'S BUILDING ID---
            new SelectCommand<tbbuilding>()
                .Select(tbbuilding.BuildingID)
                .From
                .StartWhere
                    .Where(tbbuilding.BuildingName, SQLOperator.Equal, "@BuildingName")
                .EndWhere
                .ExecuteReader(Internals.DBC, new ParametersMetadata("@BuildignName", BuildingInfo.Name));
            int bID = Convert.ToInt32(Internals.DBC.Values[0]);

            //---INSERT NEW BUILDING ID TO UTILITIES SETTINGS TABLE---
            new InsertIntoCommand<tbutilities_settings>()
                .Column(tbutilities_settings.BuildingID)
                .Values(bID.ToString(), DataTypes.Numeric)
                .ExecuteNonQuery(Internals.DBC);

            MBOK = new Dialogs.MSGBox_OK(
                "Room Management - Add New Building",
                "New building added.", Dialogs.DialogIcons.Information);
            MBOK.ShowDialog();
            Close();
        }

        private void NewBuilding_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
