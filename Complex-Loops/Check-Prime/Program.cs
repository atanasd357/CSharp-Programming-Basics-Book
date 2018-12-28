using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 10

namespace Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            long n = long.Parse(Console.ReadLine());

            bool prime = (n > 1);

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
            }

            if (prime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            } 
        }
    }
}
