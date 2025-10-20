using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;
using JunX.NETStandard.Utility;

namespace Real_Estate_Management_System.Tenants
{
    /// <summary>
    /// Represents metadata for a tenancy record, encapsulating rental type, duration, location, internet plan, and status.
    /// Designed for structured tenancy validation, identity resolution, and contextual database mapping within real estate systems.
    /// </summary>
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

                if (!string.IsNullOrWhiteSpace(InternetPlan) && InternetPlan != "None")
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
                return 1;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TenancyMetadata"/> struct with optional tenancy details.
        /// Supports both monthly and fixed rent types, allowing flexible configuration of tenancy duration, location, internet plan, and status.
        /// </summary>
        /// <param name="SetRentType">The type of rent applied to the tenancy (e.g., Monthly, Fixed).</param>
        /// <param name="SetStartDate">The start date of the tenancy period.</param>
        /// <param name="SetEndDate">The end date of the tenancy period (used for fixed rent type).</param>
        /// <param name="SetBuildingName">The name of the building associated with the tenancy.</param>
        /// <param name="SetRoomName">The name of the room assigned to the tenant.</param>
        /// <param name="SetInternetPlan">The internet plan selected for the tenancy.</param>
        /// <param name="SetStatus">The current status of the tenancy.</param>
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

        /// <summary>
        /// Determines whether the current <see cref="TenancyMetadata"/> instance contains a valid configuration based on its <c>RentType</c>.
        /// For <c>Monthly</c> rent, requires a non-default start date and non-empty building, room, and internet plan names.
        /// For <c>Fixed</c> rent, additionally requires a non-default end date.
        /// </summary>
        /// <returns>
        /// <c>true</c> if the tenancy metadata satisfies the required conditions for its rent type; otherwise, <c>false</c>.
        /// </returns>
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

        /// <summary>
        /// Determines whether two <see cref="TenancyMetadata"/> instances are equal based on their validated tenancy configuration.
        /// Compares relevant fields depending on the <c>RentType</c>: for <c>Monthly</c>, compares start date, building, room, internet plan, and status;
        /// for <c>Fixed</c>, additionally compares end date.
        /// </summary>
        /// <param name="Left">The first <see cref="TenancyMetadata"/> instance to compare.</param>
        /// <param name="Right">The second <see cref="TenancyMetadata"/> instance to compare.</param>
        /// <returns>
        /// <c>true</c> if both instances are valid and their tenancy details match according to their rent type; otherwise, <c>false</c>.
        /// </returns>
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
        /// <summary>
        /// Determines whether two <see cref="TenancyMetadata"/> instances are not equal based on their validated tenancy configuration.
        /// Returns <c>true</c> if both instances are valid and differ in any of the compared fields according to their <c>RentType</c>; otherwise, <c>false</c>.
        /// </summary>
        /// <param name="Left">The first <see cref="TenancyMetadata"/> instance to compare.</param>
        /// <param name="Right">The second <see cref="TenancyMetadata"/> instance to compare.</param>
        /// <returns>
        /// <c>true</c> if both instances are valid and not equal; otherwise, <c>false</c>.
        /// </returns>
        public static bool operator !=(TenancyMetadata Left, TenancyMetadata Right)
        {
            if(!Left.IsValid() || !Right.IsValid())
                return false;

            if(Left == Right)
                return false;
            return true;
        }
    }
    /// <summary>
    /// Represents metadata for a tenant, including personal details, contact information, and identification credentials.
    /// Designed for validation, comparison, and structured tenancy registration within real estate systems.
    /// </summary>
    internal struct TenantMetadata
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => LastName + ", " + FirstName;
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public ValidIDList ValidID { get; set; }
        public string IDNumber { get; set; }
        public string IDLocation { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantMetadata"/> struct with optional tenant details.
        /// Automatically assigns default identification values based on the specified <paramref name="SetValidID"/>.
        /// </summary>
        /// <param name="SetFirstName">The tenant's first name.</param>
        /// <param name="SetLastName">The tenant's last name.</param>
        /// <param name="SetDateOfBirth">The tenant's date of birth.</param>
        /// <param name="SetPhone">The tenant's contact number.</param>
        /// <param name="SetValidID">The type of valid ID presented by the tenant.</param>
        /// <param name="SetIDNumber">The identification number, if applicable.</param>
        /// <param name="SetIDLocation">The location where the ID was issued, if applicable.</param>
        public TenantMetadata(
            string SetFirstName = "",
            string SetLastName = "",
            DateTime SetDateOfBirth = default,
            string SetPhone = "",
            ValidIDList SetValidID = ValidIDList.Unknown,
            string SetIDNumber = "",
            string SetIDLocation = "")
        {
            LastName = SetFirstName;
            FirstName = SetLastName;
            DateOfBirth = SetDateOfBirth;
            Phone = SetPhone;
            ValidID = SetValidID;

            switch (SetValidID)
            {
                case ValidIDList.Unknown:
                    IDNumber = "";
                    IDLocation = "";
                    break;
                case ValidIDList.None:
                    IDNumber = "N/A";
                    IDLocation = Internals.DEFAULT_ID_LOCATION;
                    break;
                default:
                    IDNumber = SetIDNumber;
                    IDLocation = SetIDLocation;
                    break;
            }
        }

        /// <summary>
        /// Determines whether the current <see cref="TenantMetadata"/> instance contains a valid tenant configuration.
        /// Requires non-empty first and last names, a non-default date of birth, a valid phone number, and a known ID type.
        /// </summary>
        /// <returns>
        /// <c>true</c> if the tenant metadata satisfies all required conditions; otherwise, <c>false</c>.
        /// </returns>
        public bool IsValid()
        {
            return
                !string.IsNullOrWhiteSpace(FirstName) &&
                !string.IsNullOrWhiteSpace(LastName) &&
                DateOfBirth != default &&
                !string.IsNullOrWhiteSpace(Phone) &&
                ValidID != ValidIDList.Unknown;
        }
        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Determines whether two <see cref="TenantMetadata"/> instances are equal by validating both and comparing all public property values.
        /// Uses <see cref="StructHelper{T}"/> to perform a reflection-based property-level comparison.
        /// </summary>
        /// <param name="Left">The first <see cref="TenantMetadata"/> instance to compare.</param>
        /// <param name="Right">The second <see cref="TenantMetadata"/> instance to compare.</param>
        /// <returns>
        /// <c>true</c> if both instances are valid and all public property values are equal; otherwise, <c>false</c>.
        /// </returns>
        public static bool operator ==(TenantMetadata Left,  TenantMetadata Right)
        {
            if(!Left.IsValid() || !Right.IsValid()) 
                return false;

            return StructHelper<TenantMetadata>.AreEqual(Left, Right);
        }
        /// <summary>
        /// Determines whether two <see cref="TenantMetadata"/> instances are not equal by validating both and comparing all public property values.
        /// Returns <c>true</c> if both instances are valid and differ in any property; otherwise, <c>false</c>.
        /// </summary>
        /// <param name="Left">The first <see cref="TenantMetadata"/> instance to compare.</param>
        /// <param name="Right">The second <see cref="TenantMetadata"/> instance to compare.</param>
        /// <returns>
        /// <c>true</c> if both instances are valid and not equal; otherwise, <c>false</c>.
        /// </returns>
        public static bool operator !=(TenantMetadata Left, TenantMetadata Right)
        {
            if (!Left.IsValid() || !Right.IsValid())
                return false;

            if (Left == Right)
                return false;
            return true;
        }
    }
    /// <summary>
    /// Represents emergency contact information for a tenant, including name, phone number, relationship, and address.
    /// Designed for validation, comparison, and structured inclusion in tenancy records and emergency response workflows.
    /// </summary>
    internal struct EmergencyMetadata
    {
        public string EmergencyContact { get; set; }
        public string Phone { get; set; }
        public string Relationship { get; set; }
        public string Address { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmergencyMetadata"/> struct with optional emergency contact details.
        /// Assigns contact name, phone number, relationship, and address for use in tenant records and emergency response workflows.
        /// </summary>
        /// <param name="SetEmergencyContact">The name of the emergency contact person.</param>
        /// <param name="SetPhone">The contact number of the emergency contact.</param>
        /// <param name="SetRelationship">The relationship of the emergency contact to the tenant.</param>
        /// <param name="SetAddress">The address of the emergency contact.</param>
        public EmergencyMetadata(
            string SetEmergencyContact = "",
            string SetPhone = "",
            string SetRelationship = "",
            string SetAddress = "")
        {
            EmergencyContact = SetEmergencyContact;
            Phone = SetPhone;
            Relationship = SetRelationship;
            Address = SetAddress;
        }

        /// <summary>
        /// Determines whether the current <see cref="EmergencyMetadata"/> instance contains a valid emergency contact configuration.
        /// Requires non-empty values for contact name, phone number, relationship, and address.
        /// </summary>
        /// <returns>
        /// <c>true</c> if all required emergency contact fields are populated; otherwise, <c>false</c>.
        /// </returns>
        public bool IsValid()
        {
            return
                !string.IsNullOrWhiteSpace(EmergencyContact) &&
                !string.IsNullOrWhiteSpace(Phone) &&
                !string.IsNullOrWhiteSpace(Relationship) &&
                !string.IsNullOrWhiteSpace(Address);
        }
        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Determines whether two <see cref="EmergencyMetadata"/> instances are equal by validating both and comparing all public property values.
        /// Uses <see cref="StructHelper{T}"/> to perform a reflection-based property-level comparison.
        /// </summary>
        /// <param name="left">The first <see cref="EmergencyMetadata"/> instance to compare.</param>
        /// <param name="right">The second <see cref="EmergencyMetadata"/> instance to compare.</param>
        /// <returns>
        /// <c>true</c> if both instances are valid and all public property values are equal; otherwise, <c>false</c>.
        /// </returns>
        public static bool operator ==(EmergencyMetadata left, EmergencyMetadata right)
        {
            if (!left.IsValid() || !right.IsValid())
                return false;

            return StructHelper<EmergencyMetadata>.AreEqual(left, right);
        }
        /// <summary>
        /// Determines whether two <see cref="EmergencyMetadata"/> instances are not equal by validating both and comparing all public property values.
        /// Returns <c>true</c> if both instances are valid and differ in any property; otherwise, <c>false</c>.
        /// </summary>
        /// <param name="left">The first <see cref="EmergencyMetadata"/> instance to compare.</param>
        /// <param name="right">The second <see cref="EmergencyMetadata"/> instance to compare.</param>
        /// <returns>
        /// <c>true</c> if both instances are valid and not equal; otherwise, <c>false</c>.
        /// </returns>
        public static bool operator !=(EmergencyMetadata left, EmergencyMetadata right)
        {
            if (!left.IsValid() || !right.IsValid())
                return false;

            return !(left == right);
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
                        .Where(tbtenants.TenantID, SQLOperator.Equal, TenantID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                return Internals.DBC.Values;
            }
        }
        private int TenantID { get; set; }

        public string FullName => TInfo[0];
        public DateTime DateOfBirth => Convert.ToDateTime(TInfo[1]);
        public string Phone => TInfo[2];
        public string ValidID => TInfo[3];
        public string IDLocation => TInfo[4];

        public TenantInfo_UI(int SetTenantID)
        {
            TenantID = SetTenantID;
        }
    } 
    internal struct EmergencyInfo_UI
    {
        private List<string> EInfo
        {
            get
            {
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
                return Internals.DBC.Values;
            }
        }
        private int TenantID { get; set; }

        public string EmergencyContact => EInfo[0];
        public string EmergencyPhone => EInfo[1];
        public string EmergencyRelationship => EInfo[2];
        public string EmergencyAddress => EInfo[3];

        public EmergencyInfo_UI(int SetTenantID)
        {
            TenantID = SetTenantID; 
        }
    }
    internal struct TenancyInfo_UI
    {
        private int TenantID { get; set; }
        private List<string> TInfo
        {
            get
            {
                new SelectCommand<tbtenants>()
                    .Select(new tbtenants[]
                    {
                        tbtenants.RoomID,
                        tbtenants.ISPlanID,
                        tbtenants.RentType,
                        tbtenants.TenancyStatus,
                        tbtenants.StartDate,
                        tbtenants.EndDate
                    })
                    .From
                    .StartWhere
                        .Where(tbtenants.TenantID, SQLOperator.Equal, TenantID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                return Internals.DBC.Values;
            }
        }

        public string RoomName
        {
            get
            {
                new SelectCommand<tbrooms>()
                    .Select(tbrooms.RoomName)
                    .From
                    .StartWhere
                        .Where(tbrooms.RoomID, SQLOperator.Equal, TInfo[0])
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                return Internals.DBC.Values[0];
            }
        }
        public string Building
        {
            get
            {
                int bID = -1;

                new SelectCommand<tbrooms>()
                    .Select(tbrooms.BuildingID)
                    .From
                    .StartWhere
                        .Where(tbrooms.RoomID, SQLOperator.Equal, TInfo[0])
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                bID = Convert.ToInt32(Internals.DBC.Values[0]);

                new SelectCommand<tbbuilding>()
                    .Select(tbbuilding.BuildingName)
                    .From
                    .StartWhere
                        .Where(tbbuilding.BuildingID, SQLOperator.Equal, bID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                return Internals.DBC.Values[0];
            }
        }
        public string PlanName
        {
            get
            {
                if (Convert.ToInt32(TInfo[1]) == -1)
                    return "None";

                new SelectCommand<tbinternetplans>()
                    .Select(tbinternetplans.PlanName)
                    .From
                    .StartWhere
                        .Where(tbinternetplans.PlanID, SQLOperator.Equal, TInfo[1])
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                return Internals.DBC.Values[0];
            }
        }
        public string RentType => TInfo[2];
        public string TenancyStatus => TInfo[3];
        public DateTime StartDate => Convert.ToDateTime(TInfo[4]);
        public DateTime EndDate => Convert.ToDateTime(TInfo[5]);

        public TenancyInfo_UI(int SetTenantID)
        {
            TenantID = SetTenantID;
        }
    }
}
