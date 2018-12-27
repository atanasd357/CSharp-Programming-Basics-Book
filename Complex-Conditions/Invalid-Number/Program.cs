using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 5 

namespace Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            double num = double.Parse(Console.ReadLine());
            bool inRange = ((num >= 100 && num <= 200) || num == 0);

            if (!inRange)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
