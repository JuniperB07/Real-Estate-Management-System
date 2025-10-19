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
    public partial class EditPlan : Form
    {
        InternetPlanMetadata OriginalIPM;
        InternetPlanMetadata UpdatedIPM;
        Dialogs.MSGBox_OK MBOK;

        public EditPlan()
        {
            InitializeComponent();
        }

        private void EditPlan_Load(object sender, EventArgs e)
        {
            ResetForm();
            FillAvailabilityStatusCMB();
            FillForm();
        }

        private void txtPlanName_TextChanged(object sender, EventArgs e)
        {
            UpdatedIPM.PlanName = txtPlanName.Text;
        }

        private void txtPlanPrice_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtPlanPrice.Text, out _))
                UpdatedIPM.PlanPrice = Convert.ToDouble(txtPlanPrice.Text);
            else
                UpdatedIPM.PlanPrice = -1;
        }

        private void cmbAvailabilityStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatedIPM.Status = cmbAvailabilityStatus.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Check if Updated IPM is valid
            if (!UpdatedIPM.IsValid())
            {
                MBOK = new Dialogs.MSGBox_OK(this.Text, "Please fill all fields and make sure that all inputs are correct and valid.", Dialogs.DialogIcons.Error);
                MBOK.ShowDialog();
                return;
            }

            //Check if changes were made
            if (UpdatedIPM != OriginalIPM) //Changes were made
            {
                new UpdateCommand<tbinternetplans>()
                    .Set(new UpdateMetadata<tbinternetplans>[]
                    {
                        new UpdateMetadata<tbinternetplans>(tbinternetplans.PlanName, "@PlanName", DataTypes.Numeric),
                        new UpdateMetadata<tbinternetplans>(tbinternetplans.PlanPrice, UpdatedIPM.PlanPrice.ToString(), DataTypes.Numeric),
                        new UpdateMetadata<tbinternetplans>(tbinternetplans.Status, UpdatedIPM.Status, DataTypes.NonNumeric) })
                    .StartWhere
                        .Where(tbinternetplans.PlanID, SQLOperator.Equal, IMHelper.PlanID.ToString())
                    .EndWhere
                    .ExecuteNonQuery(Internals.DBC, new ParametersMetadata("@PlanName", UpdatedIPM.PlanName));

                MBOK = new Dialogs.MSGBox_OK(this.Text, "Changes successfully saved.", Dialogs.DialogIcons.Information);
                MBOK.ShowDialog();
            }
            Close();
        }

        private void EditPlan_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
