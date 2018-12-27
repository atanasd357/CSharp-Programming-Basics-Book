using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 14

namespace Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number 1: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter number 2: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Enter number 3: ");
            double num3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Are they equal?");
            if (num1 == num2 && num1 == num3 && num2 == num3)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
