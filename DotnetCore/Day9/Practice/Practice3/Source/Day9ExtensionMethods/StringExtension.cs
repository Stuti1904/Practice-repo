﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Day9ExtensionMethods
{
   static class StringExtension
    {

        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;

        }
    }
}
