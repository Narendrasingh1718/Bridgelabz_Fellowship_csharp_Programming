using Models;
using System.Globalization;

namespace Services
{
    public class FileService
    {
        public List<Order> ReadOrders(string filePath)
        {
            var orders = new List<Order>();

            using (var reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var data = line.Split(',');

                    orders.Add(new Order
                    {
                        OrderId = int.Parse(data[0]),
                        CustomerName = data[1],
                        Amount = double.Parse(data[2], CultureInfo.InvariantCulture)
                    });
                }
            }

            return orders;
        }
    }
}