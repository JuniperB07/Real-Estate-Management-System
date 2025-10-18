using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Management_System.Rooms
{
    internal static class RMHelper
    {
        internal static int RoomID { get; set; }
        internal static int BuildingID { get; set; }
    }

    internal struct RoomInformation
    {
        public string BuildingName { get; set; }
        public string RoomName { get; set; }

        public RoomInformation(string SetBuildingName = "", string SetRoomName = "")
        {
            BuildingName = SetBuildingName;
            RoomName = SetRoomName;
        }

        public bool IsValid()
        {
            return
                !string.IsNullOrWhiteSpace(BuildingName) &&
                !string.IsNullOrWhiteSpace(RoomName);
        }
        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(RoomInformation left, RoomInformation right)
        {
            if (!left.IsValid() || !right.IsValid())
                return false;

            if (left.BuildingName == right.BuildingName &&
                left.RoomName == right.RoomName)
                return true;
            return false;
        }
        public static bool operator !=(RoomInformation left, RoomInformation right)
        {
            if (!left.IsValid() || !right.IsValid())
                return false;

            if (left == right)
                return false;
            return true;
        }
    }
}
