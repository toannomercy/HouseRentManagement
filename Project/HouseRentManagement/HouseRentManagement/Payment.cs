using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering.Templates;
using HouseRentManagement.HRMcontextDB;
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
    public partial class Payment : DevExpress.XtraEditors.XtraForm
    {
        private Model_QLCHCC context;
        private string username;
        private string connString = ConfigurationManager.ConnectionStrings["Model_QLCHCC"].ConnectionString;


        public Payment(string username)
        {
            InitializeComponent();
            this.username = username;
            context = new Model_QLCHCC();
            List<HOADONTHANHTOAN> listPayment = context.HOADONTHANHTOANs.ToList();
            BindGrid(username);
        }
        private void BindGrid(string username)
        {
            dgvPayment.Rows.Clear();
            string maNguoiThue = null;

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                // Lấy MaNguoiThue từ bảng THECUDAN dựa trên MaTheCuDan và username
                string selectTheCuDanQuery = "SELECT MaNguoiThue FROM THECUDAN WHERE MaTheCuDan = @MaTheCuDan";
                using (SqlCommand selectTheCuDanCommand = new SqlCommand(selectTheCuDanQuery, connection))
                {
                    selectTheCuDanCommand.Parameters.AddWithValue("@MaTheCuDan", username);
                    maNguoiThue = selectTheCuDanCommand.ExecuteScalar()?.ToString();
                }

                if (maNguoiThue != null)
                {
                    // Lấy danh sách MaCanHo từ bảng DANHSACHNHANKHAU dựa trên MaNguoiThue
                    string selectMaCanHoQuery = "SELECT MaCanHo FROM DANHSACHNHANKHAU WHERE MaNguoiThue = @MaNguoiThue";
                    using (SqlCommand selectMaCanHoCommand = new SqlCommand(selectMaCanHoQuery, connection))
                    {
                        selectMaCanHoCommand.Parameters.AddWithValue("@MaNguoiThue", maNguoiThue);
                        List<string> condoIds = new List<string>();

                        using (SqlDataReader reader = selectMaCanHoCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                condoIds.Add(reader["MaCanHo"].ToString());
                            }
                        }

                        // Lấy danh sách hóa đơn thanh toán phù hợp
                        string selectPaymentQuery = "SELECT * FROM HOADONTHANHTOAN WHERE MaCanHo IN ({0})";
                        string condoIdParams = string.Join(",", condoIds.Select((s, i) => "@MaCanHo" + i));
                        selectPaymentQuery = string.Format(selectPaymentQuery, condoIdParams);

                        using (SqlCommand selectPaymentCommand = new SqlCommand(selectPaymentQuery, connection))
                        {
                            for (int i = 0; i < condoIds.Count; i++)
                            {
                                selectPaymentCommand.Parameters.AddWithValue("@MaCanHo" + i, condoIds[i]);
                            }

                            using (SqlDataReader reader = selectPaymentCommand.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    int rowIndex = dgvPayment.Rows.Add();
                                    string ngaylap = reader["NgayLap"].ToString();
                                    float tongtien = float.Parse(reader["TongTien"].ToString());
                                    string formattedTongTien = tongtien.ToString("#,##0").Replace(",", " ");
                                    dgvPayment.Rows[rowIndex].Cells[0].Value = reader["SoHoaDon"].ToString();
                                    dgvPayment.Rows[rowIndex].Cells[1].Value = ngaylap;
                                    dgvPayment.Rows[rowIndex].Cells[2].Value = formattedTongTien;
                                    dgvPayment.Rows[rowIndex].Cells[3].Value = reader["TrangThai"].ToString();
                                    dgvPayment.Rows[rowIndex].Cells[4].Value = reader["MaCanHo"].ToString();
                                }
                            }
                        }
                    }
                }
                updateTranAmount();
            }
        }
        private void txtBoxSearch_TextChange(object sender, EventArgs e)
        {
            string st = txtBoxSearch.Text;
            search(st);
        }
        private void txtBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Number only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
        private void search(string s)
        {
            dgvPayment.ClearSelection();
            foreach (DataGridViewRow row in dgvPayment.Rows)
            {
                if (row.Cells[0].Value.ToString().ToLower().Contains(s) ||
                    row.Cells[1].Value.ToString().ToLower().Contains(s) ||
                    row.Cells[2].Value.ToString().ToLower().Contains(s) ||
                    row.Cells[3].Value.ToString().ToLower().Contains(s) ||
                    row.Cells[4].Value.ToString().ToLower().Contains(s))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }
        private int IsValidPayID(string payID)
        {
            int rowIndex = -1; // Mặc định là -1, tức là không tìm thấy

            for (int i = 0; i < dgvPayment.Rows.Count; i++)
            {
                // Kiểm tra nếu hàng không phải là hàng header và có ít nhất một ô
                if (!dgvPayment.Rows[i].IsNewRow && dgvPayment.Rows[i].Cells["clhPaymentID"].Value != null)
                {
                    string paymentID = dgvPayment.Rows[i].Cells["clhPaymentID"].Value.ToString();

                    if (paymentID.Equals(payID))
                    {
                        rowIndex = i; // Lưu lại chỉ số của dòng chứa PaymentID cần tìm
                        break; // Tìm thấy PaymentID, có thể thoát khỏi vòng lặp
                    }
                }
            }
            return rowIndex;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            string paymentID = txtBoxPaymentID.Text;
            string amount = txtBoxAmount.Text;
            string description = txtBoxDescription.Text;

            int rowIndex = IsValidPayID(paymentID);
            if (paymentID == "" || amount == "" || description == "")
            {
                MessageBox.Show("Please complete all information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rowIndex == -1)
            {
                MessageBox.Show("Incorrect Payment ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            float paymentAmount = float.Parse(dgvPayment.Rows[rowIndex].Cells["clhTongTien"].Value.ToString().Replace(" ", ""));
            if (paymentAmount != float.Parse(amount))
            {
                MessageBox.Show("Please enter the correct amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                // Cập nhật trạng thái thanh toán trong cơ sở dữ liệu
                string updatePaymentQuery = "UPDATE HOADONTHANHTOAN SET TrangThai = @TrangThai WHERE SoHoaDon = @SoHoaDon";
                using (SqlCommand updatePaymentCommand = new SqlCommand(updatePaymentQuery, connection))
                {
                    updatePaymentCommand.Parameters.AddWithValue("@TrangThai", "Đã Thanh Toán");
                    updatePaymentCommand.Parameters.AddWithValue("@SoHoaDon", paymentID);
                    updatePaymentCommand.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Payment updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pnlAddPayment.Visible = false;
            BindGrid(username); // Cập nhật lại DataGridView
            resetPayment();
        }
        private void updateTranAmount()
        {
            int transCount = 0;
            float totalAmount = 0;

            foreach (DataGridViewRow row in dgvPayment.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    string trangThai = row.Cells[3].Value.ToString();
                    if (trangThai == "Đã Thanh Toán")
                    {
                        float paymentAmount = float.Parse(row.Cells[2].Value.ToString().Replace(" ", ""));
                        totalAmount += paymentAmount;
                        transCount++;
                    }
                }
            }

            lblTran.Text = transCount.ToString();
            lbltamount.Text = totalAmount.ToString("#,##0").Replace(",", " ");
        }
        private void resetPayment()
        {
            txtBoxAmount.Clear();
            txtBoxDescription.Clear();
            txtBoxPaymentID.Clear();
        }
        private void btnPayment_Click(object sender, EventArgs e)
        {
            pnlAddPayment.Visible = !pnlAddPayment.Visible;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddPayment.Visible = false;
            resetPayment();
        }


    }
}