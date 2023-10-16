namespace HouseRentManagement
{
    partial class ExportAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportAdmin));
            this.pnlPriceTitle = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlReport = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnExcel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnPdf = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlExport = new Bunifu.UI.WinForms.BunifuPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbRC = new System.Windows.Forms.ToolStripButton();
            this.tsbRF = new System.Windows.Forms.ToolStripButton();
            this.tsbRS = new System.Windows.Forms.ToolStripButton();
            this.pnlPriceTitle.SuspendLayout();
            this.pnlReport.SuspendLayout();
            this.pnlExport.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPriceTitle
            // 
            this.pnlPriceTitle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.pnlPriceTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPriceTitle.BackgroundImage")));
            this.pnlPriceTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPriceTitle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.pnlPriceTitle.BorderRadius = 0;
            this.pnlPriceTitle.BorderThickness = 0;
            this.pnlPriceTitle.Controls.Add(this.bunifuLabel2);
            this.pnlPriceTitle.Controls.Add(this.bunifuLabel1);
            this.pnlPriceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.pnlPriceTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlPriceTitle.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPriceTitle.Name = "pnlPriceTitle";
            this.pnlPriceTitle.ShowBorders = true;
            this.pnlPriceTitle.Size = new System.Drawing.Size(958, 86);
            this.pnlPriceTitle.TabIndex = 12;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel2.Location = new System.Drawing.Point(16, 46);
            this.bunifuLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(306, 28);
            this.bunifuLabel2.TabIndex = 0;
            this.bunifuLabel2.Text = "Export Reports into Pdf files or Paper";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.AutoSize = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(0, -4);
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(164, 54);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Export";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pnlReport
            // 
            this.pnlReport.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlReport.BackgroundImage")));
            this.pnlReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlReport.BorderColor = System.Drawing.Color.Transparent;
            this.pnlReport.BorderRadius = 3;
            this.pnlReport.BorderThickness = 1;
            this.pnlReport.Controls.Add(this.btnExcel);
            this.pnlReport.Controls.Add(this.pnlPriceTitle);
            this.pnlReport.Controls.Add(this.btnPdf);
            this.pnlReport.Controls.Add(this.pnlExport);
            this.pnlReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReport.Location = new System.Drawing.Point(0, 0);
            this.pnlReport.Margin = new System.Windows.Forms.Padding(4);
            this.pnlReport.Name = "pnlReport";
            this.pnlReport.ShowBorders = true;
            this.pnlReport.Size = new System.Drawing.Size(958, 697);
            this.pnlReport.TabIndex = 1;
            // 
            // btnExcel
            // 
            this.btnExcel.ActiveBorderThickness = 1;
            this.btnExcel.ActiveCornerRadius = 20;
            this.btnExcel.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(196)))));
            this.btnExcel.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.btnExcel.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(196)))));
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.btnExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.BackgroundImage")));
            this.btnExcel.ButtonText = "Print to Excel file";
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.btnExcel.IdleBorderThickness = 1;
            this.btnExcel.IdleCornerRadius = 20;
            this.btnExcel.IdleFillColor = System.Drawing.Color.DarkGreen;
            this.btnExcel.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.btnExcel.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(125)))), ((int)(((byte)(122)))));
            this.btnExcel.Location = new System.Drawing.Point(575, 560);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(5);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(220, 39);
            this.btnExcel.TabIndex = 26;
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.ActiveBorderThickness = 1;
            this.btnPdf.ActiveCornerRadius = 20;
            this.btnPdf.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(196)))));
            this.btnPdf.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.btnPdf.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(196)))));
            this.btnPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.btnPdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPdf.BackgroundImage")));
            this.btnPdf.ButtonText = "Print to PDF file";
            this.btnPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPdf.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.btnPdf.IdleBorderThickness = 1;
            this.btnPdf.IdleCornerRadius = 20;
            this.btnPdf.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPdf.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.btnPdf.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(125)))), ((int)(((byte)(122)))));
            this.btnPdf.Location = new System.Drawing.Point(198, 560);
            this.btnPdf.Margin = new System.Windows.Forms.Padding(5);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(205, 39);
            this.btnPdf.TabIndex = 26;
            this.btnPdf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // pnlExport
            // 
            this.pnlExport.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlExport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlExport.BackgroundImage")));
            this.pnlExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlExport.BorderColor = System.Drawing.Color.Transparent;
            this.pnlExport.BorderRadius = 3;
            this.pnlExport.BorderThickness = 1;
            this.pnlExport.Controls.Add(this.toolStrip1);
            this.pnlExport.Location = new System.Drawing.Point(0, 82);
            this.pnlExport.Margin = new System.Windows.Forms.Padding(4);
            this.pnlExport.Name = "pnlExport";
            this.pnlExport.ShowBorders = false;
            this.pnlExport.Size = new System.Drawing.Size(958, 469);
            this.pnlExport.TabIndex = 13;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRC,
            this.tsbRF,
            this.tsbRS});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(958, 28);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbRC
            // 
            this.tsbRC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRC.Image = ((System.Drawing.Image)(resources.GetObject("tsbRC.Image")));
            this.tsbRC.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbRC.Name = "tsbRC";
            this.tsbRC.Size = new System.Drawing.Size(130, 25);
            this.tsbRC.Text = "Report of Condos";
            this.tsbRC.Click += new System.EventHandler(this.tsbRC_Click);
            // 
            // tsbRF
            // 
            this.tsbRF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRF.Image = ((System.Drawing.Image)(resources.GetObject("tsbRF.Image")));
            this.tsbRF.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbRF.Name = "tsbRF";
            this.tsbRF.Size = new System.Drawing.Size(109, 25);
            this.tsbRF.Text = "Report of Fees";
            this.tsbRF.Click += new System.EventHandler(this.tsbRF_Click);
            // 
            // tsbRS
            // 
            this.tsbRS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRS.Image = ((System.Drawing.Image)(resources.GetObject("tsbRS.Image")));
            this.tsbRS.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbRS.Name = "tsbRS";
            this.tsbRS.Size = new System.Drawing.Size(133, 25);
            this.tsbRS.Text = "Report of Services";
            this.tsbRS.Click += new System.EventHandler(this.tsbRS_Click);
            // 
            // ExportAdmin
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 697);
            this.Controls.Add(this.pnlReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = global::HouseRentManagement.Properties.Resources.appLogo16x16;
            this.Name = "ExportAdmin";
            this.Text = "ExportAdmin";
            this.pnlPriceTitle.ResumeLayout(false);
            this.pnlPriceTitle.PerformLayout();
            this.pnlReport.ResumeLayout(false);
            this.pnlExport.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel pnlPriceTitle;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuPanel pnlReport;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExcel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPdf;
        private Bunifu.UI.WinForms.BunifuPanel pnlExport;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbRC;
        private System.Windows.Forms.ToolStripButton tsbRF;
        private System.Windows.Forms.ToolStripButton tsbRS;
    }
}