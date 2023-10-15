using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HouseRentManagement
{
    public partial class Admin : DevExpress.XtraEditors.XtraForm
    {
        private string username;
        public Admin(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
    
}
