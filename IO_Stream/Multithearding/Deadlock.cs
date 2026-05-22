using System;
using System.Collections.Generic;
using System.Text;

namespace Multithearding
{
    public  class Deadlock
    {
        static readonly object lock1 = new object();
        static readonly object lock2 = new object();
        public void Thread1()
        {
            lock (lock1)
            {
                Console.WriteLine("Thread 1: Acquired lock1");
                Thread.Sleep(1000); // Simulate some work
                lock (lock2)
                {
                    Console.WriteLine("Thread 1: Acquired lock2");
                }
            }
        }
        public void Thread2()
        {
            lock (lock2)
            {
                Console.WriteLine("Thread 2: Acquired lock2");
                Thread.Sleep(1000); // Simulate some work
                lock (lock1)
                {
                    Console.WriteLine("Thread 2: Acquired lock1");
                }
            }
        }


    }
}
