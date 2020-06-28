namespace BanVeRapChieuPhim.GUI_QuanLyTaiKhoan
{
    partial class GUI_ThanhVien
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvThanhVien = new System.Windows.Forms.DataGridView();
            this.MaThanhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenXaPhuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenQuanHuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTinhThanhPho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLichSuDatVe = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(473, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 37);
            this.label2.TabIndex = 65;
            this.label2.Text = "QUẢN LÝ THÀNH VIÊN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(1119, 91);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTimKiem.Size = new System.Drawing.Size(90, 30);
            this.btnTimKiem.TabIndex = 58;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTimKiem.Location = new System.Drawing.Point(813, 95);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTimKiem.Size = new System.Drawing.Size(300, 25);
            this.txtTimKiem.TabIndex = 57;
            this.txtTimKiem.Text = "Nhập tên thành viên...";
            // 
            // dgvThanhVien
            // 
            this.dgvThanhVien.AllowUserToAddRows = false;
            this.dgvThanhVien.AllowUserToDeleteRows = false;
            this.dgvThanhVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvThanhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThanhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThanhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThanhVien,
            this.HoVaTen,
            this.Email,
            this.Password,
            this.SDT,
            this.SoThe,
            this.NgaySinh,
            this.GioiTinh,
            this.TrangThai,
            this.TenXaPhuong,
            this.TenQuanHuyen,
            this.TenTinhThanhPho});
            this.dgvThanhVien.Location = new System.Drawing.Point(2, 152);
            this.dgvThanhVien.Name = "dgvThanhVien";
            this.dgvThanhVien.ReadOnly = true;
            this.dgvThanhVien.Size = new System.Drawing.Size(1254, 213);
            this.dgvThanhVien.TabIndex = 56;
            this.dgvThanhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThanhVien_CellClick);
            // 
            // MaThanhVien
            // 
            this.MaThanhVien.DataPropertyName = "MaThanhVien";
            this.MaThanhVien.FillWeight = 335.0254F;
            this.MaThanhVien.HeaderText = "Mã Thành Viên";
            this.MaThanhVien.Name = "MaThanhVien";
            this.MaThanhVien.ReadOnly = true;
            // 
            // HoVaTen
            // 
            this.HoVaTen.DataPropertyName = "HoTen";
            this.HoVaTen.FillWeight = 76.49746F;
            this.HoVaTen.HeaderText = "Họ Và Tên";
            this.HoVaTen.Name = "HoVaTen";
            this.HoVaTen.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.FillWeight = 76.49746F;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "PassWord";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Visible = false;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "Sdt";
            this.SDT.FillWeight = 76.49746F;
            this.SDT.HeaderText = "Số Điện Thoại";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // SoThe
            // 
            this.SoThe.DataPropertyName = "SoThe";
            this.SoThe.FillWeight = 76.49746F;
            this.SoThe.HeaderText = "Số Thẻ";
            this.SoThe.Name = "SoThe";
            this.SoThe.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.FillWeight = 76.49746F;
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.FillWeight = 76.49746F;
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.FillWeight = 76.49746F;
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // TenXaPhuong
            // 
            this.TenXaPhuong.DataPropertyName = "TenXaPhuong";
            this.TenXaPhuong.FillWeight = 76.49746F;
            this.TenXaPhuong.HeaderText = "Xã, Phường";
            this.TenXaPhuong.Name = "TenXaPhuong";
            this.TenXaPhuong.ReadOnly = true;
            // 
            // TenQuanHuyen
            // 
            this.TenQuanHuyen.DataPropertyName = "TenQuanHuyen";
            this.TenQuanHuyen.FillWeight = 76.49746F;
            this.TenQuanHuyen.HeaderText = "Quận, Huyện";
            this.TenQuanHuyen.Name = "TenQuanHuyen";
            this.TenQuanHuyen.ReadOnly = true;
            // 
            // TenTinhThanhPho
            // 
            this.TenTinhThanhPho.DataPropertyName = "TenTinhThanhPho";
            this.TenTinhThanhPho.FillWeight = 76.49746F;
            this.TenTinhThanhPho.HeaderText = "Tỉnh,Thành Phố";
            this.TenTinhThanhPho.Name = "TenTinhThanhPho";
            this.TenTinhThanhPho.ReadOnly = true;
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.Location = new System.Drawing.Point(823, 399);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 30);
            this.btnThoat.TabIndex = 70;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.Location = new System.Drawing.Point(583, 399);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 30);
            this.btnXoa.TabIndex = 69;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.Location = new System.Drawing.Point(463, 399);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 30);
            this.btnSua.TabIndex = 68;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.Location = new System.Drawing.Point(343, 399);
            this.btnThem.Name = "btnThem";
            this.btnThem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThem.Size = new System.Drawing.Size(90, 30);
            this.btnThem.TabIndex = 67;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLichSuDatVe
            // 
            this.btnLichSuDatVe.AutoSize = true;
            this.btnLichSuDatVe.Location = new System.Drawing.Point(703, 399);
            this.btnLichSuDatVe.Name = "btnLichSuDatVe";
            this.btnLichSuDatVe.Size = new System.Drawing.Size(90, 30);
            this.btnLichSuDatVe.TabIndex = 66;
            this.btnLichSuDatVe.Text = "Lịch Sử Đặt Vé";
            this.btnLichSuDatVe.UseVisualStyleBackColor = true;
            this.btnLichSuDatVe.Click += new System.EventHandler(this.btnLichSuDatVe_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.Location = new System.Drawing.Point(219, 399);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRefresh.Size = new System.Drawing.Size(90, 30);
            this.btnRefresh.TabIndex = 71;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // GUI_ThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLichSuDatVe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dgvThanhVien);
            this.Name = "GUI_ThanhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_ThanhVien";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvThanhVien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLichSuDatVe;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThanhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenXaPhuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenQuanHuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTinhThanhPho;
    }
}