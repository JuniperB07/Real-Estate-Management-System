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
        public RoomTypes RoomType { get; set; }
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
            RoomTypes SetRoomType = RoomTypes.None,
            DateTime SetStartDate = default,
            DateTime SetEndDate = default,
            string SetBuildingName = "",
            string SetRoomName = "",
            string SetInternetPlan = "",
            TenancyStatuses SetStatus = TenancyStatuses.None)
        {
            RoomType = SetRoomType;
            StartDate = SetStartDate;
            EndDate = SetEndDate;
            BuildingName = SetBuildingName;
            RoomName = SetRoomName;
            InternetPlan = SetInternetPlan;
            Status = SetStatus;
        }

        public bool IsValid()
        {
            if (RoomType == RoomTypes.Monthly)
                return
                    RoomType != RoomTypes.None &&
                    StartDate != default &&
                    !string.IsNullOrWhiteSpace(BuildingName) &&
                    !string.IsNullOrWhiteSpace(RoomName) &&
                    !string.IsNullOrWhiteSpace(InternetPlan) &&
                    Status != TenancyStatuses.None;
            else if (RoomType == RoomTypes.Fixed)
                return
                    RoomType != RoomTypes.None &&
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

            if (Left.RoomType == Right.RoomType)
            {
                if (Left.RoomType == RoomTypes.Monthly)
                {
                    if (Left.StartDate == Right.StartDate &&
                        Left.BuildingName == Right.BuildingName &&
                        Left.RoomName == Right.RoomName &&
                        Left.InternetPlan == Right.InternetPlan &&
                        Left.Status == Right.Status)
                        return true;
                    return false;
                }
                else if (Left.RoomType == RoomTypes.Fixed)
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
}
