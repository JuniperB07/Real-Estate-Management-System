using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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

        public MSGBox_OK(string SetText = "", string SetMessage = "", DialogIcons SetIcon = DialogIcons.None)
        {
            InitializeComponent();
            Internals.SetFormColors(this);
            rtxtMessage.BackColor = Internals.SandDune;
            btnOK.BackColor = Internals.Cyprus;
            btnOK.ForeColor = Internals.SandDune;

            text = SetText;
            message = SetMessage;

            IconSetter(SetIcon);
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
            Dialogs.Result = DialogResult.OK;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void MSGBox_OK_Shown(object sender, EventArgs e)
        {
            switch (icon)
            {
                case DialogIcons.Exclamation:
                case DialogIcons.Error:
                    SystemSounds.Exclamation.Play();
                    break;
                case DialogIcons.Question:
                    SystemSounds.Question.Play();
                    break;
                default:
                    SystemSounds.Asterisk.Play();
                    break;
            }
        }
    }
}
