using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Exception
{
    public  class UserNotFoundException : IOException
    {
        public UserNotFoundException(String Message):base(Message) { }
    }
}
