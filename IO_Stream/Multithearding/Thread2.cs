using System;
using System.Collections.Generic;
using System.Text;

namespace Multithearding
{
    internal class Thread2
    {
       public void print()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Narendra" + i);
            }
        }
    }
}
