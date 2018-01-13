using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using System.Threading;

namespace MS_CIT
{
    public partial class SecurityForm : MetroForm
    {
        MySqlCommand mycommand;
        public static bool SECURITY_CHECK = false;
        public SecurityForm()
        {
            InitializeComponent();
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.WorkerReportsProgress = true;
        }
        private void SecurityForm_Load(object sender, EventArgs e)
        {
            
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
           
            if (new Regex("(LINKER)\\-([0-9]{2})\\-(IT)\\-([0-5]{2})\\-(SOLUTIONS)\\-([0-9]{5})").IsMatch(txtKey.Text))
            {
                string serverIp = "185.224.137.8";
                string port = "3306";
                string username = "u478198330_root";
                string password = "Linker@70531";
                string database = "u478198330_skey";

                string dbConnectionString = string.Format("server={0};port={4};database={3};uid={1};pwd={2}", serverIp, username, password, database, port);

                var con = new MySql.Data.MySqlClient.MySqlConnection(dbConnectionString);
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    String query = "select date from clients where serial_key='" + txtKey.Text + "'";
                    mycommand = new MySqlCommand(query, con);
                    var a = mycommand.ExecuteScalar().ToString();
                    if (!a.Equals(""))
                    {
                        MessageBox.Show("Authentication is Successful..!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (!Directory.Exists("C:\\MS-CIT\\FirstRun"))
                        {
                            Directory.CreateDirectory("C:\\MS-CIT\\FirstRun");
                        }
                        if (!File.Exists("C:\\MS-CIT\\FirstRun\\DoNotDelete.txt"))
                        {
                            string createText = CryptorEngine.Encrypt(a.ToString(), true);
                            FileStream tt = new FileStream("C:\\MS-CIT\\FirstRun\\DoNotDelete.txt", FileMode.OpenOrCreate, FileAccess.Write);
                            StreamWriter writer = new StreamWriter(tt);
                            writer.Write(createText);
                            writer.Close();
                        }
                        SECURITY_CHECK = true;
                        Dispose();                        
                    }
                    else
                    {
                        MessageBox.Show("Authentication is Unsuccessfull check for serial key or contact administrator...!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                        SECURITY_CHECK = false;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Incorrect Key", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SECURITY_CHECK = false;                
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {                
                backgroundWorker1.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            ProgressBar1.Value = e.ProgressPercentage;
        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
