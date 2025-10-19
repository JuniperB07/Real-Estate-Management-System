using JunX.NET8.WinForms;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Management_System.Internet
{
    partial class InternetManagement
    {
        SubscribersList SubsList = new SubscribersList();

        private void ResetForm()
        {
            Forms.ClearControlText(new Label[]
            {
                lblBuilding,
                lblPlanName,
                lblPlanPrice,
                lblSubscribers
            });
            dgvSubscribers.DataSource = null;
            lstInternetPlans.Items.Clear();

            IMHelper.BuildingID = null;
            IMHelper.PlanID = null;
            SubsList.dtbSubscribersList.Rows.Clear();
            dgvSubscribers.DataSource = SubsList.dtbSubscribersList;
        }
        
        private void FillBuildingsCMB()
        {
            new SelectCommand<tbbuilding>()
                .Select(tbbuilding.BuildingName)
                .From
                .OrderBy(tbbuilding.BuildingName, OrderByModes.ASC)
                .ExecuteReader(Internals.DBC);
            Forms.FillComboBox(cmbBuilding, Internals.DBC.Values);
        }

        private void RefreshInternetPlansList()
        {
            lstInternetPlans.Items.Add("None");
            new SelectCommand<tbinternetplans>()
                .Select(tbinternetplans.PlanName)
                .From
                .StartWhere
                    .Where(tbinternetplans.BuildingID, SQLOperator.Equal, IMHelper.BuildingID.ToString())
                .EndWhere
                .OrderBy(tbinternetplans.PlanName, OrderByModes.ASC)
                .ExecuteReader(Internals.DBC);
            Forms.AppendListBox(lstInternetPlans, Internals.DBC.Values);
        }

        private void FillSubscribersList()
        {
            List<SubscribersListMetadata> subsListInfo = new List<SubscribersListMetadata>();
            SubscribersList.dtbSubscribersListRow newRow;

            new SelectCommand<tbtenants, tbrooms>()
                .Select(new tbtenants[]
                {
                    tbtenants.TenantID,
                    tbtenants.FullName })
                .Select(tbrooms.RoomName)
                .From
                .Join(JoinModes.INNER_JOIN, tbtenants.TenantID, tbrooms.TenantID)
                .StartWhere
                    .Where(tbtenants.ISPlanID, SQLOperator.Equal, IMHelper.PlanID.ToString())
                .EndWhere
                .ExecuteReader(Internals.DBC);
            if (Internals.DBC.HasRows)
            {
                while (Internals.DBC.Reader.Read())
                    subsListInfo.Add(new SubscribersListMetadata(
                        Convert.ToInt32(Internals.DBC.Reader[0].ToString()),
                        Internals.DBC.Reader[1].ToString(),
                        Internals.DBC.Reader[2].ToString()));
            }
            Internals.DBC.CloseReader();

            foreach(SubscribersListMetadata SLI in subsListInfo)
            {
                newRow = SubsList.dtbSubscribersList.NewdtbSubscribersListRow();

                newRow.Tenant_Name = SLI.TenantName;
                newRow.Room_Name = SLI.RoomName;

                SubsList.dtbSubscribersList.Rows.Add(newRow);
            }
        }
    }
}
