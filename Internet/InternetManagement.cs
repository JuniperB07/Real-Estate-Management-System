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

namespace Real_Estate_Management_System.Internet
{
    public partial class InternetManagement : Form
    {
        public InternetManagement()
        {
            InitializeComponent();
        }

        private void InternetManagement_Load(object sender, EventArgs e)
        {
            ResetForm();
            FillBuildingsCMB();
        }

        private void cmbBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstInternetPlans.Items.Clear();

            if (!string.IsNullOrWhiteSpace(cmbBuilding.Text))
            {
                //Get Building ID
                new SelectCommand<tbbuilding>()
                    .Select(tbbuilding.BuildingID)
                    .From
                    .StartWhere
                        .Where(tbbuilding.BuildingName, SQLOperator.Equal, "@BuildingName")
                    .EndWhere
                    .ExecuteReader(Internals.DBC, new ParametersMetadata("@BuildingName", cmbBuilding.Text));
                IMHelper.BuildingID = Convert.ToInt32(Internals.DBC.Values[0]);

                RefreshInternetPlansList();
            }
        }

        private void lstInternetPlans_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string? planName = lstInternetPlans.SelectedItem?.ToString();

            if (!string.IsNullOrWhiteSpace(planName))
            {
                if (planName != "None")
                {
                    //Get Plan ID
                    new SelectCommand<tbinternetplans>()
                        .Select(tbinternetplans.PlanID)
                        .From
                        .StartWhere
                            .Where(tbinternetplans.PlanName, SQLOperator.Equal, "@PlanName")
                            .And(tbinternetplans.BuildingID, SQLOperator.Equal, IMHelper.BuildingID.ToString())
                        .EndWhere
                        .ExecuteReader(Internals.DBC, new ParametersMetadata("@PlanName", planName));
                    IMHelper.PlanID = Convert.ToInt32(Internals.DBC.Values[0]);
                }
                else
                    IMHelper.PlanID = 1;

                lblPlanName.Text = planName;
                lblPlanPrice.Text = IMHelper.PlanPrice?.ToString("0,0.00");
                lblBuilding.Text = IMHelper.BuildingName;
                lblSubscribers.Text = IMHelper.SubscribersCount.ToString();
                FillSubscribersList();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewPlan NP = new NewPlan();
            NP.ShowDialog();
        }

        private void InternetManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InternetManagement_Load(this, EventArgs.Empty);
        }
    }
}
