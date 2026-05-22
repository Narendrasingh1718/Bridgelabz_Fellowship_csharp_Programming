using System;
using System.IO;
namespace FileHandlinDemo
{
    class Stream_Writer
    {
        public static void Start()
        {
            try
            {
                string path = @"C:\Users\naren\Documents\file.txt";
                Directory.CreateDirectory(Path.GetDirectoryName(path));

                using (StreamWriter sw = new StreamWriter(path))
                {
                    Console.WriteLine("Enter text:");
                    string input = Console.ReadLine();

                    sw.WriteLine(input);
                }

                Console.WriteLine("✅ File created successfully at: " + path);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error: " + ex.Message);
            }

            Console.ReadKey();
        }

    }
}