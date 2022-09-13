using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
  public   class DateException: Exception
    {

        public DateException()
        {

        }
        public DateException(string message): base(message)
        {

        }
    }
}
