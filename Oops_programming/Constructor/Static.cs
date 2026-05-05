using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
   
   class Static2
    {
        public static int x; // Static variable
        public static int y; // Static variable
        static Static2() // Static constructor to initialize static variables
        {
            x = 50;
            y = 60;
        }
        public static void Display() // Static method can be called without creating an instance of the class
        {
            Console.WriteLine($"x: {x}, y: {y}");
        }
    }
    class Static
    {
        static void Main()
        {
            Static2.Display(); // Output: x: 50, y: 60
        }
    }
}
