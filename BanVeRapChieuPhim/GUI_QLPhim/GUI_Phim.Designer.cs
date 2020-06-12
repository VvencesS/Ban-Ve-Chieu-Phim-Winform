﻿namespace BanVeRapChieuPhim.GUI_QLPhim
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhim)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhim
            // 
            this.dgvPhim.AllowUserToAddRows = false;
            this.dgvPhim.AllowUserToDeleteRows = false;
            this.dgvPhim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvPhim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dgvPhim.Location = new System.Drawing.Point(4, 191);
            this.dgvPhim.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPhim.Name = "dgvPhim";
            this.dgvPhim.ReadOnly = true;
            this.dgvPhim.RowHeadersWidth = 51;
            this.dgvPhim.RowTemplate.Height = 24;
            this.dgvPhim.Size = new System.Drawing.Size(1672, 257);
            this.dgvPhim.TabIndex = 50;
            // 
            // MaPhim
            // 
            this.MaPhim.HeaderText = "Mã Phim";
            this.MaPhim.MinimumWidth = 6;
            this.MaPhim.Name = "MaPhim";
            this.MaPhim.ReadOnly = true;
            // 
            // TenPhim
            // 
            this.TenPhim.HeaderText = "Tên Phim";
            this.TenPhim.MinimumWidth = 6;
            this.TenPhim.Name = "TenPhim";
            this.TenPhim.ReadOnly = true;
            // 
            // AnhDaiDien
            // 
            this.AnhDaiDien.HeaderText = "Ảnh Đại Diện";
            this.AnhDaiDien.MinimumWidth = 6;
            this.AnhDaiDien.Name = "AnhDaiDien";
            this.AnhDaiDien.ReadOnly = true;
            // 
            // MaTheLoai
            // 
            this.MaTheLoai.HeaderText = "Mã Thể Loại";
            this.MaTheLoai.MinimumWidth = 6;
            this.MaTheLoai.Name = "MaTheLoai";
            this.MaTheLoai.ReadOnly = true;
            // 
            // MaQuocGia
            // 
            this.MaQuocGia.HeaderText = "Mã Quốc Gia";
            this.MaQuocGia.MinimumWidth = 6;
            this.MaQuocGia.Name = "MaQuocGia";
            this.MaQuocGia.ReadOnly = true;
            // 
            // ThoiLuong
            // 
            this.ThoiLuong.HeaderText = "Thời Lượng";
            this.ThoiLuong.MinimumWidth = 6;
            this.ThoiLuong.Name = "ThoiLuong";
            this.ThoiLuong.ReadOnly = true;
            // 
            // KhoiChieu
            // 
            this.KhoiChieu.HeaderText = "Khởi Chiếu";
            this.KhoiChieu.MinimumWidth = 6;
            this.KhoiChieu.Name = "KhoiChieu";
            this.KhoiChieu.ReadOnly = true;
            // 
            // KetThuc
            // 
            this.KetThuc.HeaderText = "Kết Thúc";
            this.KetThuc.MinimumWidth = 6;
            this.KetThuc.Name = "KetThuc";
            this.KetThuc.ReadOnly = true;
            // 
            // DaoDien
            // 
            this.DaoDien.HeaderText = "Đạo Diễn";
            this.DaoDien.MinimumWidth = 6;
            this.DaoDien.Name = "DaoDien";
            this.DaoDien.ReadOnly = true;
            // 
            // NoiDung
            // 
            this.NoiDung.HeaderText = "Nội Dung";
            this.NoiDung.MinimumWidth = 6;
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.ReadOnly = true;
            // 
            // Trailer
            // 
            this.Trailer.HeaderText = "Trailer";
            this.Trailer.MinimumWidth = 6;
            this.Trailer.Name = "Trailer";
            this.Trailer.ReadOnly = true;
            // 
            // MaDinhDang
            // 
            this.MaDinhDang.HeaderText = "Mã Định Dạng";
            this.MaDinhDang.MinimumWidth = 6;
            this.MaDinhDang.Name = "MaDinhDang";
            this.MaDinhDang.ReadOnly = true;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.HeaderText = "Mã Nhân Viên";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(1094, 478);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 43);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(1231, 478);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 43);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1367, 478);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 43);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(947, 120);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(399, 30);
            this.txtTimKiem.TabIndex = 56;
            this.txtTimKiem.Text = "nhập tên phim....";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(1375, 120);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(92, 30);
            this.btnTimKiem.TabIndex = 51;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1511, 478);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 43);
            this.btnThoat.TabIndex = 57;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(699, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 38);
            this.label1.TabIndex = 58;
            this.label1.Text = "Quản lý Phim";
            // 
            // GUI_Phim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1676, 546);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvPhim);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
    }
}