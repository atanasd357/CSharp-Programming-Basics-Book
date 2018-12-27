using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 6

namespace Math_Power
{
    class MathPower
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num: ");
            double num = double.Parse(Console.ReadLine());
            Console.Write("Enter pow: ");
            double pow = double.Parse(Console.ReadLine());

            double power = CalculatePower(num, pow);

            Console.WriteLine(power);
        }

        static double CalculatePower(double num, double pow)
        {
            double result = 0d;
            result = Math.Pow(num, pow);
            return result;
        }
    }
}
