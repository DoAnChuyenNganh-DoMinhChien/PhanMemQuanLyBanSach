using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DoAn_BanSach.Control;

namespace DoAn_BanSach.View
{
    public partial class frmTimkiemNXB : UserControl
    {
        NhaXuatBanCtr nxbCtr = new NhaXuatBanCtr();
        public frmTimkiemNXB()
        {
            InitializeComponent();
        }
        public static frmTimkiemNXB frmTKNXB = new frmTimkiemNXB();
        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (cbbTimkiem.Text == "Mã NXB")
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-D617688;Initial Catalog=QuanLyBanSach;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("Select * from  NhaXuatBan where MaNXB like N'" + txtTimkiem.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dtgvDS.DataSource = dt;
            }
            else if (cbbTimkiem.Text == "Tên NXB")
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-D617688;Initial Catalog=QuanLyBanSach;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("Select * from  NhaXuatBan where TenNXB like N'" + txtTimkiem.Text + "%'", con);
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmTimkiemNXB_Load(object sender, EventArgs e)
        {
            DataTable dtDS = new System.Data.DataTable();
            dtDS = nxbCtr.GetData();
            dtgvDS.DataSource = dtDS;
        }
    }
}
