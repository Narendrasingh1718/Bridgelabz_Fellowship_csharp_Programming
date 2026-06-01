using System;
using System.Collections.Generic;
using System.Text;
using Task;

namespace Task
{
    public class OrderProcess
    {
        public static void ProcessOrders()
        {

            List<string> orders = new List<string>();

            using (StreamReader sr = new StreamReader(inputPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    orders.Add(line);
                }
            }

            Console.WriteLine($"Total Orders : {orders.Count}");
        }
    }
}
