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
using THGL_Managment_System.TESTMODEL;
using Bunifu.Framework.UI;

namespace THGL_Managment_System
{
    public partial class Form3 : Form
    {
        SqlConnection connection;
        
        
        public Form3()
        {
            
            connection = new SqlConnection("Data Source=VOUTC-PC\\SQLEXPRESS;Initial Catalog=THGLdb;Integrated Security=True");
            //connection.Open();
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
   /*     private void clearForm()
        {
            foreach (Control control in Controls)
            {
                if (control is BunifuMaterialTextbox)
                    control.Text = string.Empty;
            }
        }*/
        private async void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            using (THGLdbEntities tHGLdbEntities = new THGLdbEntities())
            {
                Pelatis pelatis = new Pelatis
                {
                    Kwdikos_Pelati = bunifuMaterialTextbox1.Text,
                    Onoma = bunifuMaterialTextbox2.Text,
                    Epitheto = bunifuMaterialTextbox3.Text,
                    Hm_gennisis = Convert.ToDateTime(bunifuMaterialTextbox4.Text),
                    Poli = bunifuMaterialTextbox5.Text,
                    Tk = bunifuMaterialTextbox6.Text,
                    Dieuthinsi = bunifuMaterialTextbox7.Text,
                    Thlefwno = bunifuMaterialTextbox8.Text,
                    Sxolia = bunifuMaterialTextbox9.Text,
                    Pontoi = int.Parse(bunifuMaterialTextbox10.Text),
                };

                tHGLdbEntities.Pelatis.Add(pelatis);
                await tHGLdbEntities.SaveChangesAsync();
            }
            this.ClearForm();
         }
      }
}
