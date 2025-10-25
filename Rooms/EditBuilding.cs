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

namespace Real_Estate_Management_System.Rooms
{
    public partial class EditBuilding : Form
    {
        Dialogs.MSGBox_OK MBOK;
        double OriginalRR;
        double UpdatedRR;

        public EditBuilding()
        {
            InitializeComponent();
        }

        private void EditBuilding_Load(object sender, EventArgs e)
        {
            MBOK = new Dialogs.MSGBox_OK();
            txtRentalRate.Text = "";

            new SelectCommand<tbbuilding>()
                .Select(tbbuilding.RentalRate)
                .From
                .StartWhere
                    .Where(tbbuilding.BuildingID, SQLOperator.Equal, RMHelper.BuildingID.ToString())
                .EndWhere
                .ExecuteReader(Internals.DBC);
            OriginalRR = Convert.ToDouble(Internals.DBC.Values[0]);
            txtRentalRate.Text = OriginalRR.ToString("0,0.00");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtRentalRate.Text) || !double.TryParse(txtRentalRate.Text, out _))
            {
                MBOK = new Dialogs.MSGBox_OK(this.Text, "Please enter a valid Rental Rate.", Dialogs.DialogIcons.Error);
                MBOK.ShowDialog();
                return;
            }

            new UpdateCommand<tbbuilding>()
                .Set(new UpdateMetadata<tbbuilding>(tbbuilding.RentalRate, txtRentalRate.Text, DataTypes.Numeric))
                .StartWhere
                    .Where(tbbuilding.BuildingID, SQLOperator.Equal, RMHelper.BuildingID.ToString())
                .EndWhere
                .ExecuteNonQuery(Internals.DBC);

            MBOK = new Dialogs.MSGBox_OK(this.Text, "Rental rate updated.", Dialogs.DialogIcons.Information);
            MBOK.ShowDialog();
            Close();
        }
    }
}
