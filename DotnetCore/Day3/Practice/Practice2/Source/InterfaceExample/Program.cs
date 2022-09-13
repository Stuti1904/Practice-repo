using System;

namespace InterfaceExample
{

    interface IsSampleInterface
    {
        void sampleMethod();
    }
    class Program: IsSampleInterface
    {

        void IsSampleInterface.sampleMethod()
        {
            Console.WriteLine("this is interface implementation");
        }
        static void Main(string[] args)
        {
            IsSampleInterface obj = new Program();
            obj.sampleMethod();
        }
    }
}
