namespace HouseRentManagement
{
    partial class Receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtBoxSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pnlReceipt = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblCondoReceipt = new Bunifu.UI.WinForms.BunifuLabel();
            this.cbbReceipt = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvPayment = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clhMaCanHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhTongTienThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlReceipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.ActiveBorderThickness = 1;
            this.btnSearch.ActiveCornerRadius = 20;
            this.btnSearch.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(223)))), ((int)(((byte)(22)))));
            this.btnSearch.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.btnSearch.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(223)))), ((int)(((byte)(22)))));
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.ButtonText = "Search";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.btnSearch.IdleBorderThickness = 1;
            this.btnSearch.IdleCornerRadius = 20;
            this.btnSearch.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(147)))), ((int)(((byte)(15)))));
            this.btnSearch.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.btnSearch.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(147)))), ((int)(((byte)(15)))));
            this.btnSearch.Location = new System.Drawing.Point(610, 12);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 40);
            this.btnSearch.TabIndex = 31;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.AcceptsReturn = false;
            this.txtBoxSearch.AcceptsTab = false;
            this.txtBoxSearch.AnimationSpeed = 200;
            this.txtBoxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBoxSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBoxSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBoxSearch.BackgroundImage")));
            this.txtBoxSearch.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtBoxSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtBoxSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtBoxSearch.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtBoxSearch.BorderRadius = 1;
            this.txtBoxSearch.BorderThickness = 1;
            this.txtBoxSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxSearch.DefaultFont = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.DefaultText = "";
            this.txtBoxSearch.FillColor = System.Drawing.Color.White;
            this.txtBoxSearch.HideSelection = true;
            this.txtBoxSearch.IconLeft = global::HouseRentManagement.Properties.Resources.btnSearch;
            this.txtBoxSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxSearch.IconPadding = 10;
            this.txtBoxSearch.IconRight = null;
            this.txtBoxSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxSearch.Lines = new string[0];
            this.txtBoxSearch.Location = new System.Drawing.Point(686, 12);
            this.txtBoxSearch.MaxLength = 32767;
            this.txtBoxSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtBoxSearch.Modified = false;
            this.txtBoxSearch.Multiline = false;
            this.txtBoxSearch.Name = "txtBoxSearch";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBoxSearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBoxSearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBoxSearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBoxSearch.OnIdleState = stateProperties4;
            this.txtBoxSearch.Padding = new System.Windows.Forms.Padding(3);
            this.txtBoxSearch.PasswordChar = '\0';
            this.txtBoxSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtBoxSearch.PlaceholderText = "Search form";
            this.txtBoxSearch.ReadOnly = false;
            this.txtBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxSearch.SelectedText = "";
            this.txtBoxSearch.SelectionLength = 0;
            this.txtBoxSearch.SelectionStart = 0;
            this.txtBoxSearch.ShortcutsEnabled = true;
            this.txtBoxSearch.Size = new System.Drawing.Size(260, 40);
            this.txtBoxSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtBoxSearch.TabIndex = 30;
            this.txtBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxSearch.TextMarginBottom = 0;
            this.txtBoxSearch.TextMarginLeft = 3;
            this.txtBoxSearch.TextMarginTop = 0;
            this.txtBoxSearch.TextPlaceholder = "Search form";
            this.txtBoxSearch.UseSystemPasswordChar = false;
            this.txtBoxSearch.WordWrap = true;
            // 
            // pnlReceipt
            // 
            this.pnlReceipt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.pnlReceipt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlReceipt.BackgroundImage")));
            this.pnlReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlReceipt.BorderColor = System.Drawing.Color.Transparent;
            this.pnlReceipt.BorderRadius = 3;
            this.pnlReceipt.BorderThickness = 1;
            this.pnlReceipt.Controls.Add(this.dgvPayment);
            this.pnlReceipt.Controls.Add(this.lblCondoReceipt);
            this.pnlReceipt.Controls.Add(this.cbbReceipt);
            this.pnlReceipt.Controls.Add(this.btnSearch);
            this.pnlReceipt.Controls.Add(this.txtBoxSearch);
            this.pnlReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReceipt.Location = new System.Drawing.Point(0, 0);
            this.pnlReceipt.Name = "pnlReceipt";
            this.pnlReceipt.ShowBorders = true;
            this.pnlReceipt.Size = new System.Drawing.Size(958, 655);
            this.pnlReceipt.TabIndex = 32;
            // 
            // lblCondoReceipt
            // 
            this.lblCondoReceipt.AllowParentOverrides = false;
            this.lblCondoReceipt.AutoEllipsis = false;
            this.lblCondoReceipt.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCondoReceipt.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblCondoReceipt.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondoReceipt.Location = new System.Drawing.Point(12, 117);
            this.lblCondoReceipt.Name = "lblCondoReceipt";
            this.lblCondoReceipt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCondoReceipt.Size = new System.Drawing.Size(129, 28);
            this.lblCondoReceipt.TabIndex = 34;
            this.lblCondoReceipt.Text = "Condo Receipt";
            this.lblCondoReceipt.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblCondoReceipt.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // cbbReceipt
            // 
            this.cbbReceipt.BackColor = System.Drawing.Color.Transparent;
            this.cbbReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbReceipt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbReceipt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbReceipt.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbReceipt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbReceipt.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbReceipt.ForeColor = System.Drawing.Color.Black;
            this.cbbReceipt.ItemHeight = 30;
            this.cbbReceipt.Location = new System.Drawing.Point(12, 151);
            this.cbbReceipt.Name = "cbbReceipt";
            this.cbbReceipt.Size = new System.Drawing.Size(200, 36);
            this.cbbReceipt.TabIndex = 33;
            // 
            // dgvPayment
            // 
            this.dgvPayment.AllowUserToAddRows = false;
            this.dgvPayment.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPayment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPayment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.dgvPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPayment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(125)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayment.ColumnHeadersHeight = 42;
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clhMaCanHo,
            this.clhNgayLap,
            this.clhTongTienThanhToan,
            this.clhTrangThai});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayment.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPayment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPayment.Location = new System.Drawing.Point(15, 193);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayment.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPayment.RowHeadersVisible = false;
            this.dgvPayment.RowHeadersWidth = 51;
            this.dgvPayment.RowTemplate.Height = 24;
            this.dgvPayment.Size = new System.Drawing.Size(931, 450);
            this.dgvPayment.TabIndex = 35;
            this.dgvPayment.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPayment.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPayment.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPayment.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPayment.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPayment.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.dgvPayment.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPayment.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(125)))), ((int)(((byte)(122)))));
            this.dgvPayment.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvPayment.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPayment.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPayment.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPayment.ThemeStyle.HeaderStyle.Height = 42;
            this.dgvPayment.ThemeStyle.ReadOnly = true;
            this.dgvPayment.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPayment.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPayment.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.dgvPayment.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.dgvPayment.ThemeStyle.RowsStyle.Height = 24;
            this.dgvPayment.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPayment.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // clhMaCanHo
            // 
            this.clhMaCanHo.HeaderText = "CondoID";
            this.clhMaCanHo.MinimumWidth = 6;
            this.clhMaCanHo.Name = "clhMaCanHo";
            this.clhMaCanHo.ReadOnly = true;
            // 
            // clhNgayLap
            // 
            this.clhNgayLap.HeaderText = "Date";
            this.clhNgayLap.MinimumWidth = 6;
            this.clhNgayLap.Name = "clhNgayLap";
            this.clhNgayLap.ReadOnly = true;
            // 
            // clhTongTienThanhToan
            // 
            this.clhTongTienThanhToan.HeaderText = "Money Spent";
            this.clhTongTienThanhToan.MinimumWidth = 6;
            this.clhTongTienThanhToan.Name = "clhTongTienThanhToan";
            this.clhTongTienThanhToan.ReadOnly = true;
            // 
            // clhTrangThai
            // 
            this.clhTrangThai.HeaderText = "Status";
            this.clhTrangThai.MinimumWidth = 6;
            this.clhTrangThai.Name = "clhTrangThai";
            this.clhTrangThai.ReadOnly = true;
            // 
            // Receipt
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 655);
            this.Controls.Add(this.pnlReceipt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = global::HouseRentManagement.Properties.Resources.appLogo;
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.pnlReceipt.ResumeLayout(false);
            this.pnlReceipt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 btnSearch;
        private Bunifu.UI.WinForms.BunifuTextBox txtBoxSearch;
        private Bunifu.UI.WinForms.BunifuPanel pnlReceipt;
        private Bunifu.UI.WinForms.BunifuLabel lblCondoReceipt;
        private Guna.UI2.WinForms.Guna2ComboBox cbbReceipt;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhMaCanHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhTongTienThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhTrangThai;
    }
}