﻿
namespace AppPhongKham.Views
{
    partial class TrangChu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.home = new System.Windows.Forms.ToolStripMenuItem();
            this.benhnhan = new System.Windows.Forms.ToolStripMenuItem();
            this.phieukham = new System.Windows.Forms.ToolStripMenuItem();
            this.thuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.toathuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.hoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.bÁOCÁOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhthu = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(220, 101);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(885, 566);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.home,
            this.benhnhan,
            this.phieukham,
            this.thuoc,
            this.toathuoc,
            this.hoadon,
            this.bÁOCÁOToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(135, 31);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(978, 33);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // home
            // 
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(153, 29);
            this.home.Text = "TRANG CHỦ";
            // 
            // benhnhan
            // 
            this.benhnhan.Name = "benhnhan";
            this.benhnhan.Size = new System.Drawing.Size(153, 29);
            this.benhnhan.Text = "BỆNH NHÂN";
            this.benhnhan.Click += new System.EventHandler(this.benhnhan_Click);
            // 
            // phieukham
            // 
            this.phieukham.Name = "phieukham";
            this.phieukham.Size = new System.Drawing.Size(158, 29);
            this.phieukham.Text = "PHIẾU KHÁM";
            this.phieukham.Click += new System.EventHandler(this.phieukham_Click);
            // 
            // thuoc
            // 
            this.thuoc.Name = "thuoc";
            this.thuoc.Size = new System.Drawing.Size(101, 29);
            this.thuoc.Text = "THUỐC";
            this.thuoc.Click += new System.EventHandler(this.thuoc_Click);
            // 
            // toathuoc
            // 
            this.toathuoc.Name = "toathuoc";
            this.toathuoc.Size = new System.Drawing.Size(152, 29);
            this.toathuoc.Text = "TOA THUỐC";
            this.toathuoc.Click += new System.EventHandler(this.toathuoc_Click);
            // 
            // hoadon
            // 
            this.hoadon.Name = "hoadon";
            this.hoadon.Size = new System.Drawing.Size(126, 29);
            this.hoadon.Text = "HÓA ĐƠN";
            this.hoadon.Click += new System.EventHandler(this.hoadon_Click);
            // 
            // bÁOCÁOToolStripMenuItem
            // 
            this.bÁOCÁOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doanhthu});
            this.bÁOCÁOToolStripMenuItem.Name = "bÁOCÁOToolStripMenuItem";
            this.bÁOCÁOToolStripMenuItem.Size = new System.Drawing.Size(125, 29);
            this.bÁOCÁOToolStripMenuItem.Text = "BÁO CÁO";
            // 
            // doanhthu
            // 
            this.doanhthu.Name = "doanhthu";
            this.doanhthu.Size = new System.Drawing.Size(227, 30);
            this.doanhthu.Text = "DOANH THU";
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1363, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip2);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TrangChu";
            this.Text = "QUẢN LÝ PHÒNG KHÁM TƯ NHÂN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem home;
        private System.Windows.Forms.ToolStripMenuItem benhnhan;
        private System.Windows.Forms.ToolStripMenuItem phieukham;
        private System.Windows.Forms.ToolStripMenuItem thuoc;
        private System.Windows.Forms.ToolStripMenuItem toathuoc;
        private System.Windows.Forms.ToolStripMenuItem hoadon;
        private System.Windows.Forms.ToolStripMenuItem bÁOCÁOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhthu;
    }
}