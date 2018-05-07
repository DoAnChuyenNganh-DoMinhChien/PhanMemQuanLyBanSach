using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_BanSach.Object
{
    class NhanVienObj
    {
        string ma, ten, email, ngaysinh, gioitinh, cmnd;

        public string Cmnd
        {
            get
            {
                return cmnd;
            }

            set
            {
                cmnd = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Gioitinh
        {
            get
            {
                return gioitinh;
            }

            set
            {
                gioitinh = value;
            }
        }

        public string MaNhanVien
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

        public string Ngaysinh
        {
            get
            {
                return ngaysinh;
            }

            set
            {
                ngaysinh = value;
            }
        }

        public string TenNhanVien
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

        public NhanVienObj() { }

        public NhanVienObj(string ma, string ten, string email, string ngaysinh, string gioitinh, string cmnd)
        {
            this.ma = ma;
            this.ten = ten;
            this.email = email;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.cmnd = cmnd;
        }
    }
}
