using System;
using System.Collections.Generic;
using System.Text;

namespace Day4A1
{
   public  class AgeException : Exception
    {

        public AgeException()
        {

        }

        public AgeException(String message) :base(message)
        {

        }
    }
}
