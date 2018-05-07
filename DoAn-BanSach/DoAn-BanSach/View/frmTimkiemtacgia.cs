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
    public partial class frmTimkiemtacgia : UserControl
    {
        TacGiaCtr tgCtr = new TacGiaCtr();
        public frmTimkiemtacgia()
        {
            InitializeComponent();
        }
        public static frmTimkiemtacgia frmTKTG = new frmTimkiemtacgia();
        private void frmTimkiemtacgia_Load(object sender, EventArgs e)
        {
            DataTable dtDS = new System.Data.DataTable();
            dtDS = tgCtr.GetData();
            dtgvDS.DataSource = dtDS;
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (cbbTimkiem.Text == "Mã tác giả")
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-D617688;Initial Catalog=QuanLyBanSach;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("Select * from  TacGia where MaTG like N'" + txtTimkiem.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dtgvDS.DataSource = dt;
            }
            else if (cbbTimkiem.Text == "Tên tác giả")
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-D617688;Initial Catalog=QuanLyBanSach;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("Select * from  TacGia where TenTG like N'" + txtTimkiem.Text + "%'", con);
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
        }
    }
}
