using Services;

class Program
{
    static void Main()
    {
        string inputDirectory = @"C:\Users\naren\Documents\Input";
        string outputFile = @"C:\Users\naren\Documents\invoices.txt";
        string logFile = @"CC:\Users\naren\Documents\log.txt";

        var fileService = new FileService();
        var processor = new OrderProcessor();

        var files = Directory.GetFiles(inputDirectory, "*.txt");

        Console.WriteLine("Processing started...");

        // Process files in parallel (multi-threading)
        Parallel.ForEach(files, file =>
        {
            var orders = fileService.ReadOrders(file);
            processor.ProcessOrders(orders, outputFile, logFile);
        });

        Console.WriteLine("Processing completed.");
    }
}