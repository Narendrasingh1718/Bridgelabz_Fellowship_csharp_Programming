using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public class DataAnnotation : Attribute
    {
        public String[] arr { get; }
        public String  no { get; set; }
        public DataAnnotation(String[] arr, String no)
        {
            this.arr = arr;
            this.no = no;
        }
    }
}
