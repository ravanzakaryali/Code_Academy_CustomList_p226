using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.CustomExceptions
{
    public class CustomOutOfRangeException : RangeException
    {
        public CustomOutOfRangeException(string message) : base(message) { }
    }
}
