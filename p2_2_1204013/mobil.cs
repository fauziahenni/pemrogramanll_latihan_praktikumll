using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2_2_1204013
{
   public class mobil:kendaraan
    {
        protected string warna;
        public mobil (string type,string warna): base( type,warna)
        {
            this.Nama = "BMW";
            this.Warna = warna;
            this.Type = type;
        }
        public string Warna
        {
            get
            {
                return warna;
            }
            set
            {
                warna = value;
            }
        }
       
    }
}
