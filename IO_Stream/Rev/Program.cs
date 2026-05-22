using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;

class Program
{
    static object lockObj = new object();

    static void Main()
    {
        Console.WriteLine(" Online Order Processing Started");
        string inputPath = @"C:\Users\naren\Contacts\orders.txt";
        string invoicePath = @"C:\Users\naren\Contacts\invoices.txt";
        string summaryPath = @"C:\Users\naren\Contacts\summary.txt";
        string logPath = @"C:\Users\naren\Contacts\log.txt";

      
        Directory.CreateDirectory(Path.GetDirectoryName(inputPath));

        
        if (!File.Exists(inputPath))
        {
            using (StreamWriter sw = new StreamWriter(inputPath,true))
            {
                sw.WriteLine("1,Narendra,2,500");
                sw.WriteLine("2,Sandesh,1,1200");
                sw.WriteLine("3,Harshit,3,200");
                sw.WriteLine("4,Dinesh,5,100");
            }
            Console.WriteLine(" orders.txt created");
        }

  
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

        int totalOrders = 0;
        double totalAmount = 0;

        List<Task> tasks = new List<Task>();

        foreach (var order in orders)
        {
            tasks.Add(Task.Run(() =>
            {
                try
                {
               
                    var data = order.Split(',');

                    int id = int.Parse(data[0]);
                    string name = data[1];
                    int qty = int.Parse(data[2]);
                    double price = double.Parse(data[3]);

                    double total = qty * price;

                   
                    lock (lockObj)
                    {
                        
                        using (StreamWriter sw = new StreamWriter(invoicePath, true))
                        {
                            sw.WriteLine($"OrderID: {id}, Name: {name}, Quantity: {qty}, Total: {total}");
                        }
                        totalOrders++;
                        totalAmount += total;
                        using (StreamWriter log = new StreamWriter(logPath, true))
                        {
                            log.WriteLine($"SUCCESS: Order {id} processed at {DateTime.Now}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    lock (lockObj)
                    {
                        using (StreamWriter log = new StreamWriter(logPath, true))
                        {
                            log.WriteLine($"ERROR: {ex.Message}");
                        }
                    }
                }
            }));
        }
        Task.WaitAll(tasks.ToArray());
        using (StreamWriter sw = new StreamWriter(summaryPath))
        {
            sw.WriteLine("-- SUMMARY--");
            sw.WriteLine($"Total Orders: {totalOrders}");
            sw.WriteLine($"Total Amount: {totalAmount}");
        }

        Console.WriteLine(" Processing Completed!");
        Console.ReadKey();
    }
}