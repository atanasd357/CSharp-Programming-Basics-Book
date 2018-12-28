using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 8

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            int fact = 1;

            do
            {
                fact = fact * n;
                n--;
            }
            while (n > 1);
            Console.WriteLine(fact);
        }
    }
}
