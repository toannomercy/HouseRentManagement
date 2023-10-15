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
    public partial class ConstructionForm : DevExpress.XtraEditors.XtraForm
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["HRMContextDB"].ConnectionString;

        public ConstructionForm()
        {
            InitializeComponent();
            setUpDTP();
        }
        
        private void setUpDTP()
        {
            dtpBegin.Format = DateTimePickerFormat.Custom;
            dtpBegin.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpBegin.ShowUpDown = true;
            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpEnd.ShowUpDown = true;
            DateTime selectedDate = DateTime.Now;
            DateTime minTime = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, 7, 0, 0);
            DateTime maxTime = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, 19, 0, 0);
            dtpBegin.Value = minTime;
            dtpEnd.Value = maxTime.AddDays(2);
        }
        private bool checkIfValidDateTime()
        {
            DateTime currentTime = DateTime.Now;
            DateTime startDate = dtpBegin.Value;
            DateTime endDate = dtpEnd.Value;
            DateTime minstart = new DateTime(startDate.Year, startDate.Month, startDate.Day, 7, 0, 0);
            DateTime maxstart = new DateTime(startDate.Year, startDate.Month, startDate.Day, 19, 0, 0);
            DateTime minend = new DateTime(endDate.Year, endDate.Month, endDate.Day, 7, 0, 0);
            DateTime maxend = new DateTime(endDate.Year, endDate.Month, endDate.Day, 19, 0, 0);


            if (startDate < currentTime)
            {
                MessageBox.Show("The start date and time must be greater than the current date and time!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (endDate <= startDate)
            {
                MessageBox.Show("The end date and time must be greater than the start date and time!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra ngày giờ kết thúc không được lớn hơn quá 15 ngày
            if (endDate > startDate.AddDays(15))
            {
                MessageBox.Show("The end date and time cannot be more than 15 days greater than the start date and time!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (startDate < minstart || startDate > maxstart || endDate < minend || endDate > maxend)
            {
                MessageBox.Show("Please select time between 7:00 and 19:00!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ExistCondoId(string condoId, string userMaTheCuDan)
        {
            string maNguoiThue = GetUserID(userMaTheCuDan);

            if (!string.IsNullOrEmpty(maNguoiThue))
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM DANHSACHNHANKHAU WHERE MaCanHo = @MaCanHo AND MaNguoiThue = @MaNguoiThue";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaCanHo", condoId);
                        cmd.Parameters.AddWithValue("@MaNguoiThue", maNguoiThue);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }

            return false;
        }

        private string GetUserID(string userMaTheCuDan)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MaNguoiThue FROM THECUDAN WHERE MaTheCuDan = @MaTheCuDan";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaTheCuDan", userMaTheCuDan);
                    string maNguoiThue = cmd.ExecuteScalar() as string;
                    return maNguoiThue;
                }
            }
        }

        private string GetNextReceiptNumber()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MAX(CAST(SUBSTRING(SoPhieuThiCong, 3, 3) AS INT)) FROM PHIEUTHICONG";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        int maxNumber = (int)result;
                        int nextNumber = maxNumber + 1;
                        return "TC" + nextNumber.ToString("D3");
                    }
                    else
                    {
                        return "TC000";
                    }
                }
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string condoId = txtBoxCondoID.Text;
                string userID = txtResCardID.Text;
                string content = txtBoxContent.Text;
                if (string.IsNullOrEmpty(condoId) || string.IsNullOrEmpty(userID) || string.IsNullOrEmpty(content))
                {
                    MessageBox.Show("Please complete all information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!ExistCondoId(condoId, userID))
                {
                    MessageBox.Show("The CondoID does not exist or you do not own this apartment!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!checkIfValidDateTime())
                    return;
                string beginDate = dtpBegin.Value.ToString("yyyy-MM-dd HH:mm");
                string endDate = dtpEnd.Value.ToString("yyyy-MM-dd HH:mm");
                string receiptNumber = GetNextReceiptNumber();
                string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
                string insertQuery = @"INSERT INTO PHIEUTHICONG 
                (SoPhieuThiCong, NgayLap, NoiDung, TinhTrang, BDThiCong, KTThiCong, MaCanHo) VALUES
                (@SoPhieu, @NgayLap, @NoiDung, N'Đang chờ xử lý', @BDThiCong, @KTThiCong, @MaCanHo)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@SoPhieu", receiptNumber);
                        cmd.Parameters.AddWithValue("@NgayLap", currentDate);
                        cmd.Parameters.AddWithValue("@NoiDung", content);
                        cmd.Parameters.AddWithValue("@BDThiCong", beginDate);
                        cmd.Parameters.AddWithValue("@KTThiCong", endDate);
                        cmd.Parameters.AddWithValue("@MaCanHo", condoId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Construction form has been sent!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtBoxCondoID.Clear();
                            txtResCardID.Clear();
                            txtBoxContent.Clear();
                            setUpDTP();

                        }
                        else
                        {
                            MessageBox.Show("Error!");
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}