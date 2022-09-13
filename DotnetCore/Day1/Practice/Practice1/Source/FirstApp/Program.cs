using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");//simple hello world program

            //basic integer math
            int a = 15;
            int b = 19;

            //operators

            int c = a+b;
            int d = b - a;
            int e = a * b;
            int f = a / b;
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);


            //double values
            double g = 3.14;
            double area = g * 2 * 2;
            Console.WriteLine("Area of circle with Radius 2 is " + area);


            //char and string
            char ch = 's';
            Console.WriteLine(ch);
            //we cannot convert or store more than one character in the char datatype

            string str = "s,tut,i";
            Console.WriteLine(str);
            Console.WriteLine(str.Length);
            Console.WriteLine(str.Substring(2, 2));
            string[] RESULT = str.Split(',');
            for(int i=0; i<RESULT.Length; i++)
            {
                Console.WriteLine(RESULT[i]);
            }


            //CALCULATOR IN C#. THIS COVERS TAKING INPUT FROM USER, SWITCH CASE AND ARITHMETIC OPERATORS

            int num1 = 0;
            int num2 = 0;
            Console.WriteLine("CONSOLE CALCULATOR");
            Console.WriteLine("-------------------");

            //ask user to enter the first number
            Console.WriteLine("ENTER THE FIRST NUMBER");
            num1 = Convert.ToInt32(Console.ReadLine());

            //ask user to enter the second number
            Console.WriteLine("ENTER THE SECOND NUMBER");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("CHOOSE AN OPTION FOR THE ARITHMETIC OPERATION");
            Console.WriteLine("CHOOSE A for addition");
            Console.WriteLine("CHOOSE S for Subtraction");
            Console.WriteLine("CHOOSE M for Multiplication");
            Console.WriteLine("CHOOSE D for Division");
            Console.WriteLine("PLEASE ENTER YOUR CHOICE");
            char choice = (char)Console.Read();
            switch(choice)
            {
                case 'A':
                    Console.WriteLine("YOU CHOSE ADDITION. YOUR ANSWER IS: " + (num1 + num2));
                    break;
                case 'S':
                    Console.WriteLine("YOU CHOSE SUBTRACTION. YOUR ANSWER IS: " + (num1 - num2));
                    break;
                case 'M':
                    Console.WriteLine("YOU CHOSE Multiplication. YOUR ANSWER IS: " + (num1 * num2));
                    break;
                case 'D':
                    Console.WriteLine("YOU CHOSE DIVISION. YOUR ANSWER IS: " + (num1 / num2));
                    break;
            }

        }
    }
}
