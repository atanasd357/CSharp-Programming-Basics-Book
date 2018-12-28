using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 12

namespace Integer_to_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter base: ");
            int toBase = int.Parse(Console.ReadLine());

            Console.WriteLine(IntegerToBases(number, toBase));
        }

        static string IntegerToBases(int number, int toBase)
        {
            string result = "";

            while (number != 0)
            {
                int ost = number % toBase;
                result = ost + "" + result;
                number /= toBase;
            }

            return result;
        }
    }
}
