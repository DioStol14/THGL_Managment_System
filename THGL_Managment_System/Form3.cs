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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Παρακαλώ εισάγετε το Barcode πελάτη για να συνεχίσετε","Βοήθεια", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tHGLdbDataSet1.Pelatis' table. You can move, or remove it, as needed.
            this.pelatisTableAdapter.Fill(this.tHGLdbDataSet1.Pelatis);
            // TODO: This line of code loads data into the 'tHGLdbDataSet.Pelatis' table. You can move, or remove it, as needed.
            //this.pelatisTableAdapter.Fill(this.tHGLdbDataSet.Pelatis);

        }
    }
}
