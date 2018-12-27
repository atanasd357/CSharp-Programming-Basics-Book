using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 1

namespace Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x1: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Enter y1: ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("Enter x2: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Enter y2: ");
            int y2 = int.Parse(Console.ReadLine());
            Console.Write("Enter x3: ");
            int x3 = int.Parse(Console.ReadLine());
            Console.Write("Enter y3: ");
            int y3 = int.Parse(Console.ReadLine());

            int a = Math.Abs(x2 - x3);
            int h = Math.Abs(y3 - y1);
            double s = a * (h / 2.0);
            Console.WriteLine("The area is: " + s);
        }
    }
}
