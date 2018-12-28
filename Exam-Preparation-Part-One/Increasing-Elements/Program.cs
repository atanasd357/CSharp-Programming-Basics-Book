using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 8

namespace Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            int currentLongest = 0;
            int countLongest = 0;
            int aPrev = 0;
            
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a > aPrev) 
                {
                    currentLongest++;
                }
                else
                {
                    currentLongest = 1;
                }
                if (currentLongest > countLongest) 
                {
                    countLongest = currentLongest;
                }
                aPrev = a;             
            }
            Console.WriteLine(countLongest);
        }
    }
}
