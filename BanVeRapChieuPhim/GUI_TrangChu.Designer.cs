namespace BanVeRapChieuPhim
{
    partial class GUI_TrangChu
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
            this.label2 = new System.Windows.Forms.Label();
            this.mnuTrangChu = new System.Windows.Forms.MenuStrip();
            this.mnuQLPhim = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhim = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDinhDangPhim = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTheLoai = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLLichChieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKTG = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhongChieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGhe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThanhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLDatVe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDSDatVe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoGia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangNhap = new System.Windows.Forms.MenuStrip();
            this.mnuDN_DX = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuTrangChu.SuspendLayout();
            this.mnuDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(412, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 37);
            this.label2.TabIndex = 59;
            this.label2.Text = "QUẢN LÝ BÁN VÉ XEM PHIM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // mnuTrangChu
            // 
            this.mnuTrangChu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQLPhim,
            this.mnuQLLichChieu,
            this.mnuQLTaiKhoan,
            this.mnuQLDatVe});
            this.mnuTrangChu.Location = new System.Drawing.Point(0, 0);
            this.mnuTrangChu.Name = "mnuTrangChu";
            this.mnuTrangChu.Size = new System.Drawing.Size(1159, 24);
            this.mnuTrangChu.TabIndex = 60;
            this.mnuTrangChu.Text = "menuStrip1";
            // 
            // mnuQLPhim
            // 
            this.mnuQLPhim.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPhim,
            this.mnuDinhDangPhim,
            this.mnuQuocGia,
            this.mnuTheLoai});
            this.mnuQLPhim.Name = "mnuQLPhim";
            this.mnuQLPhim.Size = new System.Drawing.Size(91, 20);
            this.mnuQLPhim.Text = "Quản lý phim";
            // 
            // mnuPhim
            // 
            this.mnuPhim.Name = "mnuPhim";
            this.mnuPhim.Size = new System.Drawing.Size(160, 22);
            this.mnuPhim.Text = "Phim";
            this.mnuPhim.Click += new System.EventHandler(this.mnuPhim_Click);
            // 
            // mnuDinhDangPhim
            // 
            this.mnuDinhDangPhim.Name = "mnuDinhDangPhim";
            this.mnuDinhDangPhim.Size = new System.Drawing.Size(160, 22);
            this.mnuDinhDangPhim.Text = "Định dạng phim";
            this.mnuDinhDangPhim.Click += new System.EventHandler(this.mnuDinhDangPhim_Click);
            // 
            // mnuQuocGia
            // 
            this.mnuQuocGia.Name = "mnuQuocGia";
            this.mnuQuocGia.Size = new System.Drawing.Size(160, 22);
            this.mnuQuocGia.Text = "Quốc gia";
            this.mnuQuocGia.Click += new System.EventHandler(this.mnuQuocGia_Click);
            // 
            // mnuTheLoai
            // 
            this.mnuTheLoai.Name = "mnuTheLoai";
            this.mnuTheLoai.Size = new System.Drawing.Size(160, 22);
            this.mnuTheLoai.Text = "Thể loại";
            this.mnuTheLoai.Click += new System.EventHandler(this.mnuTheLoai_Click);
            // 
            // mnuQLLichChieu
            // 
            this.mnuQLLichChieu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKTG,
            this.mnuPhongChieu,
            this.mnuGhe});
            this.mnuQLLichChieu.Name = "mnuQLLichChieu";
            this.mnuQLLichChieu.Size = new System.Drawing.Size(145, 20);
            this.mnuQLLichChieu.Text = "Quản lý lịch chiếu phim";
            // 
            // mnuKTG
            // 
            this.mnuKTG.Name = "mnuKTG";
            this.mnuKTG.Size = new System.Drawing.Size(159, 22);
            this.mnuKTG.Text = "Khung thời gian";
            this.mnuKTG.Click += new System.EventHandler(this.mnuKTG_Click);
            // 
            // mnuPhongChieu
            // 
            this.mnuPhongChieu.Name = "mnuPhongChieu";
            this.mnuPhongChieu.Size = new System.Drawing.Size(159, 22);
            this.mnuPhongChieu.Text = "Phòng chiếu";
            this.mnuPhongChieu.Click += new System.EventHandler(this.mnuPhongChieu_Click);
            // 
            // mnuGhe
            // 
            this.mnuGhe.Name = "mnuGhe";
            this.mnuGhe.Size = new System.Drawing.Size(159, 22);
            this.mnuGhe.Text = "Ghế";
            this.mnuGhe.Click += new System.EventHandler(this.mnuGhe_Click);
            // 
            // mnuQLTaiKhoan
            // 
            this.mnuQLTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhanVien,
            this.mnuThanhVien});
            this.mnuQLTaiKhoan.Name = "mnuQLTaiKhoan";
            this.mnuQLTaiKhoan.Size = new System.Drawing.Size(112, 20);
            this.mnuQLTaiKhoan.Text = "Quản lý tài khoản";
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(132, 22);
            this.mnuNhanVien.Text = "Nhân viên ";
            this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
            // 
            // mnuThanhVien
            // 
            this.mnuThanhVien.Name = "mnuThanhVien";
            this.mnuThanhVien.Size = new System.Drawing.Size(132, 22);
            this.mnuThanhVien.Text = "Thành viên";
            this.mnuThanhVien.Click += new System.EventHandler(this.mnuThanhVien_Click);
            // 
            // mnuQLDatVe
            // 
            this.mnuQLDatVe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVe,
            this.mnuDSDatVe,
            this.mnuBaoGia});
            this.mnuQLDatVe.Name = "mnuQLDatVe";
            this.mnuQLDatVe.Size = new System.Drawing.Size(95, 20);
            this.mnuQLDatVe.Text = "Quản lý đặt vé";
            // 
            // mnuVe
            // 
            this.mnuVe.Name = "mnuVe";
            this.mnuVe.Size = new System.Drawing.Size(180, 22);
            this.mnuVe.Text = "Vé";
            this.mnuVe.Click += new System.EventHandler(this.mnuVe_Click);
            // 
            // mnuDSDatVe
            // 
            this.mnuDSDatVe.Name = "mnuDSDatVe";
            this.mnuDSDatVe.Size = new System.Drawing.Size(180, 22);
            this.mnuDSDatVe.Text = "Danh sách vé đặt";
            this.mnuDSDatVe.Click += new System.EventHandler(this.mnuDSDatVe_Click);
            // 
            // mnuBaoGia
            // 
            this.mnuBaoGia.Name = "mnuBaoGia";
            this.mnuBaoGia.Size = new System.Drawing.Size(180, 22);
            this.mnuBaoGia.Text = "Báo giá";
            this.mnuBaoGia.Click += new System.EventHandler(this.mnuBaoGia_Click);
            // 
            // mnuDangNhap
            // 
            this.mnuDangNhap.Dock = System.Windows.Forms.DockStyle.Right;
            this.mnuDangNhap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDN_DX});
            this.mnuDangNhap.Location = new System.Drawing.Point(1159, 0);
            this.mnuDangNhap.Name = "mnuDangNhap";
            this.mnuDangNhap.Size = new System.Drawing.Size(83, 540);
            this.mnuDangNhap.TabIndex = 61;
            this.mnuDangNhap.Text = "menuStrip2";
            // 
            // mnuDN_DX
            // 
            this.mnuDN_DX.Name = "mnuDN_DX";
            this.mnuDN_DX.Size = new System.Drawing.Size(70, 19);
            this.mnuDN_DX.Text = "Đăng nhập";
            this.mnuDN_DX.Click += new System.EventHandler(this.mnuDN_DX_Click);
            // 
            // label1
            // 
            this.label1.Image = global::BanVeRapChieuPhim.Properties.Resources.beta_slide;
            this.label1.Location = new System.Drawing.Point(0, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1242, 479);
            this.label1.TabIndex = 62;
            // 
            // GUI_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mnuTrangChu);
            this.Controls.Add(this.mnuDangNhap);
            this.MainMenuStrip = this.mnuTrangChu;
            this.Name = "GUI_TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.GUI_TrangChu_Load);
            this.mnuTrangChu.ResumeLayout(false);
            this.mnuTrangChu.PerformLayout();
            this.mnuDangNhap.ResumeLayout(false);
            this.mnuDangNhap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip mnuTrangChu;
        private System.Windows.Forms.ToolStripMenuItem mnuQLPhim;
        private System.Windows.Forms.ToolStripMenuItem mnuPhim;
        private System.Windows.Forms.ToolStripMenuItem mnuDinhDangPhim;
        private System.Windows.Forms.ToolStripMenuItem mnuQuocGia;
        private System.Windows.Forms.ToolStripMenuItem mnuTheLoai;
        private System.Windows.Forms.ToolStripMenuItem mnuQLLichChieu;
        private System.Windows.Forms.ToolStripMenuItem mnuKTG;
        private System.Windows.Forms.ToolStripMenuItem mnuPhongChieu;
        private System.Windows.Forms.ToolStripMenuItem mnuGhe;
        private System.Windows.Forms.ToolStripMenuItem mnuQLTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuThanhVien;
        private System.Windows.Forms.ToolStripMenuItem mnuQLDatVe;
        private System.Windows.Forms.ToolStripMenuItem mnuVe;
        private System.Windows.Forms.ToolStripMenuItem mnuDSDatVe;
        private System.Windows.Forms.MenuStrip mnuDangNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuDN_DX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoGia;
    }
}