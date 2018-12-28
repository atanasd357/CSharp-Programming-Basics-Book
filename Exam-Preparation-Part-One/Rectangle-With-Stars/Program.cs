using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 10

namespace Rectangle_With_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('%', n * 2));
            int numRows = n;

            if (n % 2 == 0) 
            {
                numRows--;
            }

            for (int i = 0; i < numRows; i++)
            {
                Console.Write("%");
                if (i == numRows / 2)
                {
                    Console.Write(new string(' ', n - 2));
                    Console.Write("**");
                    Console.Write(new string(' ', n - 2));
                }
                else
                {
                    Console.Write(new string(' ', n * 2 - 2));
                }
                Console.Write("%");
                Console.WriteLine();
            }
            Console.WriteLine(new string('%', n * 2));
        }
    }
}
