using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DoAn_BanSach.Model;
using DoAn_BanSach.Object;

namespace DoAn_BanSach.Control
{
    class KhachHangCtr
    {
         KhachHangMod nvMod = new KhachHangMod();
        public DataTable GetData()
        {
            return nvMod.GetData();
        }
        public bool AddData(KhachHangObj khObj)
        {
            return nvMod.AddData(khObj);
        }
        public bool UpdData(KhachHangObj khObj)
        {
            return nvMod.UpdData(khObj);
        }


        public bool DelData(string ma)
        {
            return nvMod.DelData(ma);
        }
    }
}
