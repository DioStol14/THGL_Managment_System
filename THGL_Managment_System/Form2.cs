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
            Form6 proion = new Form6();
            proion.MdiParent = this;
            proion.Show();
        }

        private void howToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Παρακαλώ Επικοινωνήστε με το Κέντρο Εξυπηρέτησης\nTel : +30 23210 99999 \nEmail : info@thgl.com \nAddress : Βενιζέλου 8", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void προσθήκηToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 pelatis = new Form3();
            pelatis.MdiParent = this;
            pelatis.Show();
        }

        private void entryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 kataxwrisi = new Form7();
            kataxwrisi.MdiParent = this;
            kataxwrisi.Show();
            entryToolStripMenuItem.Enabled = false;
        }

        private void tHGLCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 aboutUs = new Form4();
            aboutUs.MdiParent = this;
            aboutUs.Show();
            //entryToolStripMenuItem.Enabled = false; to exeis sto menu katwxirwsi an einai anagkaio balto kai gia to menu Σχετικα με εμας

        }
    }
}
