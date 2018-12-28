using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exam task 5

namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            int d1 = (n / 100) % 10;
            int d2 = (n / 10) % 10;
            int d3 = n % 10;
            int rows = d1 + d2;
            int cols = d1 + d3;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= cols; j++)
                {
                    if (n % 5 == 0)
                    {
                        n = n - d1;
                    }
                    else if (n % 3 == 0)
                    {
                        n = n - d2;
                    }
                    else
                    {
                        n = n + d3;
                    }
                    Console.Write("{0} ", n);
                }
                Console.WriteLine();
            }
        }
    }
}
