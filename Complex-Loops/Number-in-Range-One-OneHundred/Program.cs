﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 6

namespace Number_in_Range_One_OneHundred
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num: ");
            int num = int.Parse(Console.ReadLine());

            while (num < 1 || num > 100) 
            {
                Console.WriteLine("Invalid number!");
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The number is: {0}", num);
        }
    }
}
