using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADO_DotNET
{
    public class Connection_Class
    {
        static String ConnectionString = "Server=localhost;database=ado;User Id=root;Password=Narendra@123";
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
