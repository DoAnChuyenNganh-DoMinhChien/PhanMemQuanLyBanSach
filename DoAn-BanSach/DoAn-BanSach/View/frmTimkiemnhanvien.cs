using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_BanSach.Control;
using System.Data.SqlClient;

namespace DoAn_BanSach.View
{
    public partial class frmTimkiemnhanvien : UserControl
    {
        NhanVienCtr nvCtr = new NhanVienCtr();
        public frmTimkiemnhanvien()
        {
            InitializeComponent();
        }
        public static frmTimkiemnhanvien frmTKNV = new frmTimkiemnhanvien();
        private void frmTimkiemnhanvien_Load(object sender, EventArgs e)
        {
            DataTable dtDS = new System.Data.DataTable();
            dtDS = nvCtr.GetData();
            dtgvDS.DataSource = dtDS;
            
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (cbbTimkiem.Text == "Mã nhân viên")
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-D617688;Initial Catalog=QuanLyBanSach;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("Select * from  NhanVien where MaNV like N'" + txtTimkiem.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dtgvDS.DataSource = dt;
            }
            else if (cbbTimkiem.Text == "Tên nhân viên")
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-D617688;Initial Catalog=QuanLyBanSach;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("Select * from  NhanVien where TenNV like N'" + txtTimkiem.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dtgvDS.DataSource = dt;
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            cbbTimkiem.Text = "";
            txtTimkiem.Text = "";
        }
    }
}
