﻿using DoAn_BanSach.Control;
using DoAn_BanSach.Model;
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
    public partial class frmNhanVien : UserControl
    {
        NhanVienCtr nvCtr = new NhanVienCtr();
        private int flagLuu = 0;
        public frmNhanVien()
        {
            InitializeComponent();
        }
        public static frmNhanVien frmNV = new frmNhanVien();
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dtDS = new System.Data.DataTable();
            dtDS = nvCtr.GetData();
            dtgvDS.DataSource = dtDS;
            binhding();
            DisEnl(false);
        }
        private void binhding()
        {
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", dtgvDS.DataSource, "MaNV");
            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add("Text", dtgvDS.DataSource, "TenNV");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dtgvDS.DataSource, "Email");
            dtimeNgaySinh.DataBindings.Clear();
            dtimeNgaySinh.DataBindings.Add("Text", dtgvDS.DataSource, "NgaySinh");
            cbbGioiTinh.DataBindings.Clear();
            cbbGioiTinh.DataBindings.Add("Text", dtgvDS.DataSource, "GioiTinh");
            txtCMND.DataBindings.Clear();
            txtCMND.DataBindings.Add("Text", dtgvDS.DataSource, "CMND");
        }
        private void loadCMB()
        {
            cbbGioiTinh.Items.Clear();
            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nữ");
            cbbGioiTinh.SelectedItem = 0;
        }
        private void clearData()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtEmail.Text = "";
            txtCMND.Text = "";
            dtimeNgaySinh.Value = DateTime.Now.Date;
            loadCMB();
        }
        private void addData(NhanVienObj nv)
        {
            nv.MaNhanVien = txtMaNV.Text.Trim();
            if (cbbGioiTinh.SelectedIndex == 0)
            {
                nv.Gioitinh = "Nam";
            }
            else
                nv.Gioitinh = "Nữ";
            nv.Email = txtEmail.Text.Trim();
            nv.Cmnd = txtCMND.Text.Trim();
            nv.TenNhanVien = txtTenNV.Text.Trim();
            nv.Ngaysinh = dtimeNgaySinh.Text;
        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaNV.Enabled = e;
            txtTenNV.Enabled = e;
            txtEmail.Enabled = e;
            txtCMND.Enabled = e;
            cbbGioiTinh.Enabled = e;
            dtimeNgaySinh.Enabled = e;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            flagLuu = 0;
            clearData();
            DisEnl(true);
            txtMaNV.Focus();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
            loadCMB();
            txtTenNV.Focus();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (nvCtr.DelData(txtMaNV.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmNhanVien_Load(sender, e);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtTenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
            NhanVienObj nvObj = new NhanVienObj();
            addData(nvObj);
            if (flagLuu == 0)
            {
                if (nvCtr.AddData(nvObj))
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (nvCtr.UpdData(nvObj))
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmNhanVien_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frmNhanVien_Load(sender, e);
            else
                return;
        }
        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
