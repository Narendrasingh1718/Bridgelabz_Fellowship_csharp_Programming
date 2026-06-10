using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Exception
{
    public class NoRecordFound : IOException
    {
        public NoRecordFound(String Message) :base(Message){ }
    }
}
