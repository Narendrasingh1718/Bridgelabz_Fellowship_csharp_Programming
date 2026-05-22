using System;
using System.Collections.Generic;
using System.Text;

namespace Multithearding
{
    public static class PrameterizedThread
    {
        public static void run(object name)
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + " " + name);
            }
        }
    }
}
