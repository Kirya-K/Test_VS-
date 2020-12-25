using System;

namespace git_Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите А:");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите B:");
            int b = Int32.Parse(Console.ReadLine());

///ффффф


            int f = a / b;
            Console.WriteLine("=" + f);


            int d = a - b;
            Console.WriteLine("=" + d);


            int c = a + b;
            Console.WriteLine("=" + c);

            int e = a * b;
            Console.WriteLine("=" + e);


        }
    }
}
