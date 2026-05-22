using System;
using System.Collections.Generic;
using System.Text;

namespace Multithearding
{
    internal class Createthread
    {

        public void run()
        {
            for (int i=0;i<10;i++)
            {
                Console.WriteLine("Child thread is running"+i);
            }
            
        }
    }
}
