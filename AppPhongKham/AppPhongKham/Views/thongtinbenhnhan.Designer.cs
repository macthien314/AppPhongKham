
namespace AppPhongKham.Views
{
    partial class thongtinbenhnhan
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSex = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbGioitinh = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListBN = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dateNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.btnDel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btntEdit = new System.Windows.Forms.Button();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMabn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSex.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(513, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Bệnh Nhân";
            // 
            // cmbSex
            // 
            this.cmbSex.Controls.Add(this.btnSave);
            this.cmbSex.Controls.Add(this.cmbGioitinh);
            this.cmbSex.Controls.Add(this.label7);
            this.cmbSex.Controls.Add(this.groupBox2);
            this.cmbSex.Controls.Add(this.btnCancel);
            this.cmbSex.Controls.Add(this.dateNgaysinh);
            this.cmbSex.Controls.Add(this.btnDel);
            this.cmbSex.Controls.Add(this.label5);
            this.cmbSex.Controls.Add(this.btntEdit);
            this.cmbSex.Controls.Add(this.txtDiachi);
            this.cmbSex.Controls.Add(this.btnAdd);
            this.cmbSex.Controls.Add(this.label6);
            this.cmbSex.Controls.Add(this.txtSdt);
            this.cmbSex.Controls.Add(this.label4);
            this.cmbSex.Controls.Add(this.txtHoten);
            this.cmbSex.Controls.Add(this.label3);
            this.cmbSex.Controls.Add(this.txtMabn);
            this.cmbSex.Controls.Add(this.label2);
            this.cmbSex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSex.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSex.ForeColor = System.Drawing.Color.Blue;
            this.cmbSex.Location = new System.Drawing.Point(0, 0);
            this.cmbSex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSex.Size = new System.Drawing.Size(1363, 652);
            this.cmbSex.TabIndex = 1;
            this.cmbSex.TabStop = false;
            this.cmbSex.Text = "Thông Tin Bệnh Nhân";

            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(853, 255);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 57);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // cmbGioitinh
            // 
            this.cmbGioitinh.Enabled = false;
            this.cmbGioitinh.FormattingEnabled = true;
            this.cmbGioitinh.Location = new System.Drawing.Point(141, 146);
            this.cmbGioitinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbGioitinh.Name = "cmbGioitinh";
            this.cmbGioitinh.Size = new System.Drawing.Size(168, 34);
            this.cmbGioitinh.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 28);
            this.label7.TabIndex = 12;
            this.label7.Text = "Giới Tính:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvListBN);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(13, 354);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1349, 258);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Bệnh Nhân";
            // 
            // dgvListBN
            // 
            this.dgvListBN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListBN.Location = new System.Drawing.Point(3, 29);
            this.dgvListBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListBN.Name = "dgvListBN";
            this.dgvListBN.RowHeadersWidth = 51;
            this.dgvListBN.Size = new System.Drawing.Size(1343, 227);
            this.dgvListBN.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1017, 255);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 57);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dateNgaysinh
            // 
            this.dateNgaysinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateNgaysinh.CalendarTitleForeColor = System.Drawing.Color.Blue;
            this.dateNgaysinh.Enabled = false;
            this.dateNgaysinh.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgaysinh.Location = new System.Drawing.Point(1035, 62);
            this.dateNgaysinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateNgaysinh.Name = "dateNgaysinh";
            this.dateNgaysinh.Size = new System.Drawing.Size(299, 30);
            this.dateNgaysinh.TabIndex = 11;
            // 
            // btnDel
            // 
            this.btnDel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDel.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(695, 255);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(125, 57);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(863, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày Sinh:";
            // 
            // btntEdit
            // 
            this.btntEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btntEdit.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntEdit.Location = new System.Drawing.Point(532, 255);
            this.btntEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntEdit.Name = "btntEdit";
            this.btntEdit.Size = new System.Drawing.Size(125, 57);
            this.btntEdit.TabIndex = 4;
            this.btntEdit.Text = "Sửa";
            this.btntEdit.UseVisualStyleBackColor = true;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiachi.Enabled = false;
            this.txtDiachi.Location = new System.Drawing.Point(471, 146);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(377, 34);
            this.txtDiachi.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(368, 255);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 57);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "Địa Chỉ:";
            // 
            // txtSdt
            // 
            this.txtSdt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSdt.Enabled = false;
            this.txtSdt.Location = new System.Drawing.Point(1035, 146);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(299, 34);
            this.txtSdt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(863, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số Điện Thoại:";
            // 
            // txtHoten
            // 
            this.txtHoten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoten.Enabled = false;
            this.txtHoten.Location = new System.Drawing.Point(471, 52);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(377, 34);
            this.txtHoten.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ Tên:";
            // 
            // txtMabn
            // 
            this.txtMabn.Enabled = false;
            this.txtMabn.Location = new System.Drawing.Point(104, 55);
            this.txtMabn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMabn.Name = "txtMabn";
            this.txtMabn.Size = new System.Drawing.Size(205, 34);
            this.txtMabn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã BN:";
            // 
            // thongtinbenhnhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1363, 652);
            this.Controls.Add(this.cmbSex);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "thongtinbenhnhan";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "QUẢN LÝ BỆNH NHÂN";
            this.cmbSex.ResumeLayout(false);
            this.cmbSex.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox cmbSex;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvListBN;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btntEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMabn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateNgaysinh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbGioitinh;
        private System.Windows.Forms.Label label7;
    }
}