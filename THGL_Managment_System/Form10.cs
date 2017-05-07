using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THGL_Managment_System.TESTMODEL;

namespace THGL_Managment_System
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            using (THGLdbEntities tHGLdbEntities = new THGLdbEntities())
            {
                var pelates = tHGLdbEntities.Pelatis.ToList().OrderByDescending(a => a.getPoints()).ThenBy(a => a.Onoma).Take(10).ToList();
                dataGridView1.DataSource = pelates;

            }
        }
    }
}
