namespace BanVeRapChieuPhim.GUI_QuanLyLichChieu
{
    partial class GUI_SoGhe
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
            this.dgvSoGhe = new System.Windows.Forms.DataGridView();
            this.SoGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoGhe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSoGhe
            // 
            this.dgvSoGhe.AllowUserToAddRows = false;
            this.dgvSoGhe.AllowUserToDeleteRows = false;
            this.dgvSoGhe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvSoGhe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSoGhe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoGhe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoGhe,
            this.SoHang,
            this.SoCot});
            this.dgvSoGhe.Location = new System.Drawing.Point(2, 152);
            this.dgvSoGhe.Name = "dgvSoGhe";
            this.dgvSoGhe.ReadOnly = true;
            this.dgvSoGhe.Size = new System.Drawing.Size(1254, 209);
            this.dgvSoGhe.TabIndex = 41;
            // 
            // SoGhe
            // 
            this.SoGhe.HeaderText = "Số Ghế";
            this.SoGhe.Name = "SoGhe";
            this.SoGhe.ReadOnly = true;
            // 
            // SoHang
            // 
            this.SoHang.HeaderText = "Số Hàng";
            this.SoHang.Name = "SoHang";
            this.SoHang.ReadOnly = true;
            // 
            // SoCot
            // 
            this.SoCot.HeaderText = "Số Cột";
            this.SoCot.Name = "SoCot";
            this.SoCot.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(507, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 37);
            this.label2.TabIndex = 47;
            this.label2.Text = "QUẢN LÝ SỐ GHẾ";
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
            // GUI_SoGhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvSoGhe);
            this.Controls.Add(this.label2);
            this.Name = "GUI_SoGhe";
            this.Text = "GUI_SoGhe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoGhe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSoGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}