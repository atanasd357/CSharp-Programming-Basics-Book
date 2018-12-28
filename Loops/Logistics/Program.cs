using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exam task 6

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of freights: ");
            int n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            Console.WriteLine("Enter weight of the each freight: ");

            for (int i = 0; i < n; i++)
            {
                int weight = int.Parse(Console.ReadLine());
                if (weight <= 3)
                {
                    p1 = p1 + weight;
                }
                else if (weight > 3 && weight <= 11)
                {
                    p2 = p2 + weight;
                }
                else if(weight>11)
                {
                    p3 = p3 + weight;
                }
            }

            double averagePrice = (p1 * 200 + p2 * 175 + p3 * 120)/(p1+p2+p3);

            Console.WriteLine("Average price for ton: {0:f2}", averagePrice);
            Console.WriteLine("With bus: {0:f2}%", (p1 * 100) / (p1 + p2 + p3));
            Console.WriteLine("With truck: {0:f2}%", (p2 * 100) / (p1 + p2 + p3));
            Console.WriteLine("With train: {0:f2}%", (p3 * 100) / (p1 + p2 + p3));
        }
    }
}
