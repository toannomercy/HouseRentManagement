using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace HouseRentManagement
{
    public partial class CondoServices : XtraForm
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Model_QLCHCC"].ConnectionString;
        private readonly FormVisibilityManager constructionVisibility;
        private readonly FormVisibilityManager transferVisibility;
        private readonly FormVisibilityManager reportVisibility;
        private readonly ChildFormManager formManager;

        private DataTable originalData;

        private string username;
        private bool isConstructionVisible;
        private bool isTransferVisible;
        private bool isReportVisible;

        public CondoServices(string username)
        {
            InitializeComponent();

            // Khởi tạo các đối tượng quản lý hiển thị form và quản lý form con
            constructionVisibility = new FormVisibilityManager(pnlConstruction);
            transferVisibility = new FormVisibilityManager(pnlTransferForm);
            reportVisibility = new FormVisibilityManager(pnlReportForm);
            formManager = new ChildFormManager();
            this.username = username;
            // Khởi tạo trạng thái ban đầu cho các biến cờ
            isConstructionVisible = false;
            isTransferVisible = false;
            isReportVisible = false;

        }

        private void CondoServices_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadData();
            originalData = dgvCondoServices.DataSource as DataTable;
        }

        // Hiển thị form Construction
        private void ShowConstructionForm()
        {
            Form constructionForm = new ConstructionForm();
            formManager.ShowChildForm(this, constructionForm);

            if (isConstructionVisible)
            {
                // Nếu form Construction đang hiển thị, ẩn đi
                constructionVisibility.HideForm();
                isConstructionVisible = false;
            }
            else
            {
                // Nếu form Construction chưa hiển thị, hiển thị nó và ẩn các form khác
                constructionVisibility.ShowForm(constructionForm);
                isConstructionVisible = true;

                transferVisibility.HideForm();
                isTransferVisible = false;

                reportVisibility.HideForm();
                isReportVisible = false;
            }
            LoadData();
            originalData = dgvCondoServices.DataSource as DataTable;


        }

        // Hiển thị form Transfer
        private void ShowTransferForm()
        {
            Form transferForm = new TransferForm();
            formManager.ShowChildForm(this, transferForm);

            if (isTransferVisible)
            {
                // Nếu form Transfer đang hiển thị, ẩn đi
                transferVisibility.HideForm();
                isTransferVisible = false;
            }
            else
            {
                // Nếu form Transfer chưa hiển thị, hiển thị nó và ẩn các form khác
                constructionVisibility.HideForm();
                isConstructionVisible = false;

                transferVisibility.ShowForm(transferForm);
                isTransferVisible = true;

                reportVisibility.HideForm();
                isReportVisible = false;
            }
            LoadData();
            originalData = dgvCondoServices.DataSource as DataTable;

        }

        // Hiển thị form Report
        private void ShowReportForm()
        {
            Form reportForm = new ReportForm();
            formManager.ShowChildForm(this, reportForm);

            if (isReportVisible)
            {
                // Nếu form Report đang hiển thị, ẩn đi
                reportVisibility.HideForm();
                isReportVisible = false;
            }
            else
            {
                // Nếu form Report chưa hiển thị, hiển thị nó và ẩn các form khác
                constructionVisibility.HideForm();
                isConstructionVisible = false;

                transferVisibility.HideForm();
                isTransferVisible = false;

                reportVisibility.ShowForm(reportForm);
                isReportVisible = true;
            }
            LoadData();
            originalData = dgvCondoServices.DataSource as DataTable;

        }

        // Xử lý sự kiện khi button Construction Form được nhấp
        private void btnConstructionForm_Click(object sender, EventArgs e)
        {
            //pnlConstruction.Location = new Point(btnConstructionForm.Left, btnConstructionForm.Bottom);
            ShowConstructionForm();
            txtBoxSearch.Clear();
        }

        // Xử lý sự kiện khi button Transfer Form được nhấp
        private void btnTransferForm_Click(object sender, EventArgs e)
        {
            //pnlTransferForm.Location = new Point(btnTransferForm.Left, btnTransferForm.Bottom);
            ShowTransferForm();
            txtBoxSearch.Clear();

        }

        // Xử lý sự kiện khi button Report Form được nhấp
        private void btnReportForm_Click(object sender, EventArgs e)
        {
            //pnlReportForm.Location = new Point(btnReportForm.Left, btnReportForm.Bottom);
            ShowReportForm();
            txtBoxSearch.Clear();

        }

        private DataTable FilterDataTable(string searchText)
        {
            DataTable filteredData = originalData.Clone();
            searchText = searchText.ToLower();

            foreach (DataRow row in originalData.Rows)
            {
                bool match = false;
                foreach (DataColumn col in originalData.Columns)
                {
                    string cellValue = row[col].ToString().ToLower();
                    if (cellValue.Contains(searchText))
                    {
                        match = true;
                        break;
                    }
                }

                if (match)
                {
                    filteredData.ImportRow(row);
                }
            }

            return filteredData;
        }

        private void txtBoxSearch_TextChange(object sender, EventArgs e)
        {
            string searchText = txtBoxSearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                DataTable filteredData = FilterDataTable(searchText);
                dgvCondoServices.DataSource = filteredData;
            }
            else
            {
                dgvCondoServices.DataSource = originalData;
            }
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    string maNguoiThue;
                    conn.Open();
                    string query = "SELECT MaNguoiThue FROM THECUDAN WHERE MaTheCuDan = @MaTheCuDan";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaTheCuDan", username);
                        maNguoiThue = cmd.ExecuteScalar() as string;
                    }
                    string maCanHo;
                    string queryCondoID = "SELECT MaCanHo FROM DANHSACHNHANKHAU WHERE MaNguoiThue = @MaNguoiThue";
                    using (SqlCommand cmd = new SqlCommand(queryCondoID, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNguoiThue", maNguoiThue);
                        maCanHo = cmd.ExecuteScalar() as string;
                    }


                    string querybind = @"
                SELECT 
                    MaCanHo AS 'Condo ID', 
                    CASE
                        WHEN LoaiPhieu = 'Report Form' THEN 'Report Form'
                        WHEN LoaiPhieu = 'Construction Form' THEN 'Construction Form'
                        WHEN LoaiPhieu = 'Transfer Form' THEN 'Transfer Form'
                        ELSE ''
                    END AS 'Service Name',
                    FORMAT(NgayLap, 'dd/MM/yyyy') AS 'Date Created',
                    NoiDung AS 'Content',
                    CASE
                        WHEN LoaiPhieu = 'Report Form' THEN NULL
                        WHEN LoaiPhieu = 'Construction Form' THEN FORMAT(NgayGioBD, 'dd/MM/yyyy HH:mm') 
                        WHEN LoaiPhieu = 'Transfer Form' THEN FORMAT(NgayGioBD, 'dd/MM/yyyy HH:mm')
                        ELSE NULL
                    END AS 'Start Date',
                    CASE
                        WHEN LoaiPhieu = 'Report Form' THEN NULL
                        WHEN LoaiPhieu = 'Construction Form' THEN FORMAT(NgayGioKT, 'dd/MM/yyyy HH:mm')
                        WHEN LoaiPhieu = 'Transfer Form' THEN FORMAT(NgayGioKT, 'dd/MM/yyyy HH:mm')
                        ELSE NULL
                    END AS 'End Date',
                    CASE
                        WHEN TinhTrang = N'Đang chờ xử lý' THEN 'Pending'
                        WHEN TinhTrang = N'Đã Duyệt' THEN 'Approved'
                        ELSE TinhTrang
                    END AS 'From Status'
                FROM (
                    SELECT MaCanHo, 'Report Form' AS LoaiPhieu, NgayLap, NoiDung, NULL AS NgayGioBD, NULL AS NgayGioKT, 'Pending' AS TinhTrang
                    FROM PHIEUPHANHOI
                    WHERE MaCanHo = @MaCanHo

                    UNION

                    SELECT MaCanHo, 'Construction Form' AS LoaiPhieu, NgayLap, NoiDung, BDThiCong AS NgayGioBD, KTThiCong AS NgayGioKT, TinhTrang
                    FROM PHIEUTHICONG
                    WHERE MaCanHo = @MaCanHo

                    UNION

                    SELECT MaCanHo, 'Transfer Form' AS LoaiPhieu, NgayLap, NoiDung, BDChuyen AS NgayGioBD, KTChuyen AS NgayGioKT, TrangThai AS TinhTrang
                    FROM PHIEUCHUYENDO
                    WHERE MaCanHo = @MaCanHo
                ) AS AllPhieu";
                    using (SqlCommand cmd = new SqlCommand(querybind, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaCanHo", maCanHo);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgvCondoServices.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}