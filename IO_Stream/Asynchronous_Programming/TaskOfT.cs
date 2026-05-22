 using System;
using System.Collections.Generic;
using System.Text;

namespace Asynchronous_Programming
{
     public class TaskOfT
    {
        public static async Task<Weather> Get(String city) 
        {
            await Task.Delay(1000);
            var weather = new Weather
            {
                City = city,
                date = DateTime.Now,
                Temprature = new Random().Next(-20, 40)
            };
            return weather;
        }
        public  static void TaskStatus(TaskStatus status)
        {
            Console.WriteLine(status);
        }
    }
}
