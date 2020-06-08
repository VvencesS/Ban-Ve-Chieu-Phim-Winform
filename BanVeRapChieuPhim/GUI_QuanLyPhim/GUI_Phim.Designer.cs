namespace BanVeRapChieuPhim.GUI_QLPhim
{
    partial class GUI_Phim
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
            this.dgvPhim = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.MaPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnhDaiDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaQuocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhoiChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaoDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trailer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDinhDang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMaPhim = new System.Windows.Forms.Label();
            this.lblTenPhim = new System.Windows.Forms.Label();
            this.lblAnhDaiDien = new System.Windows.Forms.Label();
            this.lblMaTheLoai = new System.Windows.Forms.Label();
            this.lblMaQuocGia = new System.Windows.Forms.Label();
            this.lblThoiLuong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaPhim = new System.Windows.Forms.TextBox();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.txtAnhDaiDien = new System.Windows.Forms.TextBox();
            this.txtMaTheLoai = new System.Windows.Forms.TextBox();
            this.txtMaQuocGia = new System.Windows.Forms.TextBox();
            this.txtThoiLuong = new System.Windows.Forms.TextBox();
            this.txtKhoiChieu = new System.Windows.Forms.TextBox();
            this.txtKetThuc = new System.Windows.Forms.TextBox();
            this.txtDaoDien = new System.Windows.Forms.TextBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.txtTrailer = new System.Windows.Forms.TextBox();
            this.txtMaDinhDang = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhim)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhim
            // 
            this.dgvPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhim,
            this.TenPhim,
            this.AnhDaiDien,
            this.MaTheLoai,
            this.MaQuocGia,
            this.ThoiLuong,
            this.KhoiChieu,
            this.KetThuc,
            this.DaoDien,
            this.NoiDung,
            this.Trailer,
            this.MaDinhDang,
            this.MaNhanVien});
            this.dgvPhim.Location = new System.Drawing.Point(2, 182);
            this.dgvPhim.Name = "dgvPhim";
            this.dgvPhim.RowHeadersWidth = 51;
            this.dgvPhim.RowTemplate.Height = 24;
            this.dgvPhim.Size = new System.Drawing.Size(1659, 273);
            this.dgvPhim.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(1116, 478);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(122, 43);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(1305, 478);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(122, 43);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1478, 478);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(122, 43);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // MaPhim
            // 
            this.MaPhim.HeaderText = "Mã Phim";
            this.MaPhim.MinimumWidth = 6;
            this.MaPhim.Name = "MaPhim";
            this.MaPhim.Width = 125;
            // 
            // TenPhim
            // 
            this.TenPhim.HeaderText = "Tên Phim";
            this.TenPhim.MinimumWidth = 6;
            this.TenPhim.Name = "TenPhim";
            this.TenPhim.Width = 125;
            // 
            // AnhDaiDien
            // 
            this.AnhDaiDien.HeaderText = "Ảnh Đại Diện";
            this.AnhDaiDien.MinimumWidth = 6;
            this.AnhDaiDien.Name = "AnhDaiDien";
            this.AnhDaiDien.Width = 125;
            // 
            // MaTheLoai
            // 
            this.MaTheLoai.HeaderText = "Mã Thể Loại";
            this.MaTheLoai.MinimumWidth = 6;
            this.MaTheLoai.Name = "MaTheLoai";
            this.MaTheLoai.Width = 125;
            // 
            // MaQuocGia
            // 
            this.MaQuocGia.HeaderText = "Mã Quốc Gia";
            this.MaQuocGia.MinimumWidth = 6;
            this.MaQuocGia.Name = "MaQuocGia";
            this.MaQuocGia.Width = 125;
            // 
            // ThoiLuong
            // 
            this.ThoiLuong.HeaderText = "Thời Lượng";
            this.ThoiLuong.MinimumWidth = 6;
            this.ThoiLuong.Name = "ThoiLuong";
            this.ThoiLuong.Width = 125;
            // 
            // KhoiChieu
            // 
            this.KhoiChieu.HeaderText = "Khởi Chiếu";
            this.KhoiChieu.MinimumWidth = 6;
            this.KhoiChieu.Name = "KhoiChieu";
            this.KhoiChieu.Width = 125;
            // 
            // KetThuc
            // 
            this.KetThuc.HeaderText = "Kết Thúc";
            this.KetThuc.MinimumWidth = 6;
            this.KetThuc.Name = "KetThuc";
            this.KetThuc.Width = 125;
            // 
            // DaoDien
            // 
            this.DaoDien.HeaderText = "Đạo Diễn";
            this.DaoDien.MinimumWidth = 6;
            this.DaoDien.Name = "DaoDien";
            this.DaoDien.Width = 125;
            // 
            // NoiDung
            // 
            this.NoiDung.HeaderText = "Nội Dung";
            this.NoiDung.MinimumWidth = 6;
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.Width = 125;
            // 
            // Trailer
            // 
            this.Trailer.HeaderText = "Trailer";
            this.Trailer.MinimumWidth = 6;
            this.Trailer.Name = "Trailer";
            this.Trailer.Width = 125;
            // 
            // MaDinhDang
            // 
            this.MaDinhDang.HeaderText = "Mã Định Dạng";
            this.MaDinhDang.MinimumWidth = 6;
            this.MaDinhDang.Name = "MaDinhDang";
            this.MaDinhDang.Width = 125;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.HeaderText = "Mã Nhân Viên";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.Width = 125;
            // 
            // lblMaPhim
            // 
            this.lblMaPhim.AutoSize = true;
            this.lblMaPhim.Location = new System.Drawing.Point(35, 20);
            this.lblMaPhim.Name = "lblMaPhim";
            this.lblMaPhim.Size = new System.Drawing.Size(62, 17);
            this.lblMaPhim.TabIndex = 4;
            this.lblMaPhim.Text = "Mã Phim";
            // 
            // lblTenPhim
            // 
            this.lblTenPhim.AutoSize = true;
            this.lblTenPhim.Location = new System.Drawing.Point(35, 68);
            this.lblTenPhim.Name = "lblTenPhim";
            this.lblTenPhim.Size = new System.Drawing.Size(68, 17);
            this.lblTenPhim.TabIndex = 5;
            this.lblTenPhim.Text = "Tên Phim";
            // 
            // lblAnhDaiDien
            // 
            this.lblAnhDaiDien.AutoSize = true;
            this.lblAnhDaiDien.Location = new System.Drawing.Point(35, 115);
            this.lblAnhDaiDien.Name = "lblAnhDaiDien";
            this.lblAnhDaiDien.Size = new System.Drawing.Size(91, 17);
            this.lblAnhDaiDien.TabIndex = 6;
            this.lblAnhDaiDien.Text = "Ảnh Đại Diện";
            // 
            // lblMaTheLoai
            // 
            this.lblMaTheLoai.AutoSize = true;
            this.lblMaTheLoai.Location = new System.Drawing.Point(389, 23);
            this.lblMaTheLoai.Name = "lblMaTheLoai";
            this.lblMaTheLoai.Size = new System.Drawing.Size(87, 17);
            this.lblMaTheLoai.TabIndex = 7;
            this.lblMaTheLoai.Text = "Mã Thể Loại";
            // 
            // lblMaQuocGia
            // 
            this.lblMaQuocGia.AutoSize = true;
            this.lblMaQuocGia.Location = new System.Drawing.Point(389, 68);
            this.lblMaQuocGia.Name = "lblMaQuocGia";
            this.lblMaQuocGia.Size = new System.Drawing.Size(91, 17);
            this.lblMaQuocGia.TabIndex = 8;
            this.lblMaQuocGia.Text = "Mã Quốc Gia";
            // 
            // lblThoiLuong
            // 
            this.lblThoiLuong.AutoSize = true;
            this.lblThoiLuong.Location = new System.Drawing.Point(389, 115);
            this.lblThoiLuong.Name = "lblThoiLuong";
            this.lblThoiLuong.Size = new System.Drawing.Size(80, 17);
            this.lblThoiLuong.TabIndex = 9;
            this.lblThoiLuong.Text = "Thời Lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(736, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Khởi Chiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(736, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kết Thúc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(736, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Đạo Diễn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1054, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nội Dung";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1054, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Trailer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1054, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mã Định Dạng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1362, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mã Nhân Viên";
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.Location = new System.Drawing.Point(139, 20);
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.Size = new System.Drawing.Size(187, 22);
            this.txtMaPhim.TabIndex = 17;
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.Location = new System.Drawing.Point(139, 65);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(187, 22);
            this.txtTenPhim.TabIndex = 18;
            // 
            // txtAnhDaiDien
            // 
            this.txtAnhDaiDien.Location = new System.Drawing.Point(139, 115);
            this.txtAnhDaiDien.Name = "txtAnhDaiDien";
            this.txtAnhDaiDien.Size = new System.Drawing.Size(187, 22);
            this.txtAnhDaiDien.TabIndex = 19;
            // 
            // txtMaTheLoai
            // 
            this.txtMaTheLoai.Location = new System.Drawing.Point(496, 23);
            this.txtMaTheLoai.Name = "txtMaTheLoai";
            this.txtMaTheLoai.Size = new System.Drawing.Size(187, 22);
            this.txtMaTheLoai.TabIndex = 20;
            // 
            // txtMaQuocGia
            // 
            this.txtMaQuocGia.Location = new System.Drawing.Point(496, 68);
            this.txtMaQuocGia.Name = "txtMaQuocGia";
            this.txtMaQuocGia.Size = new System.Drawing.Size(187, 22);
            this.txtMaQuocGia.TabIndex = 21;
            // 
            // txtThoiLuong
            // 
            this.txtThoiLuong.Location = new System.Drawing.Point(496, 115);
            this.txtThoiLuong.Name = "txtThoiLuong";
            this.txtThoiLuong.Size = new System.Drawing.Size(187, 22);
            this.txtThoiLuong.TabIndex = 22;
            // 
            // txtKhoiChieu
            // 
            this.txtKhoiChieu.Location = new System.Drawing.Point(818, 23);
            this.txtKhoiChieu.Name = "txtKhoiChieu";
            this.txtKhoiChieu.Size = new System.Drawing.Size(187, 22);
            this.txtKhoiChieu.TabIndex = 23;
            // 
            // txtKetThuc
            // 
            this.txtKetThuc.Location = new System.Drawing.Point(818, 68);
            this.txtKetThuc.Name = "txtKetThuc";
            this.txtKetThuc.Size = new System.Drawing.Size(187, 22);
            this.txtKetThuc.TabIndex = 24;
            // 
            // txtDaoDien
            // 
            this.txtDaoDien.Location = new System.Drawing.Point(818, 115);
            this.txtDaoDien.Name = "txtDaoDien";
            this.txtDaoDien.Size = new System.Drawing.Size(187, 22);
            this.txtDaoDien.TabIndex = 25;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(1156, 25);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(187, 22);
            this.txtNoiDung.TabIndex = 26;
            // 
            // txtTrailer
            // 
            this.txtTrailer.Location = new System.Drawing.Point(1156, 68);
            this.txtTrailer.Name = "txtTrailer";
            this.txtTrailer.Size = new System.Drawing.Size(187, 22);
            this.txtTrailer.TabIndex = 27;
            // 
            // txtMaDinhDang
            // 
            this.txtMaDinhDang.Location = new System.Drawing.Point(1156, 115);
            this.txtMaDinhDang.Name = "txtMaDinhDang";
            this.txtMaDinhDang.Size = new System.Drawing.Size(187, 22);
            this.txtMaDinhDang.TabIndex = 28;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(1465, 25);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(187, 22);
            this.txtMaNhanVien.TabIndex = 29;
            // 
            // GUI_Phim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 547);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.txtMaDinhDang);
            this.Controls.Add(this.txtTrailer);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.txtDaoDien);
            this.Controls.Add(this.txtKetThuc);
            this.Controls.Add(this.txtKhoiChieu);
            this.Controls.Add(this.txtThoiLuong);
            this.Controls.Add(this.txtMaQuocGia);
            this.Controls.Add(this.txtMaTheLoai);
            this.Controls.Add(this.txtAnhDaiDien);
            this.Controls.Add(this.txtTenPhim);
            this.Controls.Add(this.txtMaPhim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblThoiLuong);
            this.Controls.Add(this.lblMaQuocGia);
            this.Controls.Add(this.lblMaTheLoai);
            this.Controls.Add(this.lblAnhDaiDien);
            this.Controls.Add(this.lblTenPhim);
            this.Controls.Add(this.lblMaPhim);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvPhim);
            this.Name = "GUI_Phim";
            this.Text = "GUI_Phim";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhim;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnhDaiDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaQuocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhoiChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn KetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaoDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trailer;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDinhDang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.Label lblMaPhim;
        private System.Windows.Forms.Label lblTenPhim;
        private System.Windows.Forms.Label lblAnhDaiDien;
        private System.Windows.Forms.Label lblMaTheLoai;
        private System.Windows.Forms.Label lblMaQuocGia;
        private System.Windows.Forms.Label lblThoiLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaPhim;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.TextBox txtAnhDaiDien;
        private System.Windows.Forms.TextBox txtMaTheLoai;
        private System.Windows.Forms.TextBox txtMaQuocGia;
        private System.Windows.Forms.TextBox txtThoiLuong;
        private System.Windows.Forms.TextBox txtKhoiChieu;
        private System.Windows.Forms.TextBox txtKetThuc;
        private System.Windows.Forms.TextBox txtDaoDien;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtTrailer;
        private System.Windows.Forms.TextBox txtMaDinhDang;
        private System.Windows.Forms.TextBox txtMaNhanVien;
    }
}