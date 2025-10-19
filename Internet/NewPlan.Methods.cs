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
    partial class NewPlan
    {
        private void ResetForm()
        {
            Forms.ClearControlText(new TextBox[] { txtPlanName, txtPlanPrice });
            cmbAvailabilityStatus.Items.Clear();
            cmbBuilding.Items.Clear();
        }

        private void FillAvailabilityStatusCMB()
        {
            Forms.FillComboBox(cmbAvailabilityStatus, EnumHelper<AvailabilityStatuses>.ToList());
        }

        private void FillBuildingCMB()
        {
            new SelectCommand<tbbuilding>()
                 .Select(tbbuilding.BuildingName)
                 .From
                 .OrderBy(tbbuilding.BuildingName, OrderByModes.ASC)
                 .ExecuteReader(Internals.DBC);
            Forms.FillComboBox(cmbBuilding, Internals.DBC.Values);
        }
    }
}
