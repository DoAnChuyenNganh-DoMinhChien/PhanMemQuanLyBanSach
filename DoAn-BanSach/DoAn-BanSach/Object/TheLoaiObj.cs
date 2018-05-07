using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_BanSach.Object
{
    class TheLoaiObj
    {
        string ma, ten;

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
        public TheLoaiObj() { }
        public TheLoaiObj(string ma, string ten)
        {
            this.ma = ma;
            this.ten = ten;
        }
    }
}
