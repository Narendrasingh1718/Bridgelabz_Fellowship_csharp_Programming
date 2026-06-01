using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ADO_DotNET
{
    internal class Delete
    {
        
        public void DeleteData()
        {
            String command = "delete from ado.employee where age<24";
            try
            {
                using (MySqlConnection con = Connection_Class.GetConnection())
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(command, con);
                    int rowAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine($"{rowAffected} rows deleted successfully");
                    Read read = new Read();
                    read.ReadData();
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

    }
}
