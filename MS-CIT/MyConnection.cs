using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MS_CIT
{
    internal class MyConnection
    {
        //Constructor
        public MyConnection()
        {
            Initialize();
        }

        //Initialize values
        string returnValue = null;
        internal static string Initialize()
        {
             public MySqlConnection connection;
             public string server;
            public string database;
            public string uid;
            public string password;
            server = "localhost";
            database = "tutiondb";
            uid = "root";
            password = "root";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            //connection = new MySqlConnection(connectionString);
            return connectionString;
        }

        //open connection to database
        public void OpenConnection()
        {
            try
            {
                connection.Open();               
            }
            catch (MySqlException)
            {
                throw;
            }
        }

        //Close connection
        public bool CloseConnection()
        {

            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException)
            {
                throw;
            }
        }        
    }
}
