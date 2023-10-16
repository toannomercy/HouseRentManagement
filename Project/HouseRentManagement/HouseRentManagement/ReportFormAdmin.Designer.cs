namespace HouseRentManagement
{
    partial class ReportFormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportFormAdmin));
            this.pnlReportAdmin = new Bunifu.UI.WinForms.BunifuPanel();
            this.tsReportAdmin = new System.Windows.Forms.ToolStrip();
            this.tsbReportCondo = new System.Windows.Forms.ToolStripButton();
            this.tsbReportFee = new System.Windows.Forms.ToolStripButton();
            this.tsbReportServices = new System.Windows.Forms.ToolStripButton();
            this.pnlReportAdmin.SuspendLayout();
            this.tsReportAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlReportAdmin
            // 
            this.pnlReportAdmin.AutoScroll = true;
            this.pnlReportAdmin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.pnlReportAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlReportAdmin.BackgroundImage")));
            this.pnlReportAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlReportAdmin.BorderColor = System.Drawing.Color.Transparent;
            this.pnlReportAdmin.BorderRadius = 3;
            this.pnlReportAdmin.BorderThickness = 1;
            this.pnlReportAdmin.Controls.Add(this.tsReportAdmin);
            this.pnlReportAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReportAdmin.Location = new System.Drawing.Point(0, 0);
            this.pnlReportAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.pnlReportAdmin.Name = "pnlReportAdmin";
            this.pnlReportAdmin.ShowBorders = true;
            this.pnlReportAdmin.Size = new System.Drawing.Size(958, 697);
            this.pnlReportAdmin.TabIndex = 1;
            // 
            // tsReportAdmin
            // 
            this.tsReportAdmin.AutoSize = false;
            this.tsReportAdmin.BackColor = System.Drawing.Color.White;
            this.tsReportAdmin.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsReportAdmin.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsReportAdmin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsReportAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbReportCondo,
            this.tsbReportFee,
            this.tsbReportServices});
            this.tsReportAdmin.Location = new System.Drawing.Point(0, 0);
            this.tsReportAdmin.Name = "tsReportAdmin";
            this.tsReportAdmin.Size = new System.Drawing.Size(958, 50);
            this.tsReportAdmin.TabIndex = 1;
            this.tsReportAdmin.Text = "toolStrip1";
            // 
            // tsbReportCondo
            // 
            this.tsbReportCondo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbReportCondo.Image = ((System.Drawing.Image)(resources.GetObject("tsbReportCondo.Image")));
            this.tsbReportCondo.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbReportCondo.Name = "tsbReportCondo";
            this.tsbReportCondo.Size = new System.Drawing.Size(130, 47);
            this.tsbReportCondo.Text = "Report of Condos";
            this.tsbReportCondo.Click += new System.EventHandler(this.tsbReportCondo_Click);
            // 
            // tsbReportFee
            // 
            this.tsbReportFee.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbReportFee.Image = ((System.Drawing.Image)(resources.GetObject("tsbReportFee.Image")));
            this.tsbReportFee.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbReportFee.Name = "tsbReportFee";
            this.tsbReportFee.Size = new System.Drawing.Size(108, 47);
            this.tsbReportFee.Text = "Report of Fees";
            this.tsbReportFee.Click += new System.EventHandler(this.tsbReportFee_Click);
            // 
            // tsbReportServices
            // 
            this.tsbReportServices.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbReportServices.Image = ((System.Drawing.Image)(resources.GetObject("tsbReportServices.Image")));
            this.tsbReportServices.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbReportServices.Name = "tsbReportServices";
            this.tsbReportServices.Size = new System.Drawing.Size(133, 47);
            this.tsbReportServices.Text = "Report of Services";
            this.tsbReportServices.Click += new System.EventHandler(this.tsbReportServices_Click);
            // 
            // ReportFormAdmin
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(958, 697);
            this.Controls.Add(this.pnlReportAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = global::HouseRentManagement.Properties.Resources.appLogo16x16;
            this.Name = "ReportFormAdmin";
            this.Text = "ReportFormAdmin";
            this.pnlReportAdmin.ResumeLayout(false);
            this.tsReportAdmin.ResumeLayout(false);
            this.tsReportAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel pnlReportAdmin;
        private System.Windows.Forms.ToolStrip tsReportAdmin;
        private System.Windows.Forms.ToolStripButton tsbReportCondo;
        private System.Windows.Forms.ToolStripButton tsbReportFee;
        private System.Windows.Forms.ToolStripButton tsbReportServices;
    }
}