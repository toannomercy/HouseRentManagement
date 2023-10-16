using DevExpress.XtraEditors;
using HouseRentManagement.HRMcontextDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseRentManagement
{
    public partial class Employee : DevExpress.XtraEditors.XtraForm
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Model_QLCHCC"].ConnectionString;

        Model_QLCHCC context = new Model_QLCHCC();
        public Employee()
        {
            InitializeComponent();
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
        private void BindGrid(List<BANQUANLY> lsBanQuanLy)
        {
            dgvDSEMPLOYEE.Rows.Clear();
            foreach (var item in lsBanQuanLy)
            {
                int index = dgvDSEMPLOYEE.Rows.Add();
                dgvDSEMPLOYEE.Rows[index].Cells[0].Value = item.MaQL;
                dgvDSEMPLOYEE.Rows[index].Cells[1].Value = item.TenQuanLy;
                dgvDSEMPLOYEE.Rows[index].Cells[2].Value = item.CHUCVU.TenChucVu;
                dgvDSEMPLOYEE.Rows[index].Cells[3].Value = item.CCCD;
                dgvDSEMPLOYEE.Rows[index].Cells[4].Value = item.NgaySinh;
                string gender = GetGender(item.GioiTinh);
                dgvDSEMPLOYEE.Rows[index].Cells[5].Value = gender;
                dgvDSEMPLOYEE.Rows[index].Cells[6].Value = item.SDT;
                dgvDSEMPLOYEE.Rows[index].Cells[7].Value = item.Email;
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            List<BANQUANLY> lsBanQuanLy = context.BANQUANLies.ToList();
            BindGrid(lsBanQuanLy);
            FillChuVuCombobox(lsBanQuanLy);
        }
        private void FillChuVuCombobox(List<BANQUANLY> lsBanQuanLy)
        {
            List<CHUCVU> chucVuList = context.CHUCVUs.ToList();
            //var chucVuData = (from bq in lsBanQuanLy
            //                  join cv in chucVuList on bq.MaCV equals cv.MaCV
            //                  select new CHUCVU
            //                  {
            //                      MaCV = bq.MaCV,
            //                      TenChucVu = cv.TenChucVu
            //                  }).ToList();

            this.cbbRole.DataSource = chucVuList;
            this.cbbRole.DisplayMember = "TenChucVu";
            this.cbbRole.ValueMember = "MaCV";
            this.cbbRole.SelectedIndex = 1;
        }
        private void cbbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                string newTenantID = txtTenantID.Text;
                string sdt = txtPhoneNumber.Text;
                string cccd = txtProofID.Text;
                if (sdt.Length != 10 || IsAllDigitsSame(sdt) || cccd.Length != 12 || IsAllDigitsSame(cccd))
                {
                    MessageBox.Show("Wrong format Employ Identify or Employee Contact!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DateTime dob = dtpDoB.Value;
                if (!IsUnder18(dob))
                {
                    MessageBox.Show("Employees must be at least 18 years old!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!CheckValidIdentification())
                    return;
                if (CheckEmployee(newTenantID) == -1) // Kiểm tra xem người quản lý đã tồn tại chưa
                {
                    BANQUANLY newBanQuanLy = new BANQUANLY();
                    newBanQuanLy.MaQL = newTenantID;
                    newBanQuanLy.TenQuanLy = txtTenantName.Text;
                    CHUCVU selectedChucVu = (CHUCVU)cbbRole.SelectedItem;
                    newBanQuanLy.MaCV = selectedChucVu.MaCV;
                    newBanQuanLy.CCCD = txtProofID.Text; // Lấy giá trị từ TextBox thay vì từ đối tượng txtProofID
                    newBanQuanLy.NgaySinh = dtpDoB.Value;
                    newBanQuanLy.GioiTinh = GetGenderFromRadioButton();
                    newBanQuanLy.SDT = txtPhoneNumber.Text;
                    newBanQuanLy.Email = txtEmail.Text;

                    context.BANQUANLies.Add(newBanQuanLy); // Sử dụng Add thay vì AddOrUpdate
                    try
                    {
                        context.SaveChanges();
                        MessageBox.Show($"Add employee {newBanQuanLy.MaQL} successful!",
                            "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoaddgvDSSV();
                        LoadForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"Employee ID {newTenantID} already exists!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private int CheckEmployee(string TenantID)
        {
            int length = dgvDSEMPLOYEE.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if (dgvDSEMPLOYEE.Rows[i].Cells[0].Value != null)
                    if (dgvDSEMPLOYEE.Rows[i].Cells[0].Value.ToString() == TenantID)
                        return i;
            }
            return -1;
        }

        private void LoaddgvDSSV()
        {
            List<BANQUANLY> newBanQuanLy = context.BANQUANLies.ToList();
            BindGrid(newBanQuanLy);
        }

        private void LoadForm()
        {
            txtTenantID.Clear();
            txtTenantName.Clear();
            txtProofID.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
        }
        private bool IsUnder18(DateTime dob)
        {
            DateTime nowDate = DateTime.Now;

            // Tính tuổi chính xác
            int age = nowDate.Year - dob.Year;

            // Kiểm tra xem người dùng có đủ 18 tuổi hay không
            if (nowDate < dob.AddYears(age))
                age--;
            if (age >= 18)
                return true;
            return false;
        }
        private bool CheckValidIdentification()
        {
            string identification = txtProofID.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create a query to check if the ID card number exists
                string query = "SELECT COUNT(*) FROM BANQUANLY WHERE CCCD = @CCCD";
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
        private bool CheckNull()
        {
            if (txtTenantID.Text == "" || txtTenantName.Text == "" || txtProofID.Text == ""
                || txtPhoneNumber.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Please complete all information!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtTenantID.TextLength < 4)
            {
                MessageBox.Show("Employee ID must be longer than 3 characters!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (ContainsNumber(txtTenantName.Text))
            {
                MessageBox.Show("Characters only!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool ContainsNumber(string text)
        {
            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            BANQUANLY EmployeeDelete = context.BANQUANLies.FirstOrDefault(p => p.MaQL == txtTenantID.Text);
            if (EmployeeDelete != null)
            {
                DialogResult dg = MessageBox.Show($"Are you sure to delete the employee info? {EmployeeDelete.MaQL}",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    context.BANQUANLies.Remove(EmployeeDelete);
                    context.SaveChanges();

                    // reset lại thông tin sau khi xoá
                    LoaddgvDSSV();
                    LoadForm();

                    MessageBox.Show($"Deleted employee ID {EmployeeDelete.MaQL} successful!",
                        "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                // lấy phần tử đầu tiên thoả điều kiện
                string newTenantID = txtTenantID.Text;
                string sdt = txtPhoneNumber.Text;
                string cccd = txtProofID.Text;
                if (sdt.Length != 10 || IsAllDigitsSame(sdt) || cccd.Length != 12 || IsAllDigitsSame(cccd))
                {
                    MessageBox.Show("Wrong format Employ Identify or Employee Contact!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DateTime dob = dtpDoB.Value;
                if (!IsUnder18(dob))
                {
                    MessageBox.Show("Employees must be at least 18 years old!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                BANQUANLY updateEmployee = context.BANQUANLies.FirstOrDefault(p => p.MaQL == newTenantID);
                if (updateEmployee.CCCD != txtProofID.Text)
                {
                    MessageBox.Show("The Citizen Identification code cannot be changed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProofID.Text = updateEmployee.CCCD;
                    return;
                }
                CHUCVU selectedChucVu = (CHUCVU)cbbRole.SelectedItem;

                if (updateEmployee != null)
                {
                    updateEmployee.MaQL = txtTenantID.Text;
                    updateEmployee.TenQuanLy = txtTenantName.Text;
                    updateEmployee.MaCV = selectedChucVu.MaCV;
                    updateEmployee.CCCD = txtProofID.Text;
                    updateEmployee.NgaySinh = dtpDoB.Value;
                    updateEmployee.GioiTinh = GetGenderFromRadioButton();
                    updateEmployee.SDT = txtPhoneNumber.Text;
                    updateEmployee.Email = txtEmail.Text;

                    // Đưa dữ liệu khi thay đổi vào DB
                    context.BANQUANLies.AddOrUpdate(updateEmployee);
                    context.SaveChanges();

                    LoaddgvDSSV();
                    LoadForm();

                    MessageBox.Show($"Updated employee {updateEmployee.MaQL} successful!",
                        "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Employee ID not found!",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
        private void dgvDSEMPLOYEE_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSEMPLOYEE.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDSEMPLOYEE.SelectedRows[0];
                string maQL = selectedRow.Cells[0].Value.ToString();

                // Tìm BANQUANLY tương ứng trong context
                BANQUANLY selectedBanQuanLy = context.BANQUANLies.FirstOrDefault(bq => bq.MaQL == maQL);

                if (selectedBanQuanLy != null)
                {
                    txtTenantID.Text = selectedBanQuanLy.MaQL;
                    txtTenantName.Text = selectedBanQuanLy.TenQuanLy;
                    txtProofID.Text = selectedBanQuanLy.CCCD;
                    dtpDoB.Value = selectedBanQuanLy.NgaySinh.Value;
                    txtPhoneNumber.Text = selectedBanQuanLy.SDT;
                    txtEmail.Text = selectedBanQuanLy.Email;
                    SetGenderToRadioButton(selectedBanQuanLy.GioiTinh);

                    // Chọn chức vụ tương ứng trong combobox
                    CHUCVU selectedChucVu = context.CHUCVUs.FirstOrDefault(cv => cv.MaCV == selectedBanQuanLy.MaCV);
                    if (selectedChucVu != null)
                    {
                        cbbRole.SelectedValue = selectedChucVu.MaCV;
                    }

                    // Chọn giới tính tương ứng trong radiobutton
                }
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
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

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
            string searchText = bunifuTextBox1.Text.Trim();

            // Filter the data based on the search text
            List<BANQUANLY> filteredData = context.BANQUANLies
                .Where(bq => bq.MaQL.Contains(searchText) ||
                             bq.TenQuanLy.Contains(searchText) ||
                             bq.CCCD.Contains(searchText) ||
                             bq.SDT.Contains(searchText) ||
                             bq.Email.Contains(searchText))
                .ToList();

            // Bind the filtered data to the grid
            BindGrid(filteredData);
        }

        private void txtProofID_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}