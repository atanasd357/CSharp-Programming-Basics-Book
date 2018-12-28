using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 5

namespace Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter h: ");
            double h = double.Parse(Console.ReadLine());

            double area = GetTriangleArea(a, h);

            Console.WriteLine(area);
        }

        static double GetTriangleArea(double lenght, double height)
        {
            return (lenght * height) / 2;
        }
    }
}
