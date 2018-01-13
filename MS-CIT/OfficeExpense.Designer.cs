namespace MS_CIT
{
    partial class OfficeExpense
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.dateExpense = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtPayDesc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtPaymentMethod = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtReceivedBy = new MetroFramework.Controls.MetroTextBox();
            this.txtPaidBy = new MetroFramework.Controls.MetroTextBox();
            this.txtExpeDesc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.lblTotalExpense = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtExpType = new MetroFramework.Controls.MetroTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToOrderColumns = true;
            this.metroGrid1.AllowUserToResizeColumns = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.metroGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.HighLightPercentage = 0.5F;
            this.metroGrid1.Location = new System.Drawing.Point(20, 60);
            this.metroGrid1.MultiSelect = false;
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(620, 279);
            this.metroGrid1.TabIndex = 123;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroGrid1.UseCustomBackColor = true;
            this.metroGrid1.UseCustomForeColor = true;
            this.metroGrid1.UseStyleColors = true;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Teal;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(101, 518);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Green;
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDelete.UseCustomBackColor = true;
            this.btnDelete.UseCustomForeColor = true;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Teal;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(189, 518);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.Style = MetroFramework.MetroColorStyle.Green;
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnClear.UseCustomBackColor = true;
            this.btnClear.UseCustomForeColor = true;
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Teal;
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(13, 518);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 30);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton1.TabIndex = 9;
            this.metroButton1.Text = "Edit Expense";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(569, 518);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Submit";
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateExpense
            // 
            this.dateExpense.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateExpense.Location = new System.Drawing.Point(460, 390);
            this.dateExpense.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateExpense.Name = "dateExpense";
            this.dateExpense.Size = new System.Drawing.Size(181, 29);
            this.dateExpense.Style = MetroFramework.MetroColorStyle.Silver;
            this.dateExpense.TabIndex = 3;
            this.dateExpense.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dateExpense.Value = new System.DateTime(2017, 12, 8, 21, 51, 26, 0);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.White;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.ForeColor = System.Drawing.Color.Black;
            this.metroLabel7.Location = new System.Drawing.Point(408, 395);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(49, 19);
            this.metroLabel7.TabIndex = 140;
            this.metroLabel7.Text = "Date : ";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // txtAmount
            // 
            // 
            // 
            // 
            this.txtAmount.CustomButton.Image = null;
            this.txtAmount.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.txtAmount.CustomButton.Name = "";
            this.txtAmount.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAmount.CustomButton.TabIndex = 1;
            this.txtAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAmount.CustomButton.UseSelectable = true;
            this.txtAmount.CustomButton.Visible = false;
            this.txtAmount.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtAmount.Lines = new string[0];
            this.txtAmount.Location = new System.Drawing.Point(112, 394);
            this.txtAmount.MaxLength = 32767;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAmount.SelectedText = "";
            this.txtAmount.SelectionLength = 0;
            this.txtAmount.SelectionStart = 0;
            this.txtAmount.ShortcutsEnabled = true;
            this.txtAmount.Size = new System.Drawing.Size(181, 25);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.UseSelectable = true;
            this.txtAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.White;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.ForeColor = System.Drawing.Color.Black;
            this.metroLabel6.Location = new System.Drawing.Point(43, 396);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(66, 19);
            this.metroLabel6.TabIndex = 138;
            this.metroLabel6.Text = "Amount :";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // txtPayDesc
            // 
            // 
            // 
            // 
            this.txtPayDesc.CustomButton.Image = null;
            this.txtPayDesc.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.txtPayDesc.CustomButton.Name = "";
            this.txtPayDesc.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPayDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPayDesc.CustomButton.TabIndex = 1;
            this.txtPayDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPayDesc.CustomButton.UseSelectable = true;
            this.txtPayDesc.CustomButton.Visible = false;
            this.txtPayDesc.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPayDesc.Lines = new string[0];
            this.txtPayDesc.Location = new System.Drawing.Point(112, 434);
            this.txtPayDesc.MaxLength = 32767;
            this.txtPayDesc.Name = "txtPayDesc";
            this.txtPayDesc.PasswordChar = '\0';
            this.txtPayDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPayDesc.SelectedText = "";
            this.txtPayDesc.SelectionLength = 0;
            this.txtPayDesc.SelectionStart = 0;
            this.txtPayDesc.ShortcutsEnabled = true;
            this.txtPayDesc.Size = new System.Drawing.Size(181, 25);
            this.txtPayDesc.TabIndex = 4;
            this.txtPayDesc.UseSelectable = true;
            this.txtPayDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPayDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPayDesc.TextChanged += new System.EventHandler(this.txtPayDesc_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.White;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.Black;
            this.metroLabel2.Location = new System.Drawing.Point(347, 355);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(110, 19);
            this.metroLabel2.TabIndex = 136;
            this.metroLabel2.Text = "Exp Description :";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // txtPaymentMethod
            // 
            this.txtPaymentMethod.FormattingEnabled = true;
            this.txtPaymentMethod.ItemHeight = 23;
            this.txtPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Cheque",
            "Bank Transfer"});
            this.txtPaymentMethod.Location = new System.Drawing.Point(460, 434);
            this.txtPaymentMethod.Name = "txtPaymentMethod";
            this.txtPaymentMethod.Size = new System.Drawing.Size(181, 29);
            this.txtPaymentMethod.TabIndex = 5;
            this.txtPaymentMethod.UseSelectable = true;
            this.txtPaymentMethod.TextChanged += new System.EventHandler(this.txtPaymentMethod_TextChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.White;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.ForeColor = System.Drawing.Color.Black;
            this.metroLabel8.Location = new System.Drawing.Point(334, 439);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(123, 19);
            this.metroLabel8.TabIndex = 134;
            this.metroLabel8.Text = "Payment Method :";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.White;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.ForeColor = System.Drawing.Color.Black;
            this.metroLabel5.Location = new System.Drawing.Point(12, 355);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(97, 19);
            this.metroLabel5.TabIndex = 133;
            this.metroLabel5.Text = "Expense Type :";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // txtReceivedBy
            // 
            // 
            // 
            // 
            this.txtReceivedBy.CustomButton.Image = null;
            this.txtReceivedBy.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.txtReceivedBy.CustomButton.Name = "";
            this.txtReceivedBy.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtReceivedBy.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReceivedBy.CustomButton.TabIndex = 1;
            this.txtReceivedBy.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReceivedBy.CustomButton.UseSelectable = true;
            this.txtReceivedBy.CustomButton.Visible = false;
            this.txtReceivedBy.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtReceivedBy.Lines = new string[0];
            this.txtReceivedBy.Location = new System.Drawing.Point(460, 474);
            this.txtReceivedBy.MaxLength = 32767;
            this.txtReceivedBy.Name = "txtReceivedBy";
            this.txtReceivedBy.PasswordChar = '\0';
            this.txtReceivedBy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReceivedBy.SelectedText = "";
            this.txtReceivedBy.SelectionLength = 0;
            this.txtReceivedBy.SelectionStart = 0;
            this.txtReceivedBy.ShortcutsEnabled = true;
            this.txtReceivedBy.Size = new System.Drawing.Size(181, 25);
            this.txtReceivedBy.TabIndex = 7;
            this.txtReceivedBy.UseSelectable = true;
            this.txtReceivedBy.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReceivedBy.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtReceivedBy.TextChanged += new System.EventHandler(this.txtReceivedBy_TextChanged);
            // 
            // txtPaidBy
            // 
            // 
            // 
            // 
            this.txtPaidBy.CustomButton.Image = null;
            this.txtPaidBy.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.txtPaidBy.CustomButton.Name = "";
            this.txtPaidBy.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPaidBy.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPaidBy.CustomButton.TabIndex = 1;
            this.txtPaidBy.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPaidBy.CustomButton.UseSelectable = true;
            this.txtPaidBy.CustomButton.Visible = false;
            this.txtPaidBy.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPaidBy.Lines = new string[0];
            this.txtPaidBy.Location = new System.Drawing.Point(112, 474);
            this.txtPaidBy.MaxLength = 32767;
            this.txtPaidBy.Name = "txtPaidBy";
            this.txtPaidBy.PasswordChar = '\0';
            this.txtPaidBy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPaidBy.SelectedText = "";
            this.txtPaidBy.SelectionLength = 0;
            this.txtPaidBy.SelectionStart = 0;
            this.txtPaidBy.ShortcutsEnabled = true;
            this.txtPaidBy.Size = new System.Drawing.Size(181, 25);
            this.txtPaidBy.TabIndex = 6;
            this.txtPaidBy.UseSelectable = true;
            this.txtPaidBy.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPaidBy.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPaidBy.TextChanged += new System.EventHandler(this.txtPaidBy_TextChanged);
            // 
            // txtExpeDesc
            // 
            // 
            // 
            // 
            this.txtExpeDesc.CustomButton.Image = null;
            this.txtExpeDesc.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.txtExpeDesc.CustomButton.Name = "";
            this.txtExpeDesc.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtExpeDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtExpeDesc.CustomButton.TabIndex = 1;
            this.txtExpeDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtExpeDesc.CustomButton.UseSelectable = true;
            this.txtExpeDesc.CustomButton.Visible = false;
            this.txtExpeDesc.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtExpeDesc.Lines = new string[0];
            this.txtExpeDesc.Location = new System.Drawing.Point(460, 352);
            this.txtExpeDesc.MaxLength = 32767;
            this.txtExpeDesc.Multiline = true;
            this.txtExpeDesc.Name = "txtExpeDesc";
            this.txtExpeDesc.PasswordChar = '\0';
            this.txtExpeDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtExpeDesc.SelectedText = "";
            this.txtExpeDesc.SelectionLength = 0;
            this.txtExpeDesc.SelectionStart = 0;
            this.txtExpeDesc.ShortcutsEnabled = true;
            this.txtExpeDesc.Size = new System.Drawing.Size(181, 25);
            this.txtExpeDesc.TabIndex = 1;
            this.txtExpeDesc.UseSelectable = true;
            this.txtExpeDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtExpeDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtExpeDesc.TextChanged += new System.EventHandler(this.txtExpeDesc_TextChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.White;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.Color.Black;
            this.metroLabel4.Location = new System.Drawing.Point(6, 437);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(103, 19);
            this.metroLabel4.TabIndex = 129;
            this.metroLabel4.Text = "Payment Desc :";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.White;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.Black;
            this.metroLabel3.Location = new System.Drawing.Point(48, 477);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(61, 19);
            this.metroLabel3.TabIndex = 128;
            this.metroLabel3.Text = "Paid By :";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.White;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(369, 479);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.TabIndex = 127;
            this.metroLabel1.Text = "Received By :";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(109, 2);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(509, 29);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(127, 20);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.Color.White;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.ForeColor = System.Drawing.Color.Black;
            this.metroLabel10.Location = new System.Drawing.Point(218, 30);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(108, 19);
            this.metroLabel10.TabIndex = 149;
            this.metroLabel10.Text = "Total Expense :";
            this.metroLabel10.UseCustomBackColor = true;
            this.metroLabel10.UseCustomForeColor = true;
            // 
            // lblTotalExpense
            // 
            this.lblTotalExpense.AutoSize = true;
            this.lblTotalExpense.BackColor = System.Drawing.Color.White;
            this.lblTotalExpense.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTotalExpense.ForeColor = System.Drawing.Color.Black;
            this.lblTotalExpense.Location = new System.Drawing.Point(322, 30);
            this.lblTotalExpense.Name = "lblTotalExpense";
            this.lblTotalExpense.Size = new System.Drawing.Size(0, 0);
            this.lblTotalExpense.TabIndex = 151;
            this.lblTotalExpense.UseCustomBackColor = true;
            this.lblTotalExpense.UseCustomForeColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.White;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.ForeColor = System.Drawing.Color.Black;
            this.metroLabel9.Location = new System.Drawing.Point(448, 28);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(56, 19);
            this.metroLabel9.TabIndex = 152;
            this.metroLabel9.Text = "Search :";
            this.metroLabel9.UseCustomBackColor = true;
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // txtExpType
            // 
            // 
            // 
            // 
            this.txtExpType.CustomButton.Image = null;
            this.txtExpType.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.txtExpType.CustomButton.Name = "";
            this.txtExpType.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtExpType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtExpType.CustomButton.TabIndex = 1;
            this.txtExpType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtExpType.CustomButton.UseSelectable = true;
            this.txtExpType.CustomButton.Visible = false;
            this.txtExpType.Lines = new string[0];
            this.txtExpType.Location = new System.Drawing.Point(112, 355);
            this.txtExpType.MaxLength = 32767;
            this.txtExpType.Name = "txtExpType";
            this.txtExpType.PasswordChar = '\0';
            this.txtExpType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtExpType.SelectedText = "";
            this.txtExpType.SelectionLength = 0;
            this.txtExpType.SelectionStart = 0;
            this.txtExpType.ShortcutsEnabled = true;
            this.txtExpType.Size = new System.Drawing.Size(181, 25);
            this.txtExpType.TabIndex = 0;
            this.txtExpType.UseSelectable = true;
            this.txtExpType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtExpType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtExpType.TextChanged += new System.EventHandler(this.txtExpType_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.Black;
            this.metroButton2.ForeColor = System.Drawing.Color.White;
            this.metroButton2.Location = new System.Drawing.Point(277, 518);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 30);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton2.TabIndex = 13;
            this.metroButton2.Text = "Exit";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click_1);
            // 
            // OfficeExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackMaxSize = 900;
            this.ClientSize = new System.Drawing.Size(660, 567);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.txtExpType);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.lblTotalExpense);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dateExpense);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtPayDesc);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtPaymentMethod);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtReceivedBy);
            this.Controls.Add(this.txtPaidBy);
            this.Controls.Add(this.txtExpeDesc);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroGrid1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "OfficeExpense";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "OfficeExpense";
            this.Load += new System.EventHandler(this.OfficeExpense_Load);
            this.Click += new System.EventHandler(this.OfficeExpense_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OfficeExpense_MouseClick);
            this.MouseEnter += new System.EventHandler(this.OfficeExpense_MouseEnter);
            this.MouseHover += new System.EventHandler(this.OfficeExpense_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroDateTime dateExpense;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtAmount;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtPayDesc;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox txtPaymentMethod;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtReceivedBy;
        private MetroFramework.Controls.MetroTextBox txtPaidBy;
        private MetroFramework.Controls.MetroTextBox txtExpeDesc;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel lblTotalExpense;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtExpType;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}