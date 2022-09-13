using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
  public static class TesterClass
    {

        public static void getter( DateTime generateddate)
        {
           

            if (generateddate < DateTime.Today)
            {
                throw new DateException("DATE IS LESS THAN THE CURRENT DATE");
            }
            else
            {
                Console.WriteLine("VALID");
            }
        }

        public static void tester(DateTime newdate)
        {
            try
            {
                getter(newdate);
            }

            catch(DateException de)
            {
                Console.WriteLine(de.Message);
            }
        }
    }
}
