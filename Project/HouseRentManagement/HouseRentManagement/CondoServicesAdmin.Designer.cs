namespace HouseRentManagement
{
    partial class CondoServicesAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CondoServicesAdmin));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.cbbFromStatus = new System.Windows.Forms.ComboBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtConUnit = new System.Windows.Forms.TextBox();
            this.txtMoneySpend = new System.Windows.Forms.TextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.cbbCondoID = new System.Windows.Forms.ComboBox();
            this.lblConUnit = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFromStatus = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblCondoID = new System.Windows.Forms.Label();
            this.gbCondoService = new System.Windows.Forms.GroupBox();
            this.txtBoxSearchAdmin = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnAC = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddAdmin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDe = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cbbPhieu = new System.Windows.Forms.ComboBox();
            this.dgvCondoServicesAdmin = new System.Windows.Forms.DataGridView();
            this.clhMaCanHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhBDChuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhKTChuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhFine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhMoneySpend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCondoService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondoServicesAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFine
            // 
            this.txtFine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFine.Location = new System.Drawing.Point(131, 99);
            this.txtFine.Name = "txtFine";
            this.txtFine.Size = new System.Drawing.Size(182, 34);
            this.txtFine.TabIndex = 40;
            this.txtFine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFine_KeyPress);
            // 
            // cbbFromStatus
            // 
            this.cbbFromStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFromStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFromStatus.FormattingEnabled = true;
            this.cbbFromStatus.Location = new System.Drawing.Point(484, 104);
            this.cbbFromStatus.Name = "cbbFromStatus";
            this.cbbFromStatus.Size = new System.Drawing.Size(174, 36);
            this.cbbFromStatus.TabIndex = 38;
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(664, 62);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(260, 78);
            this.txtContent.TabIndex = 40;
            // 
            // txtConUnit
            // 
            this.txtConUnit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConUnit.Location = new System.Drawing.Point(131, 59);
            this.txtConUnit.Name = "txtConUnit";
            this.txtConUnit.Size = new System.Drawing.Size(182, 34);
            this.txtConUnit.TabIndex = 40;
            // 
            // txtMoneySpend
            // 
            this.txtMoneySpend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoneySpend.Location = new System.Drawing.Point(484, 146);
            this.txtMoneySpend.Name = "txtMoneySpend";
            this.txtMoneySpend.Size = new System.Drawing.Size(174, 34);
            this.txtMoneySpend.TabIndex = 40;
            this.txtMoneySpend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFine_KeyPress);
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.Location = new System.Drawing.Point(659, 31);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(82, 28);
            this.lblContent.TabIndex = 36;
            this.lblContent.Text = "Content";
            // 
            // cbbCondoID
            // 
            this.cbbCondoID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCondoID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCondoID.FormattingEnabled = true;
            this.cbbCondoID.Location = new System.Drawing.Point(484, 62);
            this.cbbCondoID.Name = "cbbCondoID";
            this.cbbCondoID.Size = new System.Drawing.Size(174, 36);
            this.cbbCondoID.TabIndex = 38;
            this.cbbCondoID.SelectedIndexChanged += new System.EventHandler(this.cbbCondoID_SelectedIndexChanged);
            // 
            // lblConUnit
            // 
            this.lblConUnit.AutoSize = true;
            this.lblConUnit.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConUnit.Location = new System.Drawing.Point(3, 59);
            this.lblConUnit.Name = "lblConUnit";
            this.lblConUnit.Size = new System.Drawing.Size(113, 28);
            this.lblConUnit.TabIndex = 36;
            this.lblConUnit.Text = "Condo Unit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 28);
            this.label7.TabIndex = 36;
            this.label7.Text = "Fine";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(335, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 28);
            this.label6.TabIndex = 36;
            this.label6.Text = "Monney Spend";
            // 
            // lblFromStatus
            // 
            this.lblFromStatus.AutoSize = true;
            this.lblFromStatus.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromStatus.Location = new System.Drawing.Point(335, 101);
            this.lblFromStatus.Name = "lblFromStatus";
            this.lblFromStatus.Size = new System.Drawing.Size(116, 28);
            this.lblFromStatus.TabIndex = 44;
            this.lblFromStatus.Text = "From Status";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(3, 23);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(114, 28);
            this.lblDate.TabIndex = 45;
            this.lblDate.Text = "Create Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(131, 19);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(182, 34);
            this.dtpDate.TabIndex = 39;
            this.dtpDate.Value = new System.DateTime(2023, 10, 16, 0, 0, 0, 0);
            // 
            // lblCondoID
            // 
            this.lblCondoID.AutoSize = true;
            this.lblCondoID.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondoID.Location = new System.Drawing.Point(335, 62);
            this.lblCondoID.Name = "lblCondoID";
            this.lblCondoID.Size = new System.Drawing.Size(90, 28);
            this.lblCondoID.TabIndex = 46;
            this.lblCondoID.Text = "CondoID";
            // 
            // gbCondoService
            // 
            this.gbCondoService.Controls.Add(this.txtBoxSearchAdmin);
            this.gbCondoService.Controls.Add(this.btnAC);
            this.gbCondoService.Controls.Add(this.lblFromStatus);
            this.gbCondoService.Controls.Add(this.lblDate);
            this.gbCondoService.Controls.Add(this.btnAddAdmin);
            this.gbCondoService.Controls.Add(this.label1);
            this.gbCondoService.Controls.Add(this.lblCondoID);
            this.gbCondoService.Controls.Add(this.txtFine);
            this.gbCondoService.Controls.Add(this.btnDe);
            this.gbCondoService.Controls.Add(this.dtpDate);
            this.gbCondoService.Controls.Add(this.cbbFromStatus);
            this.gbCondoService.Controls.Add(this.txtContent);
            this.gbCondoService.Controls.Add(this.txtConUnit);
            this.gbCondoService.Controls.Add(this.txtMoneySpend);
            this.gbCondoService.Controls.Add(this.lblContent);
            this.gbCondoService.Controls.Add(this.cbbPhieu);
            this.gbCondoService.Controls.Add(this.cbbCondoID);
            this.gbCondoService.Controls.Add(this.lblConUnit);
            this.gbCondoService.Controls.Add(this.label7);
            this.gbCondoService.Controls.Add(this.label6);
            this.gbCondoService.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCondoService.Location = new System.Drawing.Point(15, 12);
            this.gbCondoService.Name = "gbCondoService";
            this.gbCondoService.Size = new System.Drawing.Size(931, 225);
            this.gbCondoService.TabIndex = 47;
            this.gbCondoService.TabStop = false;
            this.gbCondoService.Text = "CondoService";
            // 
            // txtBoxSearchAdmin
            // 
            this.txtBoxSearchAdmin.AcceptsReturn = false;
            this.txtBoxSearchAdmin.AcceptsTab = false;
            this.txtBoxSearchAdmin.AnimationSpeed = 200;
            this.txtBoxSearchAdmin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBoxSearchAdmin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBoxSearchAdmin.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxSearchAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBoxSearchAdmin.BackgroundImage")));
            this.txtBoxSearchAdmin.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtBoxSearchAdmin.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtBoxSearchAdmin.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtBoxSearchAdmin.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtBoxSearchAdmin.BorderRadius = 1;
            this.txtBoxSearchAdmin.BorderThickness = 1;
            this.txtBoxSearchAdmin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBoxSearchAdmin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxSearchAdmin.DefaultFont = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearchAdmin.DefaultText = "";
            this.txtBoxSearchAdmin.FillColor = System.Drawing.Color.White;
            this.txtBoxSearchAdmin.HideSelection = true;
            this.txtBoxSearchAdmin.IconLeft = global::HouseRentManagement.Properties.Resources.btnSearch;
            this.txtBoxSearchAdmin.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxSearchAdmin.IconPadding = 10;
            this.txtBoxSearchAdmin.IconRight = null;
            this.txtBoxSearchAdmin.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxSearchAdmin.Lines = new string[0];
            this.txtBoxSearchAdmin.Location = new System.Drawing.Point(664, 172);
            this.txtBoxSearchAdmin.MaxLength = 32767;
            this.txtBoxSearchAdmin.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtBoxSearchAdmin.Modified = false;
            this.txtBoxSearchAdmin.Multiline = false;
            this.txtBoxSearchAdmin.Name = "txtBoxSearchAdmin";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBoxSearchAdmin.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBoxSearchAdmin.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBoxSearchAdmin.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBoxSearchAdmin.OnIdleState = stateProperties12;
            this.txtBoxSearchAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.txtBoxSearchAdmin.PasswordChar = '\0';
            this.txtBoxSearchAdmin.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtBoxSearchAdmin.PlaceholderText = "Search";
            this.txtBoxSearchAdmin.ReadOnly = false;
            this.txtBoxSearchAdmin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxSearchAdmin.SelectedText = "";
            this.txtBoxSearchAdmin.SelectionLength = 0;
            this.txtBoxSearchAdmin.SelectionStart = 0;
            this.txtBoxSearchAdmin.ShortcutsEnabled = true;
            this.txtBoxSearchAdmin.Size = new System.Drawing.Size(260, 40);
            this.txtBoxSearchAdmin.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtBoxSearchAdmin.TabIndex = 47;
            this.txtBoxSearchAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxSearchAdmin.TextMarginBottom = 0;
            this.txtBoxSearchAdmin.TextMarginLeft = 3;
            this.txtBoxSearchAdmin.TextMarginTop = 0;
            this.txtBoxSearchAdmin.TextPlaceholder = "Search";
            this.txtBoxSearchAdmin.UseSystemPasswordChar = false;
            this.txtBoxSearchAdmin.WordWrap = true;
            // 
            // btnAC
            // 
            this.btnAC.ActiveBorderThickness = 1;
            this.btnAC.ActiveCornerRadius = 20;
            this.btnAC.ActiveFillColor = System.Drawing.Color.Cyan;
            this.btnAC.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.btnAC.ActiveLineColor = System.Drawing.Color.Cyan;
            this.btnAC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.btnAC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAC.BackgroundImage")));
            this.btnAC.ButtonText = "Update";
            this.btnAC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAC.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.btnAC.IdleBorderThickness = 1;
            this.btnAC.IdleCornerRadius = 20;
            this.btnAC.IdleFillColor = System.Drawing.Color.Teal;
            this.btnAC.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.btnAC.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(125)))), ((int)(((byte)(122)))));
            this.btnAC.Location = new System.Drawing.Point(144, 179);
            this.btnAC.Margin = new System.Windows.Forms.Padding(4);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(70, 40);
            this.btnAC.TabIndex = 34;
            this.btnAC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.ActiveBorderThickness = 1;
            this.btnAddAdmin.ActiveCornerRadius = 20;
            this.btnAddAdmin.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(223)))), ((int)(((byte)(22)))));
            this.btnAddAdmin.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.btnAddAdmin.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(223)))), ((int)(((byte)(22)))));
            this.btnAddAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.btnAddAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddAdmin.BackgroundImage")));
            this.btnAddAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAdmin.ButtonText = "Add";
            this.btnAddAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAdmin.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.btnAddAdmin.IdleBorderThickness = 1;
            this.btnAddAdmin.IdleCornerRadius = 20;
            this.btnAddAdmin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(147)))), ((int)(((byte)(15)))));
            this.btnAddAdmin.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.btnAddAdmin.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(147)))), ((int)(((byte)(15)))));
            this.btnAddAdmin.Location = new System.Drawing.Point(67, 179);
            this.btnAddAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(70, 40);
            this.btnAddAdmin.TabIndex = 32;
            this.btnAddAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 28);
            this.label1.TabIndex = 46;
            this.label1.Text = "Services";
            // 
            // btnDe
            // 
            this.btnDe.ActiveBorderThickness = 1;
            this.btnDe.ActiveCornerRadius = 20;
            this.btnDe.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(196)))));
            this.btnDe.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.btnDe.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(196)))));
            this.btnDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.btnDe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDe.BackgroundImage")));
            this.btnDe.ButtonText = "Delete";
            this.btnDe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDe.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.btnDe.IdleBorderThickness = 1;
            this.btnDe.IdleCornerRadius = 20;
            this.btnDe.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDe.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.btnDe.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(125)))), ((int)(((byte)(122)))));
            this.btnDe.Location = new System.Drawing.Point(222, 179);
            this.btnDe.Margin = new System.Windows.Forms.Padding(4);
            this.btnDe.Name = "btnDe";
            this.btnDe.Size = new System.Drawing.Size(70, 40);
            this.btnDe.TabIndex = 35;
            this.btnDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbPhieu
            // 
            this.cbbPhieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPhieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPhieu.FormattingEnabled = true;
            this.cbbPhieu.Location = new System.Drawing.Point(131, 139);
            this.cbbPhieu.Name = "cbbPhieu";
            this.cbbPhieu.Size = new System.Drawing.Size(182, 36);
            this.cbbPhieu.TabIndex = 38;
            this.cbbPhieu.SelectedIndexChanged += new System.EventHandler(this.cbbCondoID_SelectedIndexChanged);
            // 
            // dgvCondoServicesAdmin
            // 
            this.dgvCondoServicesAdmin.AllowUserToAddRows = false;
            this.dgvCondoServicesAdmin.AllowUserToDeleteRows = false;
            this.dgvCondoServicesAdmin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.dgvCondoServicesAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCondoServicesAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clhMaCanHo,
            this.clhServiceName,
            this.clhNgayLap,
            this.clhContent,
            this.clhBDChuyen,
            this.clhKTChuyen,
            this.clhFine,
            this.clhMoneySpend,
            this.clhTrangThai});
            this.dgvCondoServicesAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCondoServicesAdmin.Location = new System.Drawing.Point(0, 238);
            this.dgvCondoServicesAdmin.Name = "dgvCondoServicesAdmin";
            this.dgvCondoServicesAdmin.ReadOnly = true;
            this.dgvCondoServicesAdmin.RowHeadersWidth = 51;
            this.dgvCondoServicesAdmin.RowTemplate.Height = 24;
            this.dgvCondoServicesAdmin.Size = new System.Drawing.Size(958, 333);
            this.dgvCondoServicesAdmin.TabIndex = 48;
            this.dgvCondoServicesAdmin.SelectionChanged += new System.EventHandler(this.dgvCondoServicesAdmin_SelectionChanged);
            // 
            // clhMaCanHo
            // 
            this.clhMaCanHo.HeaderText = "Condo ID";
            this.clhMaCanHo.MinimumWidth = 6;
            this.clhMaCanHo.Name = "clhMaCanHo";
            this.clhMaCanHo.ReadOnly = true;
            this.clhMaCanHo.Width = 125;
            // 
            // clhServiceName
            // 
            this.clhServiceName.HeaderText = "Service Name";
            this.clhServiceName.MinimumWidth = 6;
            this.clhServiceName.Name = "clhServiceName";
            this.clhServiceName.ReadOnly = true;
            this.clhServiceName.Width = 125;
            // 
            // clhNgayLap
            // 
            this.clhNgayLap.HeaderText = "Create Date";
            this.clhNgayLap.MinimumWidth = 6;
            this.clhNgayLap.Name = "clhNgayLap";
            this.clhNgayLap.ReadOnly = true;
            this.clhNgayLap.Width = 125;
            // 
            // clhContent
            // 
            this.clhContent.HeaderText = "Content";
            this.clhContent.MinimumWidth = 6;
            this.clhContent.Name = "clhContent";
            this.clhContent.ReadOnly = true;
            this.clhContent.Width = 125;
            // 
            // clhBDChuyen
            // 
            this.clhBDChuyen.HeaderText = "Start Date";
            this.clhBDChuyen.MinimumWidth = 6;
            this.clhBDChuyen.Name = "clhBDChuyen";
            this.clhBDChuyen.ReadOnly = true;
            this.clhBDChuyen.Width = 125;
            // 
            // clhKTChuyen
            // 
            this.clhKTChuyen.HeaderText = "End Date";
            this.clhKTChuyen.MinimumWidth = 6;
            this.clhKTChuyen.Name = "clhKTChuyen";
            this.clhKTChuyen.ReadOnly = true;
            this.clhKTChuyen.Width = 125;
            // 
            // clhFine
            // 
            this.clhFine.HeaderText = "Fine";
            this.clhFine.MinimumWidth = 6;
            this.clhFine.Name = "clhFine";
            this.clhFine.ReadOnly = true;
            this.clhFine.Width = 125;
            // 
            // clhMoneySpend
            // 
            this.clhMoneySpend.HeaderText = "Money Spend";
            this.clhMoneySpend.MinimumWidth = 6;
            this.clhMoneySpend.Name = "clhMoneySpend";
            this.clhMoneySpend.ReadOnly = true;
            this.clhMoneySpend.Width = 125;
            // 
            // clhTrangThai
            // 
            this.clhTrangThai.HeaderText = "Form Status";
            this.clhTrangThai.MinimumWidth = 6;
            this.clhTrangThai.Name = "clhTrangThai";
            this.clhTrangThai.ReadOnly = true;
            this.clhTrangThai.Width = 125;
            // 
            // CondoServicesAdmin
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 571);
            this.Controls.Add(this.dgvCondoServicesAdmin);
            this.Controls.Add(this.gbCondoService);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = global::HouseRentManagement.Properties.Resources.appLogo16x16;
            this.Name = "CondoServicesAdmin";
            this.Text = "CondoServicesAdmin";
            this.gbCondoService.ResumeLayout(false);
            this.gbCondoService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondoServicesAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.ComboBox cbbFromStatus;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtConUnit;
        private System.Windows.Forms.TextBox txtMoneySpend;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.ComboBox cbbCondoID;
        private System.Windows.Forms.Label lblConUnit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFromStatus;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblCondoID;
        private System.Windows.Forms.GroupBox gbCondoService;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAC;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddAdmin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDe;
        private System.Windows.Forms.DataGridView dgvCondoServicesAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhMaCanHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhBDChuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhKTChuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhFine;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhMoneySpend;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhTrangThai;
        private Bunifu.UI.WinForms.BunifuTextBox txtBoxSearchAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbPhieu;
    }
}