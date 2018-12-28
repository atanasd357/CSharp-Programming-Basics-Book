using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exam task 4

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            int d1;
            int d2;
            int d3;
            int d4;

            for (int i = 1111; i <= 9999; i++)
            {
                d1 = (i / 1000) % 10;
                d2 = (i / 100) % 10;
                d3 = (i / 10) % 10;
                d4 = i % 10;

                if (d1 != 0 && d2 != 0 && d3 != 0 && d4 != 0)
                {
                    if (n % d1 == 0 && n % d2 == 0 && n % d3 == 0 && n % d4 == 0)
                    {
                        Console.Write("{0} ", i);
                    }
                }   
            }
        }
    }
}
