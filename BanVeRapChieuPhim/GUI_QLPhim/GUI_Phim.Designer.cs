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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.MaPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnhDaiDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenQuocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhoiChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaoDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trailer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDinhDang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.TenTheLoai,
            this.TenQuocGia,
            this.ThoiLuong,
            this.KhoiChieu,
            this.KetThuc,
            this.DaoDien,
            this.NoiDung,
            this.Trailer,
            this.TenDinhDang,
            this.TenNhanVien});
            this.dgvPhim.Location = new System.Drawing.Point(3, 154);
            this.dgvPhim.Name = "dgvPhim";
            this.dgvPhim.ReadOnly = true;
            this.dgvPhim.RowHeadersWidth = 51;
            this.dgvPhim.RowTemplate.Height = 24;
            this.dgvPhim.Size = new System.Drawing.Size(1254, 209);
            this.dgvPhim.TabIndex = 50;
            this.dgvPhim.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhim_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(820, 388);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(73, 35);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(923, 388);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(70, 35);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1025, 388);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 35);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(710, 98);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(300, 25);
            this.txtTimKiem.TabIndex = 56;
            this.txtTimKiem.Text = "Nhập tên phim....";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(1031, 98);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(69, 24);
            this.btnTimKiem.TabIndex = 51;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1133, 388);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 35);
            this.btnThoat.TabIndex = 57;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(524, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 31);
            this.label1.TabIndex = 58;
            this.label1.Text = "Quản lý Phim";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(717, 388);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(70, 35);
            this.btnRefresh.TabIndex = 59;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // MaPhim
            // 
            this.MaPhim.DataPropertyName = "MaPhim";
            this.MaPhim.HeaderText = "Mã Phim";
            this.MaPhim.MinimumWidth = 6;
            this.MaPhim.Name = "MaPhim";
            this.MaPhim.ReadOnly = true;
            this.MaPhim.Visible = false;
            // 
            // TenPhim
            // 
            this.TenPhim.DataPropertyName = "TenPhim";
            this.TenPhim.HeaderText = "Tên Phim";
            this.TenPhim.MinimumWidth = 6;
            this.TenPhim.Name = "TenPhim";
            this.TenPhim.ReadOnly = true;
            // 
            // AnhDaiDien
            // 
            this.AnhDaiDien.DataPropertyName = "AnhDaiDien";
            this.AnhDaiDien.HeaderText = "Ảnh Đại Diện";
            this.AnhDaiDien.MinimumWidth = 6;
            this.AnhDaiDien.Name = "AnhDaiDien";
            this.AnhDaiDien.ReadOnly = true;
            this.AnhDaiDien.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AnhDaiDien.Visible = false;
            // 
            // TenTheLoai
            // 
            this.TenTheLoai.DataPropertyName = "TenTheLoai";
            this.TenTheLoai.HeaderText = "Tên thể Loại";
            this.TenTheLoai.MinimumWidth = 6;
            this.TenTheLoai.Name = "TenTheLoai";
            this.TenTheLoai.ReadOnly = true;
            // 
            // TenQuocGia
            // 
            this.TenQuocGia.DataPropertyName = "TenQuocGia";
            this.TenQuocGia.HeaderText = "Tên quốc Gia";
            this.TenQuocGia.MinimumWidth = 6;
            this.TenQuocGia.Name = "TenQuocGia";
            this.TenQuocGia.ReadOnly = true;
            // 
            // ThoiLuong
            // 
            this.ThoiLuong.DataPropertyName = "ThoiLuong";
            this.ThoiLuong.HeaderText = "Thời Lượng";
            this.ThoiLuong.MinimumWidth = 6;
            this.ThoiLuong.Name = "ThoiLuong";
            this.ThoiLuong.ReadOnly = true;
            // 
            // KhoiChieu
            // 
            this.KhoiChieu.DataPropertyName = "KhoiChieu";
            this.KhoiChieu.HeaderText = "Khởi Chiếu";
            this.KhoiChieu.MinimumWidth = 6;
            this.KhoiChieu.Name = "KhoiChieu";
            this.KhoiChieu.ReadOnly = true;
            // 
            // KetThuc
            // 
            this.KetThuc.DataPropertyName = "KetThuc";
            this.KetThuc.HeaderText = "Kết Thúc";
            this.KetThuc.MinimumWidth = 6;
            this.KetThuc.Name = "KetThuc";
            this.KetThuc.ReadOnly = true;
            // 
            // DaoDien
            // 
            this.DaoDien.DataPropertyName = "DaoDien";
            this.DaoDien.HeaderText = "Đạo Diễn";
            this.DaoDien.MinimumWidth = 6;
            this.DaoDien.Name = "DaoDien";
            this.DaoDien.ReadOnly = true;
            // 
            // NoiDung
            // 
            this.NoiDung.DataPropertyName = "NoiDung";
            this.NoiDung.HeaderText = "Nội Dung";
            this.NoiDung.MinimumWidth = 6;
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.ReadOnly = true;
            // 
            // Trailer
            // 
            this.Trailer.DataPropertyName = "Trailer";
            this.Trailer.HeaderText = "Trailer";
            this.Trailer.MinimumWidth = 6;
            this.Trailer.Name = "Trailer";
            this.Trailer.ReadOnly = true;
            this.Trailer.Visible = false;
            // 
            // TenDinhDang
            // 
            this.TenDinhDang.DataPropertyName = "TenDinhDang";
            this.TenDinhDang.HeaderText = "Tên định Dạng";
            this.TenDinhDang.MinimumWidth = 6;
            this.TenDinhDang.Name = "TenDinhDang";
            this.TenDinhDang.ReadOnly = true;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "HoTen";
            this.TenNhanVien.HeaderText = "Tên nhân Viên";
            this.TenNhanVien.MinimumWidth = 6;
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.ReadOnly = true;
            // 
            // GUI_Phim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvPhim);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GUI_Phim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_Phim";
            this.Load += new System.EventHandler(this.GUI_Phim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhim;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnhDaiDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenQuocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhoiChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn KetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaoDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trailer;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDinhDang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
    }
}