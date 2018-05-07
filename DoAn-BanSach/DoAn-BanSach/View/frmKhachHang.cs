using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_BanSach.Control;
using DoAn_BanSach.Object;

namespace DoAn_BanSach.View
{
    public partial class frmKhachHang : UserControl
    {
        KhachHangCtr khCtr = new KhachHangCtr();
        private int flagLuu = 0;
        public frmKhachHang()
        {
            InitializeComponent();
        }
        public static frmKhachHang frmKH = new frmKhachHang();
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            
            DataTable dtDS = new System.Data.DataTable();
            dtDS = khCtr.GetData();
            dtgvDS.DataSource = dtDS;
            binhding();
            DisEnl(false);
        }

        private void binhding()
        {
            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text", dtgvDS.DataSource, "MaKH");
            txtTenKH.DataBindings.Clear();
            txtTenKH.DataBindings.Add("Text", dtgvDS.DataSource, "TenKH");
            cbbGioitinh.DataBindings.Clear();
            cbbGioitinh.DataBindings.Add("Text", dtgvDS.DataSource, "GioiTinh");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dtgvDS.DataSource, "DiaChi");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dtgvDS.DataSource, "SoDT");
            
        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaKH.Enabled = e;
            txtTenKH.Enabled = e;
            txtDiaChi.Enabled = e;
            txtSDT.Enabled = e;
            cbbGioitinh.Enabled = e;
        }
        private void loadCMB()
        {
            cbbGioitinh.Items.Clear();
            cbbGioitinh.Items.Add("Nam");
            cbbGioitinh.Items.Add("Nữ");
            cbbGioitinh.SelectedItem = 0;
        }
        private void clearData()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            loadCMB();
        }
        private void addData(KhachHangObj kh)
        {
            kh.MaKhachHang = txtMaKH.Text.Trim();
            if (cbbGioitinh.SelectedIndex == 0)
            {
                kh.GioiTinh = "Nam";
            }
            else
                kh.GioiTinh = "Nữ";
            kh.DiaChi = txtDiaChi.Text.Trim();
            kh.SoDT = txtSDT.Text.Trim();
            kh.TenKhachHang = txtTenKH.Text.Trim();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flagLuu = 0;
            clearData();
            DisEnl(true);
            txtMaKH.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
            loadCMB();
            txtTenKH.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (khCtr.DelData(txtMaKH.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmKhachHang_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            KhachHangObj khObj = new KhachHangObj();
            addData(khObj);
            if (flagLuu == 0)
            {
                if (khCtr.AddData(khObj))
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (khCtr.UpdData(khObj))
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmKhachHang_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frmKhachHang_Load(sender, e);
            else
                return;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       
    }
}
