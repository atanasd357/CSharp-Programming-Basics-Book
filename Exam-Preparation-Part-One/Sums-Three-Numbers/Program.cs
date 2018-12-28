using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 6

namespace Sums_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = int.Parse(Console.ReadLine());

            int sum = 0;

            if (a >= b && a >= c)
            {
                sum = b + c;
            }
            else if (b >= a && b >= c)
            {
                sum = a + c;
            }
            else if (c >= a && c >= b)
            {
                sum = a + b;
            }
            
            if(sum==a)
            {
                Console.WriteLine("{0} + {1} = {2}", Math.Min(b, c), Math.Max(b, c), a);
            }
            else if (sum == b)
            {
                Console.WriteLine("{0} + {1} = {2}", Math.Min(a, c), Math.Max(a, c), b);
            }
            else if (sum == c)
            {
                Console.WriteLine("{0} + {1} = {2}", Math.Min(a, b), Math.Max(a, b), c);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
