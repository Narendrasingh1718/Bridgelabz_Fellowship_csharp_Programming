using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Multithearding
{
    public class Moniter
    {
        private static readonly object sync = new object();
        public static int count;
        public void run()
        {
            for (int i = 0; i < 50; i++)
            {
                Monitor.Enter(sync);
                try
                {
                    count++;
                }
                finally 
                {
                    Monitor.Exit(sync);
                }
            }
        }

    }
}
