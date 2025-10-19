using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunX.NET8.WinForms;

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
    }
}
