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
    public partial class ViewConsumptions : Form
    {
        public ViewConsumptions()
        {
            InitializeComponent();
        }

        private void ViewConsumptions_Load(object sender, EventArgs e)
        {
            ResetForm();
            FillWaterDGV();
            FillWaterCHRT();
            FillElectricityDGV();
            FillElectricityCHRT();
        }
    }
}
