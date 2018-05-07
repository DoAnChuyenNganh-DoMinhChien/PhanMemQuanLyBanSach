using System.Windows.Forms;

namespace DoAn_BanSach
{
    partial class frmTrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangChu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhàXuấtBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýThểLoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnBánSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuNhậpSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inPhiếuNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhiếuNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmNhàXuấtBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxtmenuTabHienTai = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.đóngTrangHiệnTạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đóngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabHienThi = new System.Windows.Forms.TabControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.ctxtmenuTabHienTai.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem,
            this.báoCáoToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.thôngTinToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(997, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýKháchHàngToolStripMenuItem,
            this.quảnLýNhàXuấtBảnToolStripMenuItem,
            this.quảnLýTácGiảToolStripMenuItem,
            this.quảnLýThểLoạiToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýToolStripMenuItem.Image")));
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản lý chung";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý Nhân Viên";
            this.quảnLýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhânViênToolStripMenuItem_Click);
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            this.quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            this.quảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý Khách Hàng";
            this.quảnLýKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKháchHàngToolStripMenuItem_Click);
            // 
            // quảnLýNhàXuấtBảnToolStripMenuItem
            // 
            this.quảnLýNhàXuấtBảnToolStripMenuItem.Name = "quảnLýNhàXuấtBảnToolStripMenuItem";
            this.quảnLýNhàXuấtBảnToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.quảnLýNhàXuấtBảnToolStripMenuItem.Text = "Quản lý Nhà Xuất Bản";
            this.quảnLýNhàXuấtBảnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhàXuấtBảnToolStripMenuItem_Click);
            // 
            // quảnLýTácGiảToolStripMenuItem
            // 
            this.quảnLýTácGiảToolStripMenuItem.Name = "quảnLýTácGiảToolStripMenuItem";
            this.quảnLýTácGiảToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.quảnLýTácGiảToolStripMenuItem.Text = "Quản Lý Tác Giả";
            this.quảnLýTácGiảToolStripMenuItem.Click += new System.EventHandler(this.quảnLýTácGiảToolStripMenuItem_Click);
            // 
            // quảnLýThểLoạiToolStripMenuItem
            // 
            this.quảnLýThểLoạiToolStripMenuItem.Name = "quảnLýThểLoạiToolStripMenuItem";
            this.quảnLýThểLoạiToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.quảnLýThểLoạiToolStripMenuItem.Text = "Quản Lý Thể Loại";
            this.quảnLýThểLoạiToolStripMenuItem.Click += new System.EventHandler(this.quảnLýThểLoạiToolStripMenuItem_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hóaĐơnBánSáchToolStripMenuItem,
            this.phiếuNhậpSáchToolStripMenuItem});
            this.hóaĐơnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hóaĐơnToolStripMenuItem.Image")));
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            // 
            // hóaĐơnBánSáchToolStripMenuItem
            // 
            this.hóaĐơnBánSáchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inHóaĐơnToolStripMenuItem,
            this.quảnLýHóaĐơnToolStripMenuItem});
            this.hóaĐơnBánSáchToolStripMenuItem.Name = "hóaĐơnBánSáchToolStripMenuItem";
            this.hóaĐơnBánSáchToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.hóaĐơnBánSáchToolStripMenuItem.Text = "Hóa đơn bán Sách";
            // 
            // inHóaĐơnToolStripMenuItem
            // 
            this.inHóaĐơnToolStripMenuItem.Name = "inHóaĐơnToolStripMenuItem";
            this.inHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.inHóaĐơnToolStripMenuItem.Text = "In hóa đơn";
            // 
            // quảnLýHóaĐơnToolStripMenuItem
            // 
            this.quảnLýHóaĐơnToolStripMenuItem.Name = "quảnLýHóaĐơnToolStripMenuItem";
            this.quảnLýHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.quảnLýHóaĐơnToolStripMenuItem.Text = "Quản lý hóa đơn";
            // 
            // phiếuNhậpSáchToolStripMenuItem
            // 
            this.phiếuNhậpSáchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inPhiếuNhậpToolStripMenuItem,
            this.quảnLýPhiếuNhậpToolStripMenuItem});
            this.phiếuNhậpSáchToolStripMenuItem.Name = "phiếuNhậpSáchToolStripMenuItem";
            this.phiếuNhậpSáchToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.phiếuNhậpSáchToolStripMenuItem.Text = "Phiếu nhập Sách";
            // 
            // inPhiếuNhậpToolStripMenuItem
            // 
            this.inPhiếuNhậpToolStripMenuItem.Name = "inPhiếuNhậpToolStripMenuItem";
            this.inPhiếuNhậpToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.inPhiếuNhậpToolStripMenuItem.Text = "In phiếu nhập";
            // 
            // quảnLýPhiếuNhậpToolStripMenuItem
            // 
            this.quảnLýPhiếuNhậpToolStripMenuItem.Name = "quảnLýPhiếuNhậpToolStripMenuItem";
            this.quảnLýPhiếuNhậpToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.quảnLýPhiếuNhậpToolStripMenuItem.Text = "Quản lý phiếu nhập";
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmKiếmKháchHàngToolStripMenuItem,
            this.tìmKiếmNhânViênToolStripMenuItem,
            this.tìmKiếmNhàXuấtBảnToolStripMenuItem,
            this.tìmKiếmTácGiảToolStripMenuItem});
            this.tìmKiếmToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tìmKiếmToolStripMenuItem.Image")));
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
            // 
            // tìmKiếmKháchHàngToolStripMenuItem
            // 
            this.tìmKiếmKháchHàngToolStripMenuItem.Name = "tìmKiếmKháchHàngToolStripMenuItem";
            this.tìmKiếmKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.tìmKiếmKháchHàngToolStripMenuItem.Text = "Tìm kiếm Khách Hàng";
            this.tìmKiếmKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmKháchHàngToolStripMenuItem_Click_1);
            // 
            // tìmKiếmNhânViênToolStripMenuItem
            // 
            this.tìmKiếmNhânViênToolStripMenuItem.Name = "tìmKiếmNhânViênToolStripMenuItem";
            this.tìmKiếmNhânViênToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.tìmKiếmNhânViênToolStripMenuItem.Text = "Tìm kiếm Nhân Viên";
            this.tìmKiếmNhânViênToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmNhânViênToolStripMenuItem_Click);
            // 
            // tìmKiếmNhàXuấtBảnToolStripMenuItem
            // 
            this.tìmKiếmNhàXuấtBảnToolStripMenuItem.Name = "tìmKiếmNhàXuấtBảnToolStripMenuItem";
            this.tìmKiếmNhàXuấtBảnToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.tìmKiếmNhàXuấtBảnToolStripMenuItem.Text = "Tìm kiếm Nhà Xuất Bản";
            this.tìmKiếmNhàXuấtBảnToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmNhàXuấtBảnToolStripMenuItem_Click);
            // 
            // tìmKiếmTácGiảToolStripMenuItem
            // 
            this.tìmKiếmTácGiảToolStripMenuItem.Name = "tìmKiếmTácGiảToolStripMenuItem";
            this.tìmKiếmTácGiảToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.tìmKiếmTácGiảToolStripMenuItem.Text = "Tìm kiếm Tác Giả";
            this.tìmKiếmTácGiảToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmTácGiảToolStripMenuItem_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("báoCáoToolStripMenuItem.Image")));
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thốngKêToolStripMenuItem.Image")));
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thôngTinToolStripMenuItem.Image")));
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thoátToolStripMenuItem.Image")));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // ctxtmenuTabHienTai
            // 
            this.ctxtmenuTabHienTai.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đóngTrangHiệnTạiToolStripMenuItem,
            this.đóngToolStripMenuItem});
            this.ctxtmenuTabHienTai.Name = "ctxtmenuTabHienTai";
            this.ctxtmenuTabHienTai.Size = new System.Drawing.Size(188, 48);
            // 
            // đóngTrangHiệnTạiToolStripMenuItem
            // 
            this.đóngTrangHiệnTạiToolStripMenuItem.Name = "đóngTrangHiệnTạiToolStripMenuItem";
            this.đóngTrangHiệnTạiToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.đóngTrangHiệnTạiToolStripMenuItem.Text = "Đóng trang hiện tại";
            this.đóngTrangHiệnTạiToolStripMenuItem.Click += new System.EventHandler(this.đóngTrangHiệnTạiToolStripMenuItem_Click);
            // 
            // đóngToolStripMenuItem
            // 
            this.đóngToolStripMenuItem.Name = "đóngToolStripMenuItem";
            this.đóngToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.đóngToolStripMenuItem.Text = "Đóng tất cả các trang";
            this.đóngToolStripMenuItem.Click += new System.EventHandler(this.đóngToolStripMenuItem_Click);
            // 
            // TabHienThi
            // 
            this.TabHienThi.ContextMenuStrip = this.ctxtmenuTabHienTai;
            this.TabHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabHienThi.ImageList = this.imageList1;
            this.TabHienThi.Location = new System.Drawing.Point(0, 24);
            this.TabHienThi.Name = "TabHienThi";
            this.TabHienThi.SelectedIndex = 0;
            this.TabHienThi.Size = new System.Drawing.Size(997, 554);
            this.TabHienThi.TabIndex = 2;
            this.TabHienThi.SelectedIndexChanged += new System.EventHandler(this.TabHienThi_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "logo.jpg");
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 578);
            this.Controls.Add(this.TabHienThi);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTrangChu";
            this.Text = "Quản lý Bán Sách";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ctxtmenuTabHienTai.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhàXuấtBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnBánSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuNhậpSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inPhiếuNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhiếuNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctxtmenuTabHienTai;
        private System.Windows.Forms.ToolStripMenuItem đóngTrangHiệnTạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đóngToolStripMenuItem;
        private TabControl TabHienThi;
        private ToolStripMenuItem thôngTinToolStripMenuItem;
        private ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private ToolStripMenuItem tìmKiếmKháchHàngToolStripMenuItem;
        private ToolStripMenuItem tìmKiếmNhânViênToolStripMenuItem;
        private ToolStripMenuItem tìmKiếmNhàXuấtBảnToolStripMenuItem;
        private ToolStripMenuItem quảnLýTácGiảToolStripMenuItem;
        private ToolStripMenuItem quảnLýThểLoạiToolStripMenuItem;
        private ToolStripMenuItem tìmKiếmTácGiảToolStripMenuItem;
        private ImageList imageList1;
    }
}

