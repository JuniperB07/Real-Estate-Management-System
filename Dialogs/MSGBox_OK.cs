using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JunX.NET8.WinForms;

namespace Real_Estate_Management_System.Dialogs
{
    public partial class MSGBox_OK : Form
    {
        private string text, message;
        private DialogIcons icon;

        public MSGBox_OK(string SetText="", string SetMessage="", DialogIcons SetIcon = DialogIcons.None)
        {
            InitializeComponent();
            Internals.SetFormColors(this);
            rtxtMessage.BackColor = Internals.SandDune;
            btnOK.BackColor = Internals.Cyprus;
            btnOK.ForeColor = Internals.SandDune;

            text = SetText;
            message = SetMessage;

            switch (SetIcon)
            {
                case DialogIcons.Information:
                    pcbIcon.Image = Properties.Resources.REMS_ICON_INFORMATION;
                    break;
                case DialogIcons.Exclamation:
                    pcbIcon.Image = Properties.Resources.REMS_ICON_EXCLAMATION;
                    break;
                case DialogIcons.Error:
                    pcbIcon.Image = Properties.Resources.REMS_ICON_ERROR;
                    break;
                case DialogIcons.Question:
                    pcbIcon.Image = Properties.Resources.REMS_ICON_QUESTION;
                    break;
                default:
                    pcbIcon.Image = null;
                    break;
            }
        }

        private void MSGBox_OK_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(text))
                Text = text;
            else
                Text = Dialogs.DEFAULT_MBTEXT;

            rtxtMessage.Text = message;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Dialogs.Result = DialogResult.OK;
            Close();
        }

        private void MSGBox_OK_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
