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

namespace Real_Estate_Management_System.Utilities
{
    public partial class Utilities : Form
    {
        public Utilities()
        {
            InitializeComponent();

            chrtUtilitiesGraph.Titles.Add("UTILITIES CONSUMPTION GRAPH FOR THE YEAR " + DateTime.Now.Year.ToString());
            chrtUtilitiesGraph.Titles[0].Font = new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Point, 0);
            chrtUtilitiesGraph.ChartAreas[0].AxisX.Title = "Year " + DateTime.Now.Year.ToString();
            chrtUtilitiesGraph.ChartAreas[0].AxisY.Title = "Consumption";
        }

        private void Utilities_Load(object sender, EventArgs e)
        {
            
        }
    }
}
