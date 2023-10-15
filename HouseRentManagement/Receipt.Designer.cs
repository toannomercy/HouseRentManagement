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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.pnlReceipt = new Bunifu.UI.WinForms.BunifuPanel();
            this.dgvReceipt = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clhName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbReceipt = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtBoxSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lblCondoReceipt = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlCondoReceipt = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblPaymentID = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlReceipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).BeginInit();
            this.pnlCondoReceipt.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlReceipt
            // 
            this.pnlReceipt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.pnlReceipt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlReceipt.BackgroundImage")));
            this.pnlReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlReceipt.BorderColor = System.Drawing.Color.Transparent;
            this.pnlReceipt.BorderRadius = 3;
            this.pnlReceipt.BorderThickness = 1;
            this.pnlReceipt.Controls.Add(this.lblPaymentID);
            this.pnlReceipt.Controls.Add(this.pnlCondoReceipt);
            this.pnlReceipt.Controls.Add(this.dgvReceipt);
            this.pnlReceipt.Controls.Add(this.cbbReceipt);
            this.pnlReceipt.Controls.Add(this.txtBoxSearch);
            this.pnlReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReceipt.Location = new System.Drawing.Point(0, 0);
            this.pnlReceipt.Name = "pnlReceipt";
            this.pnlReceipt.ShowBorders = true;
            this.pnlReceipt.Size = new System.Drawing.Size(958, 655);
            this.pnlReceipt.TabIndex = 32;
            // 
            // dgvReceipt
            // 
            this.dgvReceipt.AllowUserToAddRows = false;
            this.dgvReceipt.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvReceipt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvReceipt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.dgvReceipt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReceipt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(125)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReceipt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReceipt.ColumnHeadersHeight = 42;
            this.dgvReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clhName,
            this.clhBegin,
            this.clhEnd,
            this.clhQuantity,
            this.clhMoney});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReceipt.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReceipt.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReceipt.Location = new System.Drawing.Point(15, 193);
            this.dgvReceipt.Name = "dgvReceipt";
            this.dgvReceipt.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceipt.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReceipt.RowHeadersVisible = false;
            this.dgvReceipt.RowHeadersWidth = 51;
            this.dgvReceipt.RowTemplate.Height = 24;
            this.dgvReceipt.Size = new System.Drawing.Size(931, 450);
            this.dgvReceipt.TabIndex = 35;
            this.dgvReceipt.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReceipt.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvReceipt.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvReceipt.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvReceipt.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvReceipt.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.dgvReceipt.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReceipt.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(125)))), ((int)(((byte)(122)))));
            this.dgvReceipt.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvReceipt.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReceipt.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReceipt.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvReceipt.ThemeStyle.HeaderStyle.Height = 42;
            this.dgvReceipt.ThemeStyle.ReadOnly = true;
            this.dgvReceipt.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReceipt.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReceipt.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.dgvReceipt.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.dgvReceipt.ThemeStyle.RowsStyle.Height = 24;
            this.dgvReceipt.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReceipt.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // clhName
            // 
            this.clhName.HeaderText = "Name Service";
            this.clhName.MinimumWidth = 6;
            this.clhName.Name = "clhName";
            this.clhName.ReadOnly = true;
            // 
            // clhBegin
            // 
            this.clhBegin.HeaderText = "Begin";
            this.clhBegin.MinimumWidth = 6;
            this.clhBegin.Name = "clhBegin";
            this.clhBegin.ReadOnly = true;
            // 
            // clhEnd
            // 
            this.clhEnd.HeaderText = "End";
            this.clhEnd.MinimumWidth = 6;
            this.clhEnd.Name = "clhEnd";
            this.clhEnd.ReadOnly = true;
            // 
            // clhQuantity
            // 
            this.clhQuantity.HeaderText = "Quantity";
            this.clhQuantity.MinimumWidth = 6;
            this.clhQuantity.Name = "clhQuantity";
            this.clhQuantity.ReadOnly = true;
            // 
            // clhMoney
            // 
            this.clhMoney.HeaderText = "Money Spent";
            this.clhMoney.MinimumWidth = 6;
            this.clhMoney.Name = "clhMoney";
            this.clhMoney.ReadOnly = true;
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
            this.cbbReceipt.Location = new System.Drawing.Point(15, 151);
            this.cbbReceipt.Name = "cbbReceipt";
            this.cbbReceipt.Size = new System.Drawing.Size(187, 36);
            this.cbbReceipt.TabIndex = 33;
            this.cbbReceipt.SelectedIndexChanged += new System.EventHandler(this.cbbReceipt_SelectedIndexChanged);
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
            this.txtBoxSearch.DefaultFont = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.DefaultText = "";
            this.txtBoxSearch.FillColor = System.Drawing.Color.White;
            this.txtBoxSearch.HideSelection = true;
            this.txtBoxSearch.IconLeft = global::HouseRentManagement.Properties.Resources.btnSearch;
            this.txtBoxSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxSearch.IconPadding = 10;
            this.txtBoxSearch.IconRight = null;
            this.txtBoxSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxSearch.Lines = new string[0];
            this.txtBoxSearch.Location = new System.Drawing.Point(668, 12);
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
            this.txtBoxSearch.PlaceholderText = "Search Receipt";
            this.txtBoxSearch.ReadOnly = false;
            this.txtBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxSearch.SelectedText = "";
            this.txtBoxSearch.SelectionLength = 0;
            this.txtBoxSearch.SelectionStart = 0;
            this.txtBoxSearch.ShortcutsEnabled = true;
            this.txtBoxSearch.Size = new System.Drawing.Size(260, 43);
            this.txtBoxSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtBoxSearch.TabIndex = 30;
            this.txtBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxSearch.TextMarginBottom = 0;
            this.txtBoxSearch.TextMarginLeft = 3;
            this.txtBoxSearch.TextMarginTop = 0;
            this.txtBoxSearch.TextPlaceholder = "Search Receipt";
            this.txtBoxSearch.UseSystemPasswordChar = false;
            this.txtBoxSearch.WordWrap = true;
            this.txtBoxSearch.TextChange += new System.EventHandler(this.txtBoxSearch_TextChange);
            // 
            // lblCondoReceipt
            // 
            this.lblCondoReceipt.AllowParentOverrides = false;
            this.lblCondoReceipt.AutoEllipsis = false;
            this.lblCondoReceipt.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCondoReceipt.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblCondoReceipt.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondoReceipt.ForeColor = System.Drawing.Color.White;
            this.lblCondoReceipt.Location = new System.Drawing.Point(26, 25);
            this.lblCondoReceipt.Name = "lblCondoReceipt";
            this.lblCondoReceipt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCondoReceipt.Size = new System.Drawing.Size(175, 37);
            this.lblCondoReceipt.TabIndex = 0;
            this.lblCondoReceipt.Text = "Condo Receipt";
            this.lblCondoReceipt.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCondoReceipt.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pnlCondoReceipt
            // 
            this.pnlCondoReceipt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.pnlCondoReceipt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCondoReceipt.BackgroundImage")));
            this.pnlCondoReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCondoReceipt.BorderColor = System.Drawing.Color.Transparent;
            this.pnlCondoReceipt.BorderRadius = 3;
            this.pnlCondoReceipt.BorderThickness = 1;
            this.pnlCondoReceipt.Controls.Add(this.lblCondoReceipt);
            this.pnlCondoReceipt.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCondoReceipt.ForeColor = System.Drawing.Color.White;
            this.pnlCondoReceipt.Location = new System.Drawing.Point(15, 12);
            this.pnlCondoReceipt.Name = "pnlCondoReceipt";
            this.pnlCondoReceipt.ShowBorders = true;
            this.pnlCondoReceipt.Size = new System.Drawing.Size(231, 90);
            this.pnlCondoReceipt.TabIndex = 36;
            // 
            // lblPaymentID
            // 
            this.lblPaymentID.AllowParentOverrides = false;
            this.lblPaymentID.AutoEllipsis = false;
            this.lblPaymentID.CursorType = null;
            this.lblPaymentID.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentID.ForeColor = System.Drawing.Color.Black;
            this.lblPaymentID.Location = new System.Drawing.Point(15, 114);
            this.lblPaymentID.Name = "lblPaymentID";
            this.lblPaymentID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPaymentID.Size = new System.Drawing.Size(111, 31);
            this.lblPaymentID.TabIndex = 37;
            this.lblPaymentID.Text = "PaymentID";
            this.lblPaymentID.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblPaymentID.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.pnlReceipt.ResumeLayout(false);
            this.pnlReceipt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).EndInit();
            this.pnlCondoReceipt.ResumeLayout(false);
            this.pnlCondoReceipt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuTextBox txtBoxSearch;
        private Bunifu.UI.WinForms.BunifuPanel pnlReceipt;
        private Guna.UI2.WinForms.Guna2ComboBox cbbReceipt;
        private Guna.UI2.WinForms.Guna2DataGridView dgvReceipt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhMoney;
        private Bunifu.UI.WinForms.BunifuPanel pnlCondoReceipt;
        private Bunifu.UI.WinForms.BunifuLabel lblCondoReceipt;
        private Bunifu.UI.WinForms.BunifuLabel lblPaymentID;
    }
}