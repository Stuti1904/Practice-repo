using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    class StudentDetail
    {
        public string name { get;  set ;  }
        public string address { get; set; }
        public int enlgish { get; set; }
        public int hindi { get; set; }

        public int math { get; set; }

        public int total { get { return hindi + enlgish + math; } }

        public char grade
        {
            get
            {
                if ((total / 3) >= 90)
                {
                    return 'a';
                }
                else if ((total / 3) >= 75)
                {
                    return 'b';
                }
                else if ((total / 3) >= 65)
                {
                    return 'c';
                }
                else if ((total / 3) >= 35)
                {
                    return 'd';
                }
                else
                {
                    return 'f';
                };
            }
        }
    }
}
