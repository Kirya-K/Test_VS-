﻿using System;

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


            int f = a / b;
            Console.WriteLine("=" + f);


            int d = a - b;
            Console.WriteLine("=" + d);

        }
    }
}
