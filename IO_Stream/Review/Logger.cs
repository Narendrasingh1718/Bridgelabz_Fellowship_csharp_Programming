namespace Services
{
    public class Logger
    {
        private static readonly object logLock = new object();

        public void Log(string message, string logFile)
        {
            lock (logLock)
            {
                using (var writer = new StreamWriter(logFile, true))
                {
                    writer.WriteLine($"{DateTime.Now}: {message}");
                }
            }
        }
    }
}