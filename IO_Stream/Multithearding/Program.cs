using Multithearding;
using System;
using System.Threading; 
class program
{
    static void Main()
    {
        // creating thread using Thread class

        //Createthread ct = new Createthread();
        //Thread2 ct2 = new Thread2();
        //Thread t = new Thread(ct.run);
        //Thread t2 = new Thread(ct2.print);
        //t.Start();
        //t2.Start();

        //creating thread using delegate
        //ThreadStart ts =new ThreadStart(Multithearding.Delegate.show);
        //Thread T=new Thread(ts);
        //T.Start();

        //creating thread using parameterized thread
        //ParameterizedThreadStart pt=new ParameterizedThreadStart(PrameterizedThread.run);
        //Thread t = new Thread(pt);
        //t.Start("Narendra");

        // creating thred using lambda expression
        //Thread t = new Thread(() =>
        //{
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine("This is a lambda expression thread" + i);
        //    }
        //});
        //t.Start();
        //creating thread using anonymous method
        //Thread t2= new Thread(delegate ()
        //{
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine("This is an anonymous method thread" + i);
        //    }

        //});
        //.Start();
        //t.Priority = ThreadPriority.Highest;
        //t2.Priority = ThreadPriority.Lowest;
        //Thread.CurrentThread.Priority = ThreadPriority.Normal; 

        //join method
        //Join j = new Join();    
        //Thread t= new Thread(j.run);
        //t.Start();
        //t.Join();

        //sleep method
        //Sleep s = new Sleep();
        //Thread t2 = new Thread(s.run);
        //t2.Start();


        //Yeild method
        //Yeild yeild = new Yeild();
        //Thread t3=new Thread(yeild.run);
        //t3.Start();

        //Race condition
        //RaceCondition rc = new RaceCondition(); 
        //Thread t1 = new Thread(rc.run);
        //Thread t2 = new Thread(rc.run);
        //t1.Start();
        //t2.Start();
        //t1.Join(); t2.Join();
        //Console.WriteLine(RaceCondition.count);

        //Synchronization using lock
        //Syncronization s = new Syncronization();
        //Thread t1 = new Thread(s.run);
        //Thread t2 = new Thread(s.run);
        //t1.Start(); 
        //t2.Start();
        //t1.Join(); 
        //t2.Join(); 
        //Console.WriteLine(Syncronization.count);

        //monier
        //Moniter m = new Moniter();
        //Thread t1 = new Thread(m.run);
        //Thread t2 = new Thread(m.run);
        //t1.Start();
        //t2.Start();
        //t1.Join();
        //t2.Join();
        //Console.WriteLine(Moniter.count);

        //Mutex
        //MutexSync m = new MutexSync();
        //Thread t1 = new Thread(m.run);
        //Thread t2 = new Thread(m.run);
        //t1.Start();
        //t2.Start();
        //t1.Join();
        //t2.Join();
        //Console.WriteLine(MutexSync.count);

        // Deadlock
        //Thread t1 = new Thread(new Deadlock().Thread1);
        //Thread t2 = new Thread(new Deadlock().Thread2);
        //t1.Start();
        //t2.Start();
        //t1.Join();
        //t2.Join();

        //deadlock avoidance
        Thread t1 = new Thread(new DeadlockAvoidance().Thread1);
        Thread t2 = new Thread(new DeadlockAvoidance().Thread2);
        t1.Start();
        t2.Start();
        t1.Join();
        t2.Join();


        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine("Main thread is running" + i);
        //}
    }

}
