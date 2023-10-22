using DevExpress.XtraEditors;
using HouseRentManagement.HRMcontextDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Configuration;

namespace HouseRentManagement
{
    public partial class Tenant : DevExpress.XtraEditors.XtraForm
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Model_QLCHCC"].ConnectionString;

        Model_QLCHCC context = new Model_QLCHCC();
        public Tenant()
        {
            InitializeComponent();
            rbMale.Checked = true;

        }
        private ChildFormManager formManager = new ChildFormManager();

        private void BindGrid(List<NGUOITHUE> lsNguoiThue)
        {
            dgvTenant.Rows.Clear();
            foreach (var item in lsNguoiThue)
            {
                int index = dgvTenant.Rows.Add();
                dgvTenant.Rows[index].Cells[0].Value = item.MaNguoiThue;
                dgvTenant.Rows[index].Cells[1].Value = item.TenNguoiThue;
                dgvTenant.Rows[index].Cells[2].Value = item.CCCD;
                dgvTenant.Rows[index].Cells[3].Value = item.NgaySinh;
                string gender = GetGender(item.GioiTinh);
                dgvTenant.Rows[index].Cells[4].Value = gender;
                dgvTenant.Rows[index].Cells[5].Value = item.SDT;
                dgvTenant.Rows[index].Cells[6].Value = item.Email;
            }
        }

        private string GetGender(bool? isMale)
        {
            if (isMale.HasValue)
            {
                return isMale.Value ? "Nam" : "Nữ";
            }
            else
            {
                return "Unknown";
            }
        }

        private void Resident_Card_Load(object sender, EventArgs e)
        {
            List<NGUOITHUE> lsNguoiThue = context.NGUOITHUEs.ToList();
            BindGrid(lsNguoiThue);
        }
        private bool? GetGenderFromRadioButton()
        {
            if (rbMale.Checked)
            {
                return true;
            }
            else if (rbFemale.Checked)
            {
                return false;
            }
            else
            {
                return null;
            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                if (CheckTenantIdentify(txtTenantIdentify.Text) == -1) 
                {
                    string sdt = txtTenantContact.Text;
                    string cccd = txtTenantIdentify.Text;
                    if (sdt.Length != 10 || IsAllDigitsSame(sdt) || cccd.Length != 12 || IsAllDigitsSame(cccd))
                    {
                        MessageBox.Show("Wrong format Employ Identify or Employee Contact!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    DateTime dob = dtpTenant.Value;
                    if (dob > DateTime.Now)
                    {
                        MessageBox.Show("Invalid Date of Birth!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!CheckValidIdentification())
                        return;
                    NGUOITHUE newNguoiThue = new NGUOITHUE();

                    newNguoiThue.MaNguoiThue = txtTenantID.Text;
                    newNguoiThue.TenNguoiThue = txtTenantName.Text;
                    newNguoiThue.CCCD = txtTenantIdentify.Text;
                    newNguoiThue.NgaySinh = dtpTenant.Value;
                    newNguoiThue.GioiTinh = GetGenderFromRadioButton(); // Lấy giới tính từ RadioButton
                    newNguoiThue.SDT = txtTenantContact.Text;
                    newNguoiThue.Email = txtTenantEmail.Text;
                    // Thêm newNguoiThue vào cơ sở dữ liệu
                    context.NGUOITHUEs.Add(newNguoiThue);
                    context.SaveChanges();

                    LoaddgvDSSV();
                    LoadForm();

                    MessageBox.Show($"Add Tenant ID {newNguoiThue.MaNguoiThue} successful!",
                        "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show($"The Tenant ID {txtTenantIdentify.Text} already exist!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private int CheckTenantIdentify(string TenantID)
        {
            int length = dgvTenant.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if (dgvTenant.Rows[i].Cells[0].Value != null)
                    if (dgvTenant.Rows[i].Cells[0].Value.ToString() == TenantID)
                        return i;
            }
            return -1;
        }

        private void LoaddgvDSSV()
        {
            List<NGUOITHUE> newNguoiThue = context.NGUOITHUEs.ToList();
            BindGrid(newNguoiThue);
        }

        private void LoadForm()
        {
            txtTenantName.Clear();
            txtTenantContact.Clear();
            txtTenantEmail.Clear();
            txtTenantIdentify.Clear();
            txtTenantID.Clear();
            rbMale.Checked = true;
        }
        private bool CheckNull()
        {
            if (txtTenantContact.Text == "" || txtTenantEmail.Text == "" || txtTenantIdentify.Text == "" || txtTenantName.Text == "")
            {
                MessageBox.Show("Please complete all information!!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            NGUOITHUE ReCardDelete = context.NGUOITHUEs.FirstOrDefault(p => p.MaNguoiThue == txtTenantID.Text);
            if (ReCardDelete != null)
            {
                DialogResult dg = MessageBox.Show($"Are you sure to delete the tenant info? {ReCardDelete.MaNguoiThue}",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    context.NGUOITHUEs.Remove(ReCardDelete);
                    context.SaveChanges();

                    // reset lại thông tin sau khi xoá
                    LoaddgvDSSV();
                    LoadForm();

                    MessageBox.Show($"Deleted tennant ID {ReCardDelete.MaNguoiThue} successful!",
                        "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
        
        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                string tenantID = txtTenantID.Text;
                string sdt = txtTenantContact.Text;
                string cccd = txtTenantIdentify.Text;
                if (sdt.Length != 10 || IsAllDigitsSame(sdt) || cccd.Length != 12 || IsAllDigitsSame(cccd))
                {
                    MessageBox.Show("Wrong format Employ Identify or Employee Contact!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DateTime dob = dtpTenant.Value;
                if (dob > DateTime.Now)
                {
                    MessageBox.Show("Invalid Date of Birth!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                NGUOITHUE updatedNguoiThue = context.NGUOITHUEs.FirstOrDefault(nt => nt.MaNguoiThue == tenantID);
                if (updatedNguoiThue.CCCD != txtTenantIdentify.Text)
                {
                    MessageBox.Show("The Citizen Identification code cannot be changed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenantIdentify.Text = updatedNguoiThue.CCCD;
                    return;
                }
                if (updatedNguoiThue != null)
                {
                    updatedNguoiThue.TenNguoiThue = txtTenantName.Text;
                    updatedNguoiThue.CCCD = txtTenantIdentify.Text;
                    updatedNguoiThue.NgaySinh = dtpTenant.Value;
                    updatedNguoiThue.GioiTinh = GetGenderFromRadioButton(); // Lấy giới tính từ RadioButton
                    updatedNguoiThue.SDT = txtTenantContact.Text;
                    updatedNguoiThue.Email = txtTenantEmail.Text;

                    context.SaveChanges();

                    LoaddgvDSSV();
                    LoadForm();

                    MessageBox.Show($"Updated tennant {updatedNguoiThue.MaNguoiThue} successful!",
                        "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tenant ID not found!",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool CheckValidIdentification()
        {
            string identification = txtTenantIdentify.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create a query to check if the ID card number exists
                string query = "SELECT COUNT(*) FROM NGUOITHUE WHERE CCCD = @CCCD";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CCCD", identification);

                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("The Citizen Identification code already exists in the database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        private void SetGenderToRadioButton(bool? gender)
        {
            if (gender.HasValue)
            {
                if (gender.Value)
                {
                    rbMale.Checked = true;
                    rbFemale.Checked = false;
                }
                else
                {
                    rbMale.Checked = false;
                    rbFemale.Checked = true;
                }
            }
            else
            {
                rbMale.Checked = false;
                rbFemale.Checked = false;
            }
        }
        private void dgvDSReCard_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTenant.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvTenant.SelectedRows[0];
                string tenantID = selectedRow.Cells[0].Value.ToString();

                // Hiển thị thông tin người thuê lên các điều khiển
                NGUOITHUE nguoiThue = context.NGUOITHUEs.FirstOrDefault(nt => nt.MaNguoiThue == tenantID);
                if (nguoiThue != null)
                {
                    txtTenantID.Text = nguoiThue.MaNguoiThue;
                    txtTenantName.Text = nguoiThue.TenNguoiThue;
                    txtTenantIdentify.Text = nguoiThue.CCCD;
                    dtpTenant.Value = nguoiThue.NgaySinh.HasValue ? nguoiThue.NgaySinh.Value : DateTime.MinValue;
                    SetGenderToRadioButton(nguoiThue.GioiTinh); // Đặt giới tính cho RadioButton
                    txtTenantContact.Text = nguoiThue.SDT;
                    txtTenantEmail.Text = nguoiThue.Email;
                }
            }
        }
        private void ShowResidentCard()
        {
            if (formManager.CurrentChildForm is ResidentCard)
            {
                return;
            }
            formManager.CloseCurrentChildForm();
            ResidentCard rc = new ResidentCard();
            formManager.ShowChildForm(pnlContainer, rc);
        }
        private void tsbResidentCard_Click(object sender, EventArgs e)
        {
            ShowResidentCard();
            pnlTenant.Hide();
            btnClose2.Visible = true;
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            formManager.CloseCurrentChildForm();
            btnClose2.Visible = false;
            pnlTenant.Show();
        }

        private void txtBoxSearch_TextChange(object sender, EventArgs e)
        {
            string searchText = txtBoxSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                // Nếu TextBox tìm kiếm trống, hiển thị tất cả dữ liệu
                List<NGUOITHUE> lsNguoiThue = context.NGUOITHUEs.ToList();
                BindGrid(lsNguoiThue);
            }
            else
            {
                // Nếu có dữ liệu trong TextBox tìm kiếm, thực hiện tìm kiếm và hiển thị kết quả
                List<NGUOITHUE> searchResults = context.NGUOITHUEs
                    .Where(nt => nt.MaNguoiThue.Contains(searchText) ||
                                 nt.TenNguoiThue.Contains(searchText) ||
                                 nt.CCCD.Contains(searchText) ||
                                 nt.SDT.Contains(searchText) ||
                                 nt.Email.Contains(searchText))
                    .ToList();
                BindGrid(searchResults);
            }
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

        private void txtTenantIdentify_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Number only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true; // Từ chối ký tự không phải số
            }

            // Kiểm tra chiều dài có đủ 12 chữ số hay không
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length >= 12 && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Wrong format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true; // Từ chối thêm ký tự khi đạt đủ 12 chữ số
            }
        }

        private void txtTenantContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Number only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true; // Từ chối ký tự không phải số
            }

            // Kiểm tra chiều dài có đủ 10 chữ số hay không
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Wrong format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true; // Từ chối thêm ký tự khi đạt đủ 10 chữ số
            }
        }
    }
}