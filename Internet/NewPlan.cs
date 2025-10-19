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

namespace Real_Estate_Management_System.Internet
{
    public partial class NewPlan : Form
    {
        InternetPlanMetadata newPlanMetadata;
        Dialogs.MSGBox_OK MBOK = new Dialogs.MSGBox_OK();

        public NewPlan()
        {
            InitializeComponent();
        }

        private void NewPlan_Load(object sender, EventArgs e)
        {
            ResetForm();
            FillAvailabilityStatusCMB();
            FillBuildingCMB();

            newPlanMetadata = new InternetPlanMetadata();
        }

        private void cmbBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbBuilding.Text))
            {
                new SelectCommand<tbbuilding>()
                    .Select(tbbuilding.BuildingID)
                    .From
                    .StartWhere
                        .Where(tbbuilding.BuildingName, SQLOperator.Equal, "@BuildingName")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@BuildingName", cmbBuilding.Text));
                newPlanMetadata.BuildingID = Convert.ToInt32(Internals.DBC.Values[0]);
            }
            else
                newPlanMetadata.BuildingID = 0;
        }

        private void txtPlanName_TextChanged(object sender, EventArgs e)
        {
            newPlanMetadata.PlanName = txtPlanName.Text;
        }

        private void txtPlanPrice_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtPlanPrice.Text, out _))
                newPlanMetadata.PlanPrice = Convert.ToDouble(txtPlanPrice.Text);
            else
                newPlanMetadata.PlanPrice = -1;
        }

        private void cmbAvailabilityStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            newPlanMetadata.Status = cmbAvailabilityStatus.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Check if all fields are valid
            if (!newPlanMetadata.IsValid())
            {
                MBOK = new Dialogs.MSGBox_OK(
                    this.Text,
                    "Please fill all fields and make sure that all field inputs are valid.",
                    Dialogs.DialogIcons.Error);
                MBOK.ShowDialog();
                return;
            }

            //Check if a plan with the same name exists under the selected building.
            new SelectCommand<tbinternetplans>()
                .SelectAll.From
                .StartWhere
                    .Where(tbinternetplans.PlanName, SQLOperator.Equal, "@PlanName")
                    .And(tbinternetplans.BuildingID, SQLOperator.Equal, newPlanMetadata.BuildingID.ToString())
                .EndWhere
                .ExecuteReader(Internals.DBC, new ParametersMetadata("@PlanName", newPlanMetadata.PlanName));
            if (Internals.DBC.HasRows)
            {
                Internals.DBC.CloseReader();
                MBOK = new Dialogs.MSGBox_OK(
                    this.Text,
                    "This plan name already exists under the selected building",
                    Dialogs.DialogIcons.Error);
                MBOK.ShowDialog();
                return;
            }
            Internals.DBC.CloseReader();

            //Save new plan
            new InsertIntoCommand<tbinternetplans>()
                .Column(new tbinternetplans[]
                {
                    tbinternetplans.BuildingID,
                    tbinternetplans.PlanName,
                    tbinternetplans.PlanPrice,
                    tbinternetplans.Status })
                .Values(new ValuesMetadata[]
                {
                    new ValuesMetadata(newPlanMetadata.BuildingID.ToString(), DataTypes.Numeric),
                    new ValuesMetadata("@PlanName", DataTypes.Numeric),
                    new ValuesMetadata(newPlanMetadata.PlanPrice.ToString(), DataTypes.Numeric),
                    new ValuesMetadata(newPlanMetadata.Status, DataTypes.NonNumeric) })
                .ExecuteNonQuery(Internals.DBC, new ParametersMetadata("@PlanName", newPlanMetadata.PlanName));

            MBOK = new Dialogs.MSGBox_OK(this.Text, "New service plan saved.", Dialogs.DialogIcons.Information);
            MBOK.ShowDialog();
            NewPlan_Load(this, EventArgs.Empty);
        }

        private void NewPlan_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
