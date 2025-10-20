using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;
using JunX.NETStandard.Utility;

namespace Real_Estate_Management_System.Tenants
{
    internal static class THelper
    {
        internal static readonly DateTime DEFAULT_END_DATE = Convert.ToDateTime("2000-01-01");

        internal static int TenantID { get; set; }
        internal static TenantMetadata? TenantInfo
        {
            get
            {
                if (!(TenantID > 0))
                    return null;

                new SelectCommand<tbtenants>()
                    .Select(new tbtenants[]
                    {
                        tbtenants.FirstName,
                        tbtenants.LastName,
                        tbtenants.DateOfBirth,
                        tbtenants.Phone,
                        tbtenants.ValidID,
                        tbtenants.IDNumber,
                        tbtenants.IDLocation
                    })
                    .From
                    .StartWhere
                        .Where(tbtenants.TenantID, SQLOperator.Equal, TenantID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                return new TenantMetadata(
                    Internals.DBC.Values[0],
                    Internals.DBC.Values[1],
                    Convert.ToDateTime(Internals.DBC.Values[2]),
                    Internals.DBC.Values[3],
                    EnumHelper<ValidIDList>.GetEnumValue(Internals.DBC.Values[4], ' ', '_'),
                    Internals.DBC.Values[5],
                    Internals.DBC.Values[6]);
            }
        }
        internal static EmergencyMetadata? EmergencyInfo
        {
            get
            {
                if (!(TenantID > 0))
                    return null;

                new SelectCommand<tbtenants>()
                    .Select(new tbtenants[]
                    {
                        tbtenants.EmergencyContact,
                        tbtenants.EmergencyPhone,
                        tbtenants.EmergencyRelationship,
                        tbtenants.EmergencyAddress
                    })
                    .From
                    .StartWhere
                        .Where(tbtenants.TenantID, SQLOperator.Equal, TenantID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                return new EmergencyMetadata(
                    Internals.DBC.Values[0],
                    Internals.DBC.Values[1],
                    Internals.DBC.Values[2],
                    Internals.DBC.Values[3]);
            }
        }
        internal static TenancyMetadata? TenancyInfo
        {
            get
            {
                if (!(TenantID > 0))
                    return null;

                TenancyMetadata TM;
                int rID = 0, iSPID = 0;

                new SelectCommand<tbtenants>()
                    .Select(new tbtenants[]
                    {
                        tbtenants.RentType,
                        tbtenants.StartDate,
                        tbtenants.EndDate,
                        tbtenants.RoomID,
                        tbtenants.ISPlanID,
                        tbtenants.TenancyStatus
                    })
                    .From
                    .StartWhere
                        .Where(tbtenants.TenantID, SQLOperator.Equal, TenantID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                TM = new TenancyMetadata(
                    SetRentType: EnumHelper<RentType>.GetEnumValue(Internals.DBC.Values[0], ' ', '_'),
                    SetStartDate: Convert.ToDateTime(Internals.DBC.Values[1]),
                    SetEndDate: Convert.ToDateTime(Internals.DBC.Values[2]),
                    SetStatus: EnumHelper<TenancyStatuses>.GetEnumValue(Internals.DBC.Values[5], ' ', '_'));
                rID = Convert.ToInt32(Internals.DBC.Values[3]);
                iSPID = Convert.ToInt32(Internals.DBC.Values[4]);

                //RETRIEVE Building Name & Room Name
                new SelectCommand<tbrooms, tbbuilding>()
                    .Select(tbbuilding.BuildingName)
                    .Select(tbrooms.RoomName)
                    .From
                    .Join(JoinModes.INNER_JOIN, tbrooms.BuildingID, tbbuilding.BuildingID)
                    .StartWhere
                        .Where(tbrooms.RoomID, SQLOperator.Equal, rID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                TM.BuildingName = Internals.DBC.Values[0];
                TM.RoomName = Internals.DBC.Values[1];

                //RETRIEVE Internet Plan Name
                new SelectCommand<tbinternetplans>()
                    .Select(tbinternetplans.PlanName)
                    .From
                    .StartWhere
                        .Where(tbinternetplans.PlanID, SQLOperator.Equal, iSPID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                TM.InternetPlan = Internals.DBC.Values[0];

                return TM;
            }
        }
    }
}
