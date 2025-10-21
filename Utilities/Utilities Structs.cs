using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunX.NETStandard.Utility;

namespace Real_Estate_Management_System.Utilities
{
    internal struct UtilityChargeMetadata
    {
        public double WaterCharge { get; set; }
        public double ElectricityCharge { get; set; }

        public UtilityChargeMetadata(double SetWaterCharge, double SetElectricityCharge)
        {
            WaterCharge = SetWaterCharge;
            ElectricityCharge = SetElectricityCharge;
        }

        public bool IsValid()
        {
            return
                !(WaterCharge < 0) &&
                !(ElectricityCharge < 0);
        }
        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(UtilityChargeMetadata Left,  UtilityChargeMetadata Right)
        {
            if (!Left.IsValid() || !Right.IsValid())
                return false;

            return StructHelper<UtilityChargeMetadata>.AreEqual(Left, Right);
        }
        public static bool operator !=(UtilityChargeMetadata Left, UtilityChargeMetadata Right)
        {
            if (!Left.IsValid() || !Right.IsValid())
                return false;

            return !(Left == Right);
        }
    }
}
