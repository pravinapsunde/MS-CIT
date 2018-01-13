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
    public partial class OfficeExpense : MetroForm
    {
        string Selectedid = null;
        string value1 = null;
        MySqlDataAdapter mySqlDataAdapter;
        public OfficeExpense()
        {
            InitializeComponent();
        }
        public void gridviewdata(string id)
        {           
            try
            {
                MySqlDataAdapter mySqlDataAdapter;
                mySqlDataAdapter = new MySqlDataAdapter("select id as 'ID', expense_type as 'Expense Type',description as 'Exp Description',amount as 'Amount',payment_method as 'Payment Method',payment_descrition as 'Payment Description',paid_by as 'Paid By',received_by as 'Received By' from office_expenses;", Utility.GetConnection());
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
                String query = "select sum(amount) from office_expenses";
                MySqlCommand mycommand = new MySqlCommand(query, Utility.GetConnection());
                mycommand.ExecuteNonQuery();
                double sum = (double)mycommand.ExecuteScalar();
                lblTotalExpense.Text = Convert.ToString(sum);

            }
            catch (Exception)
            {
                throw;
            }
        }
        private void OfficeExpense_Load(object sender, EventArgs e)
        {
            try
            {
                gridviewdata(null);
                foreach (DataGridViewRow row in metroGrid1.Rows)
                {
                    if (row.Cells[0].Value.ToString() == Selectedid)
                        row.Selected = true;
                }
                // code fro retriving comboitems
                DataTable dtPosts = new DataTable();
                using (Utility.GetConnection())
                {
                    using (mySqlDataAdapter = new MySqlDataAdapter("SELECT expense_type FROM office_expenses", Utility.GetConnection()))
                    {
                        mySqlDataAdapter.Fill(dtPosts);
                    }
                }
                //use LINQ method syntax to pull the Title field from a DT into a string array...
                string[] postSource = dtPosts
                                    .AsEnumerable()
                                    .Select<System.Data.DataRow, String>(x => x.Field<String>("expense_type"))
                                    .ToArray();

                var source = new AutoCompleteStringCollection();
                source.AddRange(postSource);
                txtExpType.AutoCompleteCustomSource = source;
                txtExpType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtExpType.AutoCompleteSource = AutoCompleteSource.CustomSource;
                metroGrid1.FirstDisplayedScrollingRowIndex = metroGrid1.SelectedRows[0].Index;
            }
            catch (Exception)
            {
                //MessageBox.Show(ee.Message);
            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBoxExpeType_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void OfficeExpense_Click(object sender, EventArgs e)
        {

        }

        private void OfficeExpense_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void tileSearch_Click(object sender, EventArgs e)
        {

        }

        private void OfficeExpense_MouseHover(object sender, EventArgs e)
        {

        }

        private void OfficeExpense_MouseEnter(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {

            if (metroGrid1.SelectedCells.Count > 0)
            {
                foreach (DataGridViewRow row in metroGrid1.SelectedRows)
                {
                    value1 = row.Cells[0].Value.ToString();
                    string value2 = row.Cells[1].Value.ToString();
                    string value3 = row.Cells[2].Value.ToString();
                    string value4 = row.Cells[3].Value.ToString();
                    string value5 = row.Cells[4].Value.ToString();
                    string value6 = row.Cells[5].Value.ToString();
                    string value7 = row.Cells[6].Value.ToString();
                    string value8 = row.Cells[7].Value.ToString();

                    txtExpType.Text = value2;
                    txtExpeDesc.Text = value3;
                    txtAmount.Text = value4;
                    txtPaymentMethod.Text = value5;
                    txtPayDesc.Text = value6;
                    txtPaidBy.Text = value7;
                    txtReceivedBy.Text = value8;
                }
                btnSave.Text = "Update";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
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
                    DialogResult dialogResult = MessageBox.Show("Sure to Remove Expense ?", "Remove Expense From Database", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        String query = "delete from office_expenses where id=" + Convert.ToInt16(value1) + " ;";
                        MySqlCommand mycommand = new MySqlCommand(query, Utility.GetConnection());
                        mycommand.ExecuteNonQuery();
                        gridviewdata(value1);
                        MessageBox.Show("Expense Deleted successfully..!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtExpType.Text = "";
            txtExpeDesc.Text = "";
            txtAmount.Text = "";
            txtPaymentMethod.Text = "";
            txtPayDesc.Text = "";
            txtPaidBy.Text = "";
            txtReceivedBy.Text = "";
            btnSave.Text = "Submit";
            txtSearch.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtExpType.Text) || !new Regex("^[a-zA-Z\\s]+$").IsMatch(txtExpType.Text))
            {
                errorProvider1.SetError(txtExpType, "Please enter valid Expense Type !");
            }
            else if (string.IsNullOrEmpty(txtExpeDesc.Text) || !new Regex("^[a-zA-Z\\s]+$").IsMatch(txtExpeDesc.Text))
            {
                errorProvider1.SetError(txtExpType, null);
                errorProvider1.SetError(txtExpeDesc, "Please enter valid Expense Description !");
            }
            else if (string.IsNullOrEmpty(txtAmount.Text) || !new Regex("^[-+]?\\d+(\\.\\d+)?$").IsMatch(txtAmount.Text))
            {
                errorProvider1.SetError(txtExpeDesc, null);
                errorProvider1.SetError(txtAmount, "Please enter valid amount !");
            }
            else if (string.IsNullOrEmpty(txtPayDesc.Text) || !new Regex("^[a-zA-Z\\s]+$").IsMatch(txtPayDesc.Text))
            {
                errorProvider1.SetError(txtAmount, null);
                errorProvider1.SetError(txtPayDesc, "Please enter valid Payment Description !");
            }
            else if (string.IsNullOrEmpty(txtPaymentMethod.Text) || !new Regex("^[a-zA-Z\\s]+$").IsMatch(txtPaymentMethod.Text))
            {
                errorProvider1.SetError(txtPayDesc, null);
                errorProvider1.SetError(txtPaymentMethod, "Please select Payment Method !");
            }
            else if (string.IsNullOrEmpty(txtPaidBy.Text) || !new Regex("^[a-zA-Z\\s]+$").IsMatch(txtPaidBy.Text))
            {
                errorProvider1.SetError(txtPaymentMethod, null);
                errorProvider1.SetError(txtPaidBy, "Please enter name of Amount Paid By !");
            }
            else if (string.IsNullOrEmpty(txtReceivedBy.Text) || !new Regex("^[a-zA-Z\\s]+$").IsMatch(txtReceivedBy.Text))
            {
                errorProvider1.SetError(txtPaidBy, null);
                errorProvider1.SetError(txtReceivedBy, "Please enter name of Amount Received By !");
            }
            else
            {
                errorProvider1.SetError(txtReceivedBy, null);
                if (btnSave.Text == "Submit")
                {
                    long rowSelectid = 0;
                    try
                    {
                        String query = "insert into office_expenses(expense_type,description,amount,payment_method,payment_descrition,paid_by,received_by) values('" + txtExpType.Text + "','" + txtExpeDesc.Text + "','" + txtAmount.Text + "','" + txtPaymentMethod.Text + "','" + txtPayDesc.Text + "','" + txtPaidBy.Text + "','" + txtReceivedBy.Text + "');";
                        MySqlCommand mycommand = new MySqlCommand(query, Utility.GetConnection());
                        mycommand.ExecuteNonQuery();
                        MessageBox.Show("Expense Added successfully..!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rowSelectid = mycommand.LastInsertedId;
                        gridviewdata(Convert.ToString(rowSelectid));
                        foreach (DataGridViewRow row in metroGrid1.Rows)
                        {
                            if (row.Cells[0].Value.ToString() == Selectedid)
                                row.Selected = true;
                        }
                        txtExpType.Text = "";
                        txtExpeDesc.Text = "";
                        txtAmount.Text = "";
                        txtPaymentMethod.Text = "";
                        txtPayDesc.Text = "";
                        txtPaidBy.Text = "";
                        txtReceivedBy.Text = "";
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                    finally
                    {

                    }
                }
                if (btnSave.Text == "Update")
                {
                    try
                    {
                        String query = "update office_expenses set expense_type = '" + txtExpType.Text + "', description='" + txtExpeDesc.Text + "', amount ='"
                                + txtAmount.Text + "', payment_method='" + txtPaymentMethod.Text + "', payment_descrition ='" + txtPayDesc.Text +
                                "', paid_by='" + txtPaidBy.Text + "', received_by ='" + txtReceivedBy.Text + "' where id = " + value1 + ";";
                        MySqlCommand mycommand = new MySqlCommand(query, Utility.GetConnection());
                        mycommand.ExecuteNonQuery();
                        MessageBox.Show("Expense Updated successfully..!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridviewdata(Convert.ToString(value1));
                        txtExpType.Text = "";
                        txtExpeDesc.Text = "";
                        txtAmount.Text = "";
                        txtPaymentMethod.Text = "";
                        txtPayDesc.Text = "";
                        txtPaidBy.Text = "";
                        txtReceivedBy.Text = "";
                        btnSave.Text = "Submit";
                    }
                    catch (Exception pp)
                    {
                        MessageBox.Show(pp.Message);
                    }
                }
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
                txtExpType.AutoCompleteCustomSource = source;
                txtExpType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtExpType.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter mySqlDataAdapter;
                mySqlDataAdapter = new MySqlDataAdapter("select id as 'ID', expense_type as 'Expense Type', description as 'Exp Description', amount as 'Amount', payment_method as 'Payment Method', payment_descrition as 'Payment Description', paid_by as 'Paid By', received_by as 'Received By' from office_expenses where (expense_type like '" + txtSearch.Text + "%' or description like '" + txtSearch.Text + "%' or paid_by like '" + txtSearch.Text + "%' or received_by like '" + txtSearch.Text + "%' or payment_method  like '" + txtSearch.Text + "%')", Utility.GetConnection());
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

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtExpType_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtExpType, null);
        }

        private void txtExpeDesc_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtExpeDesc, null);
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtAmount, null);
        }

        private void txtPayDesc_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPayDesc, null);
        }

        private void txtPaymentMethod_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPaymentMethod, null);
        }

        private void txtPaidBy_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPaidBy, null);
        }

        private void txtReceivedBy_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtReceivedBy, null);
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
