using System;
using System.Collections.Generic;
using System.Text;

namespace Custom
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class CustomAttribute : Attribute
    {
        public  string Name { get; set; }
        public  string empno { get; set; }

      public  CustomAttribute(string name, string empno)
        {
            Name = name;
            this.empno = empno;
        }
    }
}