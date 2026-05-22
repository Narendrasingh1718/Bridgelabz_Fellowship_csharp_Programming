using System;
using System.IO;
namespace FileHandlinDemo
{
    class Text_Reader
    {
        public static void Start()
        {
            string filePath = @"C:\Users\naren\OneDrive\Desktop\MyFile1.txt";
            //Read One Line
            try
            {
                using (TextReader textReader = File.OpenText(filePath))
                {
                    Console.WriteLine(textReader.ReadLine());
                }

                //Read 4 Characters
                using (TextReader textReader = File.OpenText(filePath))
                {
                    char[] ch = new char[4];
                    textReader.ReadBlock(ch, 0, 4);
                    Console.WriteLine(ch);
                }

                //Read full file
                using (TextReader textReader = File.OpenText(filePath))
                {
                    Console.WriteLine(textReader.ReadToEnd());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}