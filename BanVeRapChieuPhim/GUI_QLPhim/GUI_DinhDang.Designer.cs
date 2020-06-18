namespace BanVeRapChieuPhim.GUI_QLPhim
{
    partial class GUI_DinhDang
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
            this.dgvDinhDang = new System.Windows.Forms.DataGridView();
            this.MaDinhDang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDinhDang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDinhDang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDinhDang = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDinhDang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDinhDang
            // 
            this.dgvDinhDang.AllowUserToAddRows = false;
            this.dgvDinhDang.AllowUserToDeleteRows = false;
            this.dgvDinhDang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvDinhDang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDinhDang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDinhDang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDinhDang,
            this.TenDinhDang});
            this.dgvDinhDang.Location = new System.Drawing.Point(-1, 152);
            this.dgvDinhDang.Name = "dgvDinhDang";
            this.dgvDinhDang.ReadOnly = true;
            this.dgvDinhDang.RowHeadersWidth = 51;
            this.dgvDinhDang.RowTemplate.Height = 24;
            this.dgvDinhDang.Size = new System.Drawing.Size(1254, 209);
            this.dgvDinhDang.TabIndex = 50;
            // 
            // MaDinhDang
            // 
            this.MaDinhDang.DataPropertyName = "MaDinhDang";
            this.MaDinhDang.HeaderText = "Mã Định Dạng";
            this.MaDinhDang.MinimumWidth = 6;
            this.MaDinhDang.Name = "MaDinhDang";
            this.MaDinhDang.ReadOnly = true;
            // 
            // TenDinhDang
            // 
            this.TenDinhDang.DataPropertyName = "TenDinhDang";
            this.TenDinhDang.HeaderText = "Tên Định Dạng";
            this.TenDinhDang.MinimumWidth = 6;
            this.TenDinhDang.Name = "TenDinhDang";
            this.TenDinhDang.ReadOnly = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(869, 379);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(64, 40);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(975, 379);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(64, 40);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1078, 379);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(64, 40);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Định Dạng";
            // 
            // txtMaDinhDang
            // 
            this.txtMaDinhDang.Location = new System.Drawing.Point(134, 102);
            this.txtMaDinhDang.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaDinhDang.Name = "txtMaDinhDang";
            this.txtMaDinhDang.Size = new System.Drawing.Size(181, 20);
            this.txtMaDinhDang.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Định Dạng";
            // 
            // txtTenDinhDang
            // 
            this.txtTenDinhDang.Location = new System.Drawing.Point(468, 104);
            this.txtTenDinhDang.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenDinhDang.Name = "txtTenDinhDang";
            this.txtTenDinhDang.Size = new System.Drawing.Size(192, 20);
            this.txtTenDinhDang.TabIndex = 7;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1172, 379);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(64, 40);
            this.btnThoat.TabIndex = 51;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(586, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 31);
            this.label3.TabIndex = 52;
            this.label3.Text = "Định Dạng";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(751, 379);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(64, 40);
            this.btnRefresh.TabIndex = 53;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // GUI_DinhDang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtTenDinhDang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaDinhDang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDinhDang);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GUI_DinhDang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_DinhDang";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDinhDang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDinhDang;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDinhDang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDinhDang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDinhDang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDinhDang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRefresh;
    }
}