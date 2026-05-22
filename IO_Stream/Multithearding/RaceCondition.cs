using System;
using System.Collections.Generic;
using System.Text;

namespace Multithearding
{
    public class RaceCondition
    {
        public static int count;
        public void run() {
        
            for(int i = 0; i < 50; i++)
            {
                count++;
            }

        }
    }
}
