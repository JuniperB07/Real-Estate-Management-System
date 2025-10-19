using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;

namespace Real_Estate_Management_System.Tenants
{
    internal struct TenancyMetadata
    {
        public RentType RentType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? BuildingName { get; set; }
        public string? RoomName { get; set; }
        public string? InternetPlan { get; set; }
        public TenancyStatuses Status { get; set; }
        
        public int BuildingID
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(BuildingName))
                {
                    new SelectCommand<tbbuilding>()
                        .Select(tbbuilding.BuildingID)
                        .From
                        .StartWhere
                            .Where(tbbuilding.BuildingName, SQLOperator.Equal, "@BuildingName")
                        .EndWhere
                        .ExecuteReader(Internals.DBC, new ParametersMetadata("@BuildingName", BuildingName));
                    return Convert.ToInt32(Internals.DBC.Values[0]);
                }
                return -1;
            }
        }
        public int RoomID
        {
            get
            {
                if (string.IsNullOrWhiteSpace(BuildingName))
                    return -1;

                if (!string.IsNullOrWhiteSpace(RoomName))
                {
                    new SelectCommand<tbrooms>()
                        .Select(tbrooms.RoomID)
                        .From
                        .StartWhere
                            .Where(tbrooms.RoomName, SQLOperator.Equal, "@RoomName")
                            .And(tbrooms.BuildingID, SQLOperator.Equal, BuildingID.ToString())
                        .EndWhere
                        .ExecuteReader(Internals.DBC, new ParametersMetadata("@RoomName", RoomName));
                    return Convert.ToInt32(Internals.DBC.Values[0]);
                }
                return -1;
            }
        }
        public int PlanID
        {
            get
            {
                if (string.IsNullOrWhiteSpace(BuildingName))
                    return -1;

                if (!string.IsNullOrWhiteSpace(InternetPlan))
                {
                    new SelectCommand<tbinternetplans>()
                        .Select(tbinternetplans.PlanID)
                        .From
                        .StartWhere
                            .Where(tbinternetplans.PlanName, SQLOperator.Equal, "@PlanName")
                            .And(tbinternetplans.BuildingID, SQLOperator.Equal, BuildingID.ToString())
                        .EndWhere
                        .ExecuteReader(Internals.DBC, new ParametersMetadata("@PlanName", InternetPlan));
                    return Convert.ToInt32(Internals.DBC.Values[0]);
                }
                return -1;
            }
        }

        public TenancyMetadata(
            RentType SetRentType = RentType.None,
            DateTime SetStartDate = default,
            DateTime SetEndDate = default,
            string SetBuildingName = "",
            string SetRoomName = "",
            string SetInternetPlan = "",
            TenancyStatuses SetStatus = TenancyStatuses.None)
        {
            RentType = SetRentType;
            StartDate = SetStartDate;
            EndDate = SetEndDate;
            BuildingName = SetBuildingName;
            RoomName = SetRoomName;
            InternetPlan = SetInternetPlan;
            Status = SetStatus;
        }

        public bool IsValid()
        {
            if (RentType == RentType.Monthly)
                return
                    RentType != RentType.None &&
                    StartDate != default &&
                    !string.IsNullOrWhiteSpace(BuildingName) &&
                    !string.IsNullOrWhiteSpace(RoomName) &&
                    !string.IsNullOrWhiteSpace(InternetPlan) &&
                    Status != TenancyStatuses.None;
            else if (RentType == RentType.Fixed)
                return
                    RentType != RentType.None &&
                    StartDate != default &&
                    EndDate != default &&
                    !string.IsNullOrWhiteSpace(BuildingName) &&
                    !string.IsNullOrWhiteSpace(RoomName) &&
                    !string.IsNullOrWhiteSpace(InternetPlan) &&
                    Status != TenancyStatuses.None;
            else
                return false;
        }
        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(TenancyMetadata Left,  TenancyMetadata Right)
        {
            if (!Left.IsValid() || !Right.IsValid())
                return false;

            if (Left.RentType == Right.RentType)
            {
                if (Left.RentType == RentType.Monthly)
                {
                    if (Left.StartDate == Right.StartDate &&
                        Left.BuildingName == Right.BuildingName &&
                        Left.RoomName == Right.RoomName &&
                        Left.InternetPlan == Right.InternetPlan &&
                        Left.Status == Right.Status)
                        return true;
                    return false;
                }
                else if (Left.RentType == RentType.Fixed)
                {
                    if (Left.StartDate == Right.StartDate &&
                        Left.EndDate == Right.EndDate &&
                        Left.BuildingName == Right.BuildingName &&
                        Left.RoomName == Right.RoomName &&
                        Left.InternetPlan == Right.InternetPlan &&
                        Left.Status == Right.Status)
                        return true;
                    return false;
                }
                else
                    return false;
            }
            else
                return false;
        }
        public static bool operator !=(TenancyMetadata Left, TenancyMetadata Right)
        {
            if(!Left.IsValid() || !Right.IsValid())
                return false;

            if(Left == Right)
                return false;
            return true;
        }
    }

    internal struct TenantInfo_UI
    {
        private List<string> TInfo
        {
            get
            {
                new SelectCommand<tbtenants>()
                    .Select(new tbtenants[]
                    {
                        tbtenants.FullName,
                        tbtenants.DateOfBirth,
                        tbtenants.Phone,
                        tbtenants.ValidID,
                        tbtenants.IDLocation
                    })
                    .From
                    .StartWhere
                        .Where(tbtenants.TenantID, SQLOperator.Equal, THelper.TenantID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                return Internals.DBC.Values;
            }
        }

        public string FullName => TInfo[0];
        public DateTime DateOfBirth => Convert.ToDateTime(TInfo[1]);
        public string Phone => TInfo[2];
        public string ValidID => TInfo[3];
        public string IDLocation => TInfo[4];
    }
}
