using Custom;
using Data;
using Emp;
using Log;
using Model;
using Serv;
using System;
using System.Reflection;

class Program
{
    public static void Main(string[] args)
    {
        //Service service = new Service();
        //Type type = service.GetType();
        //MethodInfo methodInfo = type.GetMethod("D0work");
        //if(methodInfo.GetCustomAttribute(typeof(LogExecutionTimeAttribute)) is LogExecutionTimeAttribute attribute)
        //{
        //   var Started = DateTime.Now;
        //    service.D0work();
        //    var Ended = DateTime.Now;
        //    Console.WriteLine($"{attribute.Message} {Ended - Started}");
        //}
        Employee2 emp = new Employee2();
        Type type = emp.GetType();
        MethodInfo methodInfo = type.GetMethod("Display");
        if (methodInfo.GetCustomAttribute(typeof(DataAnnotation)) is DataAnnotation attribute)
        {
            Console.WriteLine($"{string.Join("Narendra, ", attribute.arr)} {attribute.no} ");
            emp.Display();
        }
    }
}