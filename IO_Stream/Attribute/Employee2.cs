using System;
using System.Collections.Generic;
using System.Text;
using Data;

namespace Emp
{
    public class Employee2
    {
        [DataAnnotation(new string[] { "Name :", "Age :"}, "12345")]
        public void Display()
        {
            Console.WriteLine("company :apexon");
            Console.WriteLine("designation :software engineer");
        }
    }
}
