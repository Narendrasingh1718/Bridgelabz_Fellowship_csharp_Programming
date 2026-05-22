using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace File_handling
{
    public class Json
    {
        public static void Json_Handling()
        {
            var JasonObject = new
            {
                 Name = "narendra",
                RollNo = "001",
                Grade = "A"
            };
            String jsonString = System.Text.Json.JsonSerializer.Serialize(JasonObject);
            Console.WriteLine(jsonString);
        } 

    }
}
