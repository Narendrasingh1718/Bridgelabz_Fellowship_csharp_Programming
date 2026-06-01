using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    public class Order
    {
        public static void Ord()
        {

            Console.WriteLine(" Online Order Processing Started");
            string inputPath = @"C:\Users\naren\Contacts\orders.txt";
            string invoicePath = @"C:\Users\naren\Contacts\invoices.txt";
            string summaryPath = @"C:\Users\naren\Contacts\summary.txt";
            string logPath = @"C:\Users\naren\Contacts\log.txt";


            Directory.CreateDirectory(Path.GetDirectoryName(inputPath));


            if (!File.Exists(inputPath))
            {
                using (StreamWriter sw = new StreamWriter(inputPath, true))
                {
                    sw.WriteLine("1,Narendra,2,500");
                    sw.WriteLine("2,Sandesh,1,1200");
                    sw.WriteLine("3,Harshit,3,200");
                    sw.WriteLine("4,Dinesh,5,100");
                }
                Console.WriteLine(" orders.txt created");
            }
        }
    }
}
