using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering.Templates;
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

namespace HouseRentManagement
{
    public partial class Payment : DevExpress.XtraEditors.XtraForm
    {
        private HRMContextDB context;
        private string username;

        public Payment(string username)
        {
            InitializeComponent();
            this.username = username;
            context = new HRMContextDB();
            List<HOADONTHANHTOAN> listPayment = context.HOADONTHANHTOANs.ToList();
            BindGrid(listPayment);
        }
        private void BindGrid(List<HOADONTHANHTOAN> listPayment)
        {
            dgvPayment.Rows.Clear();
            string maNguoiThue = context.THECUDANs.SingleOrDefault(item => item.MaTheCuDan == username)?.MaNguoiThue;

            if (maNguoiThue != null)
            {
                // Lấy MaCanHo từ bảng DANHSACHNHANKHAU dựa trên MaNguoiThue
                var condoIds = context.DANHSACHNHANKHAUs
                    .Where(item => item.MaNguoiThue == maNguoiThue)
                    .Select(item => item.MaCanHo)
                    .ToList();

                foreach (var payment in listPayment)
                {
                    // Kiểm tra xem MaCanHo của hóa đơn có trong danh sách MaCanHo của username
                    if (condoIds.Contains(payment.MaCanHo))
                    {
                        int rowIndex = dgvPayment.Rows.Add();
                        string ngaylap = payment.NgayLap.Value.ToString("dd-MM-yyyy");
                        float tongtien = float.Parse(payment.TongTien.Value.ToString());
                        string formattedTongTien = tongtien.ToString("#,##0").Replace(",", " ");
                        dgvPayment.Rows[rowIndex].Cells[0].Value = payment.SoHoaDon;
                        dgvPayment.Rows[rowIndex].Cells[1].Value = ngaylap;
                        dgvPayment.Rows[rowIndex].Cells[2].Value = formattedTongTien;
                        dgvPayment.Rows[rowIndex].Cells[3].Value = payment.TrangThai;
                        dgvPayment.Rows[rowIndex].Cells[4].Value = payment.MaCanHo;
                    }
                }
            }
            updateTranAmount();
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
            //MessageBox.Show(paymentID);
            //MessageBox.Show(amount);
            //MessageBox.Show(description);
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
            if(paymentAmount != float.Parse(amount))
            {
                MessageBox.Show("Please enter the correct amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string selectedPaymentID = dgvPayment.Rows[rowIndex].Cells["clhPaymentID"].Value.ToString();
            var paymentToUpdate = context.HOADONTHANHTOANs.FirstOrDefault(p => p.SoHoaDon == selectedPaymentID);

            if (paymentToUpdate != null)
            {
                paymentToUpdate.TrangThai = "Đã Thanh Toán";
                context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                MessageBox.Show("Payment updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnlAddPayment.Visible = false;
                BindGrid(context.HOADONTHANHTOANs.ToList());// Cập nhật lại DataGridView
                resetPayment();
            }

        }
        private void updateTranAmount()
        {
            int transCount = 0;
            float totalAmount = 0;

            foreach (DataGridViewRow row in dgvPayment.Rows)
            {
                if (row.Cells["clhTrangThai"].Value != null)
                {
                    string trangThai = row.Cells["clhTrangThai"].Value.ToString();
                    if (trangThai == "Đã Thanh Toán")
                    {
                        float paymentAmount = float.Parse(row.Cells["clhTongTien"].Value.ToString().Replace(" ", ""));
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