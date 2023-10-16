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

namespace HouseRentManagement
{
    public partial class ResidentCard : DevExpress.XtraEditors.XtraForm
    {
        Model_QLCHCC context = new Model_QLCHCC();
        public ResidentCard()
        {
            InitializeComponent();
        }

        private void BindGrid(List<THECUDAN> lsTheCuDan)
        {
            dgvDSReCard.Rows.Clear();
            foreach (var item in lsTheCuDan)
            {
                int index = dgvDSReCard.Rows.Add();
                dgvDSReCard.Rows[index].Cells[0].Value = item.MaTheCuDan;
                dgvDSReCard.Rows[index].Cells[1].Value = item.NgayLap;
                dgvDSReCard.Rows[index].Cells[2].Value = item.HSD;
                dgvDSReCard.Rows[index].Cells[3].Value = item.MaNguoiThue;

            }
        }

        private void Resident_Card_Load(object sender, EventArgs e)
        {
            List<NGUOITHUE> lsNguoiThue = context.NGUOITHUEs.ToList();
            List<THECUDAN> lsTheCuDan = context.THECUDANs.ToList();
            BindGrid(lsTheCuDan);
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                if (CheckTenantIDCard(txtTenantCardID.Text) == -1) // -1 để là sinh viên mới
                {
                    THECUDAN newthecudan = new THECUDAN();
                    newthecudan.MaTheCuDan = txtTenantCardID.Text;
                    newthecudan.NgayLap = DateTime.Now;
                    newthecudan.HSD = int.Parse(txtExpDate.Text);
                    newthecudan.MaNguoiThue = txtTenantID.Text;

                    context.THECUDANs.AddOrUpdate(newthecudan);
                    context.SaveChanges();

                    LoaddgvDSSV();
                    LoadForm();

                    MessageBox.Show($"Add Resident Card {newthecudan.MaTheCuDan} successful!",
                        "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show($"Resident Card ID {txtTenantCardID.Text} already exist!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private int CheckTenantIDCard(string TenantIDCard)
        {
            int length = dgvDSReCard.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if (dgvDSReCard.Rows[i].Cells[0].Value != null)
                    if (dgvDSReCard.Rows[i].Cells[0].Value.ToString() == TenantIDCard)
                        return i;
            }
            return -1;
        }

        private void LoaddgvDSSV()
        {
            List<THECUDAN> newthecudan = context.THECUDANs.ToList();
            BindGrid(newthecudan);
        }

        private void LoadForm()
        {
            txtTenantCardID.Clear();
            txtExpDate.Clear();
            txtTenantID.Clear();
        }
        private bool CheckNull()
        {
            if (txtTenantCardID.Text == "" || txtExpDate.Text == "" || txtTenantID.Text == "")
            {
                MessageBox.Show("Please complete all information!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtTenantCardID.TextLength < 4)
            {
                MessageBox.Show("Resident Card ID must be longer than 3 characters!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            THECUDAN ReCardDelete = context.THECUDANs.FirstOrDefault(p => p.MaTheCuDan == txtTenantCardID.Text);
            if (ReCardDelete != null)
            {
                DialogResult dg = MessageBox.Show($"Are you sure to delete the Resident Card? {ReCardDelete.MaTheCuDan}",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    context.THECUDANs.Remove(ReCardDelete);
                    context.SaveChanges();

                    // reset lại thông tin sau khi xoá
                    LoaddgvDSSV();
                    LoadForm();

                    MessageBox.Show($"Deleted Resident Card {ReCardDelete.MaTheCuDan} successful!",
                        "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                // lấy phần tử đầu tiên thoả điều kiện
                string newTenantIDCard = txtTenantCardID.Text;
                THECUDAN UpdateTenantIDCard = context.THECUDANs.FirstOrDefault(p => p.MaTheCuDan == newTenantIDCard);
                if (UpdateTenantIDCard != null)
                {
                    UpdateTenantIDCard.HSD = int.Parse(txtExpDate.Text);
                    UpdateTenantIDCard.NgayLap = dtpNgayLap.Value;
                    UpdateTenantIDCard.MaNguoiThue = txtTenantID.Text;
                    // Đưa dữ liệu khi thay đổi vào DB
                    context.THECUDANs.AddOrUpdate(UpdateTenantIDCard);
                    context.SaveChanges();

                    LoaddgvDSSV();
                    LoadForm();

                    MessageBox.Show($"Update Resident Card {UpdateTenantIDCard.MaTheCuDan} successful!",
                        "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Resident Card ID not found!",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvDSReCard_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSReCard.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDSReCard.SelectedRows[0];

                // Đổ dữ liệu vào các TextBox tương ứng
                txtTenantCardID.Text = selectedRow.Cells[0].Value.ToString();
                txtExpDate.Text = selectedRow.Cells[2].Value.ToString();
                txtTenantID.Text = selectedRow.Cells[3].Value.ToString();
                DateTime ngayLap = (DateTime)selectedRow.Cells[1].Value;
                dtpNgayLap.Value = ngayLap;
            }
        }

        private void dtpNgayLap_ValueChanged(object sender, EventArgs e)
        {
            if(dtpNgayLap.Value > DateTime.Now)
            {
                MessageBox.Show("Invalid date created!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNgayLap.Value = DateTime.Now;
                return;
            }
        }

        private void txtExpDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Number only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true; // Từ chối ký tự không phải số
            }
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            List<THECUDAN> searchResults = context.THECUDANs
                .Where(tc => tc.MaTheCuDan.Contains(keyword) ||
                             tc.MaNguoiThue.Contains(keyword))
                .ToList();

            BindGrid(searchResults);
        }
    }
}