using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 1

namespace Crossing_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first Tribonacci num: ");
            int firstTrib = int.Parse(Console.ReadLine());
            Console.Write("Enter second Tribonacci num: ");
            int secondTrib = int.Parse(Console.ReadLine());
            Console.Write("Enter third Tribonacci num: ");
            int thirdTrib = int.Parse(Console.ReadLine());
            Console.Write("Enter first spiral num: ");
            int firstSpiral = int.Parse(Console.ReadLine());
            Console.Write("Enter step of the spiral: ");
            int stepSpiral = int.Parse(Console.ReadLine());

            double a = double.MaxValue;

            int currentTrib = firstTrib + secondTrib + thirdTrib;
            for (int i = 1; i < a ; i++)
            {
                firstTrib = secondTrib;
                secondTrib = thirdTrib;
                thirdTrib = currentTrib;
            }
        }
    }
}
