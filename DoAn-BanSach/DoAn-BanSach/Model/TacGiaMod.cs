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
    class TacGiaMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select MaTG, TenTG, DiaChi, SoDT from TacGia";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }

            return dt;
        }
        public bool AddData(TacGiaObj tgObj)
        {
            cmd.CommandText = "Insert into TacGia values ('" + tgObj.Ma + "',N'" + tgObj.Ten + "',N'" + tgObj.Diachi + "','" + tgObj.Sodt + "')";
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
        public bool UpdData(TacGiaObj tgObj)
        {
            cmd.CommandText = "Update TacGia set TenTG =  N'" + tgObj.Ten + "', DiaChi = N'" + tgObj.Diachi + "',SoDT = '" + tgObj.Sodt + "' Where MaTG = '" + tgObj.Ma + "'";
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
            cmd.CommandText = "Delete TacGia Where MaTG = '" + ma + "'";
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
