namespace BanVeRapChieuPhim.GUI_QuanLyLichChieu
{
    partial class GUI_TrangThai
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
            this.dgvTrangThai = new System.Windows.Forms.DataGridView();
            this.MaTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrangThai)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrangThai
            // 
            this.dgvTrangThai.AllowUserToAddRows = false;
            this.dgvTrangThai.AllowUserToDeleteRows = false;
            this.dgvTrangThai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvTrangThai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrangThai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrangThai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTrangThai,
            this.MoTa});
            this.dgvTrangThai.Location = new System.Drawing.Point(2, 152);
            this.dgvTrangThai.Name = "dgvTrangThai";
            this.dgvTrangThai.ReadOnly = true;
            this.dgvTrangThai.Size = new System.Drawing.Size(1254, 209);
            this.dgvTrangThai.TabIndex = 52;
            // 
            // MaTrangThai
            // 
            this.MaTrangThai.HeaderText = "Mã Trạng Thái";
            this.MaTrangThai.Name = "MaTrangThai";
            this.MaTrangThai.ReadOnly = true;
            // 
            // MoTa
            // 
            this.MoTa.HeaderText = "Mô Tả";
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(541, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 37);
            this.label2.TabIndex = 54;
            this.label2.Text = "TRẠNG THÁI";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1096, 398);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 30);
            this.btnThoat.TabIndex = 53;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // GUI_TrangThai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 450);
            this.Controls.Add(this.dgvTrangThai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThoat);
            this.Name = "GUI_TrangThai";
            this.Text = "GUI_TrangThai";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrangThai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
    }
}