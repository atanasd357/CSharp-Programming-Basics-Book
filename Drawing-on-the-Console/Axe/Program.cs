using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exam task 5

namespace Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            int axeWidth = 5 * n;
            int axeLeft = 3 * n;
            Console.WriteLine("{0}**{1}",
                new string('-', axeLeft),
                new string('-', axeWidth - axeLeft - 2));

            for (int i = 1; i <=n-1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}",
                    new string('-', axeLeft),
                    new string('-', i),
                    new string('-', axeWidth - axeLeft - i - 2));
            }

            int b = 0;
            int axeHeight = 0;

            if (n % 2 == 0) 
            {
                b = n / 2;
                axeHeight = 2 * n;
            }
            else
            {
                b = (n - 1) / 2;
                axeHeight = 2 * n - 1;
            }

            for (int i = 1; i <= b; i++)
            {
                Console.WriteLine("{0}{1}*{1}",
                    new string('*', axeLeft + 1),
                    new string('-', (axeWidth - axeLeft - 2) / 2));
            }

            for (int i = 0; i < n/2 - 1; i++) 
            {
                Console.WriteLine("{0}*{1}*{2}",
                    new string('-', axeLeft - i),
                    new string('-', (n - 1) + 2 * i),
                    new string('-', axeWidth - (axeLeft - i) - ((n-1)+2*i)-2));
            }

            Console.WriteLine("{0}{1}{2}",
               new string('-', axeLeft - (n/2 - 1)),
               new string('*', 2+(n-1)+2*(n/2-1)),
               new string('-', axeWidth - (axeLeft - (n/2 - 1))-(2 + (n - 1) + 2 * (n / 2 - 1))));
        }
    }
}
