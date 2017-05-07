using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
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
        
        public void entryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form7 kataxwrisi = new Form7();
            kataxwrisi.MdiParent = this;
            kataxwrisi.Show();
            kataxwrisi.parent = this;
            entryToolStripMenuItem.Enabled = false;
        }

        private void tHGLCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 aboutUs = new Form4();
            aboutUs.MdiParent = this;
            aboutUs.Show();
            //entryToolStripMenuItem.Enabled = false; to exeis sto menu katwxirwsi an einai anagkaio balto kai gia to menu Σχετικα με εμας

        }
        OpenFileDialog fop = new OpenFileDialog();
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fop.Filter = "THGL|*.thgl";
            fop.ShowDialog();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            dialog.ShowDialog();
            menuStrip1.Font = dialog.Font;
           
        }

        private void επεξεργασίαΠελατώνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 epeksergasiaPelati = new Form8();
            epeksergasiaPelati.MdiParent = this;
            epeksergasiaPelati.Show();
        }

        private void mdiForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void καλύτεροςΠελάτηςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 kaliterosPelatis = new Form9();
            kaliterosPelatis.MdiParent = this;
            kaliterosPelatis.Show();
        }

        private void καλύτερεςΠόλοιToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 kaliteresPoleis = new Form10();
            kaliteresPoleis.MdiParent = this;
            kaliteresPoleis.Show();

        }

        private void κουπόνιαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 kouponia = new Form11();
            kouponia.MdiParent = this;
            kouponia.Show();
        }

        private void επεξεργασίαΠροϊόντοςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 editproduct = new Form5();
            editproduct.MdiParent = this;
            editproduct.Show();
        }

        private void mdiForm_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.bgdnew;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }
    }
}
