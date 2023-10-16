using DevExpress.XtraEditors;
using System.Diagnostics;
using System;
using System.Windows.Forms;

namespace HouseRentManagement
{
    public partial class Homepage : XtraForm
    {
        public Homepage()
        {
            InitializeComponent();
            SetupLabel();
        }

        private void SetupLabel()
        {
            lblName.Parent = picBoxCondo.Parent;
            picBoxCondo.Controls.Add(lblName);
        }

        private void lblLinkEmail_Click(object sender, EventArgs e)
        {
            string emailAddress = "jungleuncles@gmail.com";
            string subject = "";
            string body = "";
            DialogResult result = MessageBox.Show("Do you want to go to Gmail?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string emailLink = $"mailto:{emailAddress}?subject={Uri.EscapeDataString(subject)}&body={Uri.EscapeDataString(body)}";
                Process.Start(emailLink);
            }
        }
    }
}