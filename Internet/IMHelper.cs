using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;

namespace Real_Estate_Management_System.Internet
{
    internal static class IMHelper
    {
        internal static int? BuildingID { get; set; }
        internal static string? BuildingName
        {
            get
            {
                if(BuildingID != null && BuildingID > 0)
                {
                    new SelectCommand<tbbuilding>()
                        .Select(tbbuilding.BuildingName)
                        .From
                        .StartWhere
                            .Where(tbbuilding.BuildingID, SQLOperator.Equal, BuildingID.ToString())
                        .EndWhere
                        .ExecuteReader(Internals.DBC);

                    return Internals.DBC.Values[0];
                }
                return null;
            }
        }

        internal static int? PlanID { get; set; }
        internal static double? PlanPrice
        {
            get
            {
                if(PlanID != null && PlanID > 0)
                {
                    new SelectCommand<tbinternetplans>()
                        .Select(tbinternetplans.PlanPrice)
                        .From
                        .StartWhere
                            .Where(tbinternetplans.PlanID, SQLOperator.Equal, PlanID.ToString())
                        .EndWhere
                        .ExecuteReader(Internals.DBC);

                    return Convert.ToDouble(Internals.DBC.Values[0]);
                }
                return null;
            }
        }

        internal static int SubscribersCount
        {
            get
            {
                if(PlanID != null && PlanID > 0)
                {
                    new SelectCommand<tbtenants>()
                        .Select(tbtenants.TenantID)
                        .From
                        .StartWhere
                            .Where(tbtenants.ISPlanID, SQLOperator.Equal, PlanID.ToString())
                        .EndWhere
                        .ExecuteReader(Internals.DBC);
                    return Internals.DBC.Values.Count;
                }
                return 0;
            }
        }
    }
}
