using Log;
using System;
using System.Collections.Generic;
using System.Text;

namespace Serv
{
    public class Service
    {
        [LogExecutionTime("work is done in more time  :")]
        public  void D0work()
        {
            Console.WriteLine("Doing work...");
        }
    }
}
