using System;

class Demo
{
    public Demo()
    {
        Console.WriteLine("Object Created");
    }

    ~Demo() // Finalizer (Destructor)
    {
        Console.WriteLine("Object Destroyed by GC");
    }
}

class Program
{
    static void Main()
    {
        Demo obj = new Demo();

        obj = null; // Eligible for garbage collection

        GC.Collect();       // Force GC (not recommended in real apps)
        GC.WaitForPendingFinalizers();

        Console.WriteLine("End of Main");
    }
}
