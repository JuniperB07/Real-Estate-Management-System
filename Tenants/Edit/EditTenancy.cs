using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_Management_System.Tenants.Edit
{
    public partial class EditTenancy : Form
    {
        public EditTenancy()
        {
            InitializeComponent();
        }

        private void EditTenancy_Load(object sender, EventArgs e)
        {
            Text = EditHelper.FormTitle_EditTenancy;
        }
    }
}
