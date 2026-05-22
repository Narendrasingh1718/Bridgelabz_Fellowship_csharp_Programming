using System;
using System.Collections.Generic;
using System.Text;

namespace Multithearding
{
    public class Sleep
    {
        public void run()
        {
            for(int i=0;i<10; i++)
            {
                Console.WriteLine("Sleep" + i); 
                Thread.Sleep(1000);
            }   
        }
    }
}
