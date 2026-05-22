using Models;

namespace Services
{
    public class OrderProcessor
    {
        private readonly InvoiceService _invoiceService;
        private readonly Logger _logger;

        public OrderProcessor()
        {
            _invoiceService = new InvoiceService();
            _logger = new Logger();
        }

        public void ProcessOrders(List<Order> orders, string outputFile, string logFile)
        {
            Parallel.ForEach(orders, order =>
            {
                try
                {
                    if (order.Amount <= 0)
                        throw new Exception("Invalid amount");

                    _invoiceService.WriteInvoice(outputFile, order);

                    _logger.Log($"Processed Order {order.OrderId}", logFile);
                }
                catch (Exception ex)
                {
                    _logger.Log($"Failed Order {order.OrderId}: {ex.Message}", logFile);
                }
            });
        }
    }
}
 