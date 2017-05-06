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
    public partial class mdiForm : Form
    {
        public mdiForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void νέοΠροϊόνToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form5 proion = new Form5();
            proion.MdiParent = this;
            proion.Show();
        }

        private void howToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 boitheia = new Form6();
            boitheia.MdiParent = this;
            boitheia.Show();
        }

        private void προσθήκηToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 pelatis = new Form3();
            pelatis.MdiParent = this;
            pelatis.Show();
        }

        private void entryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 katwxirosi = new Form7();
            katwxirosi.MdiParent = this;
            katwxirosi.Show();
        }

        private void tHGLCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 aboutUs = new Form4();
            aboutUs.MdiParent = this;
            aboutUs.Show();
        }
    }
}
