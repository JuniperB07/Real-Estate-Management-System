using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Management_System.Tenants
{
    internal enum TenancyStatuses
    {
        None = -1,
        Active,
        Inactive,
        Terminated,
        Pending
    }

    internal enum RentType
    {
        None = -1,
        Fixed,
        Monthly
    }

    public enum ValidIDList
    {
        None,
        Philippine_Identification_Card,
        Unified_MultiPurpose_ID,
        Drivers_License,
        Passport,
        Postal_ID,
        Voters_ID,
        SSS_ID,
        GSIS_ID,
        PRC_ID,
        Senior_Citizen_ID,
        PWD_ID,
        NBI_Clearance,
        School_ID,
        Employment_ID,
        Unknown = -1
    }
}
