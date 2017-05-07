using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace THGL_Managment_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void label1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                bunifuCircleProgressbar1.Value = i;
                //Thread.Sleep(30);
#if !DEBUG
                await Task.Delay(30);
                bunifuCircleProgressbar1.Update();
                bunifuCircleProgressbar1.Show();
#endif


            }
            Hide();
            mdiForm frm2 = new mdiForm();
            frm2.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bunifuCircleProgressbar1.Hide();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.SeaGreen;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Transparent;
        }
    }
}
