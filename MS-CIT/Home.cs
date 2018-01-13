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
using System.ServiceProcess;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.IO;

namespace MS_CIT
{
    public partial class Home : MetroForm
    {
        int ScreenHight, ScreenWidth, id;
        string value1 = "", value2 = "", value3 = "", value4 = "", value5 = "", value6 = "", value7 = "", value8 = "", value9 = "", value10 = "", value11 = "", value12 = "", value13 = "", value14 = "";
        MySqlDataAdapter mySqlDataAdapter;

        private void metroTile6_Click(object sender, EventArgs e)
        {
            OfficeExpense ofe = new OfficeExpense();
            ofe.ShowDialog();
        }

        System.Windows.Forms.Timer tmr = null;
        private void StartTimer()
        {
            tmr = new System.Windows.Forms.Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Enabled = true;
        }

        private void time_lbl_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            BusinessStatus bs = new BusinessStatus();
            bs.ShowDialog();
        }

        private void feeStructureToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FeeStructure frm = new FeeStructure();
            frm.ShowDialog();
        }
        private void metroTile4_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            u.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {            
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            time_lbl.Text = DateTime.Now.ToString();
        }
        public Home()
        {
            InitializeComponent();
        }
        private void Home_Load(object sender, EventArgs e)
        {            
            StartTimer();
            ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            ScreenHight = Screen.PrimaryScreen.Bounds.Height;
            this.ClientSize = new System.Drawing.Size(ScreenWidth, ScreenHight);
            gridviewdata(Convert.ToString(null));
            AddToolTip.SetToolTip(metroTile3, "Add Student");
            AddToolTip.SetToolTip(metroTile2, "Update Student profile");
            AddToolTip.SetToolTip(metroTile4, "Remove Student from database");
            AddToolTip.SetToolTip(metroTile7, "Pay Fees");
            AddToolTip.SetToolTip(metroTile6, "Add Office Expenses");
            AddToolTip.SetToolTip(metroTile1, "Fees Status");
            DataTable dtPosts = new DataTable();
            using (Utility.GetConnection())
            {
                using (mySqlDataAdapter = new MySqlDataAdapter("SELECT expense_type FROM office_expenses", Utility.GetConnection()))
                {
                    mySqlDataAdapter.Fill(dtPosts);
                }
            }
            string[] postSource = dtPosts
                                   .AsEnumerable()
                                   .Select<System.Data.DataRow, String>(x => x.Field<String>("expense_type"))
                                   .ToArray();

            var source = new AutoCompleteStringCollection();
            source.AddRange(postSource);
        }


        public void gridviewdata(string id)
        {
            try
            {
                MySqlDataAdapter mySqlDataAdapter;
                mySqlDataAdapter = new MySqlDataAdapter("select id as 'ID', f_name as 'First Name',m_name as 'Middle Name', s_name as 'Suranme',s_address as 'Address', gender as 'Gender',student_mob as 'Student Mob.No.',parent_mob as 'Parent Mob.No.',course as 'Course Name',course_fee as 'Allocated fees',paid_fee as 'Paid Fees',(cast(course_fee as decimal) - cast(paid_fee as decimal) ) as 'Balance Fee',admission_date as 'Admission Date',dateofbirth as 'BirthDate',p_occupation as 'Parent Occupation',college_name as 'School/College Name' from student;", Utility.GetConnection());
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                metroGrid1.DataSource = DS.Tables[0];
                metroGrid1.Refresh();
                metroGrid1.Update();
                foreach (DataGridViewRow row in metroGrid1.Rows)
                {
                    if (row.Cells[0].Value.ToString() == id)
                        row.Selected = true;
                }
                metroGrid1.FirstDisplayedScrollingRowIndex = metroGrid1.SelectedRows[0].Index;
            }
            catch (ArgumentOutOfRangeException)
            {

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        private void metroTile3_Click(object sender, EventArgs e)
        {
            Form frm = new AddStudent();
            frm.ShowDialog();
        }
        private void metroTile2_Click(object sender, EventArgs e)
        {

            if (metroGrid1.SelectedCells.Count > 0)
            {
                foreach (DataGridViewRow row in metroGrid1.SelectedRows)
                {
                    value1 = row.Cells[0].Value.ToString();
                    value2 = row.Cells[1].Value.ToString();
                    value3 = row.Cells[2].Value.ToString();
                    value4 = row.Cells[3].Value.ToString();
                    value5 = row.Cells[4].Value.ToString();
                    value6 = row.Cells[5].Value.ToString();
                    value7 = row.Cells[14].Value.ToString();
                    value8 = row.Cells[6].Value.ToString();
                    value9 = row.Cells[7].Value.ToString();
                    value10 = row.Cells[13].Value.ToString();
                    value11 = row.Cells[15].Value.ToString();
                    value12 = row.Cells[8].Value.ToString();
                    value13 = row.Cells[9].Value.ToString();
                    value14 = row.Cells[12].Value.ToString();
                }
                try
                {
                    AddStudent ads = new AddStudent();
                    ads.setUpdatedValues(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
                    ads.saveButtonControl = "Update";
                    ads.ShowDialog();

                }
                catch (Exception pp)
                {

                    MessageBox.Show(pp.Message);
                }
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter mySqlDataAdapter;
                mySqlDataAdapter = new MySqlDataAdapter("select id as 'ID', f_name as 'First Name',m_name as 'Middle Name', s_name as 'Suranme',s_address as 'Address', gender as 'Gender',student_mob as 'Student Mob.No.',parent_mob as 'Parent Mob.No.',course as 'Course Name',course_fee as 'Allocated fees',paid_fee as 'Paid Fees',unpaid_fee as 'Balance Fee',admission_date as 'Admission Date',dateofbirth as 'BirthDate',p_occupation as 'Parent Occupation',college_name as 'School/College Name' from student where (f_name like '" + txtSearch.Text + "%' or m_name like '" + txtSearch.Text + "%' or s_name like '" + txtSearch.Text + "%')", Utility.GetConnection());
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                metroGrid1.DataSource = DS.Tables[0];
                metroGrid1.Refresh();
                metroGrid1.Update();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            string value1 = null;
            if (metroGrid1.SelectedCells.Count > 0)
            {
                foreach (DataGridViewRow row in metroGrid1.SelectedRows)
                {
                    value1 = row.Cells[0].Value.ToString();
                }
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Sure to Remove student ?", "Remove Student From Database", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        String query = "delete from student where id=" + Convert.ToInt16(value1) + " ;";
                        MySqlCommand mycommand = new MySqlCommand(query, Utility.GetConnection());
                        mycommand.ExecuteNonQuery();
                        gridviewdata(value1);
                        MessageBox.Show("Student Deleted successfully..!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                    }

                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
        }

        private void feeStructureToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedCells.Count > 0)
            {
                string student_id = null, Name = null;

                foreach (DataGridViewRow row in metroGrid1.SelectedRows)
                {
                    student_id = row.Cells[0].Value.ToString();
                    Name = row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString() + " " + row.Cells[3].Value.ToString();
                }
                try
                {
                    Pay_Fees pff = new Pay_Fees();
                    pff.setUpdatedValues(student_id, Name);
                    pff.ShowDialog();
                }
                catch (Exception pp)
                {

                    MessageBox.Show(pp.Message);
                }
            }
        }

        private void metroGrid1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
