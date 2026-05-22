using System;
using System.Collections.Generic;
using System.Text;

namespace Multithearding
{
    public  class MutexSync
     
    {
        public static int count;
        private static Mutex mutex = new Mutex();
        public void run() { 
            for (int i = 0; i < 50; i++)
            {
                mutex.WaitOne();
                try
                {
                    count++;
                }
                finally
                {
                    mutex.ReleaseMutex();
                }
            }
        }
    }
}
