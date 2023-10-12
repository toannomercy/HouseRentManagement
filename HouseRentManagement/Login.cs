using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HouseRentManagement
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        private bool isDragging = false;
        private Point startPoint;
        private string connectionString = @"Data Source=TOAN-PC\ASVSERVER;Initial Catalog=QLCHCC;Integrated Security=True";
        private SqlConnection conn; 

        public Login()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string enteredUsername = txtBoxUsername.Text;
                string enteredPassword = txtBoxPassword.Text;
                string queryUser = "SELECT MatKhau FROM USERS WHERE MaTheCuDan = @username";
                string queryAdmin = "SELECT MatKhau FROM ADMINS WHERE MaQL = @username";
                SqlCommand cmdUser = new SqlCommand(queryUser, conn);
                SqlCommand cmdAdmin = new SqlCommand(queryAdmin, conn);
                cmdUser.Parameters.AddWithValue("username", enteredUsername);
                cmdAdmin.Parameters.AddWithValue("username", enteredUsername);
                conn.Open();
                string realPasswordUser = (string)cmdUser.ExecuteScalar();
                string realPasswordAdmin = (string)cmdAdmin.ExecuteScalar();
                conn.Close();
                if (realPasswordAdmin != null)
                {
                    if(enteredPassword == realPasswordAdmin)
                    {
                        Admin adminForm = new Admin();
                        adminForm.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (realPasswordUser != null)
                {
                    if(enteredPassword == realPasswordUser)
                    {
                        User userForm = new User();
                        userForm.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Account doesn't exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = new Point(e.X, e.Y);
            }
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newPoint = PointToScreen(new Point(e.X, e.Y));
                Location = new Point(newPoint.X - startPoint.X, newPoint.Y - startPoint.Y);
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void txtBoxPassword_TextChange(object sender, EventArgs e)
        {
            txtBoxPassword.UseSystemPasswordChar = true;
        }

        private void btnHideShowPass_Click(object sender, EventArgs e)
        {
            if (txtBoxPassword.UseSystemPasswordChar)
            {
                txtBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxUsername.Clear();
            txtBoxPassword.Clear();
        }
    }
}