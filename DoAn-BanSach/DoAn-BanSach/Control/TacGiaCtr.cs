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
    class TacGiaCtr
    {
        TacGiaMod tgMod = new TacGiaMod();
        public DataTable GetData()
        {
            return tgMod.GetData();
        }
        public bool AddData(TacGiaObj tgbObj)
        {
            return tgMod.AddData(tgbObj);
        }
        public bool UpdData(TacGiaObj tgbObj)
        {
            return tgMod.UpdData(tgbObj);
        }


        public bool DelData(string ma)
        {
            return tgMod.DelData(ma);
        }
    }
}
