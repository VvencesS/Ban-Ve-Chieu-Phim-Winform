namespace BanVeRapChieuPhim.GUI_QuanLyLichChieu
{
    partial class GUI_LoaiGhe
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
            this.dgvLoaiGhe = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lbTenLoaiGhe = new System.Windows.Forms.Label();
            this.txtTenLoaiGhe = new System.Windows.Forms.TextBox();
            this.lbMaLoaiGhe = new System.Windows.Forms.Label();
            this.txtMaLoaiGhe = new System.Windows.Forms.TextBox();
            this.MaLoaiGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiGhe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoaiGhe
            // 
            this.dgvLoaiGhe.AllowUserToAddRows = false;
            this.dgvLoaiGhe.AllowUserToDeleteRows = false;
            this.dgvLoaiGhe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvLoaiGhe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiGhe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiGhe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiGhe,
            this.TenLoai});
            this.dgvLoaiGhe.Location = new System.Drawing.Point(2, 152);
            this.dgvLoaiGhe.Name = "dgvLoaiGhe";
            this.dgvLoaiGhe.ReadOnly = true;
            this.dgvLoaiGhe.Size = new System.Drawing.Size(1254, 209);
            this.dgvLoaiGhe.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(495, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 37);
            this.label2.TabIndex = 59;
            this.label2.Text = "QUẢN LÝ LOẠI GHẾ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.Location = new System.Drawing.Point(764, 399);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 30);
            this.btnThoat.TabIndex = 85;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.Location = new System.Drawing.Point(644, 399);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 30);
            this.btnXoa.TabIndex = 84;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.Location = new System.Drawing.Point(524, 399);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 30);
            this.btnSua.TabIndex = 83;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.Location = new System.Drawing.Point(404, 399);
            this.btnThem.Name = "btnThem";
            this.btnThem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThem.Size = new System.Drawing.Size(90, 30);
            this.btnThem.TabIndex = 82;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // lbTenLoaiGhe
            // 
            this.lbTenLoaiGhe.AutoSize = true;
            this.lbTenLoaiGhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenLoaiGhe.Location = new System.Drawing.Point(80, 108);
            this.lbTenLoaiGhe.Name = "lbTenLoaiGhe";
            this.lbTenLoaiGhe.Size = new System.Drawing.Size(89, 16);
            this.lbTenLoaiGhe.TabIndex = 89;
            this.lbTenLoaiGhe.Text = "Tên Loại Ghế";
            // 
            // txtTenLoaiGhe
            // 
            this.txtTenLoaiGhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiGhe.Location = new System.Drawing.Point(214, 105);
            this.txtTenLoaiGhe.Name = "txtTenLoaiGhe";
            this.txtTenLoaiGhe.Size = new System.Drawing.Size(230, 22);
            this.txtTenLoaiGhe.TabIndex = 88;
            // 
            // lbMaLoaiGhe
            // 
            this.lbMaLoaiGhe.AutoSize = true;
            this.lbMaLoaiGhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLoaiGhe.Location = new System.Drawing.Point(80, 80);
            this.lbMaLoaiGhe.Name = "lbMaLoaiGhe";
            this.lbMaLoaiGhe.Size = new System.Drawing.Size(84, 16);
            this.lbMaLoaiGhe.TabIndex = 87;
            this.lbMaLoaiGhe.Text = "Mã Loại Ghế";
            // 
            // txtMaLoaiGhe
            // 
            this.txtMaLoaiGhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoaiGhe.Location = new System.Drawing.Point(214, 77);
            this.txtMaLoaiGhe.Name = "txtMaLoaiGhe";
            this.txtMaLoaiGhe.Size = new System.Drawing.Size(230, 22);
            this.txtMaLoaiGhe.TabIndex = 86;
            // 
            // MaLoaiGhe
            // 
            this.MaLoaiGhe.DataPropertyName = "MaLoaiGhe";
            this.MaLoaiGhe.HeaderText = "Mã Loại Ghế";
            this.MaLoaiGhe.Name = "MaLoaiGhe";
            this.MaLoaiGhe.ReadOnly = true;
            // 
            // TenLoai
            // 
            this.TenLoai.DataPropertyName = "TenLoai";
            this.TenLoai.HeaderText = "Tên Loại Ghế";
            this.TenLoai.Name = "TenLoai";
            this.TenLoai.ReadOnly = true;
            // 
            // GUI_LoaiGhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 450);
            this.Controls.Add(this.lbTenLoaiGhe);
            this.Controls.Add(this.txtTenLoaiGhe);
            this.Controls.Add(this.lbMaLoaiGhe);
            this.Controls.Add(this.txtMaLoaiGhe);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvLoaiGhe);
            this.Controls.Add(this.label2);
            this.Name = "GUI_LoaiGhe";
            this.Text = "GUI_LoaiGhe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiGhe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoaiGhe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbTenLoaiGhe;
        private System.Windows.Forms.TextBox txtTenLoaiGhe;
        private System.Windows.Forms.Label lbMaLoaiGhe;
        private System.Windows.Forms.TextBox txtMaLoaiGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
    }
}