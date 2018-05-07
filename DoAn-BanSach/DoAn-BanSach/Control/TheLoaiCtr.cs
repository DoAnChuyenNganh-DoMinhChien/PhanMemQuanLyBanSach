using DoAn_BanSach.Model;
using DoAn_BanSach.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_BanSach.Control
{
    class TheLoaiCtr
    {
        TheLoaiMod tlMod = new TheLoaiMod();
        public DataTable GetData()
        {
            return tlMod.GetData();
        }
        public bool AddData(TheLoaiObj tlbObj)
        {
            return tlMod.AddData(tlbObj);
        }
        public bool UpdData(TheLoaiObj tlbObj)
        {
            return tlMod.UpdData(tlbObj);
        }


        public bool DelData(string ma)
        {
            return tlMod.DelData(ma);
        }
    }
}
