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
    public partial class frmTheloai : UserControl
    {
        TheLoaiCtr tlCtr = new TheLoaiCtr();
        private int flagLuu = 0;
        public frmTheloai()
        {
            InitializeComponent();
        }
        public static frmTheloai frmTL = new frmTheloai();
        private void frmTheloai_Load(object sender, EventArgs e)
        {
            DataTable dtDS = new System.Data.DataTable();
            dtDS = tlCtr.GetData();
            dtgvDS.DataSource = dtDS;
            bingding();
            DisEnl(false);
        }
        private void bingding()
        {
            txtMaTL.DataBindings.Clear();
            txtMaTL.DataBindings.Add("Text", dtgvDS.DataSource, "MaTL");
            txtTenTL.DataBindings.Clear();
            txtTenTL.DataBindings.Add("Text", dtgvDS.DataSource, "TenTL");
        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaTL.Enabled = e;
            txtTenTL.Enabled = e;
        }
        private void clearData()
        {
            txtMaTL.Text = "";
            txtTenTL.Text = "";
        }
        private void addData(TheLoaiObj tl)
        {
            tl.Ma = txtMaTL.Text.Trim();
            tl.Ten = txtTenTL.Text.Trim();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flagLuu = 0;
            clearData();
            DisEnl(true);
            txtMaTL.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
            txtTenTL.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa thể loại này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (tlCtr.DelData(txtMaTL.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmTheloai_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            TheLoaiObj tlObj = new TheLoaiObj();
            addData(tlObj);
            if (flagLuu == 0)
            {
                if (tlCtr.AddData(tlObj))
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (tlCtr.UpdData(tlObj))
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmTheloai_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frmTheloai_Load(sender, e);
            else
                return;
        }
    }
}
