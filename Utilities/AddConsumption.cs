using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_Management_System.Utilities
{
    public partial class AddConsumption : Form
    {
        ConsumptionMetadata NewCM;
        Dialogs.MSGBox_OK MBOK;

        public AddConsumption()
        {
            InitializeComponent();
        }

        private void AddConsumption_Load(object sender, EventArgs e)
        {
            NewCM = new ConsumptionMetadata();
            ResetForm();
        }

        private void nudYear_ValueChanged(object sender, EventArgs e)
        {
            NewCM.Year = Convert.ToInt32(nudYear.Value);
            FillMonthsCMB();
        }

        private void cmbMonth_TextChanged(object sender, EventArgs e)
        {
            NewCM.Month = cmbMonth.Text;
        }

        private void txtWater_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtWater.Text))
            {
                if (double.TryParse(txtWater.Text, out _))
                    NewCM.WaterConsumption = Convert.ToDouble(txtWater.Text);
                else
                    NewCM.WaterConsumption = -1;
            }
            else
                NewCM.WaterConsumption = -1;
        }

        private void txtElectricity_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtElectricity.Text))
            {
                if (double.TryParse(txtElectricity.Text, out _))
                    NewCM.ElectricityConsumption = Convert.ToDouble(txtElectricity.Text);
                else
                    NewCM.ElectricityConsumption = -1;
            }
            else
                NewCM.ElectricityConsumption = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
