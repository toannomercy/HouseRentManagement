using HouseRentManagement.HRMcontextDB;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HouseRentManagement
{
    public partial class ReportCondoForm : DevExpress.XtraEditors.XtraForm
    {
        private string connString = ConfigurationManager.ConnectionStrings["Model_QLCHCC"].ConnectionString;

        public ReportCondoForm()
        {
            InitializeComponent();
        }

        private void ReportCondoForm_Load(object sender, EventArgs e)
        {
            try
            {

                using (var connection = new SqlConnection(connString))
                {
                    connection.Open();

                    List<TANG> t = GetTANGs(connection);
                    List<CANHO> c = GetCANHOes(connection);
                    List<LOAICANHO> l = GetLOAICANHOes(connection);
                    List<NGUOITHUE> n = GetNGUOITHUEs(connection);
                    List<CHUSOHUU> ch = GetCHUSOHUUs(connection);
                    List<HOPDONGTHUE> h = GetHOPDONGTHUEs(connection);

                    binddata(connection);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private List<TANG> GetTANGs(SqlConnection connection)
        {
            List<TANG> t = new List<TANG>();

            string query = "SELECT * FROM TANG";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TANG tang = new TANG();
                        tang.MaTang = reader["Tang"].ToString();
                        t.Add(tang);
                    }
                }
            }
            return t;
        }
        private List<CANHO> GetCANHOes(SqlConnection connection)
        {
            List<CANHO> c = new List<CANHO>();

            string query = "SELECT * FROM CANHO";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CANHO canho = new CANHO();
                        canho.MaCanHo = reader["MaCanHo"].ToString();
                        c.Add(canho);
                    }
                }
            }

            return c;
        }
        private List<LOAICANHO> GetLOAICANHOes(SqlConnection connection)
        {
            List<LOAICANHO> l = new List<LOAICANHO>();

            string query = "SELECT * FROM LOAICANHO";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        LOAICANHO loaich = new LOAICANHO();
                        loaich.TenLoai = reader["TenLoai"].ToString();
                        l.Add(loaich);
                    }
                }
            }

            return l;
        }
        private List<NGUOITHUE> GetNGUOITHUEs(SqlConnection connection)
        {
            List<NGUOITHUE> n = new List<NGUOITHUE>();

            string query = "SELECT * FROM NGUOITHUE";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NGUOITHUE nguoithue = new NGUOITHUE();
                        nguoithue.TenNguoiThue = reader["TenNguoiThue"].ToString();
                        n.Add(nguoithue);
                    }
                }
            }

            return n;
        }
        private List<CHUSOHUU> GetCHUSOHUUs(SqlConnection connection)
        {
            List<CHUSOHUU> ch = new List<CHUSOHUU>();

            string query = "SELECT * FROM CHUSOHUU";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CHUSOHUU chusohuu = new CHUSOHUU();
                        chusohuu.TenChuSoHuu = reader["TenChuSoHuu"].ToString();
                        ch.Add(chusohuu);
                    }
                }
            }

            return ch;
        }

        private List<HOPDONGTHUE> GetHOPDONGTHUEs(SqlConnection connection)
        {
            List<HOPDONGTHUE> h = new List<HOPDONGTHUE>();

            string query = "SELECT * FROM HOPDONGTHUE";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        HOPDONGTHUE hopdongthue = new HOPDONGTHUE();
                        hopdongthue.SoHopDong = reader["SoHopDong"].ToString();
                        h.Add(hopdongthue);
                    }
                }
            }

            return h;
        }
        private void binddata(SqlConnection connection)
        {
            dgvDB.Rows.Clear();

            string query = @"SELECT c.MaCanHo, t.Tang, c.TinhTrang, n.TenNguoiThue, ch.TenChuSoHuu, l.TenLoai
                    FROM CANHO c
                    INNER JOIN TANG t ON c.MaTang = t.MaTang
                    INNER JOIN HOPDONGTHUE h ON c.MaCanHo = h.MaCanHo
                    INNER JOIN NGUOITHUE n ON h.MaNguoiThue = n.MaNguoiThue
                    INNER JOIN CHUSOHUU ch ON c.MaChuSoHuu = ch.MaChuSoHuu
                    INNER JOIN LOAICANHO l ON c.MaLoai = l.MaLoai";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int index = dgvDB.Rows.Add();
                        dgvDB.Rows[index].Cells[0].Value = reader["MaCanHo"];
                        dgvDB.Rows[index].Cells[1].Value = reader["Tang"];
                        dgvDB.Rows[index].Cells[2].Value = reader["TinhTrang"];
                        dgvDB.Rows[index].Cells[3].Value = reader["TenNguoiThue"];
                        dgvDB.Rows[index].Cells[4].Value = reader["TenChuSoHuu"];
                        dgvDB.Rows[index].Cells[5].Value = reader["TenLoai"];
                    }
                }
            }
        }
        public DataGridView GetDataGridView2()
        {
            return dgvDB;
        }
    }
}