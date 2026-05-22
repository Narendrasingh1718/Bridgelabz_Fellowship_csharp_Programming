
using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class program1
    {
        public static void Main(string[] args)
        {
            GenericClass<int> integerGenericClass = new GenericClass<int>(10);
            int val = integerGenericClass.GenericMethod(200);
            Console.WriteLine(val);
            Console.ReadKey();
        }
    }
}
