using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using JunX.NET8.WinForms;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;
using JunX.NETStandard.Utility;

namespace Real_Estate_Management_System.Utilities
{
    partial class Utilities
    {
        private void ResetForm()
        {
            Forms.ClearControlText(Forms.ControlType<Label>.Extract(pnlUtilitiesInformation, "lbl"));
            cmbYear.Items.Clear();
            chrtUtilitiesChart.Series["Water"].Points.Clear();
            chrtUtilitiesChart.Series["Electricity"].Points.Clear();
            chrtUtilitiesChart.Titles[0].Text = "";
            chrtUtilitiesChart.Visible = false;

            Forms.SetControlVisible(new Control[]
            {
                pnlUtilitiesInformation,
                lblYear,
                cmbYear }, false);

            UHelper.BuildingID = 0;
        }

        private void FillBuildingsList()
        {
            new SelectCommand<tbbuilding>()
                .Select(tbbuilding.BuildingName)
                .From
                .OrderBy(tbbuilding.BuildingName, OrderByModes.ASC)
                .ExecuteReader(Internals.DBC);
            Forms.FillListBox(lstBuildingsList, Internals.DBC.Values);
        }

        private void RefreshPanel_UtilityInformation()
        {
            lblWaterCharge.Text = Internals.PESO + UHelper.UtilityChargeInfo.Value.WaterCharge.ToString("0.00");
            lblElectricityCharge.Text = Internals.PESO + UHelper.UtilityChargeInfo.Value.ElectricityCharge.ToString("0.00");
            pnlUtilitiesInformation.Visible = true;
        }

        private void FillChart()
        {
            List<string> Months = EnumHelper<MonthsList>.ToList();
            int index = 0;

            chrtUtilitiesChart.Series["Water"].Points.Clear();
            chrtUtilitiesChart.Series["Electricity"].Points.Clear();

            foreach(string mon in Months)
            {
                new SelectCommand<tbutilities_consumption>()
                    .Select(new tbutilities_consumption[]
                    {
                        tbutilities_consumption.WaterConsumption,
                        tbutilities_consumption.ElectricityConsumption
                    })
                    .From
                    .StartWhere
                        .Where(tbutilities_consumption.BuildingID, SQLOperator.Equal, UHelper.BuildingID.ToString())
                        .And()
                        .StartGroup(tbutilities_consumption.Year, SQLOperator.Equal, cmbYear.Text)
                        .And(tbutilities_consumption.Month, SQLOperator.Equal, "'" + mon + "'")
                        .EndGroup
                    .EndWhere
                    .ExecuteReader(Internals.DBC);

                if (Internals.DBC.HasRows)
                {
                    Forms.AddChartSeriesPoint(chrtUtilitiesChart.Series["Water"], mon, index, Convert.ToDouble(Internals.DBC.Values[0]));
                    Forms.AddChartSeriesPoint(chrtUtilitiesChart.Series["Electricity"], mon, index, Convert.ToDouble(Internals.DBC.Values[1]));

                    index++;
                }
                else
                {
                    Internals.DBC.CloseReader();
                    break;
                }
            }

            chrtUtilitiesChart.Titles[0].Text = "Utilities Consumption Graph for Year " + cmbYear.Text;
            chrtUtilitiesChart.Visible = true;
        }

        private void FillCMB_Year()
        {
            new SelectCommand<tbutilities_consumption>()
                .Distinct
                .Select(tbutilities_consumption.Year)
                .From
                .StartWhere
                    .Where(tbutilities_consumption.BuildingID, SQLOperator.Equal, UHelper.BuildingID.ToString())
                .EndWhere
                .OrderBy(tbutilities_consumption.Year, OrderByModes.DESC)
                .ExecuteReader(Internals.DBC);
            Forms.FillComboBox(cmbYear, Internals.DBC.Values);
        }
    }
}
