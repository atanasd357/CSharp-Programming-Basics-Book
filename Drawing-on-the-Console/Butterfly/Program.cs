using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exam task 2

namespace Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            int butterflyWidth = 2 * n - 1;
            int buttterflyHeight = 2 * (n - 2) + 1;

            int bodyHeight = (buttterflyHeight - 1) / 2;
            for (int i = 1; i <= bodyHeight; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0}\\ /{0}", new string('-', (butterflyWidth - 3) / 2));
                }
                else 
                {
                    Console.WriteLine("{0}\\ /{0}", new string('*', (butterflyWidth - 3) / 2));
                }
            }

            Console.WriteLine("{0}@{0}", new string(' ', (butterflyWidth - 1) / 2));

            for (int i = 1; i <= bodyHeight; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0}/ \\{0}", new string('-', (butterflyWidth - 3) / 2));
                }
                else
                {
                    Console.WriteLine("{0}/ \\{0}", new string('*', (butterflyWidth - 3) / 2));
                }
            }
        }
    }
}
