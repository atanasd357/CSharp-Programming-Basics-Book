﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exam task 1

namespace Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number 1: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int l = int.Parse(Console.ReadLine());

            for (int d1 = 1; d1 <= n; d1++)
            {
                for (int d2 = 1; d2 <= n; d2++)
                {
                    for (char l1 = 'a'; l1 < 'a'+l; l1++)
                    {
                        for (char l2 = 'a'; l2 < 'a'+l; l2++)
                        {
                            for (int d3 = Math.Max(d1,d2)+1; d3 <=n; d3++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", d1, d2, l1, l2, d3);
                            }
                        }
                    }
                }
            }
        }
    }
}
