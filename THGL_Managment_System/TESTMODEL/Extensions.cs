using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THGL_Managment_System.TESTMODEL
{
    public static class Extensions
    {
        public static void clearControl(this Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is BunifuMaterialTextbox)
                    control.Text = string.Empty;

                if (control is BunifuDropdown)
                    control.Controls[0].Text = string.Empty;
            }
        }
        public static void ClearForm(this Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is BunifuMaterialTextbox)
                    control.Text = string.Empty;

                if (control is BunifuDropdown)
                    control.Controls[0].Text = string.Empty;
            }
        }
        public static void OriginalClear(this Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                    control.Text = string.Empty;

                if (control is ComboBox)
                    control.Controls[0].Text = string.Empty;
            }
        }
    }

}
