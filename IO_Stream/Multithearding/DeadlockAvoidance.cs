using System;
using System.Collections.Generic;
using System.Text;

namespace Multithearding
{
    public  class DeadlockAvoidance
    {
        static readonly object lock1 = new object();
        static readonly object lock2= new object();
        public void Thread1()
        {
            lock (lock1)
            {
                Console.WriteLine("lock1 accurie by thread1");
                Thread.Sleep(1000);
                lock (lock2)
                {
                    Console.WriteLine("lock2 accurie by thread1");  
                }
            }
        }
        public void Thread2()
        {
            lock (lock1)
            {
                Console.WriteLine("lock1 accurie by thread1");
                Thread.Sleep(1000);
                lock (lock2)
                {
                    Console.WriteLine("lock2 accurie by thread1");
                }
            }
        }

    }
}
