using DevExpress.XtraEditors;
using HouseRentManagement.HRMcontextDB;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;
using System.Configuration;

namespace HouseRentManagement
{
    public partial class Login : XtraForm
    {
        private bool isDragging = false;
        private Point startPoint;
        private bool isPasswordMasked = true;
        private HRMContextDB context;
        private string connString = ConfigurationManager.ConnectionStrings["HRMContextDB"].ConnectionString;
        
        public Login()
        {
            InitializeComponent();
            InitializeUI();
            context = new HRMContextDB();
        }

        private void InitializeUI()
        {
            btnHideShowPass.HoverState.ImageSize = new System.Drawing.Size(20, 20);
            btnHideShowPass.PressedState.ImageSize = new System.Drawing.Size(20, 20);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string adminSelectQuery = "SELECT * FROM ADMINS WHERE MaQL = @username AND MatKhau = @password";
            string userSelectQuery = "SELECT * FROM USERS WHERE MaTheCuDan = @username AND MatKhau = @password";

            using (SqlConnection connection = new SqlConnection(connString))
            using (SqlCommand command = new SqlCommand(adminSelectQuery, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        Admin adminForm = new Admin(username);
                        adminForm.Show();
                        this.Hide();
                        return;
                    }
                }
            }

            using (SqlConnection connection = new SqlConnection(connString))
            using (SqlCommand command = new SqlCommand(userSelectQuery, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        User userForm = new User(username);
                        userForm.Show();
                        this.Hide();
                        return;
                    }
                }
            }

            MessageBox.Show("Wrong username or password", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxUsername.Clear();
            txtBoxPassword.Clear();
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

        private void btnHideShowPass_MouseEnterLeave(object sender, EventArgs e)
        {
            if (txtBoxPassword.PlaceholderText == "Enter your password" && string.IsNullOrEmpty(txtBoxPassword.Text))
            {
                txtBoxPassword.PasswordChar = '\0';
                isPasswordMasked = true;
            }
            else
            {
                txtBoxPassword.PasswordChar = isPasswordMasked ? '*' : '\0';
                isPasswordMasked = !isPasswordMasked;
            }
        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxPassword.Text))
            {
                isPasswordMasked = true;
                txtBoxPassword.PasswordChar = '\0';
            }
            else if (isPasswordMasked)
            {
                isPasswordMasked = false;
                txtBoxPassword.PasswordChar = '*';
            }
        }

        private void lblLinkForgotPass_Click(object sender, EventArgs e)
        {
            string username = txtBoxUsername.Text;
            ForgotPassword fgpw = new ForgotPassword(username);
            fgpw.Show();
            this.Hide();
        }

        private void txtBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}