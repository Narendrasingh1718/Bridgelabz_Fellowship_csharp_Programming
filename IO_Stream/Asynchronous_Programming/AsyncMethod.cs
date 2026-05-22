using System;
using System.Collections.Generic;
using System.Text;

namespace Asynchronous_Programming
{
    public class AsyncMethod
    {
        public void run()
        {
            Console.WriteLine("running started"); //1
            run2();
            Console.WriteLine("running end"); //3
        }
        public async void run2()
        {
            Console.WriteLine("running2 started");//2
            await Task.Delay(4000);   ///
            Console.WriteLine("running2 end");//4
        }
    }
}
  