using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace ADO_DotNET
{
    internal class Crud
    {

        public void Create()
        {
            String command = "create table employee(id int primary key auto_increment,name varchar(20),age int)";
            try  
            {
                using (MySqlConnection con = Connection_Class.GetConnection())
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(command, con);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("table created successfully");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

//try and catch  //