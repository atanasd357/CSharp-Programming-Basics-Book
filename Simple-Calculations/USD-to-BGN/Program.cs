﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 11

namespace USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("USD = ");
            var usd = double.Parse(Console.ReadLine());
            var bgn = usd * 1.79549;
            Console.WriteLine("BGN = " + Math.Round(bgn, 2));
        }
    }
}
