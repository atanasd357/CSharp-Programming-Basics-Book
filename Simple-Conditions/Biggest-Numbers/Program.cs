using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 15

namespace Biggest_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());

            if (num <= 1 && num <= 9)
            {
                if (num == 0)
                {
                    Console.WriteLine("zero");
                }
                else if (num == 1)
                {
                    Console.WriteLine("one");
                }
                else if (num == 2)
                {
                    Console.WriteLine("two");
                }
                else if (num == 3)
                {
                    Console.WriteLine("three");
                }
                else if (num == 4)
                {
                    Console.WriteLine("four");
                }
                else if (num == 5)
                {
                    Console.WriteLine("five");
                }
                else if (num == 6)
                {
                    Console.WriteLine("six");
                }
                else if (num == 7)
                {
                    Console.WriteLine("seven");
                }
                else if (num == 8)
                {
                    Console.WriteLine("eight");
                }
                else if (num == 9)
                {
                    Console.WriteLine("nine");
                }
            }

            else if (num >= 10 && num <= 20)
            {
                if (num == 10)
                {
                    Console.WriteLine("ten");
                }
                else if (num == 11)
                {
                    Console.WriteLine("eleven");
                }
                else if (num == 12)
                {
                    Console.WriteLine("twelve");
                }
                else if (num == 13)
                {
                    Console.WriteLine("Thirteen");
                }
                else if (num == 14)
                {
                    Console.WriteLine("fourteen");
                }
                else if (num == 15)
                {
                    Console.WriteLine("fifteen");
                }
                else if (num == 16)
                {
                    Console.WriteLine("sixteen");
                }
                else if (num == 17)
                {
                    Console.WriteLine("seventeen");
                }
                else if (num == 18)
                {
                    Console.WriteLine("eighteen");
                }
                else if (num == 19)
                {
                    Console.WriteLine("nineteen");
                }
                else if (num == 20)
                {
                    Console.WriteLine("twenty");
                }
            }

            else if (num >= 21 && num <= 99)
            {
                double tens = num / 10;
                double ones = num % 10;
                if (tens == 2)
                {
                    Console.Write("twenty");
                }
                else if (tens == 3)
                {
                    Console.Write("thirty");
                }
                else if (tens == 4)
                {
                    Console.Write("fourty");
                }
                else if (tens == 5)
                {
                    Console.Write("fifty");
                }
                else if (tens == 6)
                {
                    Console.Write("sixty");
                }
                else if (tens == 7)
                {
                    Console.Write("seventy");
                }
                else if (tens == 8)
                {
                    Console.Write("eighty");
                }
                else if (tens == 9)
                {
                    Console.Write("ninety");
                }
                if (ones == 1)
                {
                    Console.WriteLine(" one");
                }
                else if (ones == 2)
                {
                    Console.WriteLine(" two");
                }
                else if (ones == 3)
                {
                    Console.WriteLine(" three");
                }
                else if (ones == 4)
                {
                    Console.WriteLine(" four");
                }
                else if (ones == 5)
                {
                    Console.WriteLine(" five");
                }
                else if (ones == 6)
                {
                    Console.WriteLine(" six");
                }
                else if (ones == 7)
                {
                    Console.WriteLine(" seven");
                }
                else if (ones == 8)
                {
                    Console.WriteLine(" eight");
                }
                else if (ones == 9)
                {
                    Console.WriteLine(" nine");
                }
            }

            else if (num == 100)
            {
                Console.WriteLine("one hundred");
            }
            else if (num > 100 || num < 0)
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}
