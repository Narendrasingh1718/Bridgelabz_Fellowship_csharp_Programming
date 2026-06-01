using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADO_DotNET
{
    internal class Read
    {
        
        public void ReadData()
        {
            String command = "Select *  from ado.employee";
            try
            {
                using (MySqlConnection con = Connection_Class.GetConnection())
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(command, con);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine($"Id: {reader["id"]}, Name: {reader["name"]}, Age: {reader["age"]}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
