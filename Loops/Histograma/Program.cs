using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exam task 1

namespace Histograma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of nums: ");
            int n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    p1 = p1 + 1;
                }
                else if (num >= 200 && num <= 399) 
                {
                    p2 += 1;
                }
                else if (num >= 400 && num <= 599)
                {
                    p3 += 1;
                }
                else if (num >= 600 && num <= 799)
                {
                    p4 += 1;
                }
                else if (num >= 800)
                {
                    p5 += 1;
                }
            }
            Console.WriteLine("{0:f2}%", (p1 * 100.0) / n);
            Console.WriteLine("{0:f2}%", (p2 * 100.0) / n);
            Console.WriteLine("{0:f2}%", (p3 * 100.0) / n);
            Console.WriteLine("{0:f2}%", (p4 * 100.0) / n);
            Console.WriteLine("{0:f2}%", (p5 * 100.0) / n);
        }
    }
}
