using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DoAn_BanSach.Object;

namespace DoAn_BanSach.Model
{
    class NhaXuatBanMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select MaNXB, TenNXB, DiaChi, Email, SoDT from NhaXuatBan";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch(Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }

            return dt;
        }
        public bool AddData(NhaXuatBanObj nxbObj)
        {
            cmd.CommandText = "Insert into NhaXuatBan values ('" + nxbObj.MaNhaXuatBan + "',N'" + nxbObj.TenNhaXuatBan + "',N'" + nxbObj.DiaChi + "',N'" + nxbObj.Email + "','" + nxbObj.SoDT + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }
        public bool UpdData(NhaXuatBanObj nxbObj)
        {
            cmd.CommandText = "Update NhaXuatBan set TenNXB =  N'" + nxbObj.TenNhaXuatBan + "', DiaChi = N'" + nxbObj.DiaChi + "', Email = N'" + nxbObj.Email + "',SoDT = '" + nxbObj.SoDT + "' Where MaNXB = '" + nxbObj.MaNhaXuatBan + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }
        public bool DelData(string ma)
        {
            cmd.CommandText = "Delete NhaXuatBan Where MaNXB = '" + ma + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }
    }
}
