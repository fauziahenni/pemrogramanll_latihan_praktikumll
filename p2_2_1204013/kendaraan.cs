using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2_2_1204013
{
    public class kendaraan
    {
        private string nama;
        private string type;
        public kendaraan(string nama, string type) {
            this.nama = nama;
            this.type = type;
        }
        public string Nama
        {
            get
            {
                return nama;
            }
            set
            {
                nama = value;

            }

        }
        public string Type
        {
            get
            {
                return type;

            }
            set
            {
                type = value;
            }
        }
    }
 }

