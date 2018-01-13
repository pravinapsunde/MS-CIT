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
using MySql.Data.MySqlClient;
using System.Configuration;
using System.IO;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;

namespace MS_CIT
{
    public partial class AddStudent : MetroForm
    {
        string id = "";
        Regex expr = null;
        MySqlDataAdapter mySqlDataAdapter;
        public AddStudent()
        {
            InitializeComponent();
            AddComboItem();
        }
        Home home1 = (Home)Application.OpenForms["Home"];
        private Home mainForm = null;
        public AddStudent(Form callingForm)
        {
            mainForm = callingForm as Home;
            InitializeComponent();
        }

        public void setUpdatedValues(string value1, string value2, string value3, string value4, string value5, string value6, string value7, string value8, string value9, string value10, string value11, string value12, string value13, string value14)
        {
            try
            {
                id = value1;
                txtfname.Text = value2;
                txtmname.Text = value3;
                txtsurname.Text = value4;
                txtaddress.Text = value5;
                ComboBoxGender.Text = value6;
                txtp_occupation.Text = value7;
                txt_s_mob.Text = value8;
                txtP_mob.Text = value9;
                if (value10 == "" && value12 == "")
                {
                    datetdob.Text = "";
                    datet_admission.Text = "";
                }
                else
                {
                    datetdob.Value = DateTime.ParseExact(value10, "dd-MM-yyyy", null);
                    datet_admission.Value = DateTime.ParseExact(value14, "dd-MM-yyyy", null);
                }
                txtCollege.Text = value11;
                DataTable dtPosts = new DataTable();               
                comboadmission.Text = value12;
                lblAllocatedFees.Text = value13;
                value1 = ""; value2 = ""; value3 = ""; value4 = ""; value5 = ""; value6 = "";
                value7 = ""; value8 = ""; value9 = ""; value10 = ""; value11 = ""; value12 = "";
                value13 = ""; value14 = "";
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        public void metroButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtfname.Text) || !new Regex("^[a-zA-Z\\s]+$").IsMatch(txtfname.Text))
            {
                errorProvider1.SetError(txtfname, "Please enter valid Name");
            }
            else if (string.IsNullOrEmpty(txtmname.Text) || !new Regex("^[a-zA-Z\\s]+$").IsMatch(txtmname.Text))
            {
                errorProvider1.SetError(txtfname, null);
                errorProvider1.SetError(txtmname, "Please enter the Middel Name !");
            }
            else if (string.IsNullOrEmpty(txtsurname.Text) || !new Regex("^[a-zA-Z\\s]+$").IsMatch(txtsurname.Text))
            {
                errorProvider1.SetError(txtmname, null);
                errorProvider1.SetError(txtsurname, "Please enter the Surname Name !");
            }
            else if (string.IsNullOrEmpty(txtaddress.Text))
            {
                errorProvider1.SetError(txtsurname, null);
                errorProvider1.SetError(txtaddress, "Please enter the Address");
            }
            else if (string.IsNullOrEmpty(ComboBoxGender.Text))
            {
                errorProvider1.SetError(txtaddress, null);
                errorProvider1.SetError(ComboBoxGender, "Please select Gender");
            }
            else if (string.IsNullOrEmpty(datetdob.Text))
            {
                errorProvider1.SetError(ComboBoxGender, null);
                errorProvider1.SetError(datetdob, "Please select Date of Birth");
            }
            else if (string.IsNullOrEmpty(txtp_occupation.Text) || !new Regex("^[a-zA-Z\\s]+$").IsMatch(txtp_occupation.Text))
            {
                errorProvider1.SetError(datetdob, null);
                errorProvider1.SetError(ComboBoxGender, null);
                errorProvider1.SetError(txtp_occupation, "Please enter the Occupation");
            }

            else if (string.IsNullOrEmpty(txt_s_mob.Text) || !new Regex("^(\\+\\d{1,3}[-]?)?\\d{10}$").IsMatch(txt_s_mob.Text))
            {
                errorProvider1.SetError(txtp_occupation, null);
                errorProvider1.SetError(txt_s_mob, "Please enter valid Mobile No.");
            }
            else if (string.IsNullOrEmpty(txtP_mob.Text) || !new Regex("^(\\+\\d{1,3}[-]?)?\\d{10}$").IsMatch(txtP_mob.Text))
            {
                errorProvider1.SetError(txt_s_mob, null);
                errorProvider1.SetError(txtP_mob, "Please enter valid Mobile No.");
            }
            else if (string.IsNullOrEmpty(txtCollege.Text))
            {
                errorProvider1.SetError(txtP_mob, null);
                errorProvider1.SetError(txtCollege, "Please enter the College/School Name");
            }
            else if (string.IsNullOrEmpty(comboadmission.Text))
            {
                errorProvider1.SetError(txtCollege, null);
                errorProvider1.SetError(comboadmission, "Please select Course");
            }
            else if (string.IsNullOrEmpty(datet_admission.Text))
            {
                errorProvider1.SetError(comboadmission, null);
                errorProvider1.SetError(datet_admission, "Please select the Admisson Date");
            }
            else
            {
                errorProvider1.SetError(datet_admission, null);

                if (btnSave.Text == "Save")
                {
                    try
                    {
                        String query = "insert into student(f_name, m_name, s_name, s_address, gender, p_occupation, student_mob, parent_mob, dateofbirth, college_name, course, course_fee, admission_date) values('"
                            + txtfname.Text + "','" + txtmname.Text + "','" + txtsurname.Text + "','" + txtaddress.Text + "','"
                            + ComboBoxGender.Text + "','" + txtp_occupation.Text + "','" + txt_s_mob.Text + "','" + txtP_mob.Text + "','"
                            + datetdob.Text + "','" + txtCollege.Text + "','" + comboadmission.Text + "','"
                            + lblAllocatedFees.Text + "','" + datet_admission.Text + "');";
                        MySqlCommand mycommand = new MySqlCommand(query, Utility.GetConnection());
                        mycommand.ExecuteNonQuery();
                        long id = mycommand.LastInsertedId;
                        MessageBox.Show("Student Added successfully..!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        home1.gridviewdata(Convert.ToString(id));
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                    finally
                    {
                        this.Close();
                    }
                }
                if (btnSave.Text == "Update")
                {
                    try
                    {
                        String query = "update student set f_name = '" + txtfname.Text + "', m_name='" + txtmname.Text + "', s_name ='"
                                + txtsurname.Text + "', s_address='" + txtaddress.Text + "', gender ='" + ComboBoxGender.SelectedItem +
                                "', p_occupation='" + txtp_occupation.Text + "', student_mob =" + txt_s_mob.Text + ", parent_mob ="
                                + txtP_mob.Text + ", dateofbirth ='" + datetdob.Text + "', college_name ='" + txtCollege.Text +
                                "', course ='" + comboadmission.Text + "', course_fee ='" + lblAllocatedFees.Text + "', admission_date ='" + datet_admission.Text + "' where id = '" + Convert.ToInt16(id) + "';";
                        MySqlCommand mycommand = new MySqlCommand(query, Utility.GetConnection());
                        mycommand.ExecuteNonQuery();
                        MessageBox.Show("Student Updated successfully..!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        home1.gridviewdata(Convert.ToString(id));
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                    finally
                    {
                        this.Close();
                    }
                }
            }
        }

        public string saveButtonControl
        {
            get { return btnSave.Text; }
            set { btnSave.Text = value; }
        }
        private void btn_image_Click(object sender, EventArgs e)
        {

        }
        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            datet_admission.Text = "";
            datetdob.Text = "";
            // AddComboItem();           
        }
        private void comboadmission_ValueMemberChanged(object sender, EventArgs e)
        {

        }
        public void AddComboItem()
        {
            DataTable dtPosts = new DataTable();
            using (Utility.GetConnection())
            {
                using (mySqlDataAdapter = new MySqlDataAdapter("SELECT course FROM feestruct", Utility.GetConnection()))
                {
                    mySqlDataAdapter.Fill(dtPosts);
                }
            }
            //use LINQ method syntax to pull the Title field from a DT into a string array...
            string[] postSource = dtPosts
                                .AsEnumerable()
                                .Select<System.Data.DataRow, String>(x => x.Field<String>("course"))
                                .ToArray();
            comboadmission.Items.AddRange(postSource);
        }
        private void comboadmission_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String query = "Select course_fee from feestruct where course = '" + comboadmission.SelectedItem + "';";
                MySqlCommand mycommand = new MySqlCommand(query, Utility.GetConnection());
                string value = (string)mycommand.ExecuteScalar();
                lblAllocatedFees.Text = Convert.ToString(value);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            errorProvider1.SetError(comboadmission, null);
        }

        private void comboadmission_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtfname_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtmname_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtsurname_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtaddress_Validating(object sender, CancelEventArgs e)
        {

        }

        private void ComboBoxGender_Validating(object sender, CancelEventArgs e)
        {
        }

        private void datetdob_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtp_occupation_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtCollege_Validating(object sender, CancelEventArgs e)
        {

        }

        private void comboadmission_Validating(object sender, CancelEventArgs e)
        {

        }
        private void txt_s_mob_Click(object sender, EventArgs e)
        {

        }
        private void txtP_mob_Validating(object sender, CancelEventArgs e)
        {
        }

        private void txt_s_mob_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtP_mob_Validated(object sender, EventArgs e)
        {

        }

        private void txtfname_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtfname, null);
        }

        private void txtmname_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtmname, null);
        }

        private void txtsurname_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtsurname, null);
        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtaddress, null);
        }

        private void ComboBoxGender_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(ComboBoxGender, null);
        }

        private void txtp_occupation_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtp_occupation, null);
        }

        private void txt_s_mob_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txt_s_mob, null);
        }

        private void txtP_mob_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtP_mob, null);
        }

        private void txtCollege_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtCollege, null);
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboadmission_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                String query = "Select course_fee from feestruct where course = '" + comboadmission.SelectedItem + "';";
                MySqlCommand mycommand = new MySqlCommand(query, Utility.GetConnection());
                string value = (string)mycommand.ExecuteScalar();
                lblAllocatedFees.Text = Convert.ToString(value);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void comboadmission_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                String query = "Select course_fee from feestruct where course = '" + comboadmission.SelectedItem + "';";
                MySqlCommand mycommand = new MySqlCommand(query, Utility.GetConnection());
                string value = (string)mycommand.ExecuteScalar();
                lblAllocatedFees.Text = Convert.ToString(value);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}