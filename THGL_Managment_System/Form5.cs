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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.OriginalClear();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Παρακαλώ εισάγετε το Barcode προϊόντος για να συνεχίσετε", "Βοήθεια", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            try
            {
                using (THGLdbEntities tHGLdbEntities = new THGLdbEntities())
                {

                    var editProion = tHGLdbEntities.Proion.Single(a => a.Barcode == bunifuMaterialTextbox2.Text);
                    editProion.Onoma = bunifuMaterialTextbox2.Text;
                    editProion.Kathgoria = Convert.ToString(comboBox1.SelectedItem);
                    editProion.Pontoi = int.Parse(bunifuMaterialTextbox4.Text);
                    editProion.Anakuklwsimo = bunifuiOSSwitch1.Value ? "ΝΑΙ" : "ΟΧΙ";
                   

                    
                    await tHGLdbEntities.SaveChangesAsync();

                }
                this.ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private  void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            using (THGLdbEntities tHGLdbEntities = new THGLdbEntities())
            {
                var editproducts = tHGLdbEntities.Proion.Single(a => a.Barcode == bunifuMaterialTextbox2.Text);
                bunifuMaterialTextbox3.Text = editproducts.Onoma;
                comboBox1.SelectedItem = editproducts.Kathgoria;
                uint unsignedpoints = 0;
         

                bunifuMaterialTextbox4.Text = "" + unsignedpoints;
                
            }
           
        }
    }
}
