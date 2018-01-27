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
    public partial class AddBatches : MetroForm
    {
        MySqlCommand mycommand;
        MySqlDataAdapter mySqlDataAdapter;
        public AddBatches()
        {
            InitializeComponent();
        }
        private void AddBatches_Load(object sender, EventArgs e)
        {
            gridviewBatch();
            addAcademicYearItems();
        }

        private void addAcademicYearItems()
        {
            DataTable dtPosts = new DataTable();
            using (Utility.GetConnection())
            {
                using (mySqlDataAdapter = new MySqlDataAdapter("SELECT batch FROM batches", Utility.GetConnection()))
                {
                    mySqlDataAdapter.Fill(dtPosts);
                }
            }
            string[] batch = dtPosts
                                   .AsEnumerable()
                                   .Select<System.Data.DataRow, String>(x => x.Field<String>("batch"))
                                   .ToArray();
            var source = new AutoCompleteStringCollection();
            metroComboBox1.Items.AddRange(batch);
        }
        private void gridviewBatch()
        {
            mySqlDataAdapter = new MySqlDataAdapter("select batch as 'Academic Batch' from batches;", Utility.GetConnection());
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            metroGrid1.DataSource = DS.Tables[0];
            metroGrid2.DataSource = DS.Tables[0];
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

            if (txtStartMonth.Text == "")
            {
                errorProvider1.SetError(txtStartMonth, "Select Start Month");
            }
            else if (txtStartYear.Text == "")
            {
                errorProvider1.SetError(txtStartMonth, null);
                errorProvider1.SetError(txtStartYear, "Select Start Year");
            }
            else if (txtEndMonth.Text == "")
            {
                errorProvider1.SetError(txtStartYear, null);
                errorProvider1.SetError(txtEndMonth, "Select End Month");
            }
            else if (txtEndYear.Text == "")
            {
                errorProvider1.SetError(txtEndMonth, null);
                errorProvider1.SetError(txtEndYear, "Select End Year");
            }
            else
            {
                errorProvider1.SetError(txtEndYear, null);
                try
                {
                    String query = "insert into batches(batch) values('" + txtStartMonth.Text + "_" + txtStartYear.Text + "-" + txtEndMonth.Text + "_" + txtEndYear.Text + "');";
                    mycommand = new MySqlCommand(query, Utility.GetConnection());
                    int a = mycommand.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Batch Added successfully..!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridviewBatch(); 
                        txtEndMonth.Text = "";
                        txtEndYear.Text = "";
                        txtStartMonth.Text = "";
                        txtStartYear.Text = "";                      
                    }
                    else
                    {
                        MessageBox.Show("Batch not added..!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Sure to Remove Batch ?", "Remove Batch From List", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        String query = "delete from batches where batch ='" + metroComboBox1.SelectedItem + "';";
                        MySqlCommand mycommand = new MySqlCommand(query, Utility.GetConnection());
                        int a = mycommand.ExecuteNonQuery();
                        if (a > 0)
                        {
                            MessageBox.Show("Batch Deleted successfully..!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            gridviewBatch();
                            metroComboBox1.Items.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Batch not removed..!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception d)
                    {
                        MessageBox.Show(d.Message);
                    }
                    addAcademicYearItems();
                }
                else if (dialogResult == DialogResult.No)
                {
                }
            }
            else
            {
                MessageBox.Show("Select Batch", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void metroTabControl2_Selecting(object sender, TabControlCancelEventArgs e)
        {
            metroComboBox1.Items.Clear();
            addAcademicYearItems();
        }
        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
