using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Reflection;

namespace HouseRentManagement
{
    public partial class User : XtraForm
    {
        private ChildFormManager formManager = new ChildFormManager();
        private ProfileUser profileUser;
        private Homepage homepage;
        private Payment payment;
        private Receipt receipt;
        private CondoServices condoServices;
        private About about;
        private Login login;
        private string username;
        public User(string username)
        {
            InitializeComponent();
            InitializeCustomComponents();
            ShowHomepageForm();
            this.username = username;
        }
        private void InitializeCustomComponents()
        {
            this.SetBevel(false);
            var mdiClient = Controls.OfType<MdiClient>().FirstOrDefault();
            if (mdiClient != null)
                mdiClient.BackColor = Color.FromArgb(237, 234, 229);
        }
        bool menuExpand = true;
        bool sidebarExpand = true;
        private bool isDragging = false;
        private Point startPoint;
        
        private void ShowProfileForm()
        {
            if (profileUser == null)
            {
                profileUser = new ProfileUser(username);
                profileUser.FormClosed += ProfileUser_FormClosed;
                profileUser.MdiParent = this;
                profileUser.Dock = DockStyle.Fill;
                profileUser.Show();
            }
            else
            {
                profileUser.Activate();
            }
        }

        private void ProfileUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            profileUser = null;
        }

        private void ShowHomepageForm()
        {
            if (homepage == null)
            {
                homepage = new Homepage();
                homepage.FormClosed += Homepage_FormClosed;
                homepage.MdiParent = this;
                homepage.Dock = DockStyle.Fill;
                homepage.Show();
            }
            else
            {
                homepage.Activate();
            }
        }

        private void Homepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            homepage = null;
        }

        private void ShowPaymentForm()
        {
            if (payment == null)
            {
                payment = new Payment(username);
                payment.FormClosed += Payment_FormClosed;
                payment.MdiParent = this;
                payment.Dock = DockStyle.Fill;
                payment.Show();
            }
            else
            {
                payment.Activate();
            }
        }

        private void Payment_FormClosed(object sender, FormClosedEventArgs e)
        {
            payment = null;
        }

        private void ShowCondoServicesForm()
        {
            if (condoServices == null)
            {
                condoServices = new CondoServices(username);
                condoServices.FormClosed += CondoServices_FormClosed;
                condoServices.MdiParent = this;
                condoServices.Dock = DockStyle.Fill;
                condoServices.Show();
            }
            else
            {
                condoServices.Activate();
            }
        }

        private void CondoServices_FormClosed(object sender, FormClosedEventArgs e)
        {
            condoServices = null;
        }

        private void ShowReceiptForm()
        {
            if (receipt == null)
            {
                receipt = new Receipt(username);
                receipt.FormClosed += Receipt_FormClosed;
                receipt.MdiParent = this;
                receipt.Dock = DockStyle.Fill;
                receipt.Show();
            }
            else
            {
                receipt.Activate();
            }
        }

        private void Receipt_FormClosed(object sender, FormClosedEventArgs e)
        {
            receipt = null;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ShowProfileForm();
        }

        private void btnHome_Click(object sender, EventArgs e)
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
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                if (pnlProfileLoad.Height + 5 >= 277)
                {
                    pnlProfileLoad.Height = 277;
                    menuTransition.Stop();
                    menuExpand = false;
                }
                else
                {
                    pnlProfileLoad.Height += 5;
                }
            }
            else
            {
                if (pnlProfileLoad.Height - 5 <= 54)
                {
                    pnlProfileLoad.Height = 54;
                    menuTransition.Stop();
                    menuExpand = true;
                }
                else
                {
                    pnlProfileLoad.Height -= 5;
                }
            }
        }

        //private void sidebarTransition_Tick(object sender, EventArgs e)
        //{
        //    const int sidebarExpandWidth = 255;
        //    const int sidebarCollapseWidth = 44;
        //    const int sidebarTransitionStep = 15;

        //    if (sidebarExpand)
        //    {
        //        pnlNavLoad.Width -= sidebarTransitionStep;
        //        if (pnlNavLoad.Width <= sidebarCollapseWidth)
        //        {
        //            sideBarTransition.Stop();
        //            sidebarExpand = false;
        //            pnlProfileLoad.Width = pnlNavLoad.Width;
        //            pnlHome.Width = pnlNavLoad.Width;
        //            pnlLogout.Width = pnlNavLoad.Width;
        //            pnlAbout.Width = pnlNavLoad.Width;
        //        }
        //    }
        //    else
        //    {
        //        pnlNavLoad.Width += sidebarTransitionStep;
        //        pnlProfileLoad.Width = pnlNavLoad.Width;
        //        pnlHome.Width = pnlNavLoad.Width;
        //        pnlLogout.Width = pnlNavLoad.Width;
        //        pnlAbout.Width = pnlNavLoad.Width;
        //        if (pnlNavLoad.Width >= sidebarExpandWidth)
        //        {
        //            sideBarTransition.Stop();
        //            sidebarExpand = true;
        //        }
        //    }
        //}

        //private void btnNav_Click(object sender, EventArgs e)
        //{
        //    sideBarTransition.Start();
        //}

        private void btnUser_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = new Point(e.X, e.Y);
            }
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newPoint = PointToScreen(new Point(e.X, e.Y));
                Location = new Point(newPoint.X - startPoint.X, newPoint.Y - startPoint.Y);
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
    }
}