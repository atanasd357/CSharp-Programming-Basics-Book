using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 2

namespace Magic_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first year: ");
            int firstYear = int.Parse(Console.ReadLine());
            Console.Write("Enter second year: ");
            int lastYear = int.Parse(Console.ReadLine());
            Console.Write("Enter magic weight: ");
            int magicWeight = int.Parse(Console.ReadLine());

            int dataWeight = 0;
            int d1 = 0;
            int d2 = 0;
            int d3 = 0;
            int d4 = 0;
            int d5 = 0;
            int d6 = 0;
            int d7 = 0;
            int d8 = 0;
            bool printed = false;
            DateTime cuurrentDate = new DateTime(firstYear, 1, 1);

            while (cuurrentDate.Year <= lastYear)
            {
                d1 = cuurrentDate.Day / 10;
                d2 = cuurrentDate.Day % 10;
                d3 = cuurrentDate.Month / 10;
                d4 = cuurrentDate.Month % 10;
                d5 = cuurrentDate.Year / 1000;
                d6 = cuurrentDate.Year / 100 % 10;
                d7 = cuurrentDate.Year / 10 % 10;
                d8 = cuurrentDate.Year % 10;
                dataWeight = d1 * (d2 + d3 + d4 + d5 + d6 + d7 + d8) +
                    d2 * (d3 + d4 + d5 + d6 + d7 + d8) +
                    d3 * (d4 + d5 + d6 + d7 + d8) +
                    d4 * (d5 + d6 + d7 + d8) +
                    d5 * (d6 + d7 + d8) +
                    d6 * (d7 + d8) +
                    d7 * d8;
                if (dataWeight == magicWeight)
                {
                    Console.WriteLine(cuurrentDate.ToString("dd-MM-yyyy"));
                    printed = true;      
                }
                cuurrentDate = cuurrentDate.AddDays(1);
            }
            if (!printed)
            {
                Console.WriteLine("No");
            }
        }
    }
}
