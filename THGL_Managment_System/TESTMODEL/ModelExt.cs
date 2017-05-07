using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THGL_Managment_System.TESTMODEL
{
    public partial class Pelatis
    {
        public string prop1 { get; set; }

        public int? getPoints()
        {
            return this.Anakuklwnei.Sum(a => a.pontoi);
        }


        public int age
        {
            get
            {
                return (int)((DateTime.Now - this.Hm_gennisis).TotalDays / 365d);
            }
            //set
            //{
            //    this.Hm_gennisis = DateTime.Now.AddDays(value * -365); 
            //}
        }


    }

}
