namespace MS_CIT
{
    partial class Pay_Fees
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.txtPaymentDesc = new MetroFramework.Controls.MetroTextBox();
            this.txtPaidBy = new MetroFramework.Controls.MetroTextBox();
            this.txtReceivedBy = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txtAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.lblInstallmentNo = new MetroFramework.Controls.MetroLabel();
            this.comboPaymentMethod = new MetroFramework.Controls.MetroComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.lblAllocated = new MetroFramework.Controls.MetroLabel();
            this.lblPaid = new MetroFramework.Controls.MetroLabel();
            this.lblPending = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.datepayment = new MetroFramework.Controls.MetroDateTime();
            this.lblMarquee = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.PrintRecipt = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(71, 66);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 19);
            this.metroLabel2.TabIndex = 31;
            this.metroLabel2.Text = "Name : ";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(36, 384);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(86, 19);
            this.metroLabel1.TabIndex = 32;
            this.metroLabel1.Text = "Received By :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(63, 345);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 19);
            this.metroLabel3.TabIndex = 33;
            this.metroLabel3.Text = "Paid By :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(25, 291);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(97, 19);
            this.metroLabel4.TabIndex = 34;
            this.metroLabel4.Text = "Payment Desc :";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(20, 111);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(107, 19);
            this.metroLabel6.TabIndex = 36;
            this.metroLabel6.Text = "Installment No. : ";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(26, 156);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(101, 19);
            this.metroLabel7.TabIndex = 37;
            this.metroLabel7.Text = "Payment Date : ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblName.Location = new System.Drawing.Point(135, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 0);
            this.lblName.TabIndex = 39;
            // 
            // txtPaymentDesc
            // 
            // 
            // 
            // 
            this.txtPaymentDesc.CustomButton.Image = null;
            this.txtPaymentDesc.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtPaymentDesc.CustomButton.Name = "";
            this.txtPaymentDesc.CustomButton.Size = new System.Drawing.Size(47, 47);
            this.txtPaymentDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPaymentDesc.CustomButton.TabIndex = 1;
            this.txtPaymentDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPaymentDesc.CustomButton.UseSelectable = true;
            this.txtPaymentDesc.CustomButton.Visible = false;
            this.txtPaymentDesc.Lines = new string[0];
            this.txtPaymentDesc.Location = new System.Drawing.Point(135, 283);
            this.txtPaymentDesc.MaxLength = 32767;
            this.txtPaymentDesc.Multiline = true;
            this.txtPaymentDesc.Name = "txtPaymentDesc";
            this.txtPaymentDesc.PasswordChar = '\0';
            this.txtPaymentDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPaymentDesc.SelectedText = "";
            this.txtPaymentDesc.SelectionLength = 0;
            this.txtPaymentDesc.SelectionStart = 0;
            this.txtPaymentDesc.ShortcutsEnabled = true;
            this.txtPaymentDesc.Size = new System.Drawing.Size(183, 49);
            this.txtPaymentDesc.TabIndex = 3;
            this.txtPaymentDesc.UseSelectable = true;
            this.txtPaymentDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPaymentDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPaidBy
            // 
            // 
            // 
            // 
            this.txtPaidBy.CustomButton.Image = null;
            this.txtPaidBy.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtPaidBy.CustomButton.Name = "";
            this.txtPaidBy.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPaidBy.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPaidBy.CustomButton.TabIndex = 1;
            this.txtPaidBy.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPaidBy.CustomButton.UseSelectable = true;
            this.txtPaidBy.CustomButton.Visible = false;
            this.txtPaidBy.Lines = new string[0];
            this.txtPaidBy.Location = new System.Drawing.Point(135, 345);
            this.txtPaidBy.MaxLength = 32767;
            this.txtPaidBy.Name = "txtPaidBy";
            this.txtPaidBy.PasswordChar = '\0';
            this.txtPaidBy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPaidBy.SelectedText = "";
            this.txtPaidBy.SelectionLength = 0;
            this.txtPaidBy.SelectionStart = 0;
            this.txtPaidBy.ShortcutsEnabled = true;
            this.txtPaidBy.Size = new System.Drawing.Size(183, 25);
            this.txtPaidBy.TabIndex = 4;
            this.txtPaidBy.UseSelectable = true;
            this.txtPaidBy.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPaidBy.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtReceivedBy
            // 
            // 
            // 
            // 
            this.txtReceivedBy.CustomButton.Image = null;
            this.txtReceivedBy.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtReceivedBy.CustomButton.Name = "";
            this.txtReceivedBy.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtReceivedBy.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReceivedBy.CustomButton.TabIndex = 1;
            this.txtReceivedBy.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReceivedBy.CustomButton.UseSelectable = true;
            this.txtReceivedBy.CustomButton.Visible = false;
            this.txtReceivedBy.Lines = new string[0];
            this.txtReceivedBy.Location = new System.Drawing.Point(135, 382);
            this.txtReceivedBy.MaxLength = 32767;
            this.txtReceivedBy.Name = "txtReceivedBy";
            this.txtReceivedBy.PasswordChar = '\0';
            this.txtReceivedBy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReceivedBy.SelectedText = "";
            this.txtReceivedBy.SelectionLength = 0;
            this.txtReceivedBy.SelectionStart = 0;
            this.txtReceivedBy.ShortcutsEnabled = true;
            this.txtReceivedBy.Size = new System.Drawing.Size(183, 25);
            this.txtReceivedBy.TabIndex = 5;
            this.txtReceivedBy.UseSelectable = true;
            this.txtReceivedBy.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReceivedBy.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(233, 435);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 30);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Submit";
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAmount
            // 
            // 
            // 
            // 
            this.txtAmount.CustomButton.Image = null;
            this.txtAmount.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtAmount.CustomButton.Name = "";
            this.txtAmount.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAmount.CustomButton.TabIndex = 1;
            this.txtAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAmount.CustomButton.UseSelectable = true;
            this.txtAmount.CustomButton.Visible = false;
            this.txtAmount.Lines = new string[0];
            this.txtAmount.Location = new System.Drawing.Point(135, 200);
            this.txtAmount.MaxLength = 32767;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAmount.SelectedText = "";
            this.txtAmount.SelectionLength = 0;
            this.txtAmount.SelectionStart = 0;
            this.txtAmount.ShortcutsEnabled = true;
            this.txtAmount.Size = new System.Drawing.Size(183, 25);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.UseSelectable = true;
            this.txtAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(59, 201);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(63, 19);
            this.metroLabel5.TabIndex = 46;
            this.metroLabel5.Text = "Amount :";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(6, 246);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(116, 19);
            this.metroLabel8.TabIndex = 48;
            this.metroLabel8.Text = "Payment Method :";
            // 
            // lblInstallmentNo
            // 
            this.lblInstallmentNo.AutoSize = true;
            this.lblInstallmentNo.Location = new System.Drawing.Point(135, 111);
            this.lblInstallmentNo.Name = "lblInstallmentNo";
            this.lblInstallmentNo.Size = new System.Drawing.Size(0, 0);
            this.lblInstallmentNo.TabIndex = 50;
            // 
            // comboPaymentMethod
            // 
            this.comboPaymentMethod.FormattingEnabled = true;
            this.comboPaymentMethod.ItemHeight = 23;
            this.comboPaymentMethod.Items.AddRange(new object[] {
            "",
            "Cash",
            "Cheque",
            "Bank Transfer"});
            this.comboPaymentMethod.Location = new System.Drawing.Point(135, 243);
            this.comboPaymentMethod.Name = "comboPaymentMethod";
            this.comboPaymentMethod.Size = new System.Drawing.Size(183, 29);
            this.comboPaymentMethod.TabIndex = 2;
            this.comboPaymentMethod.UseSelectable = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrintRecipt});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.HighLightPercentage = 0.5F;
            this.metroGrid1.Location = new System.Drawing.Point(333, 95);
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
            this.metroGrid1.Size = new System.Drawing.Size(579, 312);
            this.metroGrid1.TabIndex = 124;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroGrid1.UseCustomBackColor = true;
            this.metroGrid1.UseCustomForeColor = true;
            this.metroGrid1.UseStyleColors = true;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(713, 440);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(67, 19);
            this.metroLabel9.TabIndex = 125;
            this.metroLabel9.Text = "Pending : ";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(549, 440);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(45, 19);
            this.metroLabel10.TabIndex = 126;
            this.metroLabel10.Text = "Paid : ";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(351, 440);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(79, 19);
            this.metroLabel11.TabIndex = 127;
            this.metroLabel11.Text = "Allocated  : ";
            // 
            // lblAllocated
            // 
            this.lblAllocated.AutoSize = true;
            this.lblAllocated.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAllocated.Location = new System.Drawing.Point(432, 440);
            this.lblAllocated.Name = "lblAllocated";
            this.lblAllocated.Size = new System.Drawing.Size(0, 0);
            this.lblAllocated.TabIndex = 128;
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPaid.Location = new System.Drawing.Point(597, 440);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(0, 0);
            this.lblPaid.TabIndex = 129;
            this.lblPaid.UseCustomBackColor = true;
            this.lblPaid.UseCustomForeColor = true;
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPending.ForeColor = System.Drawing.Color.Red;
            this.lblPending.Location = new System.Drawing.Point(782, 440);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(0, 0);
            this.lblPending.TabIndex = 130;
            this.lblPending.UseCustomBackColor = true;
            this.lblPending.UseCustomForeColor = true;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(135, 435);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(85, 30);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton1.TabIndex = 131;
            this.metroButton1.Text = "Close";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // datepayment
            // 
            this.datepayment.CustomFormat = "dd-MM-yyyy";
            this.datepayment.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.datepayment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepayment.Location = new System.Drawing.Point(135, 153);
            this.datepayment.MinimumSize = new System.Drawing.Size(0, 29);
            this.datepayment.Name = "datepayment";
            this.datepayment.Size = new System.Drawing.Size(183, 29);
            this.datepayment.Style = MetroFramework.MetroColorStyle.Silver;
            this.datepayment.TabIndex = 0;
            this.datepayment.Theme = MetroFramework.MetroThemeStyle.Light;
            this.datepayment.Value = new System.DateTime(2017, 12, 29, 0, 0, 0, 0);
            // 
            // lblMarquee
            // 
            this.lblMarquee.AutoSize = true;
            this.lblMarquee.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarquee.ForeColor = System.Drawing.Color.Green;
            this.lblMarquee.Location = new System.Drawing.Point(-1, 475);
            this.lblMarquee.Name = "lblMarquee";
            this.lblMarquee.Size = new System.Drawing.Size(735, 16);
            this.lblMarquee.TabIndex = 133;
            this.lblMarquee.Text = "In case of wrong payment or want to update please revert given transaction with m" +
    "inus sign to amount.(e.g amount : -500)";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // PrintRecipt
            // 
            this.PrintRecipt.HeaderText = "Print";
            this.PrintRecipt.Name = "PrintRecipt";
            this.PrintRecipt.ReadOnly = true;
            this.PrintRecipt.Text = "Print";
            this.PrintRecipt.Width = 35;
            // 
            // Pay_Fees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 499);
            this.Controls.Add(this.lblMarquee);
            this.Controls.Add(this.datepayment);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.lblPending);
            this.Controls.Add(this.lblPaid);
            this.Controls.Add(this.lblAllocated);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.comboPaymentMethod);
            this.Controls.Add(this.lblInstallmentNo);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtReceivedBy);
            this.Controls.Add(this.txtPaidBy);
            this.Controls.Add(this.txtPaymentDesc);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pay_Fees";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Pay Fees ";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Pay_Fees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroTextBox txtPaymentDesc;
        private MetroFramework.Controls.MetroTextBox txtPaidBy;
        private MetroFramework.Controls.MetroTextBox txtReceivedBy;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox txtAmount;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel lblInstallmentNo;
        private MetroFramework.Controls.MetroComboBox comboPaymentMethod;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroLabel lblPending;
        private MetroFramework.Controls.MetroLabel lblPaid;
        private MetroFramework.Controls.MetroLabel lblAllocated;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroDateTime datepayment;
        private System.Windows.Forms.Label lblMarquee;
        private System.Windows.Forms.Timer timer1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewButtonColumn PrintRecipt;
    }
}