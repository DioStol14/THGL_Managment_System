using Bunifu.Framework.UI;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            //Extensions.clearControl(panel1);
            panel1.clearControl();
        }


        private void clearForm()
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is BunifuMaterialTextbox)
                    control.Text = string.Empty;

                if (control is BunifuDropdown)
                    control.Controls[0].Text = string.Empty;
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Παρακαλώ εισάγετε το Barcode πελάτη για να συνεχίσετε", "Βοήθεια", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private async void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            using (THGLdbEntities tHGLdbEntities = new THGLdbEntities())
            {
                var proion = tHGLdbEntities.Proion.Single(a => a.Barcode == @"sdgfsd");
                proion.Onoma = "newName";
                proion.Kathgoria = "xarti";
                await tHGLdbEntities.SaveChangesAsync();


                var pelatis = tHGLdbEntities.Pelatis.Single(a => a.Kwdikos_Pelati == "");
                int? p = pelatis.Anakuklwnei.Sum(a => a.pontoi);




                //Proion proion = new Proion
                //{
                //    Barcode = bunifuMaterialTextbox1.Text,
                //    Onoma = bunifuMaterialTextbox2.Text,
                //    Kathgoria = bunifuDropdown1.selectedValue,
                //    Pontoi = int.Parse(bunifuMaterialTextbox4.Text),
                //    Anakuklwsimo = bunifuiOSSwitch1.Value ? "ΝΑΙ" : "ΟΧΙ",
                //};

                //tHGLdbEntities.Proion.Add(proion);
                //await tHGLdbEntities.SaveChangesAsync();
            }
        }




    }
}
