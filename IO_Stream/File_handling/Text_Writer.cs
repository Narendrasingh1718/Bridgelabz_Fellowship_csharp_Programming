using System;
using System.IO;
namespace FileHandlinDemo
{
    class Text_Writer
    {
        public static void Start()
        {
            string filePath = @"C:\Users\naren\OneDrive\Desktop\MyFile1.txt";
            try { 
            using (TextWriter textWriter = File.CreateText(filePath))
            {
                textWriter.WriteLine("Hello TextWriter Abstract Class!");
                textWriter.WriteLine("File Handling Tutorial in C#");
            }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            Console.WriteLine("Write Successful");
            Console.ReadKey();
        }
    }
}