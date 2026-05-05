using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectClass
{
    internal class DisplayDetails
    {
        int id;
        string name;
        int age;
        public DisplayDetails(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public void display()
        {
            Console.WriteLine("id = " + id);
            Console.WriteLine("name = " + name);
            Console.WriteLine("age = " + age);
        }
    }
}