using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 3

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            double number = double.Parse(Console.ReadLine());
            Console.Write("Enter number unit: ");
            string entryUnit = Console.ReadLine().ToLower();
            Console.Write("Enter conversion unit: ");
            string exitUnit = Console.ReadLine().ToLower();

            if (entryUnit == "mm")
            {
                number = number / 1000;
            }
            if (entryUnit == "cm")
            {
                number = number / 100;
            }
            if (entryUnit == "mi")
            {
                number = number / 0.000621371192;
            }
            if (entryUnit == "in")
            {
                number = number / 39.3700787;
            }
            if (entryUnit == "km")
            {
                number = number / 0.001;
            }
            if (entryUnit == "ft")
            {
                number = number / 3.2808399;
            }
            if (entryUnit == "yd")
            {
                number = number / 1.0936133;
            }
            if (exitUnit == "mm")
            {
                number = number * 1000;
            }
            if (exitUnit == "cm")
            {
                number = number * 100;
            }
            if (exitUnit == "mi")
            {
                number = number * 0.000621371192;
            }
            if (exitUnit == "in")
            {
                number = number * 39.3700787;
            }
            if (exitUnit == "km")
            {
                number = number * 0.001;
            }
            if (exitUnit == "ft")
            {
                number = number * 3.2808399;
            }
            if (exitUnit == "yd")
            {
                number = number * 1.0936133;
            }

            Console.WriteLine(number + " " + exitUnit);
        }
    }
}
