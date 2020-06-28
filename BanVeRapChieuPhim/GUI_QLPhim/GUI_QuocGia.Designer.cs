namespace BanVeRapChieuPhim.GUI_QLPhim
{
    partial class GUI_QuocGia
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
            this.dgvQuocGia = new System.Windows.Forms.DataGridView();
            this.MaQuocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenQuocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaQuocGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenQuocGia = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQuocGia
            // 
            this.dgvQuocGia.AllowUserToAddRows = false;
            this.dgvQuocGia.AllowUserToDeleteRows = false;
            this.dgvQuocGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvQuocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaQuocGia,
            this.TenQuocGia});
            this.dgvQuocGia.Location = new System.Drawing.Point(-1, 152);
            this.dgvQuocGia.Name = "dgvQuocGia";
            this.dgvQuocGia.ReadOnly = true;
            this.dgvQuocGia.RowHeadersWidth = 51;
            this.dgvQuocGia.RowTemplate.Height = 24;
            this.dgvQuocGia.Size = new System.Drawing.Size(1221, 209);
            this.dgvQuocGia.TabIndex = 50;
            // 
            // MaQuocGia
            // 
            this.MaQuocGia.DataPropertyName = "MaQuocGia";
            this.MaQuocGia.HeaderText = "Mã Quốc Gia";
            this.MaQuocGia.MinimumWidth = 6;
            this.MaQuocGia.Name = "MaQuocGia";
            this.MaQuocGia.ReadOnly = true;
            // 
            // TenQuocGia
            // 
            this.TenQuocGia.DataPropertyName = "TenQuocGia";
            this.TenQuocGia.HeaderText = "Tên Quốc Gia";
            this.TenQuocGia.MinimumWidth = 6;
            this.TenQuocGia.Name = "TenQuocGia";
            this.TenQuocGia.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Quốc Gia";
            // 
            // txtMaQuocGia
            // 
            this.txtMaQuocGia.Location = new System.Drawing.Point(132, 94);
            this.txtMaQuocGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaQuocGia.Name = "txtMaQuocGia";
            this.txtMaQuocGia.Size = new System.Drawing.Size(218, 20);
            this.txtMaQuocGia.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Quốc Gia";
            // 
            // txtTenQuocGia
            // 
            this.txtTenQuocGia.Location = new System.Drawing.Point(541, 94);
            this.txtTenQuocGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenQuocGia.Name = "txtTenQuocGia";
            this.txtTenQuocGia.Size = new System.Drawing.Size(238, 20);
            this.txtTenQuocGia.TabIndex = 7;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1117, 384);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(66, 40);
            this.btnThoat.TabIndex = 51;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(543, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 31);
            this.label3.TabIndex = 52;
            this.label3.Text = "Quốc Gia";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(704, 384);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(64, 40);
            this.btnRefresh.TabIndex = 57;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1017, 384);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(68, 40);
            this.btnXoa.TabIndex = 56;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(911, 384);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(71, 40);
            this.btnSua.TabIndex = 55;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(805, 384);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(64, 40);
            this.btnThem.TabIndex = 54;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // GUI_QuocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtTenQuocGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaQuocGia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvQuocGia);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GUI_QuocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_QuocGia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuocGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQuocGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaQuocGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenQuocGia;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaQuocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenQuocGia;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}