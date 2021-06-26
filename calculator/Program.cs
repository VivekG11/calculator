using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Add();
            Console.WriteLine("Sathyabama University");
            Basic.Def();
            Console.WriteLine("Performing merge command");

        }
        public static void Add()
        {
            Console.WriteLine("Performing Add");
            int a = 11;
            int b = 29;
            Console.WriteLine("The sum is :"+(a+b));
            Details();
        }
        public static void Details()
        {
            Console.WriteLine("Vivek");
            Console.WriteLine("Tvs Next Fellowship Program");
        }
    }
}
