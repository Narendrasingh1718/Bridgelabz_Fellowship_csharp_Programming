using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace CancellationTask
{
    public  class Cancel
    {
      public static async Task Start(CancellationToken ct)
        {
            for (int i = 0; i < 10; i++)
             {
                 ct.ThrowIfCancellationRequested(); 
                 Console.WriteLine($"Step {i + 1}");
                 await Task.Delay(300, ct);
            }
        }
    }
}
