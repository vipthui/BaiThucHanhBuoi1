﻿namespace BaiTapThietKeForm
{
    partial class frmBai2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnChonHang = new System.Windows.Forms.Button();
            this.btnBohang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnChonHang);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(46, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 285);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblSoTien);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnTinhTien);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Controls.Add(this.btnBohang);
            this.panel2.Location = new System.Drawing.Point(391, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 285);
            this.panel2.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Chuột",
            "Bàn phím",
            "Máy in",
            "USB Kingmax"});
            this.listBox1.Location = new System.Drawing.Point(18, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(156, 134);
            this.listBox1.TabIndex = 1;
            // 
            // btnChonHang
            // 
            this.btnChonHang.Location = new System.Drawing.Point(219, 78);
            this.btnChonHang.Name = "btnChonHang";
            this.btnChonHang.Size = new System.Drawing.Size(82, 23);
            this.btnChonHang.TabIndex = 2;
            this.btnChonHang.Text = "Chọn hàng > \r\n";
            this.btnChonHang.UseVisualStyleBackColor = true;
            this.btnChonHang.Click += new System.EventHandler(this.btnChonHang_Click);
            // 
            // btnBohang
            // 
            this.btnBohang.Location = new System.Drawing.Point(26, 78);
            this.btnBohang.Name = "btnBohang";
            this.btnBohang.Size = new System.Drawing.Size(81, 23);
            this.btnBohang.TabIndex = 3;
            this.btnBohang.Text = "< Bỏ hàng";
            this.btnBohang.UseVisualStyleBackColor = true;
            this.btnBohang.Click += new System.EventHandler(this.btnBohang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh sách hàng hóa";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(158, 55);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(156, 134);
            this.listBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Các mặt hàng khác mua";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(131, 204);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(81, 23);
            this.btnTinhTien.TabIndex = 6;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tổng tiền thanh toán:";
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTien.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSoTien.Location = new System.Drawing.Point(182, 248);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(12, 17);
            this.lblSoTien.TabIndex = 8;
            this.lblSoTien.Text = ".";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBai2";
            this.Text = "Bán hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChonHang;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBohang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
    }
}