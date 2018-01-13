using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace MS_CIT
{
    internal class Utility
    {        
        internal static MySqlConnection GetConnection()
        {
            string serverIp = "localhost";
            string username = "root";
            string password = "root";
            string database = "tutiondb";

            string dbConnectionString = string.Format("server={0};uid={1};pwd={2};database={3}", serverIp, username, password,database);

            var con = new MySql.Data.MySqlClient.MySqlConnection(dbConnectionString);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }                   
            return con;
        }
    }
}
