using System;
using System.Collections.Generic;
using System.Text;

namespace Log
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = true)]
    public class LogExecutionTimeAttribute: Attribute
    {
        public String Message { get; set; }
       

        public LogExecutionTimeAttribute(string message)
        {
            Message = message;
        }
    }
}
