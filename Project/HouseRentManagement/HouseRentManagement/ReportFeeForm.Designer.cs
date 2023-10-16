namespace HouseRentManagement
{
    partial class ReportFeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportFeeForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMoney = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.dgvDB = new System.Windows.Forms.DataGridView();
            this.clMaCanHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhiTIen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTuNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDenNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThanhTIen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlReportFee = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblReportFee = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlMoney.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB)).BeginInit();
            this.pnlReportFee.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMoney
            // 
            this.pnlMoney.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlMoney.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMoney.BackgroundImage")));
            this.pnlMoney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMoney.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.pnlMoney.BorderRadius = 3;
            this.pnlMoney.BorderThickness = 1;
            this.pnlMoney.Controls.Add(this.pnlContainer);
            this.pnlMoney.Controls.Add(this.pnlReportFee);
            this.pnlMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMoney.Location = new System.Drawing.Point(0, 0);
            this.pnlMoney.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMoney.Name = "pnlMoney";
            this.pnlMoney.ShowBorders = true;
            this.pnlMoney.Size = new System.Drawing.Size(958, 697);
            this.pnlMoney.TabIndex = 4;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.dgvDB);
            this.pnlContainer.Location = new System.Drawing.Point(0, 128);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(959, 569);
            this.pnlContainer.TabIndex = 3;
            // 
            // dgvDB
            // 
            this.dgvDB.AllowUserToAddRows = false;
            this.dgvDB.AllowUserToDeleteRows = false;
            this.dgvDB.AllowUserToOrderColumns = true;
            this.dgvDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvDB.BackgroundColor = System.Drawing.SystemColors.Control;
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
            this.clPhiTIen,
            this.clTuNgay,
            this.clDenNgay,
            this.clGiaTien,
            this.clSoLuong,
            this.clDonViTinh,
            this.clThanhTIen,
            this.clTongTien,
            this.clGhiChu});
            this.dgvDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDB.Location = new System.Drawing.Point(0, 0);
            this.dgvDB.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDB.Name = "dgvDB";
            this.dgvDB.ReadOnly = true;
            this.dgvDB.RowHeadersVisible = false;
            this.dgvDB.RowHeadersWidth = 51;
            this.dgvDB.Size = new System.Drawing.Size(959, 569);
            this.dgvDB.TabIndex = 5;
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
            // clPhiTIen
            // 
            this.clPhiTIen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clPhiTIen.HeaderText = "Cost";
            this.clPhiTIen.MinimumWidth = 6;
            this.clPhiTIen.Name = "clPhiTIen";
            this.clPhiTIen.ReadOnly = true;
            this.clPhiTIen.Width = 61;
            // 
            // clTuNgay
            // 
            this.clTuNgay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clTuNgay.HeaderText = "Begin";
            this.clTuNgay.MinimumWidth = 6;
            this.clTuNgay.Name = "clTuNgay";
            this.clTuNgay.ReadOnly = true;
            this.clTuNgay.Width = 67;
            // 
            // clDenNgay
            // 
            this.clDenNgay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clDenNgay.HeaderText = "End";
            this.clDenNgay.MinimumWidth = 6;
            this.clDenNgay.Name = "clDenNgay";
            this.clDenNgay.ReadOnly = true;
            this.clDenNgay.Width = 57;
            // 
            // clGiaTien
            // 
            this.clGiaTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clGiaTien.HeaderText = "Price";
            this.clGiaTien.MinimumWidth = 6;
            this.clGiaTien.Name = "clGiaTien";
            this.clGiaTien.ReadOnly = true;
            this.clGiaTien.Width = 64;
            // 
            // clSoLuong
            // 
            this.clSoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clSoLuong.HeaderText = "Quantity";
            this.clSoLuong.MinimumWidth = 6;
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.ReadOnly = true;
            this.clSoLuong.Width = 83;
            // 
            // clDonViTinh
            // 
            this.clDonViTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clDonViTinh.HeaderText = "Unit";
            this.clDonViTinh.MinimumWidth = 6;
            this.clDonViTinh.Name = "clDonViTinh";
            this.clDonViTinh.ReadOnly = true;
            this.clDonViTinh.Width = 58;
            // 
            // clThanhTIen
            // 
            this.clThanhTIen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clThanhTIen.HeaderText = "Money";
            this.clThanhTIen.MinimumWidth = 6;
            this.clThanhTIen.Name = "clThanhTIen";
            this.clThanhTIen.ReadOnly = true;
            this.clThanhTIen.Width = 73;
            // 
            // clTongTien
            // 
            this.clTongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clTongTien.HeaderText = "Total Money";
            this.clTongTien.MinimumWidth = 6;
            this.clTongTien.Name = "clTongTien";
            this.clTongTien.ReadOnly = true;
            this.clTongTien.Width = 106;
            // 
            // clGhiChu
            // 
            this.clGhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clGhiChu.HeaderText = "Note";
            this.clGhiChu.MinimumWidth = 6;
            this.clGhiChu.Name = "clGhiChu";
            this.clGhiChu.ReadOnly = true;
            this.clGhiChu.Width = 62;
            // 
            // pnlReportFee
            // 
            this.pnlReportFee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.pnlReportFee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlReportFee.BackgroundImage")));
            this.pnlReportFee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlReportFee.BorderColor = System.Drawing.Color.Teal;
            this.pnlReportFee.BorderRadius = 1;
            this.pnlReportFee.BorderThickness = 1;
            this.pnlReportFee.Controls.Add(this.lblReportFee);
            this.pnlReportFee.Location = new System.Drawing.Point(-1, 52);
            this.pnlReportFee.Margin = new System.Windows.Forms.Padding(4);
            this.pnlReportFee.Name = "pnlReportFee";
            this.pnlReportFee.ShowBorders = true;
            this.pnlReportFee.Size = new System.Drawing.Size(959, 78);
            this.pnlReportFee.TabIndex = 2;
            // 
            // lblReportFee
            // 
            this.lblReportFee.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.lblReportFee.AllowParentOverrides = false;
            this.lblReportFee.AutoEllipsis = false;
            this.lblReportFee.CursorType = null;
            this.lblReportFee.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportFee.ForeColor = System.Drawing.Color.White;
            this.lblReportFee.Location = new System.Drawing.Point(16, 15);
            this.lblReportFee.Margin = new System.Windows.Forms.Padding(4);
            this.lblReportFee.Name = "lblReportFee";
            this.lblReportFee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblReportFee.Size = new System.Drawing.Size(193, 41);
            this.lblReportFee.TabIndex = 0;
            this.lblReportFee.Text = "Report of Fees";
            this.lblReportFee.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblReportFee.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ReportFeeForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(958, 697);
            this.Controls.Add(this.pnlMoney);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = global::HouseRentManagement.Properties.Resources.appLogo16x16;
            this.Name = "ReportFeeForm";
            this.Text = "ReportFeeForm";
            this.pnlMoney.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB)).EndInit();
            this.pnlReportFee.ResumeLayout(false);
            this.pnlReportFee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel lblReportFee;
        private Bunifu.UI.WinForms.BunifuPanel pnlReportFee;
        private Bunifu.UI.WinForms.BunifuPanel pnlMoney;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.DataGridView dgvDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaCanHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPhiTIen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTuNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDenNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThanhTIen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhiChu;
    }
}