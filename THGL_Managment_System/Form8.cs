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
                    editPelatis.Hm_gennisis = Convert.ToDateTime(bunifuMaterialTextbox4.Text);
                    editPelatis.Poli = bunifuMaterialTextbox5.Text;
                    editPelatis.Tk = bunifuMaterialTextbox6.Text;
                    editPelatis.Dieuthinsi = bunifuMaterialTextbox7.Text;
                    editPelatis.Thlefwno = bunifuMaterialTextbox8.Text;
                    editPelatis.Sxolia = bunifuMaterialTextbox9.Text;
                    editPelatis.Pontoi = Convert.ToInt32(bunifuMaterialTextbox10.Text);
                    
                    await tHGLdbEntities.SaveChangesAsync();
                    MessageBox.Show("Επιτυχής ενημέρωσης", "Η ενημέρωση πραγματοποιήθηκε επιτυχώς!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ClearForm();
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
                bunifuMaterialTextbox4.Text = Convert.ToString(editPelatis.Hm_gennisis);
                bunifuMaterialTextbox5.Text = editPelatis.Poli;
                bunifuMaterialTextbox6.Text = editPelatis.Tk;
                bunifuMaterialTextbox7.Text = editPelatis.Dieuthinsi;
                bunifuMaterialTextbox8.Text = editPelatis.Thlefwno;
                bunifuMaterialTextbox9.Text = editPelatis.Sxolia;
                bunifuMaterialTextbox10.Text = Convert.ToString(editPelatis.Pontoi);
                //await tHGLdbEntities.SaveChangesAsync();


                //var pelates = tHGLdbEntities.Pelatis.OrderByDescending(a => a.getPoints()).ThenBy(a => a.Onoma).Take(10);
                //int? p = pelatis.Anakuklwnei.Sum(a => a.pontoi);
            }
        }
    }
}