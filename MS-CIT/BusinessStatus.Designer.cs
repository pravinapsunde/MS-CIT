namespace MS_CIT
{
    partial class BusinessStatus
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lblToatalBalance = new MetroFramework.Controls.MetroLabel();
            this.lblTotalPaid = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblTotalAllocated = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.SystemColors.Desktop;
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(232, 395);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(85, 30);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Close";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.metroDateTime2);
            this.panel1.Controls.Add(this.metroDateTime1);
            this.panel1.Controls.Add(this.metroComboBox1);
            this.panel1.Controls.Add(this.metroLabel7);
            this.panel1.Controls.Add(this.metroLabel6);
            this.panel1.Controls.Add(this.lblToatalBalance);
            this.panel1.Controls.Add(this.lblTotalPaid);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.lblTotalAllocated);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Location = new System.Drawing.Point(25, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 317);
            this.panel1.TabIndex = 1;
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.CustomFormat = "dd-MM-yyyy";
            this.metroDateTime2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.metroDateTime2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.metroDateTime2.Location = new System.Drawing.Point(132, 67);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(115, 29);
            this.metroDateTime2.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroDateTime2.TabIndex = 1;
            this.metroDateTime2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroDateTime2.Value = new System.DateTime(2017, 12, 29, 0, 0, 0, 0);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.CustomFormat = "dd-MM-yyyy";
            this.metroDateTime1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.metroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.metroDateTime1.Location = new System.Drawing.Point(132, 22);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(115, 29);
            this.metroDateTime1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroDateTime1.TabIndex = 0;
            this.metroDateTime1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroDateTime1.Value = new System.DateTime(2017, 12, 29, 0, 0, 0, 0);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(132, 113);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(115, 29);
            this.metroComboBox1.TabIndex = 2;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged_1);
            this.metroComboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.metroComboBox1_KeyDown);
            this.metroComboBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.metroComboBox1_KeyUp);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.White;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.ForeColor = System.Drawing.Color.Black;
            this.metroLabel7.Location = new System.Drawing.Point(25, 25);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(81, 19);
            this.metroLabel7.TabIndex = 179;
            this.metroLabel7.Text = "From Date :";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.White;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.ForeColor = System.Drawing.Color.Black;
            this.metroLabel6.Location = new System.Drawing.Point(43, 71);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(63, 19);
            this.metroLabel6.TabIndex = 178;
            this.metroLabel6.Text = "To Date :";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // lblToatalBalance
            // 
            this.lblToatalBalance.AutoSize = true;
            this.lblToatalBalance.BackColor = System.Drawing.Color.White;
            this.lblToatalBalance.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblToatalBalance.ForeColor = System.Drawing.Color.Red;
            this.lblToatalBalance.Location = new System.Drawing.Point(130, 269);
            this.lblToatalBalance.Name = "lblToatalBalance";
            this.lblToatalBalance.Size = new System.Drawing.Size(0, 0);
            this.lblToatalBalance.TabIndex = 5;
            this.lblToatalBalance.UseCustomBackColor = true;
            this.lblToatalBalance.UseCustomForeColor = true;
            // 
            // lblTotalPaid
            // 
            this.lblTotalPaid.AutoSize = true;
            this.lblTotalPaid.BackColor = System.Drawing.Color.White;
            this.lblTotalPaid.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTotalPaid.ForeColor = System.Drawing.Color.Green;
            this.lblTotalPaid.Location = new System.Drawing.Point(130, 238);
            this.lblTotalPaid.Name = "lblTotalPaid";
            this.lblTotalPaid.Size = new System.Drawing.Size(0, 0);
            this.lblTotalPaid.TabIndex = 4;
            this.lblTotalPaid.UseCustomBackColor = true;
            this.lblTotalPaid.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.White;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.Black;
            this.metroLabel3.Location = new System.Drawing.Point(21, 269);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(98, 19);
            this.metroLabel3.TabIndex = 175;
            this.metroLabel3.Text = "Total Pending :";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.White;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.Black;
            this.metroLabel2.Location = new System.Drawing.Point(48, 238);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 174;
            this.metroLabel2.Text = "Total Paid :";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // lblTotalAllocated
            // 
            this.lblTotalAllocated.AutoSize = true;
            this.lblTotalAllocated.BackColor = System.Drawing.Color.White;
            this.lblTotalAllocated.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTotalAllocated.ForeColor = System.Drawing.Color.Black;
            this.lblTotalAllocated.Location = new System.Drawing.Point(130, 207);
            this.lblTotalAllocated.Name = "lblTotalAllocated";
            this.lblTotalAllocated.Size = new System.Drawing.Size(0, 0);
            this.lblTotalAllocated.TabIndex = 3;
            this.lblTotalAllocated.UseCustomBackColor = true;
            this.lblTotalAllocated.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.White;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(18, 207);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(105, 19);
            this.metroLabel1.TabIndex = 172;
            this.metroLabel1.Text = "Total Allocated :";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.White;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.ForeColor = System.Drawing.Color.Black;
            this.metroLabel5.Location = new System.Drawing.Point(21, 117);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(98, 19);
            this.metroLabel5.TabIndex = 171;
            this.metroLabel5.Text = "Select Course :";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // BusinessStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 444);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroButton1);
            this.Name = "BusinessStatus";
            this.Text = "Business Status";
            this.Load += new System.EventHandler(this.Business_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel lblToatalBalance;
        private MetroFramework.Controls.MetroLabel lblTotalPaid;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblTotalAllocated;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}