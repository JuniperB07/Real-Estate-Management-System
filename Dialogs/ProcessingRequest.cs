using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_Management_System.Dialogs
{
    public partial class ProcessingRequest : Form
    {
        public ProcessingRequest()
        {
            InitializeComponent();
            Internals.SetFormColors(this);
            lblMSG.ForeColor = Internals.Cyprus;
        }

        private void ProcessingRequest_Load(object sender, EventArgs e)
        {

        }
    }
}
