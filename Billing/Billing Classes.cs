using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;

namespace Real_Estate_Management_System.Billing
{
    internal class WaterInvoice
    {
        private int TenantID { get; set; }

        private int BuildingID
        {
            get
            {
                if (!(TenantID > 0))
                    return -1;

                int rID = 0;

                new SelectCommand<tbtenants>()
                    .Select(tbtenants.RoomID)
                    .From
                    .StartWhere
                        .Where(tbtenants.TenantID, SQLOperator.Equal, TenantID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                rID = Convert.ToInt32(Internals.DBC.Values[0]);

                new SelectCommand<tbrooms>()
                    .Select(tbrooms.BuildingID)
                    .From
                    .StartWhere
                        .Where(tbrooms.RoomID, SQLOperator.Equal, rID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                return Convert.ToInt32(Internals.DBC.Values[0]);
            }
        }

        public double PreviousReading { get; set; }
        public double PresentReading { get; set; }

        public double Consumption
        {
            get
            {
                if (!(PreviousReading >= 0) || !(PresentReading >= 0))
                    return -1;

                if (PresentReading < PreviousReading)
                    return -1;

                return PresentReading - PreviousReading;
            }
        }
        public double RemainingBalance
        {
            get
            {
                double rb = 0;

                new SelectCommand<tbwaterinvoice>()
                    .Select(tbwaterinvoice.BillBalance)
                    .From
                    .StartWhere
                        .Where(tbwaterinvoice.TenantID, SQLOperator.Equal, TenantID.ToString())
                        .And()
                        .StartGroup(tbwaterinvoice.Status, SQLOperator.Equal, "'" + InvoiceStatuses.UNPAID.ToString() + "'")
                            .Or(tbwaterinvoice.Status, SQLOperator.Equal, "'" + InvoiceStatuses.PARTIAL.ToString() + "'")
                        .EndGroup
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                if (Internals.DBC.HasRows)
                {
                    for (int i = 0; i < Internals.DBC.Values.Count; i++)
                        rb += Convert.ToDouble(Internals.DBC.Values[i]);
                }
                Internals.DBC.CloseReader();

                return rb;
            }
        }
        public List<int> AdvanceIDs
        {
            get
            {
                List<int> AID = new List<int>();

                new SelectCommand<tbadvances>()
                    .Select(tbadvances.AdvanceID)
                    .From
                    .StartWhere
                        .Where(tbadvances.TenantID, SQLOperator.Equal, TenantID.ToString())
                        .And(tbadvances.BillType, SQLOperator.Equal, "'" + InvoiceTypes.WATER.ToString() + "'")
                    .EndWhere
                    .ExecuteReader(Internals.DBC);

                if (Internals.DBC.HasRows)
                {
                    for (int i = 0; i < Internals.DBC.Values.Count; i++)
                        AID.Add(Convert.ToInt32(Internals.DBC.Values[i]));
                }
                Internals.DBC.CloseReader();

                return AID;
            }
        }
        public string AdvanceIDsString
        {
            get
            {
                if (AdvanceIDs.Count > 0)
                {
                    string AID_S = "";

                    for (int i = 0; i < AdvanceIDs.Count; i++)
                    {
                        AID_S += AdvanceIDs[i].ToString();

                        if (i < AdvanceIDs.Count - 1)
                            AID_S += ",";
                    }
                    return AID_S;
                }
                else
                    return "";
            }
        }
        public double Deductions
        {
            get
            {
                double d = 0;

                new SelectCommand<tbcredits>()
                    .Select(tbcredits.CreditAmount)
                    .From
                    .StartWhere
                        .Where(tbcredits.TenantID, SQLOperator.Equal, TenantID.ToString())
                        .And(tbcredits.BillType, SQLOperator.Equal, "'" + InvoiceTypes.WATER.ToString() + "'")
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                if (Internals.DBC.HasRows)
                    d += Convert.ToDouble(Internals.DBC.Values[0]);
                Internals.DBC.CloseReader();

                if (AdvanceIDs.Count > 0)
                {
                    foreach (int aid in AdvanceIDs)
                    {
                        new SelectCommand<tbadvances>()
                            .Select(tbadvances.AmountPaid)
                            .From
                            .StartWhere
                                .Where(tbadvances.AdvanceID, SQLOperator.Equal, aid.ToString())
                            .EndWhere
                            .ExecuteReader(Internals.DBC);
                        d += Convert.ToDouble(Internals.DBC.Values[0]);
                    }
                }

                return d;
            }
        }
        public double CurrentCharge
        {
            get
            {
                if (Consumption == -1)
                    return 0;

                double ccpu = 0;

                new SelectCommand<tbutilities_settings>()
                    .Select(tbutilities_settings.WaterCCPU)
                    .From
                    .StartWhere
                        .Where(tbutilities_settings.BuildingID, SQLOperator.Equal, BuildingID.ToString())
                    .EndWhere
                    .ExecuteReader(Internals.DBC);
                ccpu = Convert.ToDouble(Internals.DBC.Values[0]);

                return Consumption * ccpu;
            }
        }
        public double Subtotal => (CurrentCharge + RemainingBalance) - Deductions;
        public InvoiceStatuses Status => InvoiceStatuses.UNPAID;

        public WaterInvoice(
            int SetTenantID = -1,
            double SetPreviousReading = -1,
            double SetPresentReading = -1)
        {
            TenantID = SetTenantID;
            PreviousReading = SetPreviousReading;
            PresentReading = SetPresentReading;
        }

        public bool IsValid()
        {
            return
                TenantID != -1 &&
                Consumption != -1;
        }
    }
}
