using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    internal class Copy2
    {
        public int x;
        public int y;
        public Copy2(int a, int b) // Parameterized constructor
        {
            x = a;
            y = b;
        }
        public Copy2(Copy2 obj) // Copy constructor
        {
            x = obj.x;
            y = obj.y;
        }
        public void Display()
        {
            Console.WriteLine($"x: {x}, y: {y}");
        }
    }
    class Copy
    {
        static void Main()
        {
            Copy2 obj1 = new Copy2(10, 20); // Creating an object of the class and passing
            Copy2 obj2 = new Copy2(obj1); // Creating a new object using the copy constructor
            obj1.Display(); // Output: x: 10, y: 20
            obj2.Display(); // Output: x: 10, y: 20 (same values as obj1)
        }
    }
}
