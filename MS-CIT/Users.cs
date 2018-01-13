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
    public partial class Users : MetroForm
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter mySqlDataAdapter;
                mySqlDataAdapter = new MySqlDataAdapter("select id as 'ID', username as 'User Name',password as 'Password' from users;", Utility.GetConnection());
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                metroGrid1.DataSource = DS.Tables[0];
                metroGrid1.Refresh();
                metroGrid1.Update();
            }
            catch (ArgumentOutOfRangeException)
            {

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
