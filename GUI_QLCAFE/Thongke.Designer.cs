namespace GUI_QLCAFE
{
    partial class Thongke
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btDoanhthuTK = new System.Windows.Forms.Button();
            this.btSanphamTK = new System.Windows.Forms.Button();
            this.dtpBatdauTK = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btTroveTK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpKetthucTK = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(201, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(616, 388);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "THỐNG KÊ";
            // 
            // btDoanhthuTK
            // 
            this.btDoanhthuTK.BackColor = System.Drawing.Color.PaleGreen;
            this.btDoanhthuTK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDoanhthuTK.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDoanhthuTK.Location = new System.Drawing.Point(15, 211);
            this.btDoanhthuTK.Name = "btDoanhthuTK";
            this.btDoanhthuTK.Size = new System.Drawing.Size(183, 29);
            this.btDoanhthuTK.TabIndex = 4;
            this.btDoanhthuTK.Text = "DOANH THU";
            this.btDoanhthuTK.UseVisualStyleBackColor = false;
            // 
            // btSanphamTK
            // 
            this.btSanphamTK.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btSanphamTK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSanphamTK.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSanphamTK.Location = new System.Drawing.Point(12, 246);
            this.btSanphamTK.Name = "btSanphamTK";
            this.btSanphamTK.Size = new System.Drawing.Size(183, 29);
            this.btSanphamTK.TabIndex = 5;
            this.btSanphamTK.Text = "SẢN PHẨM";
            this.btSanphamTK.UseVisualStyleBackColor = false;
            // 
            // dtpBatdauTK
            // 
            this.dtpBatdauTK.Location = new System.Drawing.Point(12, 119);
            this.dtpBatdauTK.Name = "dtpBatdauTK";
            this.dtpBatdauTK.Size = new System.Drawing.Size(183, 20);
            this.dtpBatdauTK.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thời gian";
            // 
            // btTroveTK
            // 
            this.btTroveTK.BackColor = System.Drawing.Color.Violet;
            this.btTroveTK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btTroveTK.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTroveTK.Location = new System.Drawing.Point(12, 281);
            this.btTroveTK.Name = "btTroveTK";
            this.btTroveTK.Size = new System.Drawing.Size(183, 29);
            this.btTroveTK.TabIndex = 8;
            this.btTroveTK.Text = "TRỞ VỀ";
            this.btTroveTK.UseVisualStyleBackColor = false;
            this.btTroveTK.Click += new System.EventHandler(this.btTroveTK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bắt đầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kết thúc";
            // 
            // dtpKetthucTK
            // 
            this.dtpKetthucTK.Location = new System.Drawing.Point(12, 173);
            this.dtpKetthucTK.Name = "dtpKetthucTK";
            this.dtpKetthucTK.Size = new System.Drawing.Size(183, 20);
            this.dtpKetthucTK.TabIndex = 11;
            // 
            // Thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(829, 476);
            this.Controls.Add(this.dtpKetthucTK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btTroveTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpBatdauTK);
            this.Controls.Add(this.btSanphamTK);
            this.Controls.Add(this.btDoanhthuTK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Thongke";
            this.Text = "Thongke";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDoanhthuTK;
        private System.Windows.Forms.Button btSanphamTK;
        private System.Windows.Forms.DateTimePicker dtpBatdauTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btTroveTK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpKetthucTK;
    }
}