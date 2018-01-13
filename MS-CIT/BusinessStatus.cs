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

namespace MS_CIT
{
    public partial class BusinessStatus : MetroForm
    {
        MySqlDataAdapter mySqlDataAdapter;
        public BusinessStatus()
        {
            InitializeComponent();
        }

        private void Business_Load(object sender, EventArgs e)
        {
            try
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
                metroComboBox1.Items.AddRange(postSource);
            }
            catch (Exception ww)
            {
                MessageBox.Show(ww.Message);
            }

        }

        private void lblTotalPaid_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            string allocated = null;
            string paid = null;
            lblToatalBalance.Text = "";
            lblTotalAllocated.Text = "";
            lblTotalPaid.Text = "";

            DataTable dt = new DataTable();
            try
            {
                string query = "select sum(course_fee) as allocated_fees,sum(paid_fee) as paid_fees from student where course = '" + metroComboBox1.Text + "' and (admission_date between '" + metroDateTime1.Text + "' and '" + metroDateTime2.Text + "');";
                MySqlCommand mycommand = new MySqlCommand(query, Utility.GetConnection());

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mycommand);
                mySqlDataAdapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    allocated = row[0].ToString();
                    paid = row[1].ToString();
                }
                double total = 0;
                if (allocated == "" || paid == "")
                {
                    MessageBox.Show("No Admissons or course between given dates..! ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    total = Convert.ToDouble(allocated) - Convert.ToDouble(paid);
                    lblToatalBalance.Text = Convert.ToString("Rs. " + total);
                    lblTotalAllocated.Text = "Rs. " + allocated;
                    lblTotalPaid.Text = "Rs. " + paid;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroComboBox1_KeyUp(object sender, KeyEventArgs e)
        {

            string allocated = null;
            string paid = null;
            lblToatalBalance.Text = "";
            lblTotalAllocated.Text = "";
            lblTotalPaid.Text = "";

            DataTable dt = new DataTable();
            try
            {
                string query = "select sum(course_fee) as allocated_fees,sum(paid_fee) as paid_fees from student where course = '" + metroComboBox1.Text + "' and (admission_date between '" + metroDateTime1.Text + "' and '" + metroDateTime2.Text + "');";
                MySqlCommand mycommand = new MySqlCommand(query, Utility.GetConnection());

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mycommand);
                mySqlDataAdapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    allocated = row[0].ToString();
                    paid = row[1].ToString();
                }
                double total = 0;
                if (allocated == "" || paid == "")
                {
                    MessageBox.Show("No Admissons or course between given dates..! ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    total = Convert.ToDouble(allocated) - Convert.ToDouble(paid);
                    lblToatalBalance.Text = Convert.ToString("Rs. " + total);
                    lblTotalAllocated.Text = "Rs. " + allocated;
                    lblTotalPaid.Text = "Rs. " + paid;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroComboBox1_KeyDown(object sender, KeyEventArgs e)
        {

            string allocated = null;
            string paid = null;
            lblToatalBalance.Text = "";
            lblTotalAllocated.Text = "";
            lblTotalPaid.Text = "";

            DataTable dt = new DataTable();
            try
            {
                string query = "select sum(course_fee) as allocated_fees,sum(paid_fee) as paid_fees from student where course = '" + metroComboBox1.Text + "' and (admission_date between '" + metroDateTime1.Text + "' and '" + metroDateTime2.Text + "');";
                MySqlCommand mycommand = new MySqlCommand(query, Utility.GetConnection());

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mycommand);
                mySqlDataAdapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    allocated = row[0].ToString();
                    paid = row[1].ToString();
                }
                double total = 0;
                if (allocated == "" || paid == "")
                {
                    MessageBox.Show("No Admissons or course between given dates..! ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    total = Convert.ToDouble(allocated) - Convert.ToDouble(paid);
                    lblToatalBalance.Text = Convert.ToString("Rs. " + total);
                    lblTotalAllocated.Text = "Rs. " + allocated;
                    lblTotalPaid.Text = "Rs. " + paid;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
