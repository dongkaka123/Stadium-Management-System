using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace Stadium_Management_System
{
    public partial class Form2 : Form
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ADMIN88\OneDrive\Tài liệu\stadiumsystem.mdf"";Integrated Security=True;Connect Timeout=30";
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void signup_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void sigup_hienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            signup_matKhau.PasswordChar = signup_hienMatKhau.Checked ? '\0' : '*';
            signup_xacNhanMatKhau.PasswordChar = signup_hienMatKhau.Checked ? '\0' : '*';
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string checkUsername = "SELECT * FROM users WHERE username = @usern";

                using (SqlCommand checkUsern = new SqlCommand(checkUsername, connect))
                {
                    checkUsern.Parameters.AddWithValue("@usern", signup_taiKhoan.Text.Trim());
                    SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count != 0)
                    {
                        MessageBox.Show($"{signup_taiKhoan.Text.Trim()} da ton tai", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    }
                    else if(signup_matKhau.Text.Trim().Length <8)
                    {
                        MessageBox.Show("Mat khau it nhat 8 ki tu", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if(signup_matKhau.Text.Trim() != signup_xacNhanMatKhau.Text.Trim())
                    {
                        MessageBox.Show("Mat khau khac nhau !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string insertData = "INSERT INTO users (username, password, status, date_created) VALUES(@usern, @pass, @status, @date)";
                        using(SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", signup_taiKhoan.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", signup_matKhau.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", "Active");

                            DateTime today = DateTime.Now;

                            cmd.Parameters.AddWithValue("@date", today);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Dang ky thanh cong!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
        }
    }
}
