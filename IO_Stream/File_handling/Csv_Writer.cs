using System;
using System.IO;
using CsvHelper;
using System.Globalization;
using System.Collections.Generic;

namespace File_handling
{
    public class Csv_Writer
    {
       
        public static void Writer() {
            using (var writer = new StreamWriter("Student.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                var records = new List<Student>
                {
                    new Student { Name = "narendra", RollNo = "001", Grade = "A" },
                    new Student { Name = "harshit", RollNo = "002", Grade = "B" },
                    new Student { Name = "sandesh", RollNo = "003", Grade = "A" }
                };

                
                csv.WriteRecords(records);
            }

            Console.WriteLine(" CSV file created successfully at: ");

        }
    }
}
