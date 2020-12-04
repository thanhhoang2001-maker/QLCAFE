namespace GUI_QLCAFE
{
    partial class Banhang
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
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btSoluongThem = new System.Windows.Forms.Button();
            this.btThoatBH = new System.Windows.Forms.Button();
            this.btSoluongTru = new System.Windows.Forms.Button();
            this.btXoaBH = new System.Windows.Forms.Button();
            this.btThemBH = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbLoaiSP = new System.Windows.Forms.ComboBox();
            this.cbbTenSP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btCapnhatBH = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongtienBH = new System.Windows.Forms.TextBox();
            this.txtGiamgiaBH = new System.Windows.Forms.TextBox();
            this.dtpThoigianBH = new System.Windows.Forms.DateTimePicker();
            this.btTinhtienBH = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.listViewSanPham = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Controls.Add(this.btSoluongThem);
            this.panel1.Controls.Add(this.btThoatBH);
            this.panel1.Controls.Add(this.btSoluongTru);
            this.panel1.Controls.Add(this.btXoaBH);
            this.panel1.Controls.Add(this.btThemBH);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbbLoaiSP);
            this.panel1.Controls.Add(this.cbbTenSP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 592);
            this.panel1.TabIndex = 0;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSoLuong.Location = new System.Drawing.Point(161, 316);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(139, 38);
            this.txtSoLuong.TabIndex = 18;
            this.txtSoLuong.Text = "0";
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btSoluongThem
            // 
            this.btSoluongThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSoluongThem.Location = new System.Drawing.Point(324, 316);
            this.btSoluongThem.Margin = new System.Windows.Forms.Padding(4);
            this.btSoluongThem.Name = "btSoluongThem";
            this.btSoluongThem.Size = new System.Drawing.Size(48, 39);
            this.btSoluongThem.TabIndex = 17;
            this.btSoluongThem.Text = "+";
            this.btSoluongThem.UseVisualStyleBackColor = true;
            this.btSoluongThem.Click += new System.EventHandler(this.btSoluongThem_Click);
            // 
            // btThoatBH
            // 
            this.btThoatBH.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btThoatBH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btThoatBH.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoatBH.Location = new System.Drawing.Point(63, 513);
            this.btThoatBH.Margin = new System.Windows.Forms.Padding(4);
            this.btThoatBH.Name = "btThoatBH";
            this.btThoatBH.Size = new System.Drawing.Size(331, 59);
            this.btThoatBH.TabIndex = 7;
            this.btThoatBH.Text = "THOÁT";
            this.btThoatBH.UseVisualStyleBackColor = false;
            this.btThoatBH.Click += new System.EventHandler(this.btThoatBH_Click);
            // 
            // btSoluongTru
            // 
            this.btSoluongTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSoluongTru.Location = new System.Drawing.Point(88, 316);
            this.btSoluongTru.Margin = new System.Windows.Forms.Padding(4);
            this.btSoluongTru.Name = "btSoluongTru";
            this.btSoluongTru.Size = new System.Drawing.Size(48, 39);
            this.btSoluongTru.TabIndex = 16;
            this.btSoluongTru.Text = "-";
            this.btSoluongTru.UseVisualStyleBackColor = true;
            this.btSoluongTru.Click += new System.EventHandler(this.btSoluongTru_Click);
            // 
            // btXoaBH
            // 
            this.btXoaBH.BackColor = System.Drawing.Color.Tomato;
            this.btXoaBH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btXoaBH.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaBH.Location = new System.Drawing.Point(63, 447);
            this.btXoaBH.Margin = new System.Windows.Forms.Padding(4);
            this.btXoaBH.Name = "btXoaBH";
            this.btXoaBH.Size = new System.Drawing.Size(331, 59);
            this.btXoaBH.TabIndex = 6;
            this.btXoaBH.Text = "XÓA";
            this.btXoaBH.UseVisualStyleBackColor = false;
            // 
            // btThemBH
            // 
            this.btThemBH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btThemBH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btThemBH.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemBH.Location = new System.Drawing.Point(63, 380);
            this.btThemBH.Margin = new System.Windows.Forms.Padding(4);
            this.btThemBH.Name = "btThemBH";
            this.btThemBH.Size = new System.Drawing.Size(331, 59);
            this.btThemBH.TabIndex = 5;
            this.btThemBH.Text = "THÊM";
            this.btThemBH.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại sản phẩm";
            // 
            // cbbLoaiSP
            // 
            this.cbbLoaiSP.FormattingEnabled = true;
            this.cbbLoaiSP.Items.AddRange(new object[] {
            "WATER",
            "FOOD"});
            this.cbbLoaiSP.Location = new System.Drawing.Point(63, 101);
            this.cbbLoaiSP.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLoaiSP.Name = "cbbLoaiSP";
            this.cbbLoaiSP.Size = new System.Drawing.Size(333, 24);
            this.cbbLoaiSP.TabIndex = 1;
            this.cbbLoaiSP.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiSP_SelectedIndexChanged);
            // 
            // cbbTenSP
            // 
            this.cbbTenSP.FormattingEnabled = true;
            this.cbbTenSP.Location = new System.Drawing.Point(63, 228);
            this.cbbTenSP.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTenSP.Name = "cbbTenSP";
            this.cbbTenSP.Size = new System.Drawing.Size(333, 24);
            this.cbbTenSP.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁN HÀNG";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btCapnhatBH);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtTongtienBH);
            this.panel2.Controls.Add(this.txtGiamgiaBH);
            this.panel2.Controls.Add(this.dtpThoigianBH);
            this.panel2.Controls.Add(this.btTinhtienBH);
            this.panel2.Location = new System.Drawing.Point(499, 426);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(705, 179);
            this.panel2.TabIndex = 1;
            // 
            // btCapnhatBH
            // 
            this.btCapnhatBH.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btCapnhatBH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCapnhatBH.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapnhatBH.Location = new System.Drawing.Point(25, 117);
            this.btCapnhatBH.Margin = new System.Windows.Forms.Padding(4);
            this.btCapnhatBH.Name = "btCapnhatBH";
            this.btCapnhatBH.Size = new System.Drawing.Size(228, 44);
            this.btCapnhatBH.TabIndex = 14;
            this.btCapnhatBH.Text = "CẬP NHẬT";
            this.btCapnhatBH.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(304, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tổng tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(304, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Giảm giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(304, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Thời gian";
            // 
            // txtTongtienBH
            // 
            this.txtTongtienBH.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongtienBH.ForeColor = System.Drawing.Color.Red;
            this.txtTongtienBH.Location = new System.Drawing.Point(441, 128);
            this.txtTongtienBH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongtienBH.Multiline = true;
            this.txtTongtienBH.Name = "txtTongtienBH";
            this.txtTongtienBH.Size = new System.Drawing.Size(237, 35);
            this.txtTongtienBH.TabIndex = 11;
            // 
            // txtGiamgiaBH
            // 
            this.txtGiamgiaBH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiamgiaBH.ForeColor = System.Drawing.Color.Yellow;
            this.txtGiamgiaBH.Location = new System.Drawing.Point(441, 71);
            this.txtGiamgiaBH.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiamgiaBH.Multiline = true;
            this.txtGiamgiaBH.Name = "txtGiamgiaBH";
            this.txtGiamgiaBH.Size = new System.Drawing.Size(237, 36);
            this.txtGiamgiaBH.TabIndex = 10;
            // 
            // dtpThoigianBH
            // 
            this.dtpThoigianBH.CustomFormat = "dd/MM/yyyy";
            this.dtpThoigianBH.Location = new System.Drawing.Point(441, 25);
            this.dtpThoigianBH.Margin = new System.Windows.Forms.Padding(4);
            this.dtpThoigianBH.Name = "dtpThoigianBH";
            this.dtpThoigianBH.Size = new System.Drawing.Size(237, 22);
            this.dtpThoigianBH.TabIndex = 9;
            // 
            // btTinhtienBH
            // 
            this.btTinhtienBH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btTinhtienBH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btTinhtienBH.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTinhtienBH.Location = new System.Drawing.Point(25, 26);
            this.btTinhtienBH.Margin = new System.Windows.Forms.Padding(4);
            this.btTinhtienBH.Name = "btTinhtienBH";
            this.btTinhtienBH.Size = new System.Drawing.Size(228, 81);
            this.btTinhtienBH.TabIndex = 8;
            this.btTinhtienBH.Text = "TÍNH TIỀN";
            this.btTinhtienBH.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(499, 16);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(705, 39);
            this.panel3.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(280, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "SẢN PHẨM ĐÃ CHỌN";
            // 
            // listViewSanPham
            // 
            this.listViewSanPham.HideSelection = false;
            this.listViewSanPham.Location = new System.Drawing.Point(499, 63);
            this.listViewSanPham.Name = "listViewSanPham";
            this.listViewSanPham.Size = new System.Drawing.Size(705, 356);
            this.listViewSanPham.TabIndex = 16;
            this.listViewSanPham.UseCompatibleStateImageBehavior = false;
            // 
            // Banhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 623);
            this.Controls.Add(this.listViewSanPham);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Banhang";
            this.Text = "Banhang";
            this.Load += new System.EventHandler(this.Banhang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbTenSP;
        private System.Windows.Forms.ComboBox cbbLoaiSP;
        private System.Windows.Forms.Button btThoatBH;
        private System.Windows.Forms.Button btXoaBH;
        private System.Windows.Forms.Button btThemBH;
        private System.Windows.Forms.TextBox txtTongtienBH;
        private System.Windows.Forms.TextBox txtGiamgiaBH;
        private System.Windows.Forms.DateTimePicker dtpThoigianBH;
        private System.Windows.Forms.Button btTinhtienBH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btCapnhatBH;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btSoluongThem;
        private System.Windows.Forms.Button btSoluongTru;
        private System.Windows.Forms.ListView listViewSanPham;
    }
}