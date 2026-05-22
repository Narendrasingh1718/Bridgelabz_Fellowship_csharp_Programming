using System;
using System.Collections.Generic;
using System.Text;

namespace File_handling
{
    public class Json2
    {
        public static void NestedJson()
        {
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
    }
}
