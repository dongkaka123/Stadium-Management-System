namespace Stadium_Management_System
{
    partial class Form1
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
            this.login_close = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_taiKhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.login_matKhau = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.login_hienMatKhau = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.login_close);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 35);
            this.panel1.TabIndex = 0;
            // 
            // login_close
            // 
            this.login_close.BackColor = System.Drawing.Color.Firebrick;
            this.login_close.Location = new System.Drawing.Point(762, 0);
            this.login_close.Name = "login_close";
            this.login_close.Size = new System.Drawing.Size(35, 35);
            this.login_close.TabIndex = 1;
            this.login_close.Text = "X";
            this.login_close.UseVisualStyleBackColor = false;
            this.login_close.Click += new System.EventHandler(this.login_close_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(0, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.Image = global::Stadium_Management_System.Properties.Resources.futsal_f22;
            this.pictureBox1.Location = new System.Drawing.Point(344, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Xin chào!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tài khoản";
            // 
            // login_taiKhoan
            // 
            this.login_taiKhoan.Location = new System.Drawing.Point(217, 212);
            this.login_taiKhoan.Name = "login_taiKhoan";
            this.login_taiKhoan.Size = new System.Drawing.Size(365, 26);
            this.login_taiKhoan.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu";
            // 
            // login_matKhau
            // 
            this.login_matKhau.Location = new System.Drawing.Point(217, 279);
            this.login_matKhau.Name = "login_matKhau";
            this.login_matKhau.PasswordChar = '*';
            this.login_matKhau.Size = new System.Drawing.Size(365, 26);
            this.login_matKhau.TabIndex = 6;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Green;
            this.login_btn.Location = new System.Drawing.Point(321, 341);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(143, 37);
            this.login_btn.TabIndex = 7;
            this.login_btn.Text = "ĐĂNG NHẬP";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // login_hienMatKhau
            // 
            this.login_hienMatKhau.AutoSize = true;
            this.login_hienMatKhau.Location = new System.Drawing.Point(217, 311);
            this.login_hienMatKhau.Name = "login_hienMatKhau";
            this.login_hienMatKhau.Size = new System.Drawing.Size(135, 24);
            this.login_hienMatKhau.TabIndex = 8;
            this.login_hienMatKhau.Text = "hiện mật khẩu";
            this.login_hienMatKhau.UseVisualStyleBackColor = true;
            this.login_hienMatKhau.CheckedChanged += new System.EventHandler(this.login_hienMatKhau_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Chưa có tài khoản? Đăng ký";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login_hienMatKhau);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.login_matKhau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.login_taiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login_taiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login_matKhau;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.CheckBox login_hienMatKhau;
        private System.Windows.Forms.Button login_close;
        private System.Windows.Forms.Label label4;
    }
}

