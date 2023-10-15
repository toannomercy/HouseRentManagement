using HouseRentManagement.HRMcontextDB;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HouseRentManagement
{
    public partial class ProfileUser : DevExpress.XtraEditors.XtraForm
    {
        private string username;
        private bool isEditing = false;

        private string connString = ConfigurationManager.ConnectionStrings["HRMContextDB"].ConnectionString;

        public ProfileUser(string username)
        {
            InitializeComponent();
            lblLinkDone.Hide();
            this.username = username;
        }

        private void lblLinkEdit_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                lblLinkDone.Hide();
                SetTextBoxesReadOnly(true);
                SetTextBoxesEnabled(false);
                dtpDoB.Enabled = false;
            }
            else
            {
                lblLinkDone.Show();
                SetTextBoxesReadOnly(false);
                SetTextBoxesEnabled(true);
                dtpDoB.Enabled = true;
            }
            isEditing = !isEditing;

            if (!isEditing)
            {
                BindUserProfile();
                BindCondoInfo();
                BindResidentCardID();
            }
        }

        private void lblLinkDone_Click(object sender, EventArgs e)
        {
            bool isValidEmail = true;
            string sdt = txtBoxContactNumber.Text;
            if (sdt.Length != 10 || IsAllDigitsSame(sdt))
            {
                MessageBox.Show("Wrong format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!string.IsNullOrEmpty(txtBoxEmail.Text))
            {
                if (!IsValidEmail(txtBoxEmail.Text))
                {
                    MessageBox.Show("Invalid email address", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isValidEmail = false;
                }
                else
                {
                    SaveChanges();
                    lblLinkDone.Hide();
                    SetTextBoxesReadOnly(false);
                    SetTextBoxesEnabled(false);
                    dtpDoB.Enabled = false;
                }
            }
            isEditing = !isEditing;
        }
        private bool IsAllDigitsSame(string text)
        {
            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] != text[0])
                {
                    return false;
                }
            }
            return true;
        }

        private void ProfileUser_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            BindUserProfile();
            BindCondoInfo();
            BindResidentCardID();
        }

        private void SetTextBoxesReadOnly(bool isReadOnly)
        {
            txtBoxContactNumber.ReadOnly = isReadOnly;
            txtBoxFullName.ReadOnly = isReadOnly;
            txtBoxEmail.ReadOnly = isReadOnly;
        }

        private void SetTextBoxesEnabled(bool isEnabled)
        {
            txtBoxContactNumber.Enabled = isEnabled;
            txtBoxFullName.Enabled = isEnabled;
            txtBoxEmail.Enabled = isEnabled;
        }

        private void SaveChanges()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string query = @"UPDATE NguoiThue SET TenNguoiThue = @tenNguoiThue, SDT = @sdt, Email = @email, NgaySinh = @ngaySinh
                                FROM NGUOITHUE nt JOIN THECUDAN tcd ON nt.MaNguoiThue = tcd.MaNguoiThue 
                                WHERE MaTheCuDan IN (SELECT MaTheCuDan FROM TheCuDan WHERE MaTheCuDan = @username)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@tenNguoiThue", txtBoxFullName.Text);
                    cmd.Parameters.AddWithValue("@sdt", txtBoxContactNumber.Text);
                    cmd.Parameters.AddWithValue("@email", txtBoxEmail.Text);
                    cmd.Parameters.AddWithValue("@ngaySinh", dtpDoB.Value);

                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
        }

        private bool IsValidEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);

            if (re.IsMatch(inputEmail))
                return true;
            else
                return false;
        }

        private void BindCondoInfo()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string query = @"SELECT csh.TenChuSoHuu, csh.SDT, csh.Email, hdt.MaCanHo 
                                 FROM TheCuDan tcd 
                                 INNER JOIN NguoiThue nt ON tcd.MaNguoiThue = nt.MaNguoiThue 
                                 INNER JOIN HopDongThue hdt ON nt.MaNguoiThue = hdt.MaNguoiThue 
                                 INNER JOIN ChuSoHuu csh ON hdt.MaChuSoHuu = csh.MaChuSoHuu 
                                 WHERE tcd.MaTheCuDan = @username";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtBoxOwner.Text = reader.GetString(0);
                            txtBoxOwnerContact.Text = reader.GetString(1);
                            txtBoxOwnerEmail.Text = reader.GetString(2);
                            txtBoxTenantName.Text = reader.GetString(3);
                        }
                    }
                }

                conn.Close();
            }
        }

        private void BindUserProfile()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string query = @"SELECT tcd.MaTheCuDan, nt.TenNguoiThue, nt.SDT, nt.Email, nt.NgaySinh 
                                 FROM TheCuDan tcd 
                                 INNER JOIN NguoiThue nt ON tcd.MaNguoiThue = nt.MaNguoiThue 
                                 WHERE tcd.MaTheCuDan = @username";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtBoxFullName.Text = reader.GetString(1);
                            txtBoxContactNumber.Text = reader.GetString(2);
                            txtBoxEmail.Text = reader.GetString(3);
                            dtpDoB.Value = reader.GetDateTime(4);
                        }
                    }
                }

                conn.Close();
            }
        }
        private void BindResidentCardID()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();


                string query = @"
    SELECT tcd.MaTheCuDan, nt.TenNguoiThue, dsnk.MaCanHo
    FROM THECUDAN tcd
    JOIN NGUOITHUE nt ON tcd.MaNguoiThue = nt.MaNguoiThue
    JOIN DANHSACHNHANKHAU dsnk ON nt.MaNguoiThue = dsnk.MaNguoiThue
    WHERE dsnk.MaCanHo = (
        SELECT dsnk2.MaCanHo 
        FROM THECUDAN tcd2
        JOIN NGUOITHUE nt2 ON tcd2.MaNguoiThue = nt2.MaNguoiThue
        JOIN DANHSACHNHANKHAU dsnk2 ON nt2.MaNguoiThue = dsnk2.MaNguoiThue
        WHERE tcd2.MaTheCuDan = @username
    )";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<string[]> residentList = new List<string[]>();

                        while (reader.Read())
                        {
                            string residentCardID = reader.GetString(0);
                            string tenantName = reader.GetString(1);

                            string[] residentInfo = { residentCardID, tenantName };
                            residentList.Add(residentInfo);
                        }

                        dgvResidentCard.Rows.Clear();

                        foreach (string[] residentInfo in residentList)
                        {
                            dgvResidentCard.Rows.Add(residentInfo);
                        }
                    }

                    conn.Close();
                }
            }
        }

        private void BunifuTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Number only!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true; // Từ chối ký tự không phải số
            }

            // Kiểm tra chiều dài có đủ 10 chữ số hay không
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Wrong format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true; // Từ chối thêm ký tự khi đạt đủ 9 chữ số
            }
        }

        
    }
}