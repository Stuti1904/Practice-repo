using System;
using System.Collections.Generic;
using System.Linq;

namespace Day4P1
{
    class Program
    {
        private static List<string> GetAlphabet(bool upper)
        {
            List<string> alphabet = new List<string>();
            int charValue = upper ? 65 : 97;
            for (int ctr = 0; ctr <= 25; ctr++)
                alphabet.Add(((char)(charValue + ctr)).ToString());
            return alphabet;
        }
        static void Main(string[] args)
        {
            //instantiate a string object
            string string1 = "this is a string";
            Console.WriteLine(string1);

            //using a constructor
            char[] ch = { 'w', 'o', 'r', 'd' };
            string string2 = new string(ch);
            Console.WriteLine(string2);

            //by concat operators
            string string3 = "This is one sentence. " + "This is a second. ";
            string3 += "This is a third sentence.";
            Console.WriteLine(string3);


            //string can be treated as an array. The indexes start from 0

            string name = "stuti shahu";
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            //comparing two strings

            string str1 = "stuti";
            string str2 = "STUTI";
            if (String.Compare(str1, str2, StringComparison.OrdinalIgnoreCase)==0) // if we dont write ignore, it shows false
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            //concat
            string output = String.Concat(GetAlphabet(true).Where(letter =>
                   letter.CompareTo("M") >= 0));
            Console.WriteLine(output);

            //tostring method
            string str = "123";
            string str_ab = str.ToString();
            Console.WriteLine(str);

            //indexof method
            string s = "stuti shahu";
            string tobesearched = "k";
            Console.WriteLine(s.IndexOf(tobesearched));// gives -1 if the match isnt found otherwise gives the position of the first matched string
        }
    }
}
