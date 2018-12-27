﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 8

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));

            for (int i = 0; i < n - 2; i++) 
            {
                Console.Write(new string('*', 1));
                Console.Write(new string('/', (2 * n) - 2));
                Console.Write(new string('*', 1));

                if (i == (n - 1) / 2 - 1)
                {
                    Console.Write(new string('|', n));
                }
                else
                {
                    Console.Write(new string(' ', n));
                }

                Console.Write(new string('*', 1));
                Console.Write(new string('/', (2 * n) - 2));
                Console.Write(new string('*', 1));
                Console.WriteLine();
            }

            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));
        }
    }
}
