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
        int posothta;
        public Form7()
        {
            InitializeComponent();
            
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {/*
            for(int i=0;i<bunifuTextbox1.text.Length;i++)
            {
                if(bunifuTextbox1.text.Substring(i))
            }
            if (bunifuTextbox1.text.Length  == 4)
            {

                String code = bunifuTextbox1.text.Substring(0, 4);
                bunifuTextbox1.text = code;


            }
            */
           // bunifuTextbox1.text.Length="";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            posothta++;
            if (posothta < 0)
            {
                posothta = 0;
                bunifuMetroTextbox1.Text = "0";
            }
            else
                bunifuMetroTextbox1.Text = posothta.ToString();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            posothta--;
            if (posothta < 0)
            {
                posothta = 0;
                bunifuMetroTextbox1.Text = "0";
            }
            else
               bunifuMetroTextbox1.Text = posothta.ToString();

        }
    }
}
