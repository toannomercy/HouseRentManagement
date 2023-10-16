using HouseRentManagement.HRMcontextDB;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HouseRentManagement
{
    public partial class PriceForm : DevExpress.XtraEditors.XtraForm
    {
        private string connString = ConfigurationManager.ConnectionStrings["Model_QLCHCC"].ConnectionString;
        private SqlConnection connection;

        public PriceForm()
        {
            InitializeComponent();
            connection = new SqlConnection(connString);
            EnterData();
            FillComboBox();
        }
        private void insert(int row)
        {
            dgvPrice.Rows[row].Cells[0].Value = txtID.Text;
            dgvPrice.Rows[row].Cells[1].Value = txtName.Text;
            dgvPrice.Rows[row].Cells[2].Value = cbbUnit.Text;
            dgvPrice.Rows[row].Cells["clCost"].Value = float.Parse(txtCost.Text);
            dgvPrice.Rows[row].Cells[4].Value = txtStatus.Text;
        }
        private int getselectedrow(string id)
        {
            for (int i = 0; i < dgvPrice.Rows.Count; i++)
            {
                if (dgvPrice.Rows[i].Cells[0].Value.ToString() == id)
                {
                    return i;
                }

            }
            return -1;
        }
        private void BindGrid(List<BANGGIA> bg)
        {
            dgvPrice.Rows.Clear();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                foreach (var item in bg)
                {
                    int index = dgvPrice.Rows.Add();
                    dgvPrice.Rows[index].Cells[0].Value = item.MaBangGia;
                    dgvPrice.Rows[index].Cells[1].Value = item.TenDichVu;
                    dgvPrice.Rows[index].Cells[2].Value = item.DonViTinh;
                    dgvPrice.Rows[index].Cells[3].Value = (float)item.GiaTien;
                    dgvPrice.Rows[index].Cells[4].Value = item.TrangThai;
                }

                connection.Close();
            }
        }
        private void FillComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    string query = "SELECT DISTINCT DonViTinh FROM BANGGIA";

                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string donViTinh = reader["DonViTinh"].ToString();
                        cbbUnit.Items.Add(donViTinh);
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
        private void EnterData()
        {
            try
            {
                List<BANGGIA> bg = new List<BANGGIA>();

                using (SqlConnection connection = new SqlConnection(connString))
                {
                    string query = "SELECT * FROM BANGGIA";

                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        BANGGIA item = new BANGGIA
                        {
                            MaBangGia = reader["MaBangGia"].ToString(),
                            TenDichVu = reader["TenDichVu"].ToString(),
                            DonViTinh = reader["DonViTinh"].ToString(),
                            GiaTien = Convert.ToDecimal(reader["GiaTien"]),
                            TrangThai = reader["TrangThai"].ToString()
                        };

                        bg.Add(item);
                    }

                    reader.Close();
                    connection.Close();
                }

                BindGrid(bg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAC_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" || txtName.Text == "" || cbbUnit.Text == "")
                    throw new Exception("Please enter all the information form");
                float c = float.Parse(txtCost.Text);
                if (c == 0)
                {
                    MessageBox.Show("The amount entered is invalid", "Error", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    int s = getselectedrow(txtID.Text);
                    if (s == -1)
                    {
                        string a = txtStatus.Text;
                        if (a.Equals("Đang sử dụng") || a.Equals("Ngừng sử dụng") || string.IsNullOrEmpty(a))
                        {
                            txtStatus.Text = a;
                        }
                        else
                        {
                            MessageBox.Show("Only enter 'Đang sử dụng' or 'Ngừng sử dụng' for data 'Status'",
                                "Error", MessageBoxButtons.OK);
                            txtStatus.Text = "";
                        }

                        using (SqlCommand command = new SqlCommand("INSERT INTO BANGGIA (MaBangGia, TenDichVu, DonViTinh, GiaTien, TrangThai) VALUES (@MaBangGia, @TenDichVu, @DonViTinh, @GiaTien, @TrangThai)", connection))
                        {
                            command.Parameters.AddWithValue("@MaBangGia", txtID.Text);
                            command.Parameters.AddWithValue("@TenDichVu", txtName.Text);
                            command.Parameters.AddWithValue("@DonViTinh", cbbUnit.Text);
                            command.Parameters.AddWithValue("@GiaTien", Convert.ToDecimal(txtCost.Text));
                            command.Parameters.AddWithValue("@TrangThai", string.IsNullOrEmpty(txtStatus.Text) ? DBNull.Value : (object)txtStatus.Text);

                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }

                        s = dgvPrice.Rows.Add();
                        insert(s);
                        MessageBox.Show("Added data successfully", "Notification", MessageBoxButtons.OK);
                    }
                    else
                    {
                        string a = txtStatus.Text;
                        if (a.Equals("Đang sử dụng") || a.Equals("Ngừng sử dụng") || string.IsNullOrEmpty(a))
                        {
                            txtStatus.Text = a;
                        }
                        else
                        {
                            MessageBox.Show("Only enter 'Đang sử dụng' or 'Ngừng sử dụng' for data 'Status'",
                                "Error", MessageBoxButtons.OK);
                            txtStatus.Text = "";
                        }

                        using (SqlCommand command = new SqlCommand("UPDATE BANGGIA SET TenDichVu = @TenDichVu, DonViTinh = @DonViTinh, GiaTien = @GiaTien, TrangThai = @TrangThai WHERE MaBangGia = @MaBangGia", connection))
                        {
                            command.Parameters.AddWithValue("@MaBangGia", txtID.Text);
                            command.Parameters.AddWithValue("@TenDichVu", txtName.Text);
                            command.Parameters.AddWithValue("@DonViTinh", cbbUnit.Text);
                            command.Parameters.AddWithValue("@GiaTien", Convert.ToDecimal(txtCost.Text));
                            command.Parameters.AddWithValue("@TrangThai", string.IsNullOrEmpty(txtStatus.Text) ? DBNull.Value : (object)txtStatus.Text);

                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }

                        insert(s);
                        MessageBox.Show("Updated data successfully", "Notification", MessageBoxButtons.OK);
                    }

                    txtID.Text = txtName.Text = cbbUnit.Text = txtStatus.Text = txtCost.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDe_Click(object sender, EventArgs e)
        {
            try
            {
                int s = getselectedrow(txtID.Text);
                if (s == -1)
                {
                    throw new Exception("Can't find the ID to be deleted");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Do you want to delete?", "Yes/No", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        using (SqlConnection connection = new SqlConnection(connString))
                        {
                            string ma = dgvPrice.Rows[s].Cells[0].Value.ToString();

                            string query = "DELETE FROM BANGGIA WHERE MaBangGia = @MaBangGia";

                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@MaBangGia", ma);

                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            connection.Close();

                            if (rowsAffected > 0)
                            {
                                dgvPrice.Rows.RemoveAt(s);
                                MessageBox.Show("Deleted successfully", "Notification", MessageBoxButtons.OK);
                                txtID.Text = txtName.Text = cbbUnit.Text = txtStatus.Text = txtCost.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBoxSearch_TextChange(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtBoxSearch.Text.Trim();

                // Perform the search operation

                if (string.IsNullOrEmpty(searchTerm))
                {
                    // Handle the case when the search term is empty or null
                    EnterData();
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connString))
                {
                    string query = "SELECT * FROM BANGGIA WHERE TenDichVu LIKE @SearchTerm OR GiaTien LIKE @SearchTerm";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                        connection.Open();

                        List<BANGGIA> bg = new List<BANGGIA>();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                BANGGIA item = new BANGGIA
                                {
                                    MaBangGia = reader["MaBangGia"].ToString(),
                                    TenDichVu = reader["TenDichVu"].ToString(),
                                    DonViTinh = reader["DonViTinh"].ToString(),
                                    GiaTien = Convert.ToDecimal(reader["GiaTien"]),
                                    TrangThai = reader["TrangThai"].ToString()
                                };

                                bg.Add(item);
                            }
                        }

                        BindGrid(bg);

                        // Select the first row in the DataGridView if it exists
                        if (dgvPrice.Rows.Count > 0)
                        {
                            DataGridViewRow firstRow = dgvPrice.Rows[0];
                            PopulateDataFromSelectedRow(firstRow);
                        }
                        else
                        {
                            ClearTextBoxesAndComboBox();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPrice_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPrice.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPrice.SelectedRows[0];

                // Đổ thông tin từ DataGridView vào các TextBox và ComboBox tương ứng
                txtID.Text = selectedRow.Cells["clID"]?.Value?.ToString() ?? "";
                txtName.Text = selectedRow.Cells["clName"]?.Value?.ToString() ?? "";
                txtStatus.Text = selectedRow.Cells["clStatus"]?.Value?.ToString() ?? "";
                txtCost.Text = selectedRow.Cells["clCost"]?.Value?.ToString() ?? "";
                cbbUnit.Text = selectedRow.Cells["clUnit"]?.Value?.ToString() ?? "";
            }
            else
            {
                // Nếu không có dòng nào được chọn, xóa thông tin trong các TextBox và ComboBox
                txtID.Text = string.Empty;
                txtName.Text = string.Empty;
                cbbUnit.SelectedIndex = -1;
                txtCost.Text = string.Empty;
                txtStatus.Text = string.Empty;
            }
        }

        private void PriceForm_Load(object sender, EventArgs e)
        {
            dgvPrice.ClearSelection();
        }

        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string searchTerm = txtBoxSearch.Text.Trim();

        //        // Perform the search operation

        //        if (string.IsNullOrEmpty(searchTerm))
        //        {
        //            // Handle the case when the search term is empty or null
        //            EnterData();
        //            return;
        //        }

        //        using (SqlConnection connection = new SqlConnection(connString))
        //        {
        //            string query = "SELECT * FROM BANGGIA WHERE TenDichVu LIKE @SearchTerm OR GiaTien LIKE @SearchTerm";

        //            using (SqlCommand command = new SqlCommand(query, connection))
        //            {
        //                command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

        //                connection.Open();

        //                List<BANGGIA> bg = new List<BANGGIA>();

        //                using (SqlDataReader reader = command.ExecuteReader())
        //                {
        //                    while (reader.Read())
        //                    {
        //                        BANGGIA item = new BANGGIA
        //                        {
        //                            MaBangGia = reader["MaBangGia"].ToString(),
        //                            TenDichVu = reader["TenDichVu"].ToString(),
        //                            DonViTinh = reader["DonViTinh"].ToString(),
        //                            GiaTien = Convert.ToDecimal(reader["GiaTien"]),
        //                            TrangThai = reader["TrangThai"].ToString()
        //                        };

        //                        bg.Add(item);
        //                    }
        //                }

        //                BindGrid(bg);

        //                // Select the first row in the DataGridView if it exists
        //                if (dgvPrice.Rows.Count > 0)
        //                {
        //                    DataGridViewRow firstRow = dgvPrice.Rows[0];
        //                    PopulateDataFromSelectedRow(firstRow);
        //                }
        //                else
        //                {
        //                    ClearTextBoxesAndComboBox();
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void PopulateDataFromSelectedRow(DataGridViewRow selectedRow)
        {
            txtID.Text = selectedRow.Cells["clID"]?.Value?.ToString() ?? "";
            txtName.Text = selectedRow.Cells["clName"]?.Value?.ToString() ?? "";
            txtStatus.Text = selectedRow.Cells["clStatus"]?.Value?.ToString() ?? "";
            txtCost.Text = selectedRow.Cells["clCost"]?.Value?.ToString() ?? "";
            cbbUnit.Text = selectedRow.Cells["clUnit"]?.Value?.ToString() ?? "";
        }

        private void ClearTextBoxesAndComboBox()
        {
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            cbbUnit.SelectedIndex = -1;
            txtCost.Text = string.Empty;
            txtStatus.Text = string.Empty;
        }
    }
}