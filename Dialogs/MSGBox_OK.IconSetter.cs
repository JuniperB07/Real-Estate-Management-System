using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Management_System.Dialogs
{
    partial class MSGBox_OK
    {
        private void IconSetter(DialogIcons SetIcon)
        {
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
    }
}
