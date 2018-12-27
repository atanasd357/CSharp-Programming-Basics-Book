using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exam task 4

namespace Arrow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            int dots = (n - 1) / 2;
            Console.WriteLine("{0}{1}{0}", 
                new string('.', dots), 
                new string('#', n));

            for (int i = 1; i <= n-2; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", 
                    new string('.', dots), 
                    new string('.', n-2));
            }

            int arrowLineWidth = 2*dots + n;
            Console.WriteLine("{0}{1}{0}",
                new string('#', (arrowLineWidth - (n - 2)) / 2),
                new string('.', n - 2));

            for (int i = 1; i <= n-2; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", 
                    new string('.', i), 
                    new string('.', arrowLineWidth - 2 - 2 * i));
            }

            Console.WriteLine("{0}#{0}", new string('.', (arrowLineWidth - 1) / 2));
        }
    }
}
