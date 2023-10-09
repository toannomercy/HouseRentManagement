using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace HouseRentManagement
{
    public partial class CondoServices : XtraForm
    {
        private readonly FormVisibilityManager constructionVisibility;
        private readonly FormVisibilityManager transferVisibility;
        private readonly FormVisibilityManager reportVisibility;
        private readonly ChildFormManager formManager;

        private bool isConstructionVisible;
        private bool isTransferVisible;
        private bool isReportVisible;

        public CondoServices()
        {
            InitializeComponent();

            // Khởi tạo các đối tượng quản lý hiển thị form và quản lý form con
            constructionVisibility = new FormVisibilityManager(pnlConstruction);
            transferVisibility = new FormVisibilityManager(pnlTransferForm);
            reportVisibility = new FormVisibilityManager(pnlReportForm);
            formManager = new ChildFormManager();

            // Khởi tạo trạng thái ban đầu cho các biến cờ
            isConstructionVisible = false;
            isTransferVisible = false;
            isReportVisible = false;
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
        }

        // Xử lý sự kiện khi button Construction Form được nhấp
        private void btnConstructionForm_Click(object sender, EventArgs e)
        {
            //pnlConstruction.Location = new Point(btnConstructionForm.Left, btnConstructionForm.Bottom);
            ShowConstructionForm();
        }

        // Xử lý sự kiện khi button Transfer Form được nhấp
        private void btnTransferForm_Click(object sender, EventArgs e)
        {
            //pnlTransferForm.Location = new Point(btnTransferForm.Left, btnTransferForm.Bottom);
            ShowTransferForm();
        }

        // Xử lý sự kiện khi button Report Form được nhấp
        private void btnReportForm_Click(object sender, EventArgs e)
        {
            //pnlReportForm.Location = new Point(btnReportForm.Left, btnReportForm.Bottom);
            ShowReportForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void pnlTransferForm_ControlAdded(object sender, ControlEventArgs e)
        {

        }

    }
}