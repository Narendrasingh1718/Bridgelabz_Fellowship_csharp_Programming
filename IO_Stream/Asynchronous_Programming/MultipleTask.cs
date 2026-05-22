using System;
using System.Collections.Generic;
using System.Text;

namespace Asynchronous_Programming
{
    public class MultipleTask
    {
       public static async Task<int> GetData(int id)
        {
            await Task.Delay(2000);
            return id * 10;
        }
    }
}
