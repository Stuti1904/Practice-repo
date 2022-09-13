using System;
using System.Collections.Generic;
using System.Text;

namespace Day4A2
{
    class NameException : Exception
    {

        public NameException()
        {

        }

        public NameException(string message): base(message)
        {

        }
    }
}
