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
            this.lqQuenmk = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassNV = new JMaterialTextbox.JMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btThoatDN = new System.Windows.Forms.Button();
            this.btDangnhap = new System.Windows.Forms.Button();
            this.txtEmailNV = new JMaterialTextbox.JMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lqQuenmk);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPassNV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btThoatDN);
            this.panel1.Controls.Add(this.btDangnhap);
            this.panel1.Controls.Add(this.txtEmailNV);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(40, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 317);
            this.panel1.TabIndex = 0;
            // 
            // lqQuenmk
            // 
            this.lqQuenmk.AutoSize = true;
            this.lqQuenmk.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lqQuenmk.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lqQuenmk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lqQuenmk.Location = new System.Drawing.Point(184, 184);
            this.lqQuenmk.Name = "lqQuenmk";
            this.lqQuenmk.Size = new System.Drawing.Size(94, 13);
            this.lqQuenmk.TabIndex = 6;
            this.lqQuenmk.Text = "Quên mật khẩu ?";
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
            // txtPassNV
            // 
            this.txtPassNV.BackColor = System.Drawing.Color.Transparent;
            this.txtPassNV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassNV.Font_Size = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassNV.ForeColors = System.Drawing.Color.White;
            this.txtPassNV.HintText = null;
            this.txtPassNV.IsPassword = false;
            this.txtPassNV.LineBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPassNV.LineThickness = 3;
            this.txtPassNV.Location = new System.Drawing.Point(33, 146);
            this.txtPassNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassNV.MaxLength = 32767;
            this.txtPassNV.Name = "txtPassNV";
            this.txtPassNV.OnFocusedColor = System.Drawing.Color.Black;
            this.txtPassNV.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtPassNV.ReadOnly = false;
            this.txtPassNV.Size = new System.Drawing.Size(244, 23);
            this.txtPassNV.TabIndex = 1;
            this.txtPassNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassNV.TextName = "Password";
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
            // 
            // txtEmailNV
            // 
            this.txtEmailNV.BackColor = System.Drawing.Color.Transparent;
            this.txtEmailNV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailNV.Font_Size = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailNV.ForeColors = System.Drawing.Color.White;
            this.txtEmailNV.HintText = null;
            this.txtEmailNV.IsPassword = false;
            this.txtEmailNV.LineBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtEmailNV.LineThickness = 3;
            this.txtEmailNV.Location = new System.Drawing.Point(33, 104);
            this.txtEmailNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmailNV.MaxLength = 32767;
            this.txtEmailNV.Name = "txtEmailNV";
            this.txtEmailNV.OnFocusedColor = System.Drawing.Color.Black;
            this.txtEmailNV.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtEmailNV.ReadOnly = false;
            this.txtEmailNV.Size = new System.Drawing.Size(244, 23);
            this.txtEmailNV.TabIndex = 0;
            this.txtEmailNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmailNV.TextName = "Email đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(406, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "CAFFEE MANAGEMENT";
            // 
            // FormDangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI_QLCAFE.Properties.Resources.image0__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(771, 404);
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
        private JMaterialTextbox.JMaterialTextbox txtPassNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btThoatDN;
        private System.Windows.Forms.Button btDangnhap;
        private JMaterialTextbox.JMaterialTextbox txtEmailNV;
        private System.Windows.Forms.Label lqQuenmk;
        private System.Windows.Forms.Label label3;
    }
}

