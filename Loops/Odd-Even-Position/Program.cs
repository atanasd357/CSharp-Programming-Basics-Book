using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 11

namespace Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of nums: ");
            double n = double.Parse(Console.ReadLine());

            double OddSum = 0;
            double OddMin = double.MaxValue;
            double OddMax = double.MinValue;
            double EvenSum = 0;
            double EvenMin = double.MaxValue;
            double EvenMax = double.MinValue;

            if (n == 1)
            {
                double num = double.Parse(Console.ReadLine());

                Console.WriteLine("OddSum={0}", num);
                Console.WriteLine("OddMin={0}", num);
                Console.WriteLine("OddMax={0}", num);
                Console.WriteLine("EvenSum=0");
                Console.WriteLine("EvenMin=No");
                Console.WriteLine("EvenMax=No");
            }
            else if (n == 0)
            {

                Console.WriteLine("OddSum=0");
                Console.WriteLine("OddMin=No");
                Console.WriteLine("OddMax=No");
                Console.WriteLine("EvenSum=0");
                Console.WriteLine("EvenMin=No");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    double num = double.Parse(Console.ReadLine());

                    if (i % 2 != 0)
                    {
                        if (num < OddMin)
                        {
                            OddMin = num;
                        }
                        if (num > OddMax)
                        {
                            OddMax = num;
                        }
                        OddSum += num;
                    }
                    else if (i % 2 == 0)
                    {
                        if (num < EvenMin)
                        {
                            EvenMin = num;
                        }
                        if (num > EvenMax)
                        {
                            EvenMax = num;
                        }
                        EvenSum += num;
                    }
                }
                Console.WriteLine("OddSum={0}", OddSum);
                Console.WriteLine("OddMin={0}", OddMin);
                Console.WriteLine("OddMax={0}", OddMax);
                Console.WriteLine("EvenSum={0}", EvenSum);
                Console.WriteLine("EvenMin={0}", EvenMin);
                Console.WriteLine("EvenMax={0}", EvenMax);
            }
        }
    }
}
