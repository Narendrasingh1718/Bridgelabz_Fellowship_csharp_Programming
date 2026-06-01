using CancellationTask;
using System;
class Program
{
    static async Task Main()
    {
        var ct= new CancellationTokenSource();
        ct.CancelAfter(2000); // Cancel after 2 seconds
        try
        {
            await Cancel.Start(ct.Token);
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Operation was cancelled.");
        }

    }
}