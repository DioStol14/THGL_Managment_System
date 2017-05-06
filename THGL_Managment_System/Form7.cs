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
    
    public partial class Form7 : Form
    {
        int posotita;
        public Form7()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            posotita++;
            if (posotita < 0)
            {
                posotita = 0;
                bunifuMetroTextbox1.Text = Convert.ToString(posotita);
            }
            else
                bunifuMetroTextbox1.Text = Convert.ToString(posotita);
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            posotita--;
            if (posotita < 0)
            {
                posotita = 0;
                bunifuMetroTextbox1.Text = Convert.ToString(posotita);
            }
            else
                bunifuMetroTextbox1.Text = Convert.ToString(posotita);
        }
    }
}
