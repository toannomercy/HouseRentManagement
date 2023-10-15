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

    public partial class ReportForm : DevExpress.XtraEditors.XtraForm
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["HRMContextDB"].ConnectionString;
        public ReportForm()
        {
            InitializeComponent();
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
                string query = "SELECT MAX(CAST(SUBSTRING(SoPhieuPhanHoi, 3, 3) AS INT)) FROM PHIEUPHANHOI";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        int maxNumber = (int)result;
                        int nextNumber = maxNumber + 1;
                        return "PH" + nextNumber.ToString("D3");
                    }
                    else
                    {
                        return "PH000";
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
                if (!ExistCondoId(condoId, userID))
                {
                    MessageBox.Show("The CondoID does not exist or you do not own this apartment!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string receiptNumber = GetNextReceiptNumber();
                string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
                string insertQuery = @"INSERT INTO PHIEUPHANHOI 
                (SoPhieuPhanHoi, NgayLap, NoiDung, TinhTrang, MaCanHo) VALUES
                (@SoPhieu, @NgayLap, @NoiDung, N'Đang chờ xử lý', @MaCanHo)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@SoPhieu", receiptNumber);
                        cmd.Parameters.AddWithValue("@NgayLap", currentDate);
                        cmd.Parameters.AddWithValue("@NoiDung", content);
                        cmd.Parameters.AddWithValue("@MaCanHo", condoId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Report form has been sent!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtBoxCondoID.Clear();
                            txtResCardID.Clear();
                            txtBoxContent.Clear();
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
