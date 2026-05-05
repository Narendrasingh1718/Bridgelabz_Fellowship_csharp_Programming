using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectClass
{
    internal class BookTitle
    {
        string title;
        string author;
        double price;
        public BookTitle(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: " + price);
        }
    }
}