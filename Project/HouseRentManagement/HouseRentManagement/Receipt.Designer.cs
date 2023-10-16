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
            this.pnlReceipt = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblCondoReceipt = new Bunifu.UI.WinForms.BunifuLabel();
            this.cbbReceipt = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtBoxSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.dgvReceipt = new System.Windows.Forms.DataGridView();
            this.clhName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlReceipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).BeginInit();
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
            this.pnlReceipt.Controls.Add(this.dgvReceipt);
            this.pnlReceipt.Controls.Add(this.lblCondoReceipt);
            this.pnlReceipt.Controls.Add(this.cbbReceipt);
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
            this.txtBoxSearch.TextChange += new System.EventHandler(this.txtBoxSearch_TextChange);
            // 
            // dgvReceipt
            // 
            this.dgvReceipt.AllowUserToAddRows = false;
            this.dgvReceipt.AllowUserToDeleteRows = false;
            this.dgvReceipt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceipt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceipt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clhName,
            this.clhBegin,
            this.clhEnd,
            this.clhQuantity,
            this.clhMoney});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReceipt.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReceipt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvReceipt.Location = new System.Drawing.Point(0, 193);
            this.dgvReceipt.Name = "dgvReceipt";
            this.dgvReceipt.ReadOnly = true;
            this.dgvReceipt.RowHeadersWidth = 51;
            this.dgvReceipt.RowTemplate.Height = 24;
            this.dgvReceipt.Size = new System.Drawing.Size(958, 462);
            this.dgvReceipt.TabIndex = 35;
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
            this.clhBegin.HeaderText = "Begin Date";
            this.clhBegin.MinimumWidth = 6;
            this.clhBegin.Name = "clhBegin";
            this.clhBegin.ReadOnly = true;
            // 
            // clhEnd
            // 
            this.clhEnd.HeaderText = "End Date";
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
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuTextBox txtBoxSearch;
        private Bunifu.UI.WinForms.BunifuPanel pnlReceipt;
        private Bunifu.UI.WinForms.BunifuLabel lblCondoReceipt;
        private Guna.UI2.WinForms.Guna2ComboBox cbbReceipt;
        private System.Windows.Forms.DataGridView dgvReceipt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhMoney;
    }
}