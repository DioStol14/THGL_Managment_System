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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
          //  Bunifu.Framework.UI.BunifuMaterialTextbox tmp;
           // Control control = new Control();
            for (int i=0; i< 5; i++)
            panel1.Controls[i].Text = "";
                
               
           
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Βοήθεια","Παρακαλώ  χρησιμοποιήστε το barcode scanner για να εισάγετε νέο προϊον", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
        }
    }
}
