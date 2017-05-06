using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THGL_Managment_System
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            panel1.Controls[i].Text = "";
            bunifuDropdown1.Controls[0].Text="";
         
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Παρακαλώ  χργσιμοποιήστε το barcode scanner για να εισάγετε νέο προϊον");
        }
    }
}
