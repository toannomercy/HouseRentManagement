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
    public partial class ProfileUser : DevExpress.XtraEditors.XtraForm
    {
        public ProfileUser()
        {
            InitializeComponent();
            lblLinkDone.Hide();
        }

        private void lblLinkEdit_Click(object sender, EventArgs e)
        {
            txtBoxContactNumber.ReadOnly = true;
            txtBoxFullName.ReadOnly = true;
            txtBoxEmail.ReadOnly = true;
            txtBoxContactNumber.Enabled = true;
            txtBoxFullName.Enabled = true;
            txtBoxEmail.Enabled = true;
            dtpDoB.Enabled = true;
            lblLinkDone.Show();
        }

        private void lblLinkDone_Click(object sender, EventArgs e)
        {
            lblLinkDone.Hide();
            txtBoxContactNumber.ReadOnly = false;
            txtBoxFullName.ReadOnly = false;
            txtBoxEmail.ReadOnly = false;
            txtBoxContactNumber.Enabled = false;
            txtBoxFullName.Enabled = false;
            txtBoxEmail.Enabled = false;
            dtpDoB.Enabled = false;
        }
    }
}