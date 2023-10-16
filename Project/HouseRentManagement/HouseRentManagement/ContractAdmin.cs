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
using System.Runtime.Remoting.Contexts;

namespace HouseRentManagement
{
    public partial class ContractAdmin : DevExpress.XtraEditors.XtraForm
    {
        Model_QLCHCC dbChungCu = new Model_QLCHCC();
        public ContractAdmin()
        {
            InitializeComponent();
        }

        public void BindGrid(List<HOPDONGTHUE> listHDT)
        {
            dgvContract.Rows.Clear();
            foreach (var item in listHDT)
            {
                int index = dgvContract.Rows.Add();
                // Đổ dữ liệu xuống dòng dgv
                dgvContract.Rows[index].Cells[0].Value = item.SoHopDong;
                dgvContract.Rows[index].Cells[1].Value = item.NgayLap;
                dgvContract.Rows[index].Cells[2].Value = item.TienCoc;
                dgvContract.Rows[index].Cells[3].Value = item.TienThue;
                dgvContract.Rows[index].Cells[4].Value = item.NoiDung;
                dgvContract.Rows[index].Cells[5].Value = item.NgayBD;
                dgvContract.Rows[index].Cells[6].Value = item.NgayKT;
                dgvContract.Rows[index].Cells[7].Value = item.MaChuSoHuu;
                dgvContract.Rows[index].Cells[8].Value = item.MaNguoiThue;
                dgvContract.Rows[index].Cells[9].Value = item.MaCanHo;
            }
        }

        private void Contract_Load(object sender, EventArgs e)
        {
            try
            {
                List<HOPDONGTHUE> listHDT = dbChungCu.HOPDONGTHUEs.ToList();

                BindGrid(listHDT);

                gnlMaCanHo.DataSource = listHDT;
                gnlMaCanHo.DisplayMember = "MaCanHo";
                gnlMaCanHo.ValueMember = "MaCanHo";

                gnlMaChuSoHuu.DataSource = listHDT;
                gnlMaChuSoHuu.DisplayMember = "MaChuSoHuu";
                gnlMaChuSoHuu.ValueMember = "MaChuSoHuu";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool CheckNull()
        {
            if (bnfSoHopDong.Text == "" || bnfTienCoc.Text == "" || bnfTienThue.Text == "" || bnfMaNguoiThue.Text == "")
            {
                MessageBox.Show("Please complete all information!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (bnfTienCoc.TextLength < 6)
            {
                MessageBox.Show("Employee ID must be longer than 5 characters!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool CheckSoHopDong(string sohopdong)
        {
            var check = dbChungCu.HOPDONGTHUEs.FirstOrDefault(id => id.SoHopDong.Equals(sohopdong));
            if (check != null) return false;
            return true;
        }

        private void LoaddgvHDT()
        {
            List<HOPDONGTHUE> listHDT = dbChungCu.HOPDONGTHUEs.ToList();
            BindGrid(listHDT);
        }

        private void LoadForm()
        {
            bnfSoHopDong.Clear();
            bnfTienCoc.Clear();
            bnfTienThue.Clear();
            bnfMaNguoiThue.Clear();
        }

        private void bnfInsert_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                if (CheckSoHopDong(bnfSoHopDong.Text))
                {
                    if (!IsValidContract())
                        return;
                    if (dtpCreateDate.Value > DateTime.Now)
                    {
                        MessageBox.Show("Invalid date created!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (gnfNgayBD.Value.AddHours(12) < DateTime.Now)
                    {
                        MessageBox.Show("Invalid date Begin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (gnfNgayKT.Value < DateTime.Now || gnfNgayKT.Value < gnfNgayBD.Value)
                    {
                        MessageBox.Show("Invalid date End!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    HOPDONGTHUE newSoHopDongThue = new HOPDONGTHUE();

                    newSoHopDongThue.SoHopDong = bnfSoHopDong.Text;
                    newSoHopDongThue.TienCoc = Convert.ToDecimal(bnfTienCoc.Text);
                    newSoHopDongThue.TienThue = Convert.ToDecimal(bnfTienThue.Text);
                    newSoHopDongThue.NgayLap = dtpCreateDate.Value;
                    newSoHopDongThue.NgayBD = gnfNgayBD.Value;
                    newSoHopDongThue.NgayKT = gnfNgayKT.Value;
                    newSoHopDongThue.MaChuSoHuu = gnlMaChuSoHuu.Text;
                    newSoHopDongThue.MaNguoiThue = bnfMaNguoiThue.Text;
                    newSoHopDongThue.MaCanHo = gnlMaCanHo.Text;
                    newSoHopDongThue.NoiDung = "";

                    try
                    {
                        dbChungCu.HOPDONGTHUEs.AddOrUpdate(newSoHopDongThue);
                        dbChungCu.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    

                    LoaddgvHDT();
                    LoadForm();

                    MessageBox.Show($"Add Contract successful!",
                         "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Contract ID {bnfSoHopDong.Text} already exist!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bnfUpdate_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                string updatedSoHopDong = bnfSoHopDong.Text;

                // Tìm hợp đồng cần cập nhật
                HOPDONGTHUE updateHopDong = dbChungCu.HOPDONGTHUEs.FirstOrDefault(hd => hd.SoHopDong == updatedSoHopDong);

                if (updateHopDong != null)
                {
                    if (!IsValidContract())
                        return;
                    // Cập nhật thông tin hợp đồng
                    updateHopDong.TienCoc = Convert.ToDecimal(bnfTienCoc.Text);
                    updateHopDong.TienThue = Convert.ToDecimal(bnfTienThue.Text);
                    // Cập nhật MaChuSoHuu - Chúng ta giả sử MaChuSoHuu cũng là một thuộc tính của HOPDONGTHUE
                    updateHopDong.MaChuSoHuu = gnlMaChuSoHuu.Text;
                    updateHopDong.MaNguoiThue = bnfMaNguoiThue.Text;
                    // Cập nhật MaCanHo - Chúng ta giả sử MaCanHo cũng là một thuộc tính của HOPDONGTHUE
                    updateHopDong.MaCanHo = gnlMaCanHo.SelectedItem.ToString();
                    updateHopDong.NoiDung = null;

                    // Lưu thay đổi vào cơ sở dữ liệu
                    dbChungCu.SaveChanges();

                    // Cập nhật DataGridView và xóa dữ liệu trên các control nhập liệu
                    LoaddgvHDT();
                    LoadForm();

                    MessageBox.Show($"Updated Contract ID {updatedSoHopDong} successful!",
                        "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Contract ID not found!",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
        private bool IsValidContract()
        {
            float deposit = float.Parse(bnfTienCoc.Text);
            float renFee = float.Parse(bnfTienThue.Text);
            string tenantID = bnfMaNguoiThue.Text;
            string condoID = gnlMaCanHo.Text;
            if(deposit <= 0 || renFee <= 0)
            {
                MessageBox.Show("Invalid date Deposit or Ren Fee!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //var isExistID = dbChungCu.HOPDONGTHUEs.FirstOrDefault(id => id.MaNguoiThue.Equals(tenantID));
            //if(isExistID != null)
            //{
            //    MessageBox.Show("Tenant ID already exists in Condo Contract!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            var isFullCondo = dbChungCu.HOPDONGTHUEs.FirstOrDefault(id => id.MaCanHo.Equals(condoID));
            if (isFullCondo != null)
            {
                MessageBox.Show("This Condo is full!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            NGUOITHUE tennant = dbChungCu.NGUOITHUEs.FirstOrDefault(id => id.MaNguoiThue.Equals(tenantID));
            if (tennant == null) 
            {
                MessageBox.Show("Tenant ID not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(!IsUnder18(tennant.NgaySinh.Value))
            {
                MessageBox.Show("The contract owner must be at least 18 years old!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            return true;
        }

        private void bnfDelete_Click(object sender, EventArgs e)
        {
            string deletedSoHopDong = bnfSoHopDong.Text;

            // Tìm hợp đồng cần xoá
            HOPDONGTHUE deletedHopDong = dbChungCu.HOPDONGTHUEs.FirstOrDefault(hd => hd.SoHopDong == deletedSoHopDong);

            if (deletedHopDong != null)
            {
                // Xoá hợp đồng khỏi cơ sở dữ liệu
                dbChungCu.HOPDONGTHUEs.Remove(deletedHopDong);
                dbChungCu.SaveChanges();

                // Cập nhật DataGridView và xóa dữ liệu trên các control nhập liệu
                LoaddgvHDT();
                LoadForm();

                MessageBox.Show($"Deleted Contract ID {deletedSoHopDong} Successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Contract ID not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchContract_TextChange(object sender, EventArgs e)
        {
            string searchQuery = txtSearchContract.Text.ToLower();

            // Filter the list of contracts based on the search query
            List<HOPDONGTHUE> filteredContracts = dbChungCu.HOPDONGTHUEs
                .Where(contract => contract.SoHopDong.ToLower().Contains(searchQuery) ||
                                   contract.NgayLap.ToString().Contains(searchQuery) ||
                                   contract.TienCoc.ToString().Contains(searchQuery) ||
                                   contract.TienThue.ToString().Contains(searchQuery) ||
                                   contract.NoiDung.ToLower().Contains(searchQuery) ||
                                   contract.NgayBD.ToString().Contains(searchQuery) ||
                                   contract.NgayKT.ToString().Contains(searchQuery) ||
                                   contract.MaChuSoHuu.ToLower().Contains(searchQuery) ||
                                   contract.MaNguoiThue.ToLower().Contains(searchQuery) ||
                                   contract.MaCanHo.ToLower().Contains(searchQuery))
                .ToList();

            // Update the DataGridView with the filtered contracts
            BindGrid(filteredContracts);
        }

        private void bnfTienCoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Number only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true; // Từ chối ký tự không phải số
            }
        }

       

        private void dgvContract_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvContract.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvContract.SelectedRows[0];
                string maHD = selectedRow.Cells[0].Value.ToString();

                // Tìm BANQUANLY tương ứng trong context
                HOPDONGTHUE selected = dbChungCu.HOPDONGTHUEs.FirstOrDefault(bq => bq.SoHopDong == maHD);

                if (selected != null)
                {
                    bnfSoHopDong.Text = selected.SoHopDong;
                    dtpCreateDate.Value = selected.NgayLap.Value;
                    bnfTienCoc.Text = selected.TienCoc.ToString();
                    bnfTienThue.Text = selected.TienThue.ToString();
                    gnfNgayBD.Value = selected.NgayBD.Value;
                    gnfNgayKT.Value = selected.NgayKT.Value;
                    gnlMaChuSoHuu.Text = selected.MaChuSoHuu;
                    bnfMaNguoiThue.Text = selected.MaNguoiThue;
                    gnlMaCanHo.Text = selected.MaCanHo;

                }
            }
        }

        
    }
}