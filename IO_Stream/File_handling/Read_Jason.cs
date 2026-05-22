using System;
using System.Collections.Generic;
using System.Text;

namespace File_handling
{
    public  class Read_Jason
    {
        public static void Read() {
            string jsonString = "{\"Name\":\"narendra\",\"RollNo\":\"001\",\"Grade\":\"A\"}";
            var deserializedObject = System.Text.Json.JsonSerializer.Deserialize<Student>(jsonString);
            Console.WriteLine($"Name: {deserializedObject.Name}, RollNo: {deserializedObject.RollNo}, Grade: {deserializedObject.Grade}");
        }
    }
}
