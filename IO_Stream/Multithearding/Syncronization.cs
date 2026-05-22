using System;
using System.Collections.Generic;
using System.Text;

namespace Multithearding
{
   public class Syncronization
   {
        public static int count;
        private static readonly object lockObj = new object();
        public void run()
        {

            for (int i = 0; i < 50; i++)
            {
                lock (lockObj)
                {
                    count++;
                }
            }

        }
    }
}
