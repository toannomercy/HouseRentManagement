using HouseRentManagement.HRMcontextDB;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HouseRentManagement
{
    public partial class ReportFeeForm : DevExpress.XtraEditors.XtraForm
    {
        private string connString = ConfigurationManager.ConnectionStrings["Model_QLCHCC"].ConnectionString;
        public ReportFeeForm()
        {
            InitializeComponent();
            EnterData();
        }

        public void EnterData()
        {
            try
            {
                using (var connection = new SqlConnection(connString))
                {
                    connection.Open();

                    List<BANGGIA> b = GetBANGGIAs(connection);
                    List<CTHDTT> c = GetCTHDTTs(connection);
                    List<HOADONTHANHTOAN> h = GetHOADONTHANHTOANs(connection);

                    binddata(connection);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private List<BANGGIA> GetBANGGIAs(SqlConnection connection)
        {
            string query = "SELECT * FROM BANGGIA";
            SqlCommand command = new SqlCommand(query, connection);

            List<BANGGIA> b = new List<BANGGIA>();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    BANGGIA banggia = new BANGGIA();
                    b.Add(banggia);
                }
            }

            return b;
        }

        private List<CTHDTT> GetCTHDTTs(SqlConnection connection)
        {
            string query = "SELECT * FROM CTHDTT";
            SqlCommand command = new SqlCommand(query, connection);

            List<CTHDTT> c = new List<CTHDTT>();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    CTHDTT cthdtt = new CTHDTT();
                    c.Add(cthdtt);
                }
            }

            return c;
        }

        private List<HOADONTHANHTOAN> GetHOADONTHANHTOANs(SqlConnection connection)
        {
            string query = "SELECT * FROM HOADONTHANHTOAN";
            SqlCommand command = new SqlCommand(query, connection);

            List<HOADONTHANHTOAN> h = new List<HOADONTHANHTOAN>();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    HOADONTHANHTOAN hoadonthanhtoan = new HOADONTHANHTOAN();
                    h.Add(hoadonthanhtoan);
                }
            }

            return h;
        }
        public void binddata(SqlConnection connection)
        {
            dgvDB.Rows.Clear();

            string query = @"SELECT c.SoHoaDon, h.MaCanHo, b.TenDichVu, c.TuNgay, c.DenNgay, h.NgayLap, b.GiaTien, c.SoLuong, b.DonViTinh, c.ThanhTien, h.TongTien, b.TrangThai, h.GhiChu
                     FROM CTHDTT c
                     INNER JOIN HOADONTHANHTOAN h ON c.SoHoaDon = h.SoHoaDon
                     INNER JOIN BANGGIA b ON c.MaBangGia = b.MaBangGia";

            SqlCommand command = new SqlCommand(query, connection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int index = dgvDB.Rows.Add();

                    dgvDB.Rows[index].Cells[0].Value = reader["MaCanHo"];
                    dgvDB.Rows[index].Cells[1].Value = reader["TenDichVu"];
                    dgvDB.Rows[index].Cells[2].Value = reader["TuNgay"];
                    dgvDB.Rows[index].Cells[3].Value = reader["DenNgay"];
                    dgvDB.Rows[index].Cells[4].Value = reader["GiaTien"];
                    dgvDB.Rows[index].Cells[5].Value = reader["SoLuong"];
                    dgvDB.Rows[index].Cells[6].Value = reader["DonViTinh"];
                    dgvDB.Rows[index].Cells[7].Value = reader["ThanhTien"];
                    dgvDB.Rows[index].Cells[8].Value = reader["TongTien"];
                    dgvDB.Rows[index].Cells[9].Value = reader["GhiChu"];
                }
            }
        }

        public DataGridView GetDataGridView1()
        {
            return dgvDB;
        }
    }
}