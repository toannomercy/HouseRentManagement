using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HouseRentManagement
{
    public partial class User : XtraForm
    {
        private ChildFormManager formManager = new ChildFormManager();

        public User()
        {
            InitializeComponent();
            ShowHomepageForm();
        }

        private void ShowProfileForm()
        {
            if (formManager.CurrentChildForm is ProfileUser)
            {
                return;
            }
            formManager.CloseCurrentChildForm();
            ProfileUser profileForm = new ProfileUser();
            formManager.ShowChildForm(pnlUser, profileForm);
        }

        private void ShowHomepageForm()
        {
            if (formManager.CurrentChildForm is Homepage)
            {
                return;
            }
            formManager.CloseCurrentChildForm();
            Homepage homepageForm = new Homepage();
            formManager.ShowChildForm(pnlUser, homepageForm);
        }

        private void ShowPaymentForm()
        {
            if (formManager.CurrentChildForm is Payment)
            {
                return;
            }
            formManager.CloseCurrentChildForm();
            Payment paymentForm = new Payment();
            formManager.ShowChildForm(pnlUser, paymentForm);
        }

        private void ShowCondoServicesForm()
        {
            if (formManager.CurrentChildForm is CondoServices)
            {
                return;
            }
            formManager.CloseCurrentChildForm();
            CondoServices condoServicesForm = new CondoServices();
            formManager.ShowChildForm(pnlUser, condoServicesForm);
        }
        private void ShowReceiptForm()
        {
            if (formManager.CurrentChildForm is Receipt)
            {
                return;
            }
            formManager.CloseCurrentChildForm();
            Receipt receiptForm = new Receipt();
            formManager.ShowChildForm(pnlUser, receiptForm);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ShowProfileForm();
        }

        private void btnHomepage_Click(object sender, EventArgs e)
        {
            ShowHomepageForm();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            ShowPaymentForm();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void btnCondoServices_Click(object sender, EventArgs e)
        {
            ShowCondoServicesForm();
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            ShowReceiptForm();
        }
    }
}