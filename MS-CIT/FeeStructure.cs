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
using System.Text.RegularExpressions;

namespace MS_CIT
{
    public partial class FeeStructure : MetroForm
    {
        private MySqlDataAdapter mySqlDataAdapter;
        public FeeStructure()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshDataGridview();
            addComboItem();
        }
        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }
        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }
        public void addComboItem()
        {        
            string query2 = "select course from feestruct;";
            MySqlCommand cmd;
            cmd = new MySqlCommand(query2, Utility.GetConnection());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    comboBoxCourses.Items.Add(row.ItemArray[0].ToString());
                    comboBoxCourses.SelectedItem = "";
                }
            }
        }
        public void refreshDataGridview()
        {
            mySqlDataAdapter = new MySqlDataAdapter("select course as 'Course Name',course_fee as 'Fees' from feestruct;", Utility.GetConnection());
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            dataGridView2.DataSource = DS.Tables[0];
        }
        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void txtCourseName_TextChanged(object sender, EventArgs e)
        {
            if (txtCourseName.Text != "")
            {
                errorProvider1.SetError(txtCourseName, null);
            }
            else if (txtCourseName.Text == "")
            {
                errorProvider1.SetError(txtCourseName, "Enter Course Name");
            }
        }

        private void txtCourseFees_TextChanged(object sender, EventArgs e)
        {
            if (txtCourseFees.Text != "" && new Regex("^[-+]?\\d+(\\.\\d+)?$").IsMatch(txtCourseFees.Text))
            {
                errorProvider1.SetError(txtCourseFees, null);
            }

            else if (txtCourseFees.Text == "" || !new Regex("^[-+]?\\d+(\\.\\d+)?$").IsMatch(txtCourseFees.Text))
            {
                errorProvider1.SetError(txtCourseFees, "Enter valid amount");
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCourseName.Text) || !new Regex("^[a-zA-Z\\s]+$").IsMatch(txtCourseName.Text))
            {
                errorProvider1.SetError(txtCourseName, "Enter Valid Course Name");
            }
            else if (string.IsNullOrEmpty(txtCourseFees.Text) || !new Regex("^[-+]?\\d+(\\.\\d+)?$").IsMatch(txtCourseFees.Text))
            {
                errorProvider1.SetError(txtCourseName, null);
                errorProvider1.SetError(txtCourseFees, "Enter Valid Amount");
            }
            else
            {
                errorProvider1.SetError(txtCourseFees, null);
                try
                {
                    String query = "insert into feestruct(course,course_fee) values('" + txtCourseName.Text + "','" + txtCourseFees.Text + "');";
                    MySqlCommand mycommand = new MySqlCommand(query, Utility.GetConnection());
                    mycommand.ExecuteNonQuery();
                    refreshDataGridview();
                    MessageBox.Show("Course/Class Added successfully..!");
                    txtCourseFees.Text = "";
                    txtCourseName.Text = "";
                    comboBoxCourses.Items.Clear();
                    addComboItem();

                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
        }

        private void metroButton1_Click_2(object sender, EventArgs e)
        {
            if (comboBoxCourses.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Sure to Remove Course ?", "Remove Course From Database", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        String query = "delete from feestruct where course='" + comboBoxCourses.SelectedItem + "';";
                        MySqlCommand mycommand = new MySqlCommand(query, Utility.GetConnection());
                        mycommand.ExecuteNonQuery();
                        MessageBox.Show("Course Deleted successfully..!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comboBoxCourses.Items.Clear();
                        refreshDataGridview();
                        addComboItem();
                    }
                    catch (Exception d)
                    {
                        MessageBox.Show(d.Message);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                }
            }
            else
            {
                MessageBox.Show("Select Course", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCourseName_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtCourseName,null);
        }

        private void txtCourseFees_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtCourseFees, null);
        }
    }
}
