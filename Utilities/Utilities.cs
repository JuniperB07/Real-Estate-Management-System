using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using JunX.NET8.WinForms;
using JunX.NETStandard.MySQL;
using JunX.NETStandard.SQLBuilder;

namespace Real_Estate_Management_System.Utilities
{
    public partial class Utilities : Form
    {
        public Utilities()
        {
            InitializeComponent();
        }

        private void Utilities_Load(object sender, EventArgs e)
        {
            ResetForm();
            FillBuildingsList();

            lblWaterUnit.Text = Configs.Utilities.UtilitiesConfig.Water_Unit;
            lblElectricityUnit.Text = Configs.Utilities.UtilitiesConfig.Electricity_Unit;
        }

        private void lstBuildingsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!(lstBuildingsList.SelectedItems.Count > 0))
                return;

            new SelectCommand<tbbuilding>()
                .Select(tbbuilding.BuildingID)
                .From
                .StartWhere
                    .Where(tbbuilding.BuildingName, SQLOperator.Equal, "@BuildingName")
                .EndWhere
                .ExecuteReader(Internals.DBC, new ParametersMetadata("@BuildingName", lstBuildingsList.SelectedItem.ToString()));
            UHelper.BuildingID = Convert.ToInt32(Internals.DBC.Values[0]);

            RefreshPanel_UtilityInformation();
            FillCMB_Year();

            Forms.SetControlVisible(new Control[]
            {
                lblNotice,
                lblYear,
                cmbYear }, true);
        }

        private void btnEditCharges_Click(object sender, EventArgs e)
        {
            EditCharges EC = new EditCharges();
            EC.ShowDialog();
            RefreshPanel_UtilityInformation();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Utilities_Load(this, EventArgs.Empty);
        }

        private void cmbYear_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbYear.Text))
            {
                UHelper.SelectedYear = Convert.ToInt32(cmbYear.Text);
                FillChart();
            }
            else
            {
                chrtUtilitiesChart.Series["Water"].Points.Clear();
                chrtUtilitiesChart.Series["Electricity"].Points.Clear();
                chrtUtilitiesChart.Titles[0].Text = "";
                chrtUtilitiesChart.Visible = false;
            }
        }

        private void Utilities_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void btnAddConsumption_Click(object sender, EventArgs e)
        {
            AddConsumption AC = new AddConsumption();
            AC.ShowDialog();

            FillCMB_Year();
            cmbYear.Text = "";
        }

        private void chrtUtilitiesChart_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ViewConsumptions VC = new ViewConsumptions();
            VC.ShowDialog();
        }
    }
}
