namespace MS_CIT
{
    partial class AddStudent
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
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.datet_admission = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtp_occupation = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.comboadmission = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtCollege = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.datetdob = new MetroFramework.Controls.MetroDateTime();
            this.txtP_mob = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtmname = new MetroFramework.Controls.MetroTextBox();
            this.txtsurname = new MetroFramework.Controls.MetroTextBox();
            this.txt_s_mob = new MetroFramework.Controls.MetroTextBox();
            this.txtaddress = new MetroFramework.Controls.MetroTextBox();
            this.txtfname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ComboBoxGender = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.lblAllocatedFees = new MetroFramework.Controls.MetroLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(627, 466);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 30);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // datet_admission
            // 
            this.datet_admission.CustomFormat = "dd-MM-yyyy";
            this.datet_admission.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.datet_admission.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datet_admission.Location = new System.Drawing.Point(150, 467);
            this.datet_admission.MinimumSize = new System.Drawing.Size(0, 29);
            this.datet_admission.Name = "datet_admission";
            this.datet_admission.Size = new System.Drawing.Size(183, 29);
            this.datet_admission.Style = MetroFramework.MetroColorStyle.Silver;
            this.datet_admission.TabIndex = 12;
            this.datet_admission.Theme = MetroFramework.MetroThemeStyle.Light;
            this.datet_admission.Value = new System.DateTime(2017, 12, 19, 0, 0, 0, 0);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(29, 472);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(107, 19);
            this.metroLabel10.TabIndex = 24;
            this.metroLabel10.Text = "Admission Date :";
            // 
            // txtp_occupation
            // 
            // 
            // 
            // 
            this.txtp_occupation.CustomButton.Image = null;
            this.txtp_occupation.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtp_occupation.CustomButton.Name = "";
            this.txtp_occupation.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtp_occupation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtp_occupation.CustomButton.TabIndex = 1;
            this.txtp_occupation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtp_occupation.CustomButton.UseSelectable = true;
            this.txtp_occupation.CustomButton.Visible = false;
            this.txtp_occupation.Lines = new string[0];
            this.txtp_occupation.Location = new System.Drawing.Point(151, 243);
            this.txtp_occupation.MaxLength = 32767;
            this.txtp_occupation.Name = "txtp_occupation";
            this.txtp_occupation.PasswordChar = '\0';
            this.txtp_occupation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtp_occupation.SelectedText = "";
            this.txtp_occupation.SelectionLength = 0;
            this.txtp_occupation.SelectionStart = 0;
            this.txtp_occupation.ShortcutsEnabled = true;
            this.txtp_occupation.Size = new System.Drawing.Size(183, 25);
            this.txtp_occupation.TabIndex = 6;
            this.txtp_occupation.UseSelectable = true;
            this.txtp_occupation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtp_occupation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtp_occupation.TextChanged += new System.EventHandler(this.txtp_occupation_TextChanged);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(7, 246);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(131, 19);
            this.metroLabel9.TabIndex = 18;
            this.metroLabel9.Text = "Parent\'s Occupation :";
            // 
            // comboadmission
            // 
            this.comboadmission.FormattingEnabled = true;
            this.comboadmission.ItemHeight = 23;
            this.comboadmission.Location = new System.Drawing.Point(150, 391);
            this.comboadmission.Name = "comboadmission";
            this.comboadmission.Size = new System.Drawing.Size(183, 29);
            this.comboadmission.TabIndex = 10;
            this.comboadmission.UseSelectable = true;
            this.comboadmission.ValueMemberChanged += new System.EventHandler(this.comboadmission_ValueMemberChanged);
            this.comboadmission.TextChanged += new System.EventHandler(this.comboadmission_TextChanged);
            this.comboadmission.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboadmission_KeyDown);
            this.comboadmission.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboadmission_KeyUp);
            this.comboadmission.Validating += new System.ComponentModel.CancelEventHandler(this.comboadmission_Validating);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(38, 396);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(100, 19);
            this.metroLabel7.TabIndex = 22;
            this.metroLabel7.Text = "Admission For :";
            // 
            // txtCollege
            // 
            // 
            // 
            // 
            this.txtCollege.CustomButton.Image = null;
            this.txtCollege.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtCollege.CustomButton.Name = "";
            this.txtCollege.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtCollege.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCollege.CustomButton.TabIndex = 1;
            this.txtCollege.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCollege.CustomButton.UseSelectable = true;
            this.txtCollege.CustomButton.Visible = false;
            this.txtCollege.Lines = new string[0];
            this.txtCollege.Location = new System.Drawing.Point(151, 355);
            this.txtCollege.MaxLength = 32767;
            this.txtCollege.Name = "txtCollege";
            this.txtCollege.PasswordChar = '\0';
            this.txtCollege.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCollege.SelectedText = "";
            this.txtCollege.SelectionLength = 0;
            this.txtCollege.SelectionStart = 0;
            this.txtCollege.ShortcutsEnabled = true;
            this.txtCollege.Size = new System.Drawing.Size(183, 25);
            this.txtCollege.TabIndex = 9;
            this.txtCollege.UseSelectable = true;
            this.txtCollege.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCollege.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCollege.TextChanged += new System.EventHandler(this.txtCollege_TextChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(17, 358);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(121, 19);
            this.metroLabel6.TabIndex = 21;
            this.metroLabel6.Text = "College or School :";
            // 
            // datetdob
            // 
            this.datetdob.CustomFormat = "dd-MM-yyyy";
            this.datetdob.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.datetdob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetdob.Location = new System.Drawing.Point(151, 204);
            this.datetdob.MinimumSize = new System.Drawing.Size(0, 29);
            this.datetdob.Name = "datetdob";
            this.datetdob.Size = new System.Drawing.Size(183, 29);
            this.datetdob.Style = MetroFramework.MetroColorStyle.Silver;
            this.datetdob.TabIndex = 5;
            this.datetdob.Theme = MetroFramework.MetroThemeStyle.Light;
            this.datetdob.Value = new System.DateTime(2017, 12, 29, 0, 0, 0, 0);
            // 
            // txtP_mob
            // 
            // 
            // 
            // 
            this.txtP_mob.CustomButton.Image = null;
            this.txtP_mob.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtP_mob.CustomButton.Name = "";
            this.txtP_mob.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtP_mob.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtP_mob.CustomButton.TabIndex = 1;
            this.txtP_mob.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtP_mob.CustomButton.UseSelectable = true;
            this.txtP_mob.CustomButton.Visible = false;
            this.txtP_mob.Lines = new string[0];
            this.txtP_mob.Location = new System.Drawing.Point(151, 317);
            this.txtP_mob.MaxLength = 10;
            this.txtP_mob.Name = "txtP_mob";
            this.txtP_mob.PasswordChar = '\0';
            this.txtP_mob.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtP_mob.SelectedText = "";
            this.txtP_mob.SelectionLength = 0;
            this.txtP_mob.SelectionStart = 0;
            this.txtP_mob.ShortcutsEnabled = true;
            this.txtP_mob.Size = new System.Drawing.Size(183, 25);
            this.txtP_mob.TabIndex = 8;
            this.txtP_mob.UseSelectable = true;
            this.txtP_mob.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtP_mob.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtP_mob.TextChanged += new System.EventHandler(this.txtP_mob_TextChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(29, 322);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(109, 19);
            this.metroLabel8.TabIndex = 20;
            this.metroLabel8.Text = "Parent Mob. No.:";
            // 
            // txtmname
            // 
            // 
            // 
            // 
            this.txtmname.CustomButton.Image = null;
            this.txtmname.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtmname.CustomButton.Name = "";
            this.txtmname.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtmname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtmname.CustomButton.TabIndex = 1;
            this.txtmname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtmname.CustomButton.UseSelectable = true;
            this.txtmname.CustomButton.Visible = false;
            this.txtmname.Lines = new string[0];
            this.txtmname.Location = new System.Drawing.Point(354, 73);
            this.txtmname.MaxLength = 32767;
            this.txtmname.Name = "txtmname";
            this.txtmname.PasswordChar = '\0';
            this.txtmname.PromptText = "Middle Name";
            this.txtmname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtmname.SelectedText = "";
            this.txtmname.SelectionLength = 0;
            this.txtmname.SelectionStart = 0;
            this.txtmname.ShortcutsEnabled = true;
            this.txtmname.Size = new System.Drawing.Size(183, 25);
            this.txtmname.TabIndex = 1;
            this.txtmname.UseSelectable = true;
            this.txtmname.WaterMark = "Middle Name";
            this.txtmname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtmname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtmname.TextChanged += new System.EventHandler(this.txtmname_TextChanged);
            // 
            // txtsurname
            // 
            // 
            // 
            // 
            this.txtsurname.CustomButton.Image = null;
            this.txtsurname.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtsurname.CustomButton.Name = "";
            this.txtsurname.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtsurname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtsurname.CustomButton.TabIndex = 1;
            this.txtsurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtsurname.CustomButton.UseSelectable = true;
            this.txtsurname.CustomButton.Visible = false;
            this.txtsurname.Lines = new string[0];
            this.txtsurname.Location = new System.Drawing.Point(554, 73);
            this.txtsurname.MaxLength = 32767;
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.PasswordChar = '\0';
            this.txtsurname.PromptText = "Surname";
            this.txtsurname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtsurname.SelectedText = "";
            this.txtsurname.SelectionLength = 0;
            this.txtsurname.SelectionStart = 0;
            this.txtsurname.ShortcutsEnabled = true;
            this.txtsurname.Size = new System.Drawing.Size(183, 25);
            this.txtsurname.TabIndex = 2;
            this.txtsurname.UseSelectable = true;
            this.txtsurname.WaterMark = "Surname";
            this.txtsurname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtsurname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtsurname.TextChanged += new System.EventHandler(this.txtsurname_TextChanged);
            // 
            // txt_s_mob
            // 
            // 
            // 
            // 
            this.txt_s_mob.CustomButton.Image = null;
            this.txt_s_mob.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txt_s_mob.CustomButton.Name = "";
            this.txt_s_mob.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_s_mob.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_s_mob.CustomButton.TabIndex = 1;
            this.txt_s_mob.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_s_mob.CustomButton.UseSelectable = true;
            this.txt_s_mob.CustomButton.Visible = false;
            this.txt_s_mob.Lines = new string[0];
            this.txt_s_mob.Location = new System.Drawing.Point(151, 280);
            this.txt_s_mob.MaxLength = 10;
            this.txt_s_mob.Name = "txt_s_mob";
            this.txt_s_mob.PasswordChar = '\0';
            this.txt_s_mob.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_s_mob.SelectedText = "";
            this.txt_s_mob.SelectionLength = 0;
            this.txt_s_mob.SelectionStart = 0;
            this.txt_s_mob.ShortcutsEnabled = true;
            this.txt_s_mob.Size = new System.Drawing.Size(183, 25);
            this.txt_s_mob.TabIndex = 7;
            this.txt_s_mob.UseSelectable = true;
            this.txt_s_mob.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_s_mob.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_s_mob.TextChanged += new System.EventHandler(this.txt_s_mob_TextChanged);
            this.txt_s_mob.Click += new System.EventHandler(this.txt_s_mob_Click);
            // 
            // txtaddress
            // 
            // 
            // 
            // 
            this.txtaddress.CustomButton.Image = null;
            this.txtaddress.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.txtaddress.CustomButton.Name = "";
            this.txtaddress.CustomButton.Size = new System.Drawing.Size(43, 43);
            this.txtaddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtaddress.CustomButton.TabIndex = 1;
            this.txtaddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtaddress.CustomButton.UseSelectable = true;
            this.txtaddress.CustomButton.Visible = false;
            this.txtaddress.Lines = new string[0];
            this.txtaddress.Location = new System.Drawing.Point(151, 112);
            this.txtaddress.MaxLength = 32767;
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.PasswordChar = '\0';
            this.txtaddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtaddress.SelectedText = "";
            this.txtaddress.SelectionLength = 0;
            this.txtaddress.SelectionStart = 0;
            this.txtaddress.ShortcutsEnabled = true;
            this.txtaddress.Size = new System.Drawing.Size(183, 45);
            this.txtaddress.TabIndex = 3;
            this.txtaddress.UseSelectable = true;
            this.txtaddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtaddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtaddress.TextChanged += new System.EventHandler(this.txtaddress_TextChanged);
            // 
            // txtfname
            // 
            // 
            // 
            // 
            this.txtfname.CustomButton.Image = null;
            this.txtfname.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtfname.CustomButton.Name = "";
            this.txtfname.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtfname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtfname.CustomButton.TabIndex = 1;
            this.txtfname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtfname.CustomButton.UseSelectable = true;
            this.txtfname.CustomButton.Visible = false;
            this.txtfname.Lines = new string[0];
            this.txtfname.Location = new System.Drawing.Point(151, 73);
            this.txtfname.MaxLength = 32767;
            this.txtfname.Name = "txtfname";
            this.txtfname.PasswordChar = '\0';
            this.txtfname.PromptText = "First Name";
            this.txtfname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtfname.SelectedText = "";
            this.txtfname.SelectionLength = 0;
            this.txtfname.SelectionStart = 0;
            this.txtfname.ShortcutsEnabled = true;
            this.txtfname.Size = new System.Drawing.Size(183, 25);
            this.txtfname.TabIndex = 0;
            this.txtfname.UseSelectable = true;
            this.txtfname.WaterMark = "First Name";
            this.txtfname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtfname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtfname.TextChanged += new System.EventHandler(this.txtfname_TextChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(75, 120);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(63, 19);
            this.metroLabel5.TabIndex = 15;
            this.metroLabel5.Text = "Address :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(79, 170);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 19);
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "Gender :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(44, 208);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(94, 19);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "Date Of Birth :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(22, 284);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(116, 19);
            this.metroLabel2.TabIndex = 19;
            this.metroLabel2.Text = "Student Mob. No.:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(82, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Name : ";
            // 
            // ComboBoxGender
            // 
            this.ComboBoxGender.FormattingEnabled = true;
            this.ComboBoxGender.ItemHeight = 23;
            this.ComboBoxGender.Items.AddRange(new object[] {
            "",
            "Male",
            "Female",
            "Other"});
            this.ComboBoxGender.Location = new System.Drawing.Point(150, 167);
            this.ComboBoxGender.Name = "ComboBoxGender";
            this.ComboBoxGender.Size = new System.Drawing.Size(183, 29);
            this.ComboBoxGender.TabIndex = 4;
            this.ComboBoxGender.UseSelectable = true;
            this.ComboBoxGender.TextChanged += new System.EventHandler(this.ComboBoxGender_TextChanged);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(37, 434);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(101, 19);
            this.metroLabel11.TabIndex = 23;
            this.metroLabel11.Text = "Allocated Fees :";
            // 
            // lblAllocatedFees
            // 
            this.lblAllocatedFees.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblAllocatedFees.Location = new System.Drawing.Point(150, 429);
            this.lblAllocatedFees.Name = "lblAllocatedFees";
            this.lblAllocatedFees.Size = new System.Drawing.Size(183, 29);
            this.lblAllocatedFees.TabIndex = 11;
            this.lblAllocatedFees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.SystemColors.ControlText;
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(627, 423);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(85, 30);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton1.TabIndex = 14;
            this.metroButton1.Text = "Close";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 512);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.lblAllocatedFees);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.ComboBoxGender);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.datet_admission);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.txtp_occupation);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.comboadmission);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtCollege);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.datetdob);
            this.Controls.Add(this.txtP_mob);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.txtmname);
            this.Controls.Add(this.txtsurname);
            this.Controls.Add(this.txt_s_mob);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AddStudent";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroDateTime datet_admission;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtp_occupation;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroComboBox comboadmission;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtCollege;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroDateTime datetdob;
        private MetroFramework.Controls.MetroTextBox txtP_mob;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtmname;
        private MetroFramework.Controls.MetroTextBox txtsurname;
        private MetroFramework.Controls.MetroTextBox txt_s_mob;
        private MetroFramework.Controls.MetroTextBox txtaddress;
        private MetroFramework.Controls.MetroTextBox txtfname;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox ComboBoxGender;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel lblAllocatedFees;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}