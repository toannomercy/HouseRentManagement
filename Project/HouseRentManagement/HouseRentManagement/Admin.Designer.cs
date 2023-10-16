namespace HouseRentManagement
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.pnlNavLoad = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlProfileLoad = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.pnlEmployee = new System.Windows.Forms.Panel();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.pnlResidentCard = new System.Windows.Forms.Panel();
            this.btnTenant = new System.Windows.Forms.Button();
            this.pnlContract = new System.Windows.Forms.Panel();
            this.btnContract = new System.Windows.Forms.Button();
            this.pnlCodo = new System.Windows.Forms.Panel();
            this.btnCondo = new System.Windows.Forms.Button();
            this.pnlPrice = new System.Windows.Forms.Panel();
            this.btnPrice = new System.Windows.Forms.Button();
            this.pnlReport = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.pnlExport = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.pnlLogout = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.pnlUserBar = new Bunifu.UI.WinForms.BunifuPanel();
            this.ctbClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblHeadUser = new System.Windows.Forms.Label();
            this.picBoxLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlNavLoad.SuspendLayout();
            this.pnlHome.SuspendLayout();
            this.pnlProfileLoad.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlEmployee.SuspendLayout();
            this.pnlResidentCard.SuspendLayout();
            this.pnlContract.SuspendLayout();
            this.pnlCodo.SuspendLayout();
            this.pnlPrice.SuspendLayout();
            this.pnlReport.SuspendLayout();
            this.pnlExport.SuspendLayout();
            this.pnlLogout.SuspendLayout();
            this.pnlUserBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNavLoad
            // 
            this.pnlNavLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.pnlNavLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlNavLoad.Controls.Add(this.pnlHome);
            this.pnlNavLoad.Controls.Add(this.pnlProfileLoad);
            this.pnlNavLoad.Controls.Add(this.pnlExport);
            this.pnlNavLoad.Controls.Add(this.pnlLogout);
            this.pnlNavLoad.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavLoad.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlNavLoad.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlNavLoad.Location = new System.Drawing.Point(0, 40);
            this.pnlNavLoad.Name = "pnlNavLoad";
            this.pnlNavLoad.Size = new System.Drawing.Size(255, 700);
            this.pnlNavLoad.TabIndex = 22;
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.btnHome);
            this.pnlHome.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlHome.Location = new System.Drawing.Point(0, 0);
            this.pnlHome.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(255, 54);
            this.pnlHome.TabIndex = 22;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::HouseRentManagement.Properties.Resources.btnHomepageWhite16x16;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(-26, -29);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(323, 117);
            this.btnHome.TabIndex = 23;
            this.btnHome.Text = "          Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // pnlProfileLoad
            // 
            this.pnlProfileLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.pnlProfileLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlProfileLoad.Controls.Add(this.panel1);
            this.pnlProfileLoad.Controls.Add(this.pnlEmployee);
            this.pnlProfileLoad.Controls.Add(this.pnlResidentCard);
            this.pnlProfileLoad.Controls.Add(this.pnlContract);
            this.pnlProfileLoad.Controls.Add(this.pnlCodo);
            this.pnlProfileLoad.Controls.Add(this.pnlPrice);
            this.pnlProfileLoad.Controls.Add(this.pnlReport);
            this.pnlProfileLoad.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlProfileLoad.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlProfileLoad.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlProfileLoad.ForeColor = System.Drawing.Color.White;
            this.pnlProfileLoad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnlProfileLoad.Location = new System.Drawing.Point(0, 54);
            this.pnlProfileLoad.Margin = new System.Windows.Forms.Padding(0);
            this.pnlProfileLoad.Name = "pnlProfileLoad";
            this.pnlProfileLoad.Size = new System.Drawing.Size(255, 54);
            this.pnlProfileLoad.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 54);
            this.panel1.TabIndex = 25;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Image = global::HouseRentManagement.Properties.Resources.btnUserWhite16x16;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(-26, -31);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAdmin.Size = new System.Drawing.Size(323, 117);
            this.btnAdmin.TabIndex = 23;
            this.btnAdmin.Text = "          Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // pnlEmployee
            // 
            this.pnlEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.pnlEmployee.Controls.Add(this.btnEmployee);
            this.pnlEmployee.Location = new System.Drawing.Point(255, 0);
            this.pnlEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(255, 54);
            this.pnlEmployee.TabIndex = 22;
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Image = global::HouseRentManagement.Properties.Resources.btnEmployeeWhite16x16;
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(-26, -34);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnEmployee.Size = new System.Drawing.Size(323, 117);
            this.btnEmployee.TabIndex = 23;
            this.btnEmployee.Text = "          Employee";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // pnlResidentCard
            // 
            this.pnlResidentCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.pnlResidentCard.Controls.Add(this.btnTenant);
            this.pnlResidentCard.Location = new System.Drawing.Point(510, 0);
            this.pnlResidentCard.Margin = new System.Windows.Forms.Padding(0);
            this.pnlResidentCard.Name = "pnlResidentCard";
            this.pnlResidentCard.Size = new System.Drawing.Size(255, 54);
            this.pnlResidentCard.TabIndex = 23;
            // 
            // btnTenant
            // 
            this.btnTenant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnTenant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTenant.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTenant.ForeColor = System.Drawing.Color.White;
            this.btnTenant.Image = global::HouseRentManagement.Properties.Resources.btnResidentCardWhite16x16;
            this.btnTenant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTenant.Location = new System.Drawing.Point(-26, -31);
            this.btnTenant.Name = "btnTenant";
            this.btnTenant.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnTenant.Size = new System.Drawing.Size(323, 117);
            this.btnTenant.TabIndex = 23;
            this.btnTenant.Text = "          Tenant";
            this.btnTenant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTenant.UseVisualStyleBackColor = false;
            this.btnTenant.Click += new System.EventHandler(this.btnResidentCard_Click);
            // 
            // pnlContract
            // 
            this.pnlContract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.pnlContract.Controls.Add(this.btnContract);
            this.pnlContract.Location = new System.Drawing.Point(765, 0);
            this.pnlContract.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContract.Name = "pnlContract";
            this.pnlContract.Size = new System.Drawing.Size(255, 54);
            this.pnlContract.TabIndex = 24;
            // 
            // btnContract
            // 
            this.btnContract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnContract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContract.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContract.ForeColor = System.Drawing.Color.White;
            this.btnContract.Image = global::HouseRentManagement.Properties.Resources.btnContractWhite16x16;
            this.btnContract.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContract.Location = new System.Drawing.Point(-26, -31);
            this.btnContract.Name = "btnContract";
            this.btnContract.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnContract.Size = new System.Drawing.Size(323, 117);
            this.btnContract.TabIndex = 23;
            this.btnContract.Text = "          Contract";
            this.btnContract.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContract.UseVisualStyleBackColor = false;
            this.btnContract.Click += new System.EventHandler(this.btnContract_Click);
            // 
            // pnlCodo
            // 
            this.pnlCodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.pnlCodo.Controls.Add(this.btnCondo);
            this.pnlCodo.Location = new System.Drawing.Point(1020, 0);
            this.pnlCodo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCodo.Name = "pnlCodo";
            this.pnlCodo.Size = new System.Drawing.Size(255, 54);
            this.pnlCodo.TabIndex = 24;
            // 
            // btnCondo
            // 
            this.btnCondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCondo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCondo.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCondo.ForeColor = System.Drawing.Color.White;
            this.btnCondo.Image = global::HouseRentManagement.Properties.Resources.btnCondoWhite16x16;
            this.btnCondo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCondo.Location = new System.Drawing.Point(-26, -31);
            this.btnCondo.Name = "btnCondo";
            this.btnCondo.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCondo.Size = new System.Drawing.Size(323, 117);
            this.btnCondo.TabIndex = 23;
            this.btnCondo.Text = "          Condo";
            this.btnCondo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCondo.UseVisualStyleBackColor = false;
            this.btnCondo.Click += new System.EventHandler(this.btnCondo_Click);
            // 
            // pnlPrice
            // 
            this.pnlPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.pnlPrice.Controls.Add(this.btnPrice);
            this.pnlPrice.Location = new System.Drawing.Point(1275, 0);
            this.pnlPrice.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPrice.Name = "pnlPrice";
            this.pnlPrice.Size = new System.Drawing.Size(255, 54);
            this.pnlPrice.TabIndex = 24;
            // 
            // btnPrice
            // 
            this.btnPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrice.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrice.ForeColor = System.Drawing.Color.White;
            this.btnPrice.Image = global::HouseRentManagement.Properties.Resources.btnPriceWhite16x16;
            this.btnPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrice.Location = new System.Drawing.Point(-26, -31);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPrice.Size = new System.Drawing.Size(323, 117);
            this.btnPrice.TabIndex = 23;
            this.btnPrice.Text = "          Price";
            this.btnPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrice.UseVisualStyleBackColor = false;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // pnlReport
            // 
            this.pnlReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.pnlReport.Controls.Add(this.btnReport);
            this.pnlReport.Location = new System.Drawing.Point(1530, 0);
            this.pnlReport.Margin = new System.Windows.Forms.Padding(0);
            this.pnlReport.Name = "pnlReport";
            this.pnlReport.Size = new System.Drawing.Size(255, 54);
            this.pnlReport.TabIndex = 24;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Image = global::HouseRentManagement.Properties.Resources.btnReportWhite16x16;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(-26, -31);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(323, 117);
            this.btnReport.TabIndex = 23;
            this.btnReport.Text = "          Report";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // pnlExport
            // 
            this.pnlExport.Controls.Add(this.btnExport);
            this.pnlExport.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlExport.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlExport.Location = new System.Drawing.Point(0, 108);
            this.pnlExport.Margin = new System.Windows.Forms.Padding(0);
            this.pnlExport.Name = "pnlExport";
            this.pnlExport.Size = new System.Drawing.Size(255, 54);
            this.pnlExport.TabIndex = 25;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Image = global::HouseRentManagement.Properties.Resources.btnExportWhite16x16;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(-26, -29);
            this.btnExport.Name = "btnExport";
            this.btnExport.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnExport.Size = new System.Drawing.Size(323, 117);
            this.btnExport.TabIndex = 23;
            this.btnExport.Text = "          Export";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // pnlLogout
            // 
            this.pnlLogout.Controls.Add(this.btnLogout);
            this.pnlLogout.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlLogout.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLogout.Location = new System.Drawing.Point(0, 162);
            this.pnlLogout.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLogout.Name = "pnlLogout";
            this.pnlLogout.Size = new System.Drawing.Size(255, 54);
            this.pnlLogout.TabIndex = 25;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::HouseRentManagement.Properties.Resources.btnLogoutWhite16x16;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(-26, -29);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(323, 117);
            this.btnLogout.TabIndex = 23;
            this.btnLogout.Text = "          Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // pnlUserBar
            // 
            this.pnlUserBar.BackgroundColor = System.Drawing.Color.White;
            this.pnlUserBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlUserBar.BackgroundImage")));
            this.pnlUserBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlUserBar.BorderColor = System.Drawing.Color.Transparent;
            this.pnlUserBar.BorderRadius = 3;
            this.pnlUserBar.BorderThickness = 1;
            this.pnlUserBar.Controls.Add(this.ctbClose);
            this.pnlUserBar.Controls.Add(this.lblHeadUser);
            this.pnlUserBar.Controls.Add(this.picBoxLogo);
            this.pnlUserBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserBar.Location = new System.Drawing.Point(0, 0);
            this.pnlUserBar.Name = "pnlUserBar";
            this.pnlUserBar.ShowBorders = true;
            this.pnlUserBar.Size = new System.Drawing.Size(1220, 40);
            this.pnlUserBar.TabIndex = 10;
            this.pnlUserBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.pnlUserBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.pnlUserBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
            // 
            // ctbClose
            // 
            this.ctbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctbClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.ctbClose.FillColor = System.Drawing.Color.White;
            this.ctbClose.IconColor = System.Drawing.Color.Black;
            this.ctbClose.Location = new System.Drawing.Point(1175, 0);
            this.ctbClose.Name = "ctbClose";
            this.ctbClose.Size = new System.Drawing.Size(45, 40);
            this.ctbClose.TabIndex = 6;
            // 
            // lblHeadUser
            // 
            this.lblHeadUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHeadUser.AutoSize = true;
            this.lblHeadUser.BackColor = System.Drawing.Color.White;
            this.lblHeadUser.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadUser.Location = new System.Drawing.Point(45, 11);
            this.lblHeadUser.Name = "lblHeadUser";
            this.lblHeadUser.Size = new System.Drawing.Size(191, 20);
            this.lblHeadUser.TabIndex = 5;
            this.lblHeadUser.Text = "Rental Mangement | Admin";
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picBoxLogo.BackColor = System.Drawing.Color.White;
            this.picBoxLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.picBoxLogo.Image = global::HouseRentManagement.Properties.Resources.appLogo16x16;
            this.picBoxLogo.ImageRotate = 0F;
            this.picBoxLogo.Location = new System.Drawing.Point(4, 3);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(35, 35);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxLogo.TabIndex = 1;
            this.picBoxLogo.TabStop = false;
            // 
            // Admin
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 740);
            this.Controls.Add(this.pnlNavLoad);
            this.Controls.Add(this.pnlUserBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Admin.IconOptions.Image")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin";
            this.Text = "JungleUncles Rental House System";
            this.pnlNavLoad.ResumeLayout(false);
            this.pnlHome.ResumeLayout(false);
            this.pnlProfileLoad.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlEmployee.ResumeLayout(false);
            this.pnlResidentCard.ResumeLayout(false);
            this.pnlContract.ResumeLayout(false);
            this.pnlCodo.ResumeLayout(false);
            this.pnlPrice.ResumeLayout(false);
            this.pnlReport.ResumeLayout(false);
            this.pnlExport.ResumeLayout(false);
            this.pnlLogout.ResumeLayout(false);
            this.pnlUserBar.ResumeLayout(false);
            this.pnlUserBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPanel pnlUserBar;
        private Guna.UI2.WinForms.Guna2ControlBox ctbClose;
        private System.Windows.Forms.Label lblHeadUser;
        private Guna.UI2.WinForms.Guna2PictureBox picBoxLogo;
        private System.Windows.Forms.FlowLayoutPanel pnlNavLoad;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.FlowLayoutPanel pnlProfileLoad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel pnlEmployee;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Panel pnlResidentCard;
        private System.Windows.Forms.Button btnTenant;
        private System.Windows.Forms.Panel pnlExport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel pnlContract;
        private System.Windows.Forms.Button btnContract;
        private System.Windows.Forms.Panel pnlCodo;
        private System.Windows.Forms.Button btnCondo;
        private System.Windows.Forms.Panel pnlPrice;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.Panel pnlReport;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Panel pnlLogout;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Timer menuTransition;
    }
}

