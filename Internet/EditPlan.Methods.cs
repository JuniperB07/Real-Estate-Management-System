using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunX.NET8.WinForms;
using JunX.NETStandard.Utility;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;

namespace Real_Estate_Management_System.Internet
{
    partial class EditPlan
    {
        private void ResetForm()
        {
            Forms.ClearControlText(new TextBox[] { txtPlanName, txtPlanPrice });
            cmbAvailabilityStatus.Items.Clear();
        }

        private void FillAvailabilityStatusCMB()
        {
            Forms.FillComboBox(cmbAvailabilityStatus, EnumHelper<AvailabilityStatuses>.ToList());
        }

        private void FillForm()
        {
            OriginalIPM = new InternetPlanMetadata();
            UpdatedIPM = new InternetPlanMetadata();

            new SelectCommand<tbinternetplans>()
                .Select(new tbinternetplans[]
                {
                    tbinternetplans.BuildingID,
                    tbinternetplans.PlanName,
                    tbinternetplans.PlanPrice,
                    tbinternetplans.Status })
                .From
                .StartWhere
                    .Where(tbinternetplans.PlanID, SQLOperator.Equal, IMHelper.PlanID.ToString())
                .EndWhere
                .ExecuteReader(Internals.DBC);
            OriginalIPM.BuildingID = Convert.ToInt32(Internals.DBC.Values[0]);
            OriginalIPM.PlanName = Internals.DBC.Values[1];
            OriginalIPM.PlanPrice = Convert.ToDouble(Internals.DBC.Values[2]);
            OriginalIPM.Status = Internals.DBC.Values[3];

            UpdatedIPM = OriginalIPM;

            txtPlanName.Text = OriginalIPM.PlanName;
            txtPlanPrice.Text = OriginalIPM.PlanPrice.ToString();
            cmbAvailabilityStatus.Text = OriginalIPM.Status;
        }
    }
}
