using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunX.NET8.WinForms;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;

namespace Real_Estate_Management_System.Utilities
{
    partial class ViewConsumptions
    {
        private void ResetForm()
        {
            dgvWater.DataSource = null;
            chrtWater.Series["Water"].Points.Clear();
            chrtElectricity.Series["Electricity"].Points.Clear();
            chrtWater.Titles[0].Text = "Water Consumption Graph";
            chrtElectricity.Titles[0].Text = "Electricity Consumption Graph";

            lblTitle.Text = "Consumption Record for the Year " + UHelper.SelectedYear.ToString();
        }

        private void FillWaterDGV()
        {
            new SelectCommand<tbutilities_consumption>()
                .Select(tbutilities_consumption.Month)
                .Select(tbutilities_consumption.WaterConsumption).As("Consumption")
                .From
                .StartWhere
                    .Where(tbutilities_consumption.BuildingID, SQLOperator.Equal, UHelper.BuildingID.ToString())
                    .And(tbutilities_consumption.Year, SQLOperator.Equal, UHelper.SelectedYear.ToString())
                .EndWhere
                .OrderBy(tbutilities_consumption.UCID, OrderByModes.ASC)
                .ExecuteDataSet(Internals.DBC);
            dgvWater.DataSource = null;
            dgvWater.DataSource = Internals.DBC.DataSet.Tables[0];
        }

        private void FillWaterCHRT()
        {
            int index = 0;

            chrtWater.Series["Water"].Points.Clear();

            new SelectCommand<tbutilities_consumption>()
                .Select(new tbutilities_consumption[]
                {
                    tbutilities_consumption.Month,
                    tbutilities_consumption.WaterConsumption
                })
                .From
                .StartWhere
                    .Where(tbutilities_consumption.BuildingID, SQLOperator.Equal, UHelper.BuildingID.ToString())
                    .And(tbutilities_consumption.Year, SQLOperator.Equal, UHelper.SelectedYear.ToString())
                .EndWhere
                .OrderBy(tbutilities_consumption.UCID, OrderByModes.ASC)
                .ExecuteReader(Internals.DBC);
            for(int i=0; i<Internals.DBC.Values.Count; i += 2)
            {
                Forms.AddChartSeriesPoint(chrtWater.Series["Water"], Internals.DBC.Values[i], index, Convert.ToDouble(Internals.DBC.Values[i + 1]));
                index++;
            }
        }

        private void FillElectricityDGV()
        {
            new SelectCommand<tbutilities_consumption>()
                .Select(tbutilities_consumption.Month)
                .Select(tbutilities_consumption.ElectricityConsumption).As("Consumption")
                .From
                .StartWhere
                    .Where(tbutilities_consumption.BuildingID, SQLOperator.Equal, UHelper.BuildingID.ToString())
                    .And(tbutilities_consumption.Year, SQLOperator.Equal, UHelper.SelectedYear.ToString())
                .EndWhere
                .OrderBy(tbutilities_consumption.UCID, OrderByModes.ASC)
                .ExecuteDataSet(Internals.DBC);
            dgvElectricity.DataSource = null;
            dgvElectricity.DataSource = Internals.DBC.DataSet.Tables[0];
        }

        private void FillElectricityCHRT()
        {
            int index = 0;

            chrtElectricity.Series["Electricity"].Points.Clear();

            new SelectCommand<tbutilities_consumption>()
                .Select(new tbutilities_consumption[]
                {
                    tbutilities_consumption.Month,
                    tbutilities_consumption.ElectricityConsumption
                })
                .From
                .StartWhere
                    .Where(tbutilities_consumption.BuildingID, SQLOperator.Equal, UHelper.BuildingID.ToString())
                    .And(tbutilities_consumption.Year, SQLOperator.Equal, UHelper.SelectedYear.ToString())
                .EndWhere
                .OrderBy(tbutilities_consumption.UCID, OrderByModes.ASC)
                .ExecuteReader(Internals.DBC);
            for (int i = 0; i < Internals.DBC.Values.Count; i += 2)
            {
                Forms.AddChartSeriesPoint(chrtElectricity.Series["Electricity"], Internals.DBC.Values[i], index, Convert.ToDouble(Internals.DBC.Values[i + 1]));
                index++;
            }
        }
    }
}
