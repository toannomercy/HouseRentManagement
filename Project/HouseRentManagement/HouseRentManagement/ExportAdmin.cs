using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Drawing;

namespace HouseRentManagement
{
    public partial class ExportAdmin : DevExpress.XtraEditors.XtraForm
    {
        public ExportAdmin()
        {
            InitializeComponent();
        }
        private ChildFormManager formManager = new ChildFormManager();
        private ReportFeeForm reportFeeForm;
        private ReportCondoForm reportCondoForm;
        private ReportServicesForm reportServicesForm;
        private void ExportToPDF(DataGridView dataGridView, string filePath)
        {
            Document document = new Document();

            try
            {
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

                document.Open();

                PdfPTable table = new PdfPTable(dataGridView.Columns.Count);

                string ARIALUNI_TFF = Path.Combine(Application.StartupPath, "Fonts", "ARIALUNI.TTF");

                BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font f = new iTextSharp.text.Font(bf, 12);
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(dataGridView.Columns[i].HeaderText, f));
                    table.AddCell(cell);
                }

                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        if (dataGridView.Rows[i].Cells[j].Value != null)
                        {
                            string cellValue = dataGridView.Rows[i].Cells[j].Value.ToString();
                            PdfPCell cell = new PdfPCell(new Phrase(cellValue, f));
                            table.AddCell(cell);
                        }
                    }
                }

                document.Add(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during PDF export: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                document.Close();
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView = null;

            if (formManager.CurrentChildForm is ReportFeeForm)
            {
                reportFeeForm = (ReportFeeForm)formManager.CurrentChildForm;
                dataGridView = reportFeeForm.GetDataGridView1();
            }
            else if (formManager.CurrentChildForm is ReportCondoForm)
            {
                reportCondoForm = (ReportCondoForm)formManager.CurrentChildForm;
                dataGridView = reportCondoForm.GetDataGridView2();
            }else if(formManager.CurrentChildForm is ReportServicesForm)
            {
                reportServicesForm = (ReportServicesForm)formManager.CurrentChildForm;
                dataGridView = reportServicesForm.GetDataGridView3();
            }

            if (dataGridView != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.Title = "Save PDF File";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        ExportToPDF(dataGridView, filePath);
                        MessageBox.Show("Export complete.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred during PDF export: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void ShowReportCondo()
        {
            if (formManager.CurrentChildForm is ReportCondoForm)
            {
                return;
            }
            formManager.CloseCurrentChildForm();
            ReportCondoForm rcf = new ReportCondoForm();
            formManager.ShowChildForm(pnlExport, rcf);
        }
        private void ShowReportFee()
        {
            if (formManager.CurrentChildForm is ReportFeeForm)
            {
                return;
            }
            formManager.CloseCurrentChildForm();
            ReportFeeForm rff = new ReportFeeForm();
            formManager.ShowChildForm(pnlExport, rff);
        }
        private void ShowReportServices()
        {
            if (formManager.CurrentChildForm is ReportServicesForm)
            {
                return;
            }
            formManager.CloseCurrentChildForm();
            ReportServicesForm rsf = new ReportServicesForm();
            formManager.ShowChildForm(pnlExport, rsf);
        }
        private void tsbRC_Click(object sender, EventArgs e)
        {
            ShowReportCondo();
        }

        private void tsbRF_Click(object sender, EventArgs e)
        {
            ShowReportFee();
        }

        private void tsbRS_Click(object sender, EventArgs e)
        {
            ShowReportServices();
        }
        private void ExportToExcel(DataGridView dataGridView, string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");

                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dataGridView.Columns[i].HeaderText;
                    worksheet.Cells[1, i + 1].Style.Font.Bold = true;
                    worksheet.Cells[1, i + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    worksheet.Cells[1, i + 1].Style.Fill.BackgroundColor.SetColor(Color.LightGray);
                }

                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dataGridView.Rows[i].Cells[j].Value;
                    }
                }

                worksheet.Cells.AutoFitColumns();

                // Lưu tệp Excel
                FileInfo file = new FileInfo(filePath);
                package.SaveAs(file);
            }
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView = null;

            if (formManager.CurrentChildForm is ReportFeeForm)
            {
                reportFeeForm = (ReportFeeForm)formManager.CurrentChildForm;
                dataGridView = reportFeeForm.GetDataGridView1();
            }
            else if (formManager.CurrentChildForm is ReportCondoForm)
            {
                reportCondoForm = (ReportCondoForm)formManager.CurrentChildForm;
                dataGridView = reportCondoForm.GetDataGridView2();
            }
            else if (formManager.CurrentChildForm is ReportServicesForm)
            {
                reportServicesForm = (ReportServicesForm)formManager.CurrentChildForm;
                dataGridView = reportServicesForm.GetDataGridView3();
            }

            if (dataGridView != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save Excel File";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        ExportToExcel(dataGridView, filePath);

                        MessageBox.Show("Export complete.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred during Excel export: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}