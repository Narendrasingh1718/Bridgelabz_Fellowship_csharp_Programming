using System;
using System.Collections.Generic;
using System.Text;

namespace Asynchronous_Programming
{
    public class AsyncSchool
    {
        public async Task run()
        {
            Console.WriteLine("School day started");
            Task t1 = Prayer();
            await t1;
            Task t2 = Class();
            Task t3 = Class2();
            Task.WaitAll(t1, t2, t3);
            Console.WriteLine("School day ended");
        }
        public static async Task Prayer()
        {
           
            await Task.Delay(4000);
            Console.WriteLine("Prayer started");
        }
        public static async Task Class()
        {
            
            await Task.Delay(2000);
            Console.WriteLine("Class started");
        }
        public static async Task Class2()
        {
            
            await Task.Delay(1000);
            Console.WriteLine("Class2 started");
        }
    }
}
