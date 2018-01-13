using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace MS_CIT
{
    public partial class LogIn : MetroForm
    {
        public static bool loginsuccess = false;
        public static bool cancelbuuton = false;
        MySqlCommand cmd;
        public LogIn()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            txtusername.Select();
            txtusername.Focus();
            string serverIp = "localhost";
            string username = "root";
            string password = "root";

            string dbConnectionString = string.Format("server={0};uid={1};pwd={2};", serverIp, username, password);

            var conn = new MySql.Data.MySqlClient.MySqlConnection(dbConnectionString);
            try
            {
                conn.Open();
                string query = "CREATE DATABASE IF NOT EXISTS `tutiondb`;" +
                                "use tutiondb; CREATE TABLE IF NOT EXISTS student(" +
                                "id int(10) NOT NULL AUTO_INCREMENT," +
                                 "f_name varchar(25) DEFAULT NULL," +
                                 "m_name varchar(25) DEFAULT NULL," +
                                 "s_name varchar(25) DEFAULT NULL," +
                                 "s_address varchar(255) DEFAULT NULL," +
                                 "gender varchar(10) DEFAULT NULL,       " +
                                 "p_occupation varchar(255) DEFAULT NULL," +
                                 "student_mob varchar(10) DEFAULT NULL,  " +
                                 "parent_mob varchar(10) DEFAULT NULL,   " +
                                 "dateofbirth varchar(10) DEFAULT NULL,  " +
                                 "college_name varchar(255) DEFAULT NULL," +
                                 "course varchar(25) DEFAULT NULL,       " +
                                 "course_fee varchar(20) DEFAULT NULL,   " +
                                 "admission_date varchar(10) DEFAULT NULL," +
                                 "unpaid_fee varchar(20) DEFAULT NULL,   " +
                                 "paid_fee varchar(25) DEFAULT '0',      " +
                                 " PRIMARY KEY(`id`));" +
                                  "CREATE TABLE IF NOT EXISTS expense_types( " +
                                  "id int(11) NOT NULL AUTO_INCREMENT,        " +
                                  "expense_type varchar(255) DEFAULT NULL,    " +
                                  "created_at datetime NOT NULL,              " +
                                  "updated_at datetime NOT NULL,              " +
                                  " PRIMARY KEY(`id`));                       " +
                                  " CREATE TABLE IF NOT EXISTS feestruct (    " +
                                  "id int(11) NOT NULL AUTO_INCREMENT,           " +
                                  "course varchar(20) NOT NULL,                  " +
                                  "course_fee varchar(20) DEFAULT NULL,          " +
                                  "PRIMARY KEY(`id`));                            " +
                                  "CREATE TABLE IF NOT EXISTS office_expenses ( " +
                                  "id int(11) NOT NULL AUTO_INCREMENT,           " +
                                  "expense_type varchar(255) DEFAULT NULL,       " +
                                  "description varchar(255) DEFAULT NULL,        " +
                                  "amount varchar(255) DEFAULT NULL,             " +
                                  "payment_method varchar(255) DEFAULT NULL,     " +
                                  "payment_descrition varchar(255) DEFAULT NULL, " +
                                  "paid_by varchar(255) DEFAULT NULL,            " +
                                  "received_by varchar(255) DEFAULT NULL,        " +
                                  "created_at timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP," +
                                  "updated_at timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,PRIMARY KEY(`id`));" +
                                  "CREATE TABLE IF NOT EXISTS `student_fees`(   " +
                                  "id int(11) NOT NULL AUTO_INCREMENT,          " +
                                  "student_id int(11) NOT NULL,                 " +
                                  "payment_date varchar(255) DEFAULT NULL,      " +
                                  "installment_no varchar(255) DEFAULT NULL,    " +
                                  "amount varchar(255) DEFAULT NULL,            " +
                                  "payment_method varchar(255) DEFAULT NULL,    " +
                                  "payment_desc varchar(255) DEFAULT NULL,      " +
                                  "paid_by varchar(255) DEFAULT NULL,           " +
                                  "received_by varchar(255) DEFAULT NULL,       " +
                                  "created_at timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,                             " +
                                  "updated_at timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,PRIMARY KEY(`id`));";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                int a = cmd.ExecuteNonQuery();
                if (a == 0)
                {
                    MessageBox.Show("Something went wrong while fetching database");
                    this.Close();
                }
                conn.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusername.Text) || !new Regex("^[a-zA-Z\\s]+$").IsMatch(txtusername.Text))
            {
                errorProvider1.SetError(txtusername, "Please enter valid username");
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.SetError(txtusername, null);
                errorProvider1.SetError(txtPassword, "Enter Password");
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
                try
                {
                    string query = "select * from users where username ='" + txtusername.Text + "' and password ='" + txtPassword.Text + "' limit 1; ";
                    cmd = new MySqlCommand(query, Utility.GetConnection());
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Login Successful !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loginsuccess = true;
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        loginsuccess = false;
                        this.Dispose();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            loginsuccess = true;
            cancelbuuton = true;
            this.Dispose();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCreateusername.Text) || !new Regex("^[a-zA-Z\\s]+$").IsMatch(txtCreateusername.Text))
            {
                errorProvider1.SetError(txtCreateusername, "Please enter valid username");
            }
            else if (string.IsNullOrEmpty(txtCreatePassword.Text))
            {
                errorProvider1.SetError(txtCreateusername, null);
                errorProvider1.SetError(txtCreatePassword, "Enter Password");
            }
            else if (string.IsNullOrEmpty(txtConfirmPass.Text) || txtCreatePassword.Text != txtConfirmPass.Text)
            {
                errorProvider1.SetError(txtCreatePassword, null);
                errorProvider1.SetError(txtConfirmPass, "password is blank or did not match");
            }
            else if (string.IsNullOrEmpty(txtAdminCode.Text))
            {
                errorProvider1.SetError(txtConfirmPass, null);
                errorProvider1.SetError(txtAdminCode, "Enter Admin Code");
            }
            else
            {
                errorProvider1.SetError(txtAdminCode, null);
                if (txtAdminCode.Text == "70531")
                {
                    try
                    {
                        string query = "insert into users(username,password) values('" + txtCreateusername.Text + "','" + txtConfirmPass.Text + "'); ";
                        cmd = new MySqlCommand(query, Utility.GetConnection());
                        int count = cmd.ExecuteNonQuery();
                        if (count == 1)
                        {
                            MessageBox.Show("User Created Successfully..!\nYour username :'" + txtCreateusername.Text + "' ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("User Not Created !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid admin code..!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                panel2.Visible = false;
                panel1.Visible = true;
            }
        }
    }
}





