using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ADO_DotNET
{
    internal class DataSet
    {
        public DataSet()
        {
            String Command = "Select *  from ado.employee";
            try
            {
                using (MySqlConnection con = Connection_Class.GetConnection())
                {
                    con.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(Command, con);
                    DataSet set = new DataSet();
                    adapter.Fill(set, "employee");
                    foreach (DataRow row in set.Tables["employee"].Rows)
                    {
                        Console.WriteLine($"Id: {row["id"]}, Name: {row["name"]}, Age: {row["age"]}");
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
