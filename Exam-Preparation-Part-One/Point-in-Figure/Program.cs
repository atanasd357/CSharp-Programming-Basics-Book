﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 4

namespace Point_in_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            int y = int.Parse(Console.ReadLine());

            bool pointInRect1 = (x >= 4 && x <= 10) && (y >= -5 && y <= 3);
            bool pointInRect2 = (x >= 2 && x <= 12) && (y >= -3 && y <= 1);

            if (pointInRect1||pointInRect2)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
        }
    }
}
