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
using DoAn_BanSach.Object;

namespace DoAn_BanSach.View
{
    public partial class frmTacgia : UserControl
    {
        TacGiaCtr tgCtr = new TacGiaCtr();
        private int flagLuu = 0;
        public frmTacgia()
        {
            InitializeComponent();
        }
        public static frmTacgia frmTG = new frmTacgia();
        private void frmTacgia_Load(object sender, EventArgs e)
        {
            DataTable dtDS = new System.Data.DataTable();
            dtDS = tgCtr.GetData();
            dtgvDS.DataSource = dtDS;
            bingding();
            DisEnl(false);
        }
        private void bingding()
        {
            txtMaTG.DataBindings.Clear();
            txtMaTG.DataBindings.Add("Text", dtgvDS.DataSource, "MaTG");
            txtTenTG.DataBindings.Clear();
            txtTenTG.DataBindings.Add("Text", dtgvDS.DataSource, "TenTG");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dtgvDS.DataSource, "DiaChi");
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
            txtMaTG.Enabled = e;
            txtTenTG.Enabled = e;
            txtDiaChi.Enabled = e;
            txtSoDT.Enabled = e;
        }
        private void clearData()
        {
            txtMaTG.Text = "";
            txtTenTG.Text = "";
            txtDiaChi.Text = "";
            txtSoDT.Text = "";
        }
        private void addData(TacGiaObj tg)
        {
            tg.Ma = txtMaTG.Text.Trim();
            tg.Ten = txtTenTG.Text.Trim();
            tg.Diachi = txtDiaChi.Text.Trim();
            tg.Sodt = txtSoDT.Text.Trim();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flagLuu = 0;
            clearData();
            DisEnl(true);
            txtMaTG.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
            txtTenTG.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa tác giả này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (tgCtr.DelData(txtMaTG.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmTacgia_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            TacGiaObj tgObj = new TacGiaObj();
            addData(tgObj);
            if (flagLuu == 0)
            {
                if (tgCtr.AddData(tgObj))
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (tgCtr.UpdData(tgObj))
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmTacgia_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frmTacgia_Load(sender, e);
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
    }
}
