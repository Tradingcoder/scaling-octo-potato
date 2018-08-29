using System;
using System.Collections.Generic;
using System.Text;

namespace scaling_octo_potato
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
        }
    }
}
