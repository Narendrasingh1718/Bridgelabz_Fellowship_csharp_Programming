using System;
using System.IO;

namespace FileHandlinDemo
{
    class Stream_Reader
    {
        public static void Start()
        {
            //Set The File Path
            string filePath = @"D:C:\Users\naren\OneDrive\Desktop\MyTextFile.txt";

            //Write Some data to a text file using StreamWriter
            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                streamWriter.WriteLine("Welcome to DotNetTutorials");
                streamWriter.WriteLine("You are Learning File Handling in C#");
            }

            //Reading text file using StreamReader Class ReadToEnd Method
            Console.WriteLine("\nReading Approach 1: using ReadToEnd Method");
            using (StreamReader reader = new StreamReader(filePath))
            {
                Console.WriteLine(reader.ReadToEnd());
            }

            //Another Approach to Read the Data from a text file using StreamReader ReadLine Method
            Console.WriteLine("\nReading Approach 2: using ReadLine Method");
            StreamReader streamReader = new StreamReader(filePath);
            streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
            string strData = streamReader.ReadLine();
            while (strData != null)
            {
                Console.WriteLine(strData);
                strData = streamReader.ReadLine();
            }

            Console.ReadKey();
        }
    }
}