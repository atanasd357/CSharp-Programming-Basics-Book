using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 11

namespace Increasing_Four_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = a; i <= b; i++)
            {
                for (int j = i+1; j <= b; j++)
                {
                    for (int r = j+1; r <= b; r++)
                    {
                        for (int t = r+1; t <= b; t++)
                        {
                            Console.WriteLine("{0} {1} {2} {3}", i, j, r, t);
                            count++;
                        }
                    }
                }
            }

            if (count == 0)
            {
                Console.WriteLine("No"); 
            }
        }
    }
}
