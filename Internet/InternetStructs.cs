using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Management_System.Internet
{
    internal struct SubscribersListMetadata
    {
        public int TenantID { get; set; }
        public string TenantName { get; set; }
        public string RoomName { get; set; }

        public SubscribersListMetadata(int SetTenantID, string SetTenantName, string SetRoomName)
        {
            TenantID = SetTenantID;
            TenantName = SetTenantName;
            RoomName = SetRoomName;
        }
    }

    internal struct InternetPlanMetadata
    {
        public int BuildingID { get; set; }
        public string PlanName { get; set; }
        public double PlanPrice { get; set; }
        public string Status { get; set; }

        public InternetPlanMetadata(
            int SetBuildingID = 0,
            string SetPlanName = "",
            double SetPlanPrice = -1,
            string SetStatus = "")
        {
            BuildingID = SetBuildingID;
            PlanName = SetPlanName;
            PlanPrice = SetPlanPrice;
            Status = SetStatus;
        }

        public bool IsValid()
        {
            return
                BuildingID > 0 &&
                !string.IsNullOrWhiteSpace(PlanName) &&
                PlanPrice >= 0 &&
                !string.IsNullOrWhiteSpace(Status);
        }
        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(InternetPlanMetadata Left,  InternetPlanMetadata Right)
        {
            if (!Left.IsValid() || !Right.IsValid())
                return false;

            if (Left.BuildingID == Right.BuildingID &&
                Left.PlanName == Right.PlanName &&
                Left.PlanPrice == Right.PlanPrice &&
                Left.Status == Right.Status)
                return true;
            return false;
        }
        public static bool operator !=(InternetPlanMetadata Left, InternetPlanMetadata Right)
        {
            if (!Left.IsValid() || !Right.IsValid())
                return false;

            if (Left == Right)
                return false;
            return true;
        }
    }
}
