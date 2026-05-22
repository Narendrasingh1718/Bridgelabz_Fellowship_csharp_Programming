using System;
using System.Collections.Generic;
using System.Text;

namespace Multithearding
{
    public class Join
    {
        public void run()
        {
           for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("join"+i);
            }
        }
    }
}
