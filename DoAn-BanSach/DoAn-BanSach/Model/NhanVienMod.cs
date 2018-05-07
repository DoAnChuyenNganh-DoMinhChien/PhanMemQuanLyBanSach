using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DoAn_BanSach.Object;
namespace DoAn_BanSach.Model
{
    class NhanVienMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select MaNV , TenNV, Email, NgaySinh, GioiTinh, CMND from NhanVien";
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

        public bool AddData(NhanVienObj nvObj)
        {
            cmd.CommandText = "Insert into NhanVien values ('" + nvObj.MaNhanVien + "',N'" + nvObj.TenNhanVien + "','" + nvObj.Email + "',CONVERT(DATE,'" + nvObj.Ngaysinh + "',103),'" + nvObj.Gioitinh + "','" + nvObj.Cmnd + "')";
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

        public bool UpdData(NhanVienObj nvObj)
        {
            cmd.CommandText = "Update NhanVien set TenNV =  N'" + nvObj.TenNhanVien + "', Email = N'" + nvObj.Email + "', NgaySinh = CONVERT(DATE,'" + nvObj.Ngaysinh + "',103), GioiTinh = N'" + nvObj.Gioitinh + "', CMND = '" + nvObj.Cmnd + "' Where MaNV = '" + nvObj.MaNhanVien + "'";
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
            cmd.CommandText = "Delete NhanVien Where MaNV = '" + ma + "'";
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
