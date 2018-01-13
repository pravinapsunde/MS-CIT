using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using MetroFramework.Fonts;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace MS_CIT
{
    public partial class Pay_Fees : MetroForm
    {
        int id = 0;
        string Name = null;
        Home home1 = (Home)Application.OpenForms["Home"];
        MySqlDataAdapter mySqlDataAdapter;
        MySqlCommand mycommand;
        private int xPos = 0;
        public Pay_Fees()
        {
            InitializeComponent();
        }
        
        private void Pay_Fees_Load(object sender, EventArgs e)
        {
            timer1.Start();
            try
            {               
                String query = "SELECT COUNT(*) FROM student_fees WHERE student_id="+id+";";                
                mycommand = new MySqlCommand(query, Utility.GetConnection());
                string value = ""+ (Convert.ToInt16( mycommand.ExecuteScalar()) +1);
                lblInstallmentNo.Text = value;
                lblName.Text = Name;
                showTotals();            
                gridviewdata();                
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        public void showTotals()
        {
            String TotalStatus = "SELECT course_fee, paid_fee, unpaid_fee FROM student WHERE id=" + id + ";";
            mycommand = new MySqlCommand(TotalStatus, Utility.GetConnection());
            var reader = mycommand.ExecuteReader();
            while (reader.Read())
            {
                // here could be problems if database value is null
                var allocated = reader["course_fee"];
                var paid = reader["paid_fee"];
                lblAllocated.Text = Convert.ToString(allocated);
                lblPaid.Text = Convert.ToString(paid);
                lblPending.Text = Convert.ToString(Convert.ToDouble(allocated) - Convert.ToDouble(paid));
            }
        }
        public void gridviewdata()
        {
            mySqlDataAdapter = new MySqlDataAdapter("select installment_no as 'Installment No.', payment_date as 'Payment Date', payment_method as 'Payment Method', amount as 'Amount', paid_by as 'Paid By', received_by as 'Received By' from student_fees where student_id ='" + id + "'; ", Utility.GetConnection());
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            metroGrid1.DataSource = DS.Tables[0];
            metroGrid1.Refresh();
            metroGrid1.Update();
        }
        public void setUpdatedValues(string value1 ,string value2)
        {
            try
            {
                id = Convert.ToInt16(value1);
                Name = value2;
                
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text == "" || !new Regex("^[-+]?\\d+(\\.\\d+)?$").IsMatch(txtAmount.Text))
            {
                errorProvider1.SetError(txtAmount, "Enter valid amount");
            }
            else if (comboPaymentMethod.Text == "")
            {
                errorProvider1.SetError(txtAmount, null);
                errorProvider1.SetError(comboPaymentMethod, "Select Payment Method");
            }
            else if (txtPaymentDesc.Text == "")
            {
                errorProvider1.SetError(comboPaymentMethod, null);
                errorProvider1.SetError(txtPaymentDesc, "Enter Payment Description");
            }
            else if (txtPaidBy.Text == "" || !new Regex("^[a-zA-Z\\s]+$").IsMatch(txtPaidBy.Text))
            {
                errorProvider1.SetError(txtPaymentDesc, null);
                errorProvider1.SetError(txtPaidBy, "Enter Name of Payee");
            }
            else if (txtReceivedBy.Text == "" || !new Regex("^[a-zA-Z\\s]+$").IsMatch(txtReceivedBy.Text))
            {
                errorProvider1.SetError(txtPaidBy, null);
                errorProvider1.SetError(txtReceivedBy, "Enter Name of payment Received by");
            }
            else
            {
                errorProvider1.SetError(txtReceivedBy, null);
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Sure Amount ?", "Create Trasaction", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Home h = new Home();
                        String query = "insert into student_fees(student_id, payment_date, installment_no, amount, payment_method, payment_desc, paid_by, received_by) values(" + id + ", '" + datepayment.Text + "', '" + lblInstallmentNo.Text + "', '" + txtAmount.Text + "', '" + comboPaymentMethod.Text + "', '" + txtPaymentDesc.Text + "', '" + txtPaidBy.Text + "', '" + txtReceivedBy.Text + "');";
                        MySqlCommand mycommand = new MySqlCommand(query, Utility.GetConnection());
                        mycommand.ExecuteNonQuery();

                        String query1 = "Select paid_fee from student where id = " + id + ";";
                        mycommand = new MySqlCommand(query1, Utility.GetConnection());
                        string paid_fee = (string)mycommand.ExecuteScalar();

                        String query2 = "update student set paid_fee = '" + ((Convert.ToInt16(paid_fee) + Convert.ToInt16(txtAmount.Text))) + "' where id = " + id + ";";
                        mycommand = new MySqlCommand(query2, Utility.GetConnection());
                        mycommand.ExecuteNonQuery();
                        btnSave.Visible = false;
                        MessageBox.Show("Payment Added successfully..!","",MessageBoxButtons.OK, MessageBoxIcon.Information);                        
                        showTotals();
                        gridviewdata();
                        home1.gridviewdata(Convert.ToString(id));
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
                finally
                {
                    txtAmount.Text = "";
                    txtPaidBy.Text = "";
                    txtPaymentDesc.Text = "";
                    txtReceivedBy.Text = "";
                    comboPaymentMethod.Text = "";
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Width == xPos)
            {
                //repeat marquee
                this.lblMarquee.Location = new System.Drawing.Point(164, 472);
                xPos = 0;
            }
            else
            {
                this.lblMarquee.Location = new System.Drawing.Point(xPos, 472);
                xPos++;
            }
        }
    }
}
