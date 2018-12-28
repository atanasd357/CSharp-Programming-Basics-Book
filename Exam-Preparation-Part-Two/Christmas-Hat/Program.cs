using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 5

namespace Christmas_Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            int numRows = 2 * n - 1;

            Console.WriteLine("{0}/|\\{0}", new string('.', ((4 * n) - 2) / 2));
            Console.WriteLine("{0}\\|/{0}", new string('.', ((4 * n) - 2) / 2));
            Console.WriteLine("{0}***{0}", new string('.',((4 * n) - 2) / 2));
            
            for (int i = 1; i <= numRows; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', numRows - i), new string('-', i));               
            }

            Console.WriteLine(new string('*', (4 * n) +1));
            for (int i = 1; i <= 2*n; i++)
            {
                Console.Write("*.");
            }
            Console.WriteLine("*");
            Console.WriteLine(new string('*', (4 * n) + 1));
        }
    }
}
