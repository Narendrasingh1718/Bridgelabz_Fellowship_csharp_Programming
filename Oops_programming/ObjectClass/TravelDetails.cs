using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectClass
{
    internal class TravelDetails
    {
        string from;
        string to;
        double distance;
        public TravelDetails(string from, string to, double distance)
        {
            this.from = from;
            this.to = to;
            this.distance = distance;
        }
        public void display()
        {
            Console.WriteLine("from" + from);
            Console.WriteLine("to" + to);
            Console.WriteLine("distance" + distance);
        }
    }
}