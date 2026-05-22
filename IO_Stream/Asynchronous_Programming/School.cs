using System;
using System.Collections.Generic;
using System.Text;

namespace Asynchronous_Programming
{
    public class School
    {
        public void Prayer()
        {
            Console.WriteLine("Prayer started");
            Thread.Sleep(4000);
        }
        public void Class()
        {
                Console.WriteLine("Class started");
                Thread.Sleep(2000);
        }
        public void Class2()
        {
            Console.WriteLine("Class2 started");
             Thread.Sleep(3000);
        }
    }
}
