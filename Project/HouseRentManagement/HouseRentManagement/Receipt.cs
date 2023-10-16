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

namespace HouseRentManagement
{
    public partial class Receipt : DevExpress.XtraEditors.XtraForm
    {
        private Model_QLCHCC context;
        private string username;

        public Receipt(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            context = new Model_QLCHCC();
            List<CTHDTT> listPaymentInfo = context.CTHDTTs.ToList();
            FillCmb();
            BindGridPaymentInfo(listPaymentInfo);
        }

        private void FillCmb()
        {
            string maNguoiThue = context.THECUDANs.SingleOrDefault(item => item.MaTheCuDan == username)?.MaNguoiThue;
            string condoID = context.DANHSACHNHANKHAUs.FirstOrDefault(item => item.MaNguoiThue == maNguoiThue)?.MaCanHo;
            if (condoID != null)
            {
                var paymentIDs = context.HOADONTHANHTOANs
                    .Where(item => item.MaCanHo == condoID)
                    .Select(item => item.SoHoaDon)
                    .ToList();
                this.cbbReceipt.DataSource = paymentIDs;
            }
        }

        private void BindGridPaymentInfo(List<CTHDTT> listPaymentInfo)
        {
            dgvReceipt.Rows.Clear();
            string PaymentID = cbbReceipt.Text;
            foreach (var item in listPaymentInfo)
            {
                if (item.SoHoaDon == PaymentID)
                {
                    int index = dgvReceipt.Rows.Add();
                    string startDate = item.TuNgay.Value.ToString("dd-MM-yyyy");
                    string endDate = item.DenNgay.Value.ToString("dd-MM-yyyy");
                    float money = float.Parse(item.ThanhTien.Value.ToString());
                    string formattedTongTien = money.ToString("#,##0").Replace(",", " ");
                    dgvReceipt.Rows[index].Cells[0].Value = item.BANGGIA.TenDichVu;
                    dgvReceipt.Rows[index].Cells[1].Value = startDate;
                    dgvReceipt.Rows[index].Cells[2].Value = endDate;
                    dgvReceipt.Rows[index].Cells[3].Value = item.SoLuong;
                    dgvReceipt.Rows[index].Cells[4].Value = formattedTongTien;
                }
            }
        }
        private void cbbReceipt_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<CTHDTT> listPaymentInfo = context.CTHDTTs.ToList();
            BindGridPaymentInfo(listPaymentInfo);
            txtBoxSearch.Clear();
        }

        private void txtBoxSearch_TextChange(object sender, EventArgs e)
        {
            string st = txtBoxSearch.Text;
            search(st);
        }

        private void search(string s)
        {
            dgvReceipt.ClearSelection();
            foreach (DataGridViewRow row in dgvReceipt.Rows)
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
    }
}