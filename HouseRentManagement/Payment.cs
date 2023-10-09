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
    public partial class Payment : DevExpress.XtraEditors.XtraForm
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            pnlAddPayment.Visible = !pnlAddPayment.Visible;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddPayment.Visible = false;
        }

    }
}