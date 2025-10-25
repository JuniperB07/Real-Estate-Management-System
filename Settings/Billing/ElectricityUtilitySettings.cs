using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_Management_System.Settings.Billing
{
    public partial class ElectricityUtilitySettings : Form
    {
        public ElectricityUtilitySettings()
        {
            InitializeComponent();
        }

        private void ElectricityUtilitySettings_Load(object sender, EventArgs e)
        {
            txtUnit.Text = Configs.Utilities.UtilitiesConfig.Electricity_Unit;
            txtUnitPrice.Text = Configs.Utilities.UtilitiesConfig.Electricity_UnitPrice.ToString("0.00");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUnit.Text) || string.IsNullOrWhiteSpace(txtUnitPrice.Text))
            {
                MessageBox.Show("Please fill all fields.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtUnitPrice.Text, out _))
            {
                MessageBox.Show("Invalid unit price.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Configs.Utilities.UtilitiesConfig.Change_ElectricityUnit(txtUnit.Text);
            Configs.Utilities.UtilitiesConfig.Change_ElectricityUnitPrice(Convert.ToDouble(txtUnitPrice.Text));

            MessageBox.Show("Changes saved!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            ElectricityUtilitySettings_Load(this, EventArgs.Empty);
        }

        private void ElectricityUtilitySettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
