using FluentEmail.Core;
using FluentEmail.Razor;
using FluentEmail.Smtp;
using HouseRentManagement.HRMcontextDB;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HouseRentManagement
{
    public partial class ForgotPassword : DevExpress.XtraEditors.XtraForm
    {
        private string captchaText;
        private bool isDragging = false;
        private Point startPoint;
        private string connString = ConfigurationManager.ConnectionStrings["HRMContextDB"].ConnectionString;
        private int atick = 90;
        int otp = 0;
        DateTime date;
        private string mail;
        private string username;
        public ForgotPassword(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        public static byte[] EncryptData(string data)
        {
            using (var md5Hasher = new System.Security.Cryptography.MD5CryptoServiceProvider())
            {
                byte[] hashedBytes;
                System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
                hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(data));
                return hashedBytes;
            }
        }

        public static string MD5(string data)
        {
            return BitConverter.ToString(EncryptData(data)).Replace("-", "").ToLower();
        }

        public string RandomString()
        {
            Random rnd = new Random();
            int number = rnd.Next(10000, 99999);
            string text = MD5(number.ToString());
            text = text.ToUpper();
            text = text.Substring(0, 6);
            return text;
        }

        private Bitmap DrawImage(string txt, int w, int h)
        {
            Bitmap bt = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(bt);
            SolidBrush sb = new SolidBrush(Color.White);

            g.FillRectangle(sb, 0, 0, bt.Width, bt.Height);
            Font font = new Font("Tahoma", 30);
            sb = new SolidBrush(Color.Blue);
            g.DrawString(txt, font, sb, bt.Width / 2 - (txt.Length / 2) * font.Size, (bt.Height / 2) - font.Size);

            // Tạo hiệu ứng cho captcha

            // Vẽ dấu chấm
            int count = 0;

            Random rand = new Random();
            while (count < 1000)
            {
                sb = new SolidBrush(Color.YellowGreen);
                g.FillEllipse(sb, rand.Next(0, bt.Width), rand.Next(0, bt.Height), 4, 2);
                count++;
            }
            count = 0;

            // Vẽ đường gạch ngang
            while (count < 25)
            {
                g.DrawLine(new Pen(Color.Pink), rand.Next(0, bt.Width), rand.Next(0, bt.Height), rand.Next(0, bt.Width), rand.Next(0, bt.Height));
                count++;
            }
            // Kết thúc tạo hiệu ứng
            return bt;
        }

        private void Reset()
        {
            captchaText = RandomString();
            txtBoxCaptcha.Text = "";
            // Vẽ captcha lên panel 1
            pnlCaptcha.BackgroundImage = DrawImage(captchaText, pnlCaptcha.Width, pnlCaptcha.Height);
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new SqlConnection(connString))
                {
                    connection.Open();

                    string username = txtBoxUsername.Text;
                    string captcha = txtBoxCaptcha.Text;
                    string getOTP = txtBoxGetOTP.Text;
                    string email = txtBoxEmail.Text;

                    if (string.IsNullOrEmpty(captcha) || string.IsNullOrEmpty(username) ||
                        string.IsNullOrEmpty(email) || string.IsNullOrEmpty(getOTP))
                    {
                        MessageBox.Show("Please Enter Full Information", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Reset();
                        return;
                    }

                    if (txtBoxCaptcha.Text != captchaText)
                    {
                        MessageBox.Show("Wrong Captcha", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Reset();
                        return;
                    }

                    string query = "SELECT * FROM USERS WHERE MaTheCuDan = @username AND Captcha = @captcha";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@captcha", captcha);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string userId = reader["UserId"].ToString();
                        ChangePassword cp = new ChangePassword(userId);
                        cp.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong UserName", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool IsValidEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            //ràng buộc phải @gmail.com
            string strRegex = @"^([a-zA-Z0-9]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);

            if (re.IsMatch(inputEmail))//nếu là re đúng vs định dạng thì true còn k thì false
                return (true);
            else
            {
                return (false);
            }
        }
        private void timeOTP_Tick(object sender, EventArgs e)
        {
            btnCountDown.Text = atick.ToString();
            atick--;

            if (atick < 0)
            {
                timeOTP.Stop();
                btnGetOTP.Enabled = true;
                btnGetOTP.Text = "Get OTP";
                btnCountDown.Visible = false;
            }
            else
            {
                btnGetOTP.Text = atick.ToString();
            }
        }
        private int randomMaOTP()
        {
            Random random = new Random();
            int rdotp = random.Next(100000, 999999);
            return rdotp;
        }
       
        private bool checkMail(string chkmail)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM NGUOITHUE WHERE Email = @email";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@email", chkmail);

                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private async void btnGetOTP_Click(object sender, EventArgs e)
        {
            if (txtBoxEmail.Text.Contains("@") && !txtBoxEmail.Text.EndsWith(".") && IsValidEmail(txtBoxEmail.Text))
            {
                string username = ""; // You need to provide the value for the username variable

                if (checkMail(txtBoxEmail.Text))
                {
                    // Tạo OTP và lưu thông tin
                    otp = randomMaOTP();
                    date = DateTime.Now; 
                    mail = txtBoxEmail.Text.Trim();
                    string senderEmail = "jungleuncles@gmail.com"; // Địa chỉ email người gửi
                    string smtpServer = "smtp.gmail.com"; // Địa chỉ máy chủ SMTP của bạn
                    string senderPassword = "cbrrjoqsjhgzswpj";
                    int smtpPort = 587; // Cổng SMTP của bạn
                    // Gửi email chứa OTP
                    var smtpSender = new SmtpSender(() => new SmtpClient(smtpServer, smtpPort)
                    {
                        Credentials = new NetworkCredential(senderEmail,senderPassword),
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        Port = 587
                    });
                    var context = new NGUOITHUE();
                    using (SqlConnection connection = new SqlConnection(connString))
                    {
                        connection.Open();
                        string query = @"SELECT nt.TenNguoiThue FROM NGUOITHUE nt 
                                JOIN THECUDAN tcd ON tcd.MaNguoiThue = nt.MaNguoiThue
                                WHERE tcd.MaTheCuDan = @username";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@username", username);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                context.TenNguoiThue = reader["TenNguoiThue"].ToString();
                            }
                        }
                    }

                    if (context != null)
                    {
                        StringBuilder template = new StringBuilder();
                        template.AppendLine($"Hello {context.TenNguoiThue},");
                        template.AppendLine($"<p>Your OTP: {otp}</p>");
                        template.AppendLine("Please use this OTP to verify your account.");
                        template.AppendLine("<p>Thank you!</p>");

                        Email.DefaultSender = smtpSender;
                        Email.DefaultRenderer = new RazorRenderer();
                        

                        var email = Email
                            .From(senderEmail)
                            .To(mail)
                            .Subject("Verify OTP")
                            .UsingTemplate(template.ToString(), context);
                        try
                        {
                            await email.SendAsync();
                            // Vô hiệu hóa nút btnGetOTP
                            btnGetOTP.Enabled = false;

                            // Hiển thị số lượng đếm ngược
                            btnCountDown.Text = atick.ToString();
                            btnCountDown.Visible = true;

                            // Bắt đầu đếm ngược
                            timeOTP.Start();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi gửi email: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username không tồn tại trong hệ thống");
                    }
                }
                else
                {
                    MessageBox.Show("Email không tồn tại trong hệ thống");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email");
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

        
    }
}