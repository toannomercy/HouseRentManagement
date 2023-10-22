using HouseRentManagement.HRMcontextDB;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace HouseRentManagement
{
    public partial class VehicleCard : DevExpress.XtraEditors.XtraForm
    {
        Model_QLCHCC context = new Model_QLCHCC();
        public VehicleCard()
        {
            InitializeComponent();
            FillcbbMaTheCuDan();
            FillComboBox();
            bindData();
        }
        private string connString = ConfigurationManager.ConnectionStrings["Model_QLCHCC"].ConnectionString;
        private bool CheckNull()
        {
            if (txtBienSoXe.Text == "" || txtTenXe.Text == "" || txtMaTheXe.Text == "" || txtHSD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Xe!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtBienSoXe.TextLength < 5)
            {
                MessageBox.Show("Biển số xe phải có 5 ký tự trở lên!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
        private int CheckBienSoXe(string NewBienSoXe)
        {
            int length = dgvVehicle.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if (dgvVehicle.Rows[i].Cells[0].Value != null)
                    if (dgvVehicle.Rows[i].Cells[0].Value.ToString() == NewBienSoXe)
                        return i;
            }
            return -1;
        }
        private void bindData()
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                string query = @"SELECT XE.BienSo, NGUOITHUE.TenNguoiThue, THECUDAN.MaTheCuDan, XE.TenXe, XE.LoaiCoGioi, THEXE.NgayLap, THEXE.HSD, XE.MaTheXe
                 FROM THEXE
                 INNER JOIN THECUDAN ON THEXE.MaTheCuDan = THECUDAN.MaTheCuDan
                 INNER JOIN NGUOITHUE ON NGUOITHUE.MaNguoiThue = THECUDAN.MaNguoiThue
                 INNER JOIN XE ON THEXE.MaTheXe = XE.MaTheXe";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dgvVehicle.Rows.Clear();

                        while (reader.Read())
                        {
                            int index = dgvVehicle.Rows.Add();

                            dgvVehicle.Rows[index].Cells[0].Value = reader["BienSo"];
                            dgvVehicle.Rows[index].Cells[1].Value = reader["TenNguoiThue"];
                            dgvVehicle.Rows[index].Cells[2].Value = reader["MaTheCuDan"];
                            dgvVehicle.Rows[index].Cells[3].Value = reader["MaTheXe"];
                            dgvVehicle.Rows[index].Cells[4].Value = reader["TenXe"];
                            dgvVehicle.Rows[index].Cells[5].Value = reader["LoaiCoGioi"];
                            dgvVehicle.Rows[index].Cells[6].Value = reader["NgayLap"];
                            dgvVehicle.Rows[index].Cells[7].Value = reader["HSD"];
                        }
                    }
                }
            }
        }
        private void FillComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    string query = "SELECT DISTINCT LoaiCoGioi FROM XE";

                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string loaiCoGioi = reader["LoaiCoGioi"].ToString();
                        cbbLoaiCoGioi.Items.Add(loaiCoGioi);
                    }

                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillcbbMaTheCuDan()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    string query = "SELECT DISTINCT MaTheCuDan FROM THECUDAN";

                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string maTheCuDan = reader["MaTheCuDan"].ToString();
                        cbbMaTheCuDan.Items.Add(maTheCuDan);
                    }

                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void LoaddgvXe()
        {
            List<XE> listXe = context.XEs.ToList();
            List<THEXE> listTheXe = context.THEXEs.ToList();
            bindData();
        }
        private void LoadForm()
        {
            txtBienSoXe.Clear();
            txtTenXe.Clear();
            txtHSD.Clear();
            txtMaTheXe.Clear();
        }





        private void dgvVehicle_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvVehicle.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvVehicle.SelectedRows[0];

                txtBienSoXe.Text = selectedRow.Cells[0].Value.ToString();
                cbbMaTheCuDan.Text = selectedRow.Cells[2].Value.ToString();
                txtMaTheXe.Text = selectedRow.Cells[3].Value.ToString();
                txtTenXe.Text = selectedRow.Cells[4].Value.ToString();
                cbbLoaiCoGioi.Text = selectedRow.Cells[5].Value.ToString();
                dtpNgayLap.Value = Convert.ToDateTime(selectedRow.Cells[6].Value);
                txtHSD.Text = selectedRow.Cells[7].Value.ToString();
            }
        }

        private void txtBoxSearch_TextChange_1(object sender, EventArgs e)
        {
            string searchTerm = txtBoxSearch.Text.Trim();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                string query = @"SELECT XE.BienSo, NGUOITHUE.TenNguoiThue, THECUDAN.MaTheCuDan, XE.TenXe, XE.LoaiCoGioi, THEXE.NgayLap, THEXE.HSD, THEXE.MaTheXe
    FROM THEXE
    INNER JOIN THECUDAN ON THEXE.MaTheCuDan = THECUDAN.MaTheCuDan
    INNER JOIN NGUOITHUE ON NGUOITHUE.MaNguoiThue = THECUDAN.MaNguoiThue
    INNER JOIN XE ON THEXE.MaTheXe = XE.MaTheXe
    WHERE XE.BienSo LIKE @searchTerm OR NGUOITHUE.TenNguoiThue LIKE @searchTerm OR THECUDAN.MaTheCuDan LIKE @searchTerm
    OR THEXE.HSD = @searchHSD OR THEXE.MaTheXe = @searchMaTheXe";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                    command.Parameters.AddWithValue("@searchMaTheXe", searchTerm);
                    int searchHSD;
                    if (int.TryParse(searchTerm, out searchHSD))
                    {
                        command.Parameters.AddWithValue("@searchHSD", searchHSD);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@searchHSD", -1);
                    }
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dgvVehicle.Rows.Clear();

                        while (reader.Read())
                        {
                            int index = dgvVehicle.Rows.Add();

                            dgvVehicle.Rows[index].Cells[0].Value = reader["BienSo"];
                            dgvVehicle.Rows[index].Cells[1].Value = reader["TenNguoiThue"];
                            dgvVehicle.Rows[index].Cells[2].Value = reader["MaTheCuDan"];
                            dgvVehicle.Rows[index].Cells[3].Value = reader["MaTheXe"];
                            dgvVehicle.Rows[index].Cells[4].Value = reader["TenXe"];
                            dgvVehicle.Rows[index].Cells[5].Value = reader["LoaiCoGioi"];
                            dgvVehicle.Rows[index].Cells[6].Value = reader["NgayLap"];
                            dgvVehicle.Rows[index].Cells[7].Value = reader["HSD"];
                        }
                    }
                }
            }
        }

        private void bnfDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                string deletedBienSoXe = txtBienSoXe.Text;

                // Find the vehicle to delete
                XE deleteXe = context.XEs.FirstOrDefault(xe => xe.BienSo == deletedBienSoXe);

                if (deleteXe != null)
                {
                    // Find the corresponding card
                    THEXE deleteTheXe = context.THEXEs.FirstOrDefault(t => t.MaTheXe == deleteXe.MaTheXe);

                    // Delete the vehicle
                    context.XEs.Remove(deleteXe);

                    // If the card exists, delete the card
                    if (deleteTheXe != null)
                    {
                        context.THEXEs.Remove(deleteTheXe);
                    }

                    context.SaveChanges();

                    // Update the DataGridView and clear input controls
                    LoaddgvXe();
                    LoadForm();

                    MessageBox.Show($"Successfully deleted the vehicle with license plate {deletedBienSoXe}!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Cannot find the vehicle with license plate {deletedBienSoXe} to delete!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the vehicle: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bnfUpdate_Click_1(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                string updatedBienSo = txtBienSoXe.Text;

                // Tìm XE cần cập nhật
                XE updateXe = context.XEs.FirstOrDefault(p => p.BienSo == updatedBienSo);

                if (updateXe != null)
                {
                    // Cập nhật thông tin xe
                    updateXe.TenXe = txtTenXe.Text;
                    updateXe.MaTheXe = txtMaTheXe.Text;
                    // Cập nhật LoaiCoGioi - Chúng ta giả sử LoaiCoGioi cũng là một thuộc tính của XE
                    updateXe.LoaiCoGioi = cbbLoaiCoGioi.SelectedItem.ToString();


                    // Tìm hoặc tạo thông tin thẻ xe tương ứng
                    THEXE updateTheXe = context.THEXEs.FirstOrDefault(p => p.MaTheXe == updateXe.MaTheXe);
                    if (updateTheXe == null)
                    {
                        updateTheXe = new THEXE();
                    }

                    // Cập nhật thông tin thẻ xe
                    updateTheXe.NgayLap = DateTime.Now;
                    updateTheXe.HSD = Convert.ToInt32(txtHSD.Text);

                    // Lưu thay đổi vào cơ sở dữ liệu
                    context.SaveChanges();

                    // Cập nhật DataGridView và xóa dữ liệu trên các control nhập liệu
                    LoaddgvXe();
                    LoadForm();

                    MessageBox.Show($"Edit {updateXe.TenXe} and vehicle card completed!",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Didn't find {updatedBienSo} for edit!",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void bnfInsert_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                if (CheckBienSoXe(txtBienSoXe.Text) == -1) // -1 để là biển số xe mới
                {
                    XE newXe = new XE();
                    THEXE newTheXe = new THEXE();

                    newTheXe.NgayLap = DateTime.Now;
                    newTheXe.HSD = Convert.ToInt32(txtHSD.Text);
                    // Lấy giá trị MaTheCuDan từ ComboBox
                    newTheXe.MaTheCuDan = cbbMaTheCuDan.SelectedItem.ToString();
                    newTheXe.MaTheXe = txtMaTheXe.Text;

                    context.THEXEs.AddOrUpdate(newTheXe);
                    context.SaveChanges();

                    newXe.BienSo = txtBienSoXe.Text;
                    newXe.TenXe = txtTenXe.Text;
                    newXe.LoaiCoGioi = cbbLoaiCoGioi.SelectedItem.ToString();
                    newXe.MaTheXe = newTheXe.MaTheXe;
                    context.XEs.AddOrUpdate(newXe);
                    context.SaveChanges();



                    LoaddgvXe();
                    LoadForm();

                    MessageBox.Show($"Add {newXe.TenXe} completed!",
                         "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Car's {txtBienSoXe.Text} is existed!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}