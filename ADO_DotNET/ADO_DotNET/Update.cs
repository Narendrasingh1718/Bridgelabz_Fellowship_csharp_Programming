using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADO_DotNET
{
    internal class Update
    {
      
        public void updateData()
        {
            String command = "update ado.employee set age=age+10 where name=@name";
            try
            {
                using (MySqlConnection con = Connection_Class.GetConnection())
                {

                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@name", "Amit");
                    int rowAffected = cmd.ExecuteNonQuery();
                    if (rowAffected > 0)
                    {
                        Console.WriteLine($"{rowAffected} rows updated successfully");
                    }
                    else
                    {
                        Console.WriteLine("No rows updated");
                    }
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
