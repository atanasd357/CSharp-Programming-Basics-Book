using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 12

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of pairs: ");
            var n = int.Parse(Console.ReadLine());

            int sum = 0;
            int difference = 0;
            int previous = 0;
            int maxDiff = 0;

            for (int i = 0; i < n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                sum = num1 + num2;
                difference = Math.Abs(num1 + num2 - previous);
                previous = sum;
                if (difference > maxDiff && sum != difference)
                {
                    maxDiff = difference;
                }
            }
            if (difference != 0 && sum != difference)
            {
                Console.WriteLine("No, maxdiff={0}", maxDiff);
            }
            else
            {
                Console.WriteLine("Yes, value={0}", sum);
            }
        }

    }
    
}
