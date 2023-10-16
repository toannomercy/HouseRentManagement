namespace HouseRentManagement
{
    partial class ReportServicesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportServicesForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSReport = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.dgvDB = new System.Windows.Forms.DataGridView();
            this.clMaCanHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoPhieuChuyenDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoPhieuThiCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSuaChua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhanHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTongSoTienSuaChua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTongSoTIenPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlReportServices = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblReportServices = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlSReport.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB)).BeginInit();
            this.pnlReportServices.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSReport
            // 
            this.pnlSReport.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlSReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSReport.BackgroundImage")));
            this.pnlSReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSReport.BorderColor = System.Drawing.Color.Transparent;
            this.pnlSReport.BorderRadius = 3;
            this.pnlSReport.BorderThickness = 1;
            this.pnlSReport.Controls.Add(this.pnlContainer);
            this.pnlSReport.Controls.Add(this.pnlReportServices);
            this.pnlSReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSReport.Location = new System.Drawing.Point(0, 0);
            this.pnlSReport.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSReport.Name = "pnlSReport";
            this.pnlSReport.ShowBorders = true;
            this.pnlSReport.Size = new System.Drawing.Size(958, 697);
            this.pnlSReport.TabIndex = 1;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.dgvDB);
            this.pnlContainer.Location = new System.Drawing.Point(0, 128);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(959, 569);
            this.pnlContainer.TabIndex = 5;
            // 
            // dgvDB
            // 
            this.dgvDB.AllowUserToAddRows = false;
            this.dgvDB.AllowUserToDeleteRows = false;
            this.dgvDB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaCanHo,
            this.clSoPhieuChuyenDo,
            this.clSoPhieuThiCong,
            this.clSuaChua,
            this.clPhat,
            this.clPhanHoi,
            this.clTongSoTienSuaChua,
            this.clTongSoTIenPhat});
            this.dgvDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDB.Location = new System.Drawing.Point(0, 0);
            this.dgvDB.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDB.Name = "dgvDB";
            this.dgvDB.ReadOnly = true;
            this.dgvDB.RowHeadersVisible = false;
            this.dgvDB.RowHeadersWidth = 51;
            this.dgvDB.Size = new System.Drawing.Size(959, 569);
            this.dgvDB.TabIndex = 6;
            // 
            // clMaCanHo
            // 
            this.clMaCanHo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clMaCanHo.HeaderText = "CondoID";
            this.clMaCanHo.MinimumWidth = 6;
            this.clMaCanHo.Name = "clMaCanHo";
            this.clMaCanHo.ReadOnly = true;
            this.clMaCanHo.Width = 84;
            // 
            // clSoPhieuChuyenDo
            // 
            this.clSoPhieuChuyenDo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clSoPhieuChuyenDo.HeaderText = "Transfer";
            this.clSoPhieuChuyenDo.MinimumWidth = 6;
            this.clSoPhieuChuyenDo.Name = "clSoPhieuChuyenDo";
            this.clSoPhieuChuyenDo.ReadOnly = true;
            this.clSoPhieuChuyenDo.Width = 85;
            // 
            // clSoPhieuThiCong
            // 
            this.clSoPhieuThiCong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clSoPhieuThiCong.HeaderText = "Construction";
            this.clSoPhieuThiCong.MinimumWidth = 6;
            this.clSoPhieuThiCong.Name = "clSoPhieuThiCong";
            this.clSoPhieuThiCong.ReadOnly = true;
            this.clSoPhieuThiCong.Width = 107;
            // 
            // clSuaChua
            // 
            this.clSuaChua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clSuaChua.HeaderText = "Fixing";
            this.clSuaChua.MinimumWidth = 6;
            this.clSuaChua.Name = "clSuaChua";
            this.clSuaChua.ReadOnly = true;
            this.clSuaChua.Width = 69;
            // 
            // clPhat
            // 
            this.clPhat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clPhat.HeaderText = "Punish";
            this.clPhat.MinimumWidth = 6;
            this.clPhat.Name = "clPhat";
            this.clPhat.ReadOnly = true;
            this.clPhat.Width = 73;
            // 
            // clPhanHoi
            // 
            this.clPhanHoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clPhanHoi.HeaderText = "Feedback";
            this.clPhanHoi.MinimumWidth = 6;
            this.clPhanHoi.Name = "clPhanHoi";
            this.clPhanHoi.ReadOnly = true;
            this.clPhanHoi.Width = 90;
            // 
            // clTongSoTienSuaChua
            // 
            this.clTongSoTienSuaChua.HeaderText = "Total Money Fixed";
            this.clTongSoTienSuaChua.MinimumWidth = 6;
            this.clTongSoTienSuaChua.Name = "clTongSoTienSuaChua";
            this.clTongSoTienSuaChua.ReadOnly = true;
            this.clTongSoTienSuaChua.Width = 220;
            // 
            // clTongSoTIenPhat
            // 
            this.clTongSoTIenPhat.HeaderText = "Total Money Punished";
            this.clTongSoTIenPhat.MinimumWidth = 6;
            this.clTongSoTIenPhat.Name = "clTongSoTIenPhat";
            this.clTongSoTIenPhat.ReadOnly = true;
            this.clTongSoTIenPhat.Width = 220;
            // 
            // pnlReportServices
            // 
            this.pnlReportServices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.pnlReportServices.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlReportServices.BackgroundImage")));
            this.pnlReportServices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlReportServices.BorderColor = System.Drawing.Color.Teal;
            this.pnlReportServices.BorderRadius = 1;
            this.pnlReportServices.BorderThickness = 1;
            this.pnlReportServices.Controls.Add(this.lblReportServices);
            this.pnlReportServices.Location = new System.Drawing.Point(0, 52);
            this.pnlReportServices.Margin = new System.Windows.Forms.Padding(4);
            this.pnlReportServices.Name = "pnlReportServices";
            this.pnlReportServices.ShowBorders = true;
            this.pnlReportServices.Size = new System.Drawing.Size(1067, 78);
            this.pnlReportServices.TabIndex = 4;
            // 
            // lblReportServices
            // 
            this.lblReportServices.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.lblReportServices.AllowParentOverrides = false;
            this.lblReportServices.AutoEllipsis = false;
            this.lblReportServices.CursorType = null;
            this.lblReportServices.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportServices.ForeColor = System.Drawing.Color.White;
            this.lblReportServices.Location = new System.Drawing.Point(16, 15);
            this.lblReportServices.Margin = new System.Windows.Forms.Padding(4);
            this.lblReportServices.Name = "lblReportServices";
            this.lblReportServices.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblReportServices.Size = new System.Drawing.Size(239, 41);
            this.lblReportServices.TabIndex = 0;
            this.lblReportServices.Text = "Report of Services";
            this.lblReportServices.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblReportServices.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ReportServicesForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 697);
            this.Controls.Add(this.pnlSReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = global::HouseRentManagement.Properties.Resources.appLogo16x16;
            this.Name = "ReportServicesForm";
            this.Text = "ReportServicesForm";
            this.pnlSReport.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB)).EndInit();
            this.pnlReportServices.ResumeLayout(false);
            this.pnlReportServices.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPanel pnlSReport;
        private Bunifu.UI.WinForms.BunifuPanel pnlReportServices;
        private Bunifu.UI.WinForms.BunifuLabel lblReportServices;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.DataGridView dgvDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaCanHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoPhieuChuyenDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoPhieuThiCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSuaChua;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPhanHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTongSoTienSuaChua;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTongSoTIenPhat;
    }
}