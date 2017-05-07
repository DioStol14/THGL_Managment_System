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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private async void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                using (THGLdbEntities tHGLdbEntities = new THGLdbEntities())
                {
                    var editPelatis = tHGLdbEntities.Pelatis.Single(a => a.Kwdikos_Pelati == bunifuMaterialTextbox1.Text);
                    editPelatis.Onoma = bunifuMaterialTextbox2.Text;
                    editPelatis.Epitheto = bunifuMaterialTextbox3.Text;
                    await tHGLdbEntities.SaveChangesAsync();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            using (THGLdbEntities tHGLdbEntities = new THGLdbEntities())
            {
                var editPelatis = tHGLdbEntities.Pelatis.Single(a => a.Kwdikos_Pelati == bunifuMaterialTextbox1.Text);
                bunifuMaterialTextbox2.Text = editPelatis.Onoma;
                bunifuMaterialTextbox3.Text = editPelatis.Epitheto;
                //await tHGLdbEntities.SaveChangesAsync();


                var pelates = tHGLdbEntities.Pelatis.OrderByDescending(a => a.getPoints()).ThenBy(a => a.Onoma).Take(10);
                //int? p = pelatis.Anakuklwnei.Sum(a => a.pontoi);
            }
        }
    }
}