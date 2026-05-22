using System;
using System.Collections.Generic;
using System.Text;

namespace File_handling
{
    public class Nested_Json
    {
        public static void Nested() {
            var nestedJsonObject = new
            {
                Name = "narendra",
                RollNo = "001",
                Grade = "A",
                Address = new
                {
                    Street = "123 Main St",
                    City = "Anytown",
                    State = "CA",
                    ZipCode = "12345"
                }
            };
            string jsonString = System.Text.Json.JsonSerializer.Serialize(nestedJsonObject);
            Console.WriteLine(jsonString);
        }
    }
}
