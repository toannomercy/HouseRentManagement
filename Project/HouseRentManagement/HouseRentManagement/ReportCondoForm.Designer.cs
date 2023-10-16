namespace HouseRentManagement
{
    partial class ReportCondoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportCondoForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlRRReport = new Bunifu.UI.WinForms.BunifuPanel();
            this.dgvDB = new System.Windows.Forms.DataGridView();
            this.clCanHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNguoiThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clChuSoHuu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlReportCondo = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblReportCondo = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlRRReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB)).BeginInit();
            this.pnlReportCondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRRReport
            // 
            this.pnlRRReport.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlRRReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlRRReport.BackgroundImage")));
            this.pnlRRReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRRReport.BorderColor = System.Drawing.Color.Transparent;
            this.pnlRRReport.BorderRadius = 3;
            this.pnlRRReport.BorderThickness = 1;
            this.pnlRRReport.Controls.Add(this.dgvDB);
            this.pnlRRReport.Controls.Add(this.pnlReportCondo);
            this.pnlRRReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRRReport.Location = new System.Drawing.Point(0, 0);
            this.pnlRRReport.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRRReport.Name = "pnlRRReport";
            this.pnlRRReport.ShowBorders = true;
            this.pnlRRReport.Size = new System.Drawing.Size(958, 697);
            this.pnlRRReport.TabIndex = 1;
            // 
            // dgvDB
            // 
            this.dgvDB.AllowUserToAddRows = false;
            this.dgvDB.AllowUserToDeleteRows = false;
            this.dgvDB.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDB.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.clCanHo,
            this.clTang,
            this.clTinhTrang,
            this.clNguoiThue,
            this.clChuSoHuu,
            this.clLoai});
            this.dgvDB.Location = new System.Drawing.Point(0, 129);
            this.dgvDB.Margin = new System.Windows.Forms.Padding(0);
            this.dgvDB.Name = "dgvDB";
            this.dgvDB.ReadOnly = true;
            this.dgvDB.RowHeadersVisible = false;
            this.dgvDB.RowHeadersWidth = 51;
            this.dgvDB.Size = new System.Drawing.Size(958, 568);
            this.dgvDB.TabIndex = 4;
            // 
            // clCanHo
            // 
            this.clCanHo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clCanHo.HeaderText = "MaCanHo";
            this.clCanHo.MinimumWidth = 6;
            this.clCanHo.Name = "clCanHo";
            this.clCanHo.ReadOnly = true;
            this.clCanHo.Width = 90;
            // 
            // clTang
            // 
            this.clTang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTang.HeaderText = "Tang";
            this.clTang.MinimumWidth = 6;
            this.clTang.Name = "clTang";
            this.clTang.ReadOnly = true;
            // 
            // clTinhTrang
            // 
            this.clTinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTinhTrang.HeaderText = "TinhTrang";
            this.clTinhTrang.MinimumWidth = 6;
            this.clTinhTrang.Name = "clTinhTrang";
            this.clTinhTrang.ReadOnly = true;
            // 
            // clNguoiThue
            // 
            this.clNguoiThue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNguoiThue.HeaderText = "NguoiThue";
            this.clNguoiThue.MinimumWidth = 6;
            this.clNguoiThue.Name = "clNguoiThue";
            this.clNguoiThue.ReadOnly = true;
            // 
            // clChuSoHuu
            // 
            this.clChuSoHuu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clChuSoHuu.HeaderText = "ChuSoHuu";
            this.clChuSoHuu.MinimumWidth = 6;
            this.clChuSoHuu.Name = "clChuSoHuu";
            this.clChuSoHuu.ReadOnly = true;
            // 
            // clLoai
            // 
            this.clLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clLoai.HeaderText = "Loai";
            this.clLoai.MinimumWidth = 6;
            this.clLoai.Name = "clLoai";
            this.clLoai.ReadOnly = true;
            // 
            // pnlReportCondo
            // 
            this.pnlReportCondo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.pnlReportCondo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlReportCondo.BackgroundImage")));
            this.pnlReportCondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlReportCondo.BorderColor = System.Drawing.Color.Teal;
            this.pnlReportCondo.BorderRadius = 1;
            this.pnlReportCondo.BorderThickness = 1;
            this.pnlReportCondo.Controls.Add(this.lblReportCondo);
            this.pnlReportCondo.Location = new System.Drawing.Point(0, 52);
            this.pnlReportCondo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlReportCondo.Name = "pnlReportCondo";
            this.pnlReportCondo.ShowBorders = true;
            this.pnlReportCondo.Size = new System.Drawing.Size(1067, 78);
            this.pnlReportCondo.TabIndex = 1;
            // 
            // lblReportCondo
            // 
            this.lblReportCondo.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.lblReportCondo.AllowParentOverrides = false;
            this.lblReportCondo.AutoEllipsis = false;
            this.lblReportCondo.CursorType = null;
            this.lblReportCondo.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportCondo.ForeColor = System.Drawing.Color.White;
            this.lblReportCondo.Location = new System.Drawing.Point(16, 15);
            this.lblReportCondo.Margin = new System.Windows.Forms.Padding(4);
            this.lblReportCondo.Name = "lblReportCondo";
            this.lblReportCondo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblReportCondo.Size = new System.Drawing.Size(236, 41);
            this.lblReportCondo.TabIndex = 0;
            this.lblReportCondo.Text = "Report of Condos";
            this.lblReportCondo.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblReportCondo.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ReportCondoForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 697);
            this.Controls.Add(this.pnlRRReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = global::HouseRentManagement.Properties.Resources.appLogo16x16;
            this.Name = "ReportCondoForm";
            this.Text = "ReportCondoForm";
            this.Load += new System.EventHandler(this.ReportCondoForm_Load);
            this.pnlRRReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB)).EndInit();
            this.pnlReportCondo.ResumeLayout(false);
            this.pnlReportCondo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDB;
        private Bunifu.UI.WinForms.BunifuPanel pnlRRReport;
        private Bunifu.UI.WinForms.BunifuPanel pnlReportCondo;
        private Bunifu.UI.WinForms.BunifuLabel lblReportCondo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCanHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNguoiThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clChuSoHuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLoai;
    }
}