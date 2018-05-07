using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_BanSach.Object
{
    class TacGiaObj
    {
        string ma, ten, diachi, sodt;

        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }

        public string Ma
        {
            get
            {
                return ma;
            }

            set
            {
                ma = value;
            }
        }

        public string Sodt
        {
            get
            {
                return sodt;
            }

            set
            {
                sodt = value;
            }
        }

        public string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }
        public TacGiaObj() { }
        public TacGiaObj(string ma, string ten, string diachi, string sodt)
        {
            this.ma = ma;
            this.ten = ten;
            this.diachi = diachi;
            this.sodt = sodt;
        }
    }
}
