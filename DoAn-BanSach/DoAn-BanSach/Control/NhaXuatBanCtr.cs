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
    class NhaXuatBanCtr
    {
        NhaXuatBanMod nxbMod = new NhaXuatBanMod();
        public DataTable GetData()
        {
            return nxbMod.GetData();
        }
        public bool AddData(NhaXuatBanObj nxbObj)
        {
            return nxbMod.AddData(nxbObj);
        }
        public bool UpdData(NhaXuatBanObj nxbObj)
        {
            return nxbMod.UpdData(nxbObj);
        }


        public bool DelData(string ma)
        {
            return nxbMod.DelData(ma);
        }
    }
}
