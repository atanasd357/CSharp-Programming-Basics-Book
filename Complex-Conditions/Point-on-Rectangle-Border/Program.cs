using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 6

namespace Point_on_Rectangle_Border
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rectangle points coordinates:");
            Console.Write("Enter x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Enter y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Enter x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Enter y2: ");
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinates of point for check:");
            Console.Write("Enter x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            double y = double.Parse(Console.ReadLine());

            if (((x == x1 || x == x2) && (y >= y1) && (y <= y2)) ||
                    ((y == y1 || y == y2) && (x >= x1) && (x <= x2)))
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside of border");
            }
        }
    }
}
