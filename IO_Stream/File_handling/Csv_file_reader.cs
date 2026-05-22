using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace File_handling
{
    public class Csv_file_reader
    {
        static string path = "Student.csv";
        public static void Reader()
        {
            try
            {
                using (var reader = new StreamReader(path)) 
                using (var csv=new CsvReader(reader,CultureInfo.InvariantCulture)) 
                {
                 var records=csv.GetRecords<Student>();
                    foreach(var record in records) 
                    {
                        Console.WriteLine($"Name: {record.Name}, RollNo: {record.RollNo}, Grade: {record.Grade}");
                    }
                }
            }
            catch(Exception ex) { 
                Console.WriteLine(" " + ex.Message);    
            }   
        }
    }
}
