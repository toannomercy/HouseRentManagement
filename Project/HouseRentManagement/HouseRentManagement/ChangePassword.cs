using DevExpress.XtraEditors;
using HouseRentManagement.HRMcontextDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HouseRentManagement
{
    public partial class ChangePassword : DevExpress.XtraEditors.XtraForm
    {
        public ChangePassword(string username)
        {
            this.username = username;
            InitializeComponent();
            btnHideShowPass1.HoverState.ImageSize = new Size(20, 20);
            btnHideShowPass1.PressedState.ImageSize = new Size(20, 20);
            btnHideShowPass2.HoverState.ImageSize = new Size(20, 20);
            btnHideShowPass2.PressedState.ImageSize = new Size(20, 20);
        }
        private string username;
        private bool isDragging = false;
        private Point startPoint;
        private bool isNewPasswordMasked = true;
        private bool isConfirmPasswordMasked = true;
        private void btnHideShowPass1_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.PasswordChar == '*')
            {
                txtNewPassword.PasswordChar = '\0';
            }
            else
            {
                txtNewPassword.PasswordChar = '*';
            }
        }

        private void btnHideShowPass2_Click(object sender, EventArgs e)
        {
            if (txtEditConfirmPassword.PasswordChar == '*')
            {
                txtEditConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtEditConfirmPassword.PasswordChar = '*';
            }
        }

        private void btnResetPw_Click(object sender, EventArgs e)
        {
            var context = new Model_QLCHCC();
            //định dạng mật khẩu phải có từ 8-16 kí tự và phải có ít nhất 1 số 
            string pattern = @"^(?=.*?[0-9])(?=.*?[a-zA-Z]).{8,16}$";
            Regex rg = new Regex(pattern);

            string newPass = txtNewPassword.Text;
            string comPass = txtEditConfirmPassword.Text;

            try
            {
                // Tìm người dùng trong cơ sở dữ liệu
                var user = context.USERS.FirstOrDefault(u => u.MaTheCuDan == username);
                if (!rg.IsMatch(newPass) || !rg.IsMatch(comPass))
                {
                    MessageBox.Show("Password must be between 8-22 characters and have at least 1 number", "Notice", MessageBoxButtons.OK);
                    return;
                }
                if (txtEditConfirmPassword.Text != txtNewPassword.Text)
                {
                    MessageBox.Show("Password mismatch", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (user != null)
                {
                    // Cập nhật mật khẩu mới
                    user.MatKhau = txtNewPassword.Text;
                    context.SaveChanges();

                    MessageBox.Show("The password has been changed successfully!", "Notice", MessageBoxButtons.OK);

                    Login lg = new Login();
                    lg.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("The user does not exis!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
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
        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                isNewPasswordMasked = true;
                txtNewPassword.PasswordChar = '\0';
            }
            else if (isNewPasswordMasked)
            {
                isNewPasswordMasked = false;
                txtNewPassword.PasswordChar = '*';
            }
        }
        private void txtEditConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEditConfirmPassword.Text))
            {
                isConfirmPasswordMasked = true;
                txtEditConfirmPassword.PasswordChar = '\0';
            }
            else if (isConfirmPasswordMasked)
            {
                isConfirmPasswordMasked = false;
                txtEditConfirmPassword.PasswordChar = '*';
            }
        }
        private void btnHideShowPass1_MouseEnterLeave(object sender, EventArgs e)
        {
            if (txtNewPassword.PlaceholderText == "8-22 characters and least 1 number" &&
                string.IsNullOrEmpty(txtNewPassword.Text))
            {
                txtNewPassword.PasswordChar = '\0';
                isNewPasswordMasked = true;
            }
            else
            {
                txtNewPassword.PasswordChar = isNewPasswordMasked ? '*' : '\0';
                isNewPasswordMasked = !isNewPasswordMasked;
            }
        }
        private void btnHideShowPass2_MouseEnterLeave(object sender, EventArgs e)
        {
            if (txtEditConfirmPassword.PlaceholderText == "Comfirm Your Pasword" &&
                string.IsNullOrEmpty(txtEditConfirmPassword.Text))
            {
                txtEditConfirmPassword.PasswordChar = '\0';
                isConfirmPasswordMasked = true;
            }
            else
            {
                txtEditConfirmPassword.PasswordChar = isConfirmPasswordMasked ? '*' : '\0';
                isConfirmPasswordMasked = !isConfirmPasswordMasked;
            }
        }
    }
}