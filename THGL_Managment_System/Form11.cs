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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            using (THGLdbEntities tHGLdbEntities = new THGLdbEntities())
            {
               // var editcust = tHGLdbEntities.Anakuklwse.Single(a => a.Kwd_Pelati == bunifuMaterialTextbox1.Text);
                var editPelatis = tHGLdbEntities.Pelatis.Single(a => a.Kwdikos_Pelati == bunifuMaterialTextbox1.Text);
              //  var editpoints = tHGLdbEntities.Proion.Single(a => a.Barcode == bunifuMaterialTextbox1.Text);

                label2.Text = editPelatis.Onoma;
                label3.Text = editPelatis.Epitheto;
                //int? a = editPelatis.Pontoi.ToString;
                //label3.Text = editcust.Posotita * editpoints.Pontoi;
                
                //await tHGLdbEntities.SaveChangesAsync();


                //var pelates = tHGLdbEntities.Pelatis.OrderByDescending(a => a.getPoints()).ThenBy(a => a.Onoma).Take(10);
                //int? p = pelatis.Anakuklwnei.Sum(a => a.pontoi);
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

        }
    }
}
