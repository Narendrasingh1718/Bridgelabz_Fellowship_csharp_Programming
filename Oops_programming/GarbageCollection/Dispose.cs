using System;

class FileManager : IDisposable
{
    public void OpenFile()
    {
        Console.WriteLine("File Opened");
    }

    public void Dispose()
    {
        Console.WriteLine("Resources Released");
    }
}

class Dispose

{
    static void Main()
    {
        using (FileManager fm = new FileManager())
        {
            fm.OpenFile();
        } // Dispose automatically called here
    }
}