using HouseRentManagement.HRMcontextDB;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HouseRentManagement
{
    public partial class ReportServicesForm : DevExpress.XtraEditors.XtraForm
    {
        private List<CANHO> c;
        private List<PHIEUCHUYENDO> d;
        private List<PHIEUTHICONG> t;
        private List<PHIEUSUACHUA> s;
        private List<PHIEUPHAT> p;
        private List<PHIEUPHANHOI> ph;
        private string connString = ConfigurationManager.ConnectionStrings["Model_QLCHCC"].ConnectionString;

        public ReportServicesForm()
        {
            InitializeComponent();
            c = new List<CANHO>();
            d = new List<PHIEUCHUYENDO>();
            t = new List<PHIEUTHICONG>();
            s = new List<PHIEUSUACHUA>();
            p = new List<PHIEUPHAT>();
            ph = new List<PHIEUPHANHOI>();
            EnterData();
        }

        public void EnterData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT * FROM CANHO", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CANHO canho = new CANHO();
                                c.Add(canho);
                            }
                        }
                    }
                    using (SqlCommand command = new SqlCommand("SELECT * FROM PHIEUCHUYENDO", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PHIEUCHUYENDO phieuchuyendo = new PHIEUCHUYENDO();
                                d.Add(phieuchuyendo);
                            }
                        }
                    }

                    using (SqlCommand command = new SqlCommand("SELECT * FROM PHIEUTHICONG", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PHIEUTHICONG phieuthicong = new PHIEUTHICONG();
                                t.Add(phieuthicong);
                            }
                        }
                    }
                    using (SqlCommand command = new SqlCommand("SELECT * FROM PHIEUSUACHUA", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PHIEUSUACHUA phieusuachua = new PHIEUSUACHUA();
                                s.Add(phieusuachua);
                            }
                        }
                    }
                    using (SqlCommand command = new SqlCommand("SELECT * FROM PHIEUPHAT", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PHIEUPHAT phieuphat = new PHIEUPHAT();
                                p.Add(phieuphat);
                            }
                        }
                    }
                    using (SqlCommand command = new SqlCommand("SELECT * FROM PHIEUPHANHOI", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PHIEUPHANHOI phieuphanhoi = new PHIEUPHANHOI();
                                ph.Add(phieuphanhoi);
                            }
                        }
                    }

                    bindData(connection);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bindData(SqlConnection connection)
        {
            dgvDB.Rows.Clear();
            c.Clear();
            string query = @"SELECT * FROM CANHO";
            SqlCommand command = new SqlCommand(query, connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    CANHO canho = new CANHO();
                    canho.MaCanHo = reader["MaCanHo"].ToString();
                    c.Add(canho);
                }
            }
            foreach (var item in c)
            {
                int index = dgvDB.Rows.Add();
                dgvDB.Rows[index].Cells[0].Value = item.MaCanHo;

                string queryD = @"SELECT COUNT(*) FROM PHIEUCHUYENDO WHERE MaCanHo = '" + item.MaCanHo + "'";
                SqlCommand commandD = new SqlCommand(queryD, connection);
                int cdCount = (int)commandD.ExecuteScalar();
                dgvDB.Rows[index].Cells[1].Value = cdCount.ToString();

                string queryT = @"SELECT COUNT(*) FROM PHIEUTHICONG WHERE MaCanHo = '" + item.MaCanHo + "'";
                SqlCommand commandT = new SqlCommand(queryT, connection);
                int tcCount = (int)commandT.ExecuteScalar();
                dgvDB.Rows[index].Cells[2].Value = tcCount.ToString();

                string queryS = @"SELECT COUNT(*), SUM(TongTien) FROM PHIEUSUACHUA WHERE MaCanHo = '" + item.MaCanHo + "'";
                SqlCommand commandS = new SqlCommand(queryS, connection);
                using (SqlDataReader reader = commandS.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int scCount = (int)reader[0];
                        decimal tscSum = reader.IsDBNull(1) ? 0 : (decimal)reader[1];
                        dgvDB.Rows[index].Cells[3].Value = scCount.ToString();
                        dgvDB.Rows[index].Cells[6].Value = tscSum.ToString();
                    }
                }

                string queryP = @"SELECT COUNT(*), SUM(ThanhTien) FROM PHIEUPHAT WHERE MaCanHo = '" + item.MaCanHo + "'";
                SqlCommand commandP = new SqlCommand(queryP, connection);
                using (SqlDataReader reader = commandP.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int ppCount = (int)reader[0];
                        decimal tpSum = reader.IsDBNull(1) ? 0 : (decimal)reader[1];
                        dgvDB.Rows[index].Cells[4].Value = ppCount.ToString();
                        dgvDB.Rows[index].Cells[7].Value = tpSum.ToString();
                    }
                }

                string queryH = @"SELECT COUNT(*) FROM PHIEUPHANHOI WHERE MaCanHo = '" + item.MaCanHo + "'";
                SqlCommand commandH = new SqlCommand(queryH, connection);
                int phCount = (int)commandH.ExecuteScalar();
                dgvDB.Rows[index].Cells[5].Value = phCount.ToString();
            }
        }
        public DataGridView GetDataGridView3()
        {
            return dgvDB;
        }
    }
}