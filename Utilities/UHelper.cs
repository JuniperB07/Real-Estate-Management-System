using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;

namespace Real_Estate_Management_System.Utilities
{
    internal static class UHelper
    {
        internal static int BuildingID { get; set; }

        internal static UtilityChargeMetadata? UtilityChargeInfo
        {
            get
            {
                if (!(BuildingID > 0))
                    return null;

                new SelectCommand<tbutilities_settings>()
                    .Select(new tbutilities_settings[]
                    {
                        tbutilities_settings.WaterCCPU,
                        tbutilities_settings.ElectricityCCPU
                    })
                    .From
                    .StartWhere
                        .Where(tbutilities_settings.BuildingID, SQLOperator.Equal, BuildingID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);

                return new UtilityChargeMetadata(
                    Convert.ToDouble(Internals.DBC.Values[0]),
                    Convert.ToDouble(Internals.DBC.Values[1]));
            }
        }
    }
}
