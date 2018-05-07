using DoAn_BanSach.Control;
using DoAn_BanSach.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_BanSach.View
{
    public partial class frmNhaXuatBan : UserControl
    {
        NhaXuatBanCtr nxbCtr = new NhaXuatBanCtr();
        private int flagLuu = 0;
        public frmNhaXuatBan()
        {
            InitializeComponent();
        }
        public static frmNhaXuatBan frmNXB = new frmNhaXuatBan();
       
        private void frmNhaXuatBan_Load(object sender, EventArgs e)
        {
            DataTable dtDS = new System.Data.DataTable();
            dtDS = nxbCtr.GetData();
            dtgvDS.DataSource = dtDS;
            binhding();
            DisEnl(false);
        }

        private void binhding()
        {
            txtMaNXB.DataBindings.Clear();
            txtMaNXB.DataBindings.Add("Text", dtgvDS.DataSource, "MaNXB");
            txtTenNXB.DataBindings.Clear();
            txtTenNXB.DataBindings.Add("Text", dtgvDS.DataSource, "TenNXB");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dtgvDS.DataSource, "DiaChi");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dtgvDS.DataSource, "Email");
            txtSoDT.DataBindings.Clear();
            txtSoDT.DataBindings.Add("Text", dtgvDS.DataSource, "SoDT");

        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaNXB.Enabled = e;
            txtTenNXB.Enabled = e;
            txtDiaChi.Enabled = e;
            txtSoDT.Enabled = e;
            txtEmail.Enabled = e;
        }
        private void clearData()
        {
            txtMaNXB.Text = "";
            txtTenNXB.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtSoDT.Text = "";
        }
        private void addData(NhaXuatBanObj nxb)
        {
            nxb.MaNhaXuatBan = txtMaNXB.Text.Trim();
            nxb.TenNhaXuatBan = txtTenNXB.Text.Trim();
            nxb.DiaChi = txtDiaChi.Text.Trim();
            nxb.Email = txtEmail.Text.Trim();
            nxb.SoDT = txtSoDT.Text.Trim();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flagLuu = 0;
            clearData();
            DisEnl(true);
            txtMaNXB.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
            txtTenNXB.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa nhà xuất bản này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (nxbCtr.DelData(txtMaNXB.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmNhaXuatBan_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhaXuatBanObj khObj = new NhaXuatBanObj();
            addData(khObj);
            if (flagLuu == 0)
            {
                if (nxbCtr.AddData(khObj))
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (nxbCtr.UpdData(khObj))
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmNhaXuatBan_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frmNhaXuatBan_Load(sender, e);
            else
                return;
        }
        private void txtSoDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
