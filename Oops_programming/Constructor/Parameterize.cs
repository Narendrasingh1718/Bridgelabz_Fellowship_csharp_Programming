using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    class Parameterize
    {
        public int x;
        public int y;
        public Parameterize(int a, int b) // Parameterized constructor
        {
            x = a;
            y = b;
        }
        public void Display()
        {
            Console.WriteLine($"x: {x}, y: {y}");
        }
    }
    class Program
    {
        static void Main()
        {
            Parameterize obj = new Parameterize(30, 40); // Creating an object of the class and passing values to the constructor
            obj.Display(); // Output: x: 30, y: 40
        }
    }
}
