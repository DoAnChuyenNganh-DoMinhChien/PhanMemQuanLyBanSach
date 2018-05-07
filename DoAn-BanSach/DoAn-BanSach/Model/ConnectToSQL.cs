using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_BanSach.Model
{
    class ConnectToSQL
    {
        #region Availible
        private SqlConnection Conn;
        private SqlCommand _cmd;
        private string StrCon = null;
        private string _error;

        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }

        public SqlConnection Connection
        {
            get { return Conn; }
        }

        public SqlCommand CMD
        {
            get { return _cmd; }
            set { _cmd = value; }
        }
        #endregion
        #region Contrustor
        public ConnectToSQL()
        {
            StrCon = @"Data Source=DESKTOP-D617688; Initial Catalog = QuanLyBanSach; User = sa; Password=123";
            Conn = new SqlConnection(StrCon);
        }
        #endregion

        #region Methods
        public bool OpenConn()
        {
            try
            {
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();
            }
            catch (Exception ex)
            {
                _error = ex.Message;
                return false;
            }
            return true;
        }
        public bool CloseConn()
        {
            try
            {
                if (Conn.State == ConnectionState.Open)
                    Conn.Close();
            }
            catch (Exception ex)
            {
                _error = ex.Message;
                return false;
            }
            return true;
        }
        #endregion
        //Hàm load dữ liệu
        public DataTable LoadData()
        {
            DataTable dt = new DataTable();
            OpenConn();
            SqlCommand cmd = new SqlCommand("NhanVien_LoadDL",Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CloseConn();
            return dt;
        }
        //Hàm tìm kiếm
        public DataTable TimKiem(string ChuoiTimKiem)
        {
            OpenConn();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("NhanVien_TimKiemTheoTen",Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("TenNV", SqlDbType.NVarChar)).Value=ChuoiTimKiem; //Tên NV là biến trong strored    
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CloseConn();
            return dt;
        }
    }
}
