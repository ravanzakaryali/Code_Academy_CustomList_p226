using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.CustomExceptions
{
    public class RangeException : Exception
    {
        public RangeException(string message) : base(message) { }   
    }
}
