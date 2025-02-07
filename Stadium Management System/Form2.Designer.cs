namespace Stadium_Management_System
{
    partial class Form2
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
            this.signup_close = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.signup_hienMatKhau = new System.Windows.Forms.CheckBox();
            this.signup_btn = new System.Windows.Forms.Button();
            this.signup_matKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.signup_taiKhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.signup_xacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.signup_close);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 35);
            this.panel1.TabIndex = 9;
            // 
            // signup_close
            // 
            this.signup_close.BackColor = System.Drawing.Color.Firebrick;
            this.signup_close.Location = new System.Drawing.Point(762, 0);
            this.signup_close.Name = "signup_close";
            this.signup_close.Size = new System.Drawing.Size(35, 35);
            this.signup_close.TabIndex = 1;
            this.signup_close.Text = "X";
            this.signup_close.UseVisualStyleBackColor = false;
            this.signup_close.Click += new System.EventHandler(this.signup_close_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(0, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 0;
            // 
            // signup_hienMatKhau
            // 
            this.signup_hienMatKhau.AutoSize = true;
            this.signup_hienMatKhau.Location = new System.Drawing.Point(217, 351);
            this.signup_hienMatKhau.Name = "signup_hienMatKhau";
            this.signup_hienMatKhau.Size = new System.Drawing.Size(135, 24);
            this.signup_hienMatKhau.TabIndex = 18;
            this.signup_hienMatKhau.Text = "hiện mật khẩu";
            this.signup_hienMatKhau.UseVisualStyleBackColor = true;
            this.signup_hienMatKhau.CheckedChanged += new System.EventHandler(this.sigup_hienMatKhau_CheckedChanged);
            // 
            // signup_btn
            // 
            this.signup_btn.BackColor = System.Drawing.Color.Green;
            this.signup_btn.Location = new System.Drawing.Point(321, 381);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(143, 37);
            this.signup_btn.TabIndex = 17;
            this.signup_btn.Text = "ĐĂNG KÝ";
            this.signup_btn.UseVisualStyleBackColor = false;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // signup_matKhau
            // 
            this.signup_matKhau.Location = new System.Drawing.Point(217, 270);
            this.signup_matKhau.Name = "signup_matKhau";
            this.signup_matKhau.PasswordChar = '*';
            this.signup_matKhau.Size = new System.Drawing.Size(361, 26);
            this.signup_matKhau.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mật khẩu";
            // 
            // signup_taiKhoan
            // 
            this.signup_taiKhoan.Location = new System.Drawing.Point(217, 218);
            this.signup_taiKhoan.Name = "signup_taiKhoan";
            this.signup_taiKhoan.Size = new System.Drawing.Size(365, 26);
            this.signup_taiKhoan.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Xin chào!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Đã có tài khoản? Đăng nhập";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Xác nhận mật khẩu";
            // 
            // signup_xacNhanMatKhau
            // 
            this.signup_xacNhanMatKhau.Location = new System.Drawing.Point(217, 319);
            this.signup_xacNhanMatKhau.Name = "signup_xacNhanMatKhau";
            this.signup_xacNhanMatKhau.PasswordChar = '*';
            this.signup_xacNhanMatKhau.Size = new System.Drawing.Size(361, 26);
            this.signup_xacNhanMatKhau.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.Image = global::Stadium_Management_System.Properties.Resources.futsal_f22;
            this.pictureBox1.Location = new System.Drawing.Point(344, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.signup_hienMatKhau);
            this.Controls.Add(this.signup_btn);
            this.Controls.Add(this.signup_xacNhanMatKhau);
            this.Controls.Add(this.signup_matKhau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.signup_taiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button signup_close;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.CheckBox signup_hienMatKhau;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.TextBox signup_matKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox signup_taiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox signup_xacNhanMatKhau;
    }
}