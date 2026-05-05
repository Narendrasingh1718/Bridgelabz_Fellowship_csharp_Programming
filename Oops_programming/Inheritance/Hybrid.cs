using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class HybridInheritance // it is a combination of single and multiple inheritance. It is a combination of hierarchical and multiple inheritance. It is a combination of single and hierarchical inheritance. It is a combination of multiple and hierarchical inheritance.
    {                              // not possible in C# because C# does not support multiple inheritance with classes but it can be achieved using interfaces.
        internal class Parent
        {
            public void method1()
            {
                Console.WriteLine("This is Method 1");
            }
        }
        internal class child : Parent 
        {
            public void methyod2()
            {
                Console.WriteLine("This is Method 2");
            }
        }
        interface C
        {
            void method3();
        }
        internal class D : C
        {
            public void method3()
            {
                Console.WriteLine("This is Method 1 from Interface");
            }
        }
    }
}