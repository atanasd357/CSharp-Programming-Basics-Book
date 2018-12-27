using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 11

namespace Nth_Digit
{
    class NthDigit
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter index of digit: ");
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine(FindNthDigitt(number, index));
        }

        static int FindNthDigitt(int number, int index)
        {
            int result = 0;
            int count = 0;

            while (number != 0)
            {
                count++;              
                if (count == index)
                {
                    result = number % 10;
                    
                }
                else
                {
                    number = number / 10;
                }             
            }

            return result;
        }
    }
}
