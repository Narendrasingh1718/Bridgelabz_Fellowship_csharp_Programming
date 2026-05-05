using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    class private2
    {
        private int x; // Private variable
        private int y; // Private variable
        private private2(int a, int b) // Private constructor
        {
            x = a;
            y = b;
        }
        public static private2 CreateInstance(int a, int b) // Public static method to create an instance of the class
        {
            return new private2(a, b);
        }
        public void Display()
        {
            Console.WriteLine($"x: {x}, y: {y}");
        }
    }
}