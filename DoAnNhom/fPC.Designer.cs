﻿namespace DoAnNhom
{
    partial class fPC
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
            this.dataGridViewPC = new System.Windows.Forms.DataGridView();
            this.pPC = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblTenPC = new System.Windows.Forms.Label();
            this.lblMaPC = new System.Windows.Forms.Label();
            this.txtNgayNhap = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenPC = new System.Windows.Forms.TextBox();
            this.txtMaPC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPC)).BeginInit();
            this.pPC.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPC
            // 
            this.dataGridViewPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPC.Location = new System.Drawing.Point(248, 241);
            this.dataGridViewPC.Name = "dataGridViewPC";
            this.dataGridViewPC.RowHeadersWidth = 51;
            this.dataGridViewPC.RowTemplate.Height = 24;
            this.dataGridViewPC.Size = new System.Drawing.Size(969, 322);
            this.dataGridViewPC.TabIndex = 3;
            // 
            // pPC
            // 
            this.pPC.Controls.Add(this.btnThem);
            this.pPC.Controls.Add(this.btnSua);
            this.pPC.Controls.Add(this.btnXoa);
            this.pPC.Controls.Add(this.lblNgayNhap);
            this.pPC.Controls.Add(this.lblDonGia);
            this.pPC.Controls.Add(this.lblSoLuong);
            this.pPC.Controls.Add(this.lblTenPC);
            this.pPC.Controls.Add(this.lblMaPC);
            this.pPC.Controls.Add(this.txtNgayNhap);
            this.pPC.Controls.Add(this.txtDonGia);
            this.pPC.Controls.Add(this.txtSoLuong);
            this.pPC.Controls.Add(this.txtTenPC);
            this.pPC.Controls.Add(this.txtMaPC);
            this.pPC.Location = new System.Drawing.Point(248, 27);
            this.pPC.Name = "pPC";
            this.pPC.Size = new System.Drawing.Size(969, 215);
            this.pPC.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(489, 158);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 33);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(757, 158);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 33);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(619, 158);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 33);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Location = new System.Drawing.Point(486, 97);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(73, 16);
            this.lblNgayNhap.TabIndex = 0;
            this.lblNgayNhap.Text = "Ngày nhập";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(486, 34);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(53, 16);
            this.lblDonGia.TabIndex = 0;
            this.lblDonGia.Text = "Đơn giá";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(85, 160);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(60, 16);
            this.lblSoLuong.TabIndex = 0;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // lblTenPC
            // 
            this.lblTenPC.AutoSize = true;
            this.lblTenPC.Location = new System.Drawing.Point(85, 97);
            this.lblTenPC.Name = "lblTenPC";
            this.lblTenPC.Size = new System.Drawing.Size(52, 16);
            this.lblTenPC.TabIndex = 0;
            this.lblTenPC.Text = "Tên PC";
            // 
            // lblMaPC
            // 
            this.lblMaPC.AutoSize = true;
            this.lblMaPC.Location = new System.Drawing.Point(85, 34);
            this.lblMaPC.Name = "lblMaPC";
            this.lblMaPC.Size = new System.Drawing.Size(47, 16);
            this.lblMaPC.TabIndex = 0;
            this.lblMaPC.Text = "Mã PC";
            // 
            // txtNgayNhap
            // 
            this.txtNgayNhap.Location = new System.Drawing.Point(587, 84);
            this.txtNgayNhap.Multiline = true;
            this.txtNgayNhap.Name = "txtNgayNhap";
            this.txtNgayNhap.Size = new System.Drawing.Size(272, 33);
            this.txtNgayNhap.TabIndex = 1;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(587, 21);
            this.txtDonGia.Multiline = true;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(272, 33);
            this.txtDonGia.TabIndex = 1;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(160, 147);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(272, 33);
            this.txtSoLuong.TabIndex = 1;
            // 
            // txtTenPC
            // 
            this.txtTenPC.Location = new System.Drawing.Point(160, 84);
            this.txtTenPC.Multiline = true;
            this.txtTenPC.Name = "txtTenPC";
            this.txtTenPC.Size = new System.Drawing.Size(272, 33);
            this.txtTenPC.TabIndex = 1;
            // 
            // txtMaPC
            // 
            this.txtMaPC.Location = new System.Drawing.Point(160, 21);
            this.txtMaPC.Multiline = true;
            this.txtMaPC.Name = "txtMaPC";
            this.txtMaPC.Size = new System.Drawing.Size(272, 33);
            this.txtMaPC.TabIndex = 1;
            // 
            // fPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1272, 590);
            this.Controls.Add(this.pPC);
            this.Controls.Add(this.dataGridViewPC);
            this.Name = "fPC";
            this.Text = "PC";
            this.Load += new System.EventHandler(this.fPC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPC)).EndInit();
            this.pPC.ResumeLayout(false);
            this.pPC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewPC;
        private System.Windows.Forms.Panel pPC;
        private System.Windows.Forms.Label lblMaPC;
        private System.Windows.Forms.TextBox txtMaPC;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblTenPC;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenPC;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.TextBox txtNgayNhap;
    }
}