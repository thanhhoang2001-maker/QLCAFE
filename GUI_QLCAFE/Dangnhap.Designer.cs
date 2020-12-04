namespace GUI_QLCAFE
{
    partial class FormDangnhap
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
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbQuenmk = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btThoatDN = new System.Windows.Forms.Button();
            this.btDangnhap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.txtMatkhau);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lbQuenmk);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btThoatDN);
            this.panel1.Controls.Add(this.btDangnhap);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(40, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 317);
            this.panel1.TabIndex = 0;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(34, 145);
            this.txtMatkhau.Multiline = true;
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(244, 26);
            this.txtMatkhau.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(34, 94);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(244, 26);
            this.txtEmail.TabIndex = 7;
            // 
            // lbQuenmk
            // 
            this.lbQuenmk.AutoSize = true;
            this.lbQuenmk.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbQuenmk.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuenmk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbQuenmk.Location = new System.Drawing.Point(184, 184);
            this.lbQuenmk.Name = "lbQuenmk";
            this.lbQuenmk.Size = new System.Drawing.Size(94, 13);
            this.lbQuenmk.TabIndex = 6;
            this.lbQuenmk.Text = "Quên mật khẩu ?";
            this.lbQuenmk.Click += new System.EventHandler(this.lbQuenmk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(106, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOGIN";
            // 
            // btThoatDN
            // 
            this.btThoatDN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThoatDN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btThoatDN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoatDN.Location = new System.Drawing.Point(97, 258);
            this.btThoatDN.Name = "btThoatDN";
            this.btThoatDN.Size = new System.Drawing.Size(117, 33);
            this.btThoatDN.TabIndex = 3;
            this.btThoatDN.Text = "THOÁT";
            this.btThoatDN.UseVisualStyleBackColor = false;
            this.btThoatDN.Click += new System.EventHandler(this.btThoatDN_Click);
            // 
            // btDangnhap
            // 
            this.btDangnhap.BackColor = System.Drawing.Color.Red;
            this.btDangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDangnhap.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangnhap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDangnhap.Location = new System.Drawing.Point(63, 211);
            this.btDangnhap.Name = "btDangnhap";
            this.btDangnhap.Size = new System.Drawing.Size(184, 41);
            this.btDangnhap.TabIndex = 2;
            this.btDangnhap.Text = "ĐĂNG NHẬP";
            this.btDangnhap.UseVisualStyleBackColor = false;
            this.btDangnhap.Click += new System.EventHandler(this.btDangnhap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(406, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "COFFEE MANAGEMENT";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormDangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI_QLCAFE.Properties.Resources.image0__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(771, 404);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "FormDangnhap";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btThoatDN;
        private System.Windows.Forms.Button btDangnhap;
        private System.Windows.Forms.Label lbQuenmk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button button1;
    }
}

