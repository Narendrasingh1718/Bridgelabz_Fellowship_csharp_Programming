using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Exception
{
    public class UserExistsException : IOException
    {
        public UserExistsException(string message) : base(message)
        {

        }

    }
}
