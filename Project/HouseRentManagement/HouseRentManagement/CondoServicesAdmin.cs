using DevExpress.Utils.Html.Internal;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseRentManagement
{
    public partial class CondoServicesAdmin : DevExpress.XtraEditors.XtraForm
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Model_QLCHCC"].ConnectionString;


        private DataTable dataTable = new DataTable();
        public CondoServicesAdmin()
        {
            InitializeComponent();
            LoadCondoIDs();
            LoadAndDisplayData();
            FillcbbFromStatus();
            FillcbbPhieu();
        }
        private void FillcbbFromStatus()
        {
            cbbFromStatus.Items.Clear();
            cbbFromStatus.Items.Add("Pending");
            cbbFromStatus.Items.Add("Approved");
            cbbFromStatus.SelectedIndex = 0;
        }
        private void FillcbbPhieu()
        {
            cbbPhieu.Items.Clear();
            cbbPhieu.Items.Add("Constructrion Form");
            cbbPhieu.Items.Add("Report Form");
            cbbPhieu.Items.Add("Fine Form");
            cbbPhieu.Items.Add("Fixing Form");
            cbbPhieu.Items.Add("Transfer Form");
            cbbPhieu.SelectedIndex = 1;
        }
        private void BindGrid()
        {
            dgvCondoServicesAdmin.Rows.Clear();

            // Kiểm tra nếu DataTable có dữ liệu
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                // Duyệt qua từng dòng trong DataTable và thêm chúng vào DataGridView
                foreach (DataRow row in dataTable.Rows)
                {
                    // Thêm một hàng mới vào DataGridView
                    int rowIndex = dgvCondoServicesAdmin.Rows.Add();

                    // Đặt giá trị cho các ô trong hàng mới
                    dgvCondoServicesAdmin.Rows[rowIndex].Cells[0].Value = row["CondoID"];
                    dgvCondoServicesAdmin.Rows[rowIndex].Cells[1].Value = row["Service Name"];
                    dgvCondoServicesAdmin.Rows[rowIndex].Cells[2].Value = row["Date"];
                    dgvCondoServicesAdmin.Rows[rowIndex].Cells[3].Value = row["Content"];
                    dgvCondoServicesAdmin.Rows[rowIndex].Cells[4].Value = row["StartDate"];
                    dgvCondoServicesAdmin.Rows[rowIndex].Cells[5].Value = row["EndDate"];
                    dgvCondoServicesAdmin.Rows[rowIndex].Cells[6].Value = row["Fine"];
                    dgvCondoServicesAdmin.Rows[rowIndex].Cells[7].Value = row["MoneySpend"];
                    dgvCondoServicesAdmin.Rows[rowIndex].Cells[8].Value = row["FormStatus"];
                }
            }
        }

        private void LoadCondoIDs()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT DISTINCT MaCanHo FROM CANHO";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string condoID = reader["MaCanHo"].ToString();
                            cbbCondoID.Items.Add(condoID);
                        }
                    }
                }
                cbbCondoID.SelectedIndex = 0;
            }
        }

        // Khi bạn muốn tải và hiển thị dữ liệu, gọi LoadDataFromDatabase và BindGrid
        private void LoadAndDisplayData()
        {
            LoadDataFromDatabase(); // Tải dữ liệu từ cơ sở dữ liệu
            BindGrid(); // Hiển thị dữ liệu trên DataGridView
        }
        private void cbbCondoID_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataFromDatabase();
        }
        private void LoadDataFromDatabase()
        {
            string selectedCondoID = cbbCondoID.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedCondoID))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
        SELECT 
    c.MaCanHo AS 'CondoID',
    'Report Form' AS 'Service Name',
    pp.NgayLap AS 'Date',
    pp.NoiDung AS 'Content',
    NULL AS 'StartDate',
    NULL AS 'EndDate',
    NULL AS 'Fine',
    NULL AS 'MoneySpend',
    pp.TinhTrang AS 'FormStatus'
FROM CANHO c
INNER JOIN PHIEUPHANHOI pp ON c.MaCanHo = pp.MaCanHo
WHERE c.MaCanHo = @SelectedCondoID
UNION ALL
SELECT 
    c.MaCanHo AS 'CondoID',
    'Repair Form' AS 'Service Name',
    ps.NgayLap AS 'Date',
    ps.NoiDung AS 'Content',
    NULL AS 'StartDate',
    NULL AS 'EndDate',
    NULL AS 'Fine',
    ps.TongTien AS 'MoneySpend',
    '' AS 'FormStatus'
FROM CANHO c
INNER JOIN PHIEUSUACHUA ps ON c.MaCanHo = ps.MaCanHo
WHERE c.MaCanHo = @SelectedCondoID
UNION ALL
SELECT 
    c.MaCanHo AS 'CondoID',
    'Fine Form' AS 'Service Name',
    pp2.NgayLap AS 'Date',
    pp2.NoiDung AS 'Content',
    NULL AS 'StartDate',
    NULL AS 'EndDate',
    pp2.ThanhTien AS 'Fine',
    NULL AS 'MoneySpend',
    '' AS 'FormStatus'
FROM CANHO c
INNER JOIN PHIEUPHAT pp2 ON c.MaCanHo = pp2.MaCanHo
WHERE c.MaCanHo = @SelectedCondoID
UNION ALL
SELECT 
    c.MaCanHo AS 'CondoID',
    'Transfer Form' AS 'Service Name',
    pc.NgayLap AS 'Date',
    pc.NoiDung AS 'Content',
    NULL AS 'StartDate',
    NULL AS 'EndDate',
    NULL AS 'Fine',
    NULL AS 'MoneySpend',
    pc.TrangThai AS 'FormStatus'
FROM CANHO c
INNER JOIN PHIEUCHUYENDO pc ON c.MaCanHo = pc.MaCanHo
WHERE c.MaCanHo = @SelectedCondoID
UNION ALL
SELECT 
    c.MaCanHo AS 'CondoID',
    'Construction Form' AS 'Service Name',
    pt.NgayLap AS 'Date',
    pt.NoiDung AS 'Content',
    pt.BDThiCong AS 'StartDate',
    pt.KTThiCong AS 'EndDate',
    NULL AS 'Fine',
    NULL AS 'MoneySpend',
    pt.TinhTrang AS 'FormStatus'
FROM CANHO c
INNER JOIN PHIEUTHICONG pt ON c.MaCanHo = pt.MaCanHo
WHERE c.MaCanHo = @SelectedCondoID
                    ";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@SelectedCondoID", selectedCondoID);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        dataTable.Clear(); // Xóa dữ liệu cũ
                        adapter.Fill(dataTable);

                        // Gọi lại hàm BindGrid để hiển thị dữ liệu mới
                        BindGrid();
                    }
                }
            }
        }
        private string GetNextFineNumber()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MAX(CAST(SUBSTRING(SoPhieuPhat, 3, 3) AS INT)) FROM PHIEUPHAt";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        int maxNumber = (int)result;
                        int nextNumber = maxNumber + 1;
                        return "P" + nextNumber.ToString("D3");
                    }
                    else
                    {
                        return "P000";
                    }
                }
            }
        }
        private string GetNextFixingNumber()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MAX(CAST(SUBSTRING(SoPhieuSuaChua, 3, 3) AS INT)) FROM PHIEUSUACHUA";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        int maxNumber = (int)result;
                        int nextNumber = maxNumber + 1;
                        return "SC" + nextNumber.ToString("D3");
                    }
                    else
                    {
                        return "SC000";
                    }
                }
            }
        }
        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            string selectedPhieu = cbbPhieu.SelectedItem as string;

            if (selectedPhieu == "Fine Form")
            {
                // Thực hiện thêm mới cho Fine Form
                string selectedCondoID = cbbCondoID.SelectedItem as string;
                string content = txtContent.Text;
                string fineAmount = txtFine.Text;
                string fineID = GetNextFineNumber();

                if (string.IsNullOrEmpty(selectedCondoID))
                {
                    MessageBox.Show("Vui lòng chọn Condo ID.");
                    return;
                }

                if (string.IsNullOrEmpty(content))
                {
                    MessageBox.Show("Vui lòng nhập nội dung.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO PHIEUPHAT (SoPhieuPhat,MaCanHo, NgayLap, NoiDung, ThanhTien) VALUES (@FineID, @CondoID, @Date, @Content, @FineAmount)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@FineID", fineID);
                        cmd.Parameters.AddWithValue("@CondoID", selectedCondoID);
                        cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                        cmd.Parameters.AddWithValue("@Content", content);
                        cmd.Parameters.AddWithValue("@FineAmount", fineAmount);

                        cmd.ExecuteNonQuery();
                        LoadDataFromDatabase();
                        MessageBox.Show("Thêm mới Fine Form thành công.");
                    }
                }
            }
            else if (selectedPhieu == "Fixing Form")
            {
                // Thực hiện thêm mới cho Fixing Form
                string fixingID = GetNextFixingNumber();
                string selectedCondoID = cbbCondoID.SelectedItem as string;
                string content = txtContent.Text;
                string fixingType = txtMoneySpend.Text;

                if (string.IsNullOrEmpty(selectedCondoID))
                {
                    MessageBox.Show("Vui lòng chọn Condo ID.");
                    return;
                }

                if (string.IsNullOrEmpty(content))
                {
                    MessageBox.Show("Vui lòng nhập nội dung.");
                    return;
                }

                if (string.IsNullOrEmpty(fixingType))
                {
                    MessageBox.Show("Vui lòng chọn loại sửa chữa.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO PHIEUSUACHUA (SoPhieuSuaChua,MaCanHo, NgayLap, NoiDung) VALUES (@FixingID, @CondoID, @Date, @Content)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@FixingID", fixingID);
                        cmd.Parameters.AddWithValue("@CondoID", selectedCondoID);
                        cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                        cmd.Parameters.AddWithValue("@Content", content);

                        cmd.ExecuteNonQuery();
                        LoadDataFromDatabase();
                        MessageBox.Show("Thêm mới Fixing Form thành công.");
                    }
                }
            }
            else
            {
                // Chưa chọn phiếu hoặc không xác định
                MessageBox.Show("Vui lòng chọn phiếu khác để thêm mới.");
            }
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            string selectedPhieu = cbbPhieu.SelectedItem as string;
            string selectedFormStatus = cbbFromStatus.SelectedItem as string;

            if (selectedPhieu == "Transfer Form")
            {
                // Cập nhật Transfer Form
                if (string.IsNullOrEmpty(selectedFormStatus))
                {
                    MessageBox.Show("Vui lòng chọn trạng thái phiếu.");
                    return;
                }

                string selectedCondoID = cbbCondoID.SelectedItem as string;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE PHIEUCHUYENDO SET TrangThai = @FormStatus WHERE MaCanHo = @CondoID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@FormStatus", selectedFormStatus);
                        cmd.Parameters.AddWithValue("@CondoID", selectedCondoID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            LoadDataFromDatabase();
                            MessageBox.Show("Cập nhật phiếu Transfer Form thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy phiếu Transfer Form để cập nhật.");
                        }
                    }
                }
            }
            else if (selectedPhieu == "Report Form")
            {
                // Cập nhật Report Form
                if (string.IsNullOrEmpty(selectedFormStatus))
                {
                    MessageBox.Show("Vui lòng chọn trạng thái phiếu.");
                    return;
                }
                string selectedCondoID = cbbCondoID.SelectedItem as string;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE PHIEUPHANHOI SET TinhTrang = @FormStatus WHERE MaCanHo = @CondoID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@FormStatus", selectedFormStatus);
                        cmd.Parameters.AddWithValue("@CondoID", selectedCondoID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            LoadDataFromDatabase();
                            MessageBox.Show("Cập nhật phiếu Report Form thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy phiếu Report Form để cập nhật.");
                        }
                    }
                }
            }
            else if (selectedPhieu == "Construction Form")
            {
                // Cập nhật Construction Form
                if (string.IsNullOrEmpty(selectedFormStatus))
                {
                    MessageBox.Show("Vui lòng chọn trạng thái phiếu.");
                    return;
                }
                string selectedCondoID = cbbCondoID.SelectedItem as string;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE PHIEUTHICONG SET TinhTrang = @FormStatus WHERE MaCanHo = @CondoID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@FormStatus", selectedFormStatus);
                        cmd.Parameters.AddWithValue("@CondoID", selectedCondoID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            LoadDataFromDatabase();
                            MessageBox.Show("Cập nhật phiếu Construction Form thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy phiếu Construction Form để cập nhật.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Phiếu không hỗ trợ chức năng cập nhật.");
            }
        }

        private void dgvCondoServicesAdmin_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCondoServicesAdmin.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvCondoServicesAdmin.SelectedRows[0];

                // Lấy giá trị từ hàng được chọn
                string condoID = selectedRow.Cells[0].Value.ToString();
                string serviceName = selectedRow.Cells[1].Value.ToString();
                string date = selectedRow.Cells[2].Value.ToString();
                string content = selectedRow.Cells[3].Value.ToString();
                string startDate = selectedRow.Cells[4].Value.ToString();
                string endDate = selectedRow.Cells[5].Value.ToString();
                string fine = selectedRow.Cells[6].Value.ToString();
                string moneySpend = selectedRow.Cells[7].Value.ToString();
                string formStatus = selectedRow.Cells[8].Value.ToString();

                // Điền giá trị vào các TextBox, ComboBox và DateTimePicker
                cbbCondoID.SelectedItem = condoID;
                cbbPhieu.SelectedItem = serviceName;
                dtpDate.Value = DateTime.Parse(date);
                txtContent.Text = content;
                txtFine.Text = fine;
                txtMoneySpend.Text = moneySpend;
                cbbFromStatus.SelectedItem = formStatus;
            }
        }

        private void txtFine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Number only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true; // Từ chối ký tự không phải số
            }
        }
    }
}