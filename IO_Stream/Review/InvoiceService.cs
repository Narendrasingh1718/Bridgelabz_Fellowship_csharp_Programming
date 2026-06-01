using Models;

namespace Services
{
    public class InvoiceService
    {
        private static readonly object fileLock = new object();

        public void WriteInvoice(string outputPath, Order order)
        {
            lock (fileLock)
            {
                using (var writer = new StreamWriter(outputPath, true))
                {
                    writer.WriteLine($"OrderId: {order.OrderId}, Customer: {order.CustomerName}, Amount: {order.Amount}");
                }
            }
        }
    }
}