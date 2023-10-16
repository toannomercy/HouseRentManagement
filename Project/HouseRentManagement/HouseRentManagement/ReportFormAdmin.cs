using DevExpress.XtraEditors;
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
    public partial class ReportFormAdmin : DevExpress.XtraEditors.XtraForm
    {
        private ReportCondoForm reportCondoForm;
        public ReportFormAdmin()
        {
            InitializeComponent();
            ShowReportCondo();
        }
        private ChildFormManager formManager = new ChildFormManager();
        private void ShowReportCondo()
        {
            if (formManager.CurrentChildForm is ReportCondoForm)
            {
                return;
            }
            formManager.CloseCurrentChildForm();
            ReportCondoForm rcf = new ReportCondoForm();
            formManager.ShowChildForm(pnlReportAdmin, rcf);
        }
        private void ShowReportFee()
        {
            if (formManager.CurrentChildForm is ReportFeeForm)
            {
                return;
            }
            formManager.CloseCurrentChildForm();
            ReportFeeForm rff = new ReportFeeForm();
            formManager.ShowChildForm(pnlReportAdmin, rff);
        }
        private void ShowReportServices()
        {
            if (formManager.CurrentChildForm is ReportServicesForm)
            {
                return;
            }
            formManager.CloseCurrentChildForm();
            ReportServicesForm rsf = new ReportServicesForm();
            formManager.ShowChildForm(pnlReportAdmin, rsf);
        }

        private void tsbReportCondo_Click(object sender, EventArgs e)
        {
            ShowReportCondo();
        }

        private void tsbReportFee_Click(object sender, EventArgs e)
        {
            ShowReportFee();
        }

        private void tsbReportServices_Click(object sender, EventArgs e)
        {
            ShowReportServices();
        }
    }
}