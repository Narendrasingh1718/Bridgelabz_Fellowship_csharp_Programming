using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
namespace ADO_DotNET
{
    internal class Insert
    {

        public void InsertData()
        {
            String command = @"INSERT INTO employee (name, age) VALUES('Rahul', 22),('Amit', 25),('Neha', 21),('Priya', 24),('Karan', 26);";
            try
            {
                using (MySqlConnection con = Connection_Class.GetConnection())
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(command, con);
                    int rowAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine($"{rowAffected} rows inserted successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        //Connection ---> con.opne() con.Close() ,without try and catch ,


    }
}
