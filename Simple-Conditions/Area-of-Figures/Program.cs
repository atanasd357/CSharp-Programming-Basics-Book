using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 12

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter type of figure: ");
            string fig = Console.ReadLine().ToLower();

            if (fig == "square") 
            {
                Console.Write("Enter side of the square: ");
                double side = double.Parse(Console.ReadLine());

                double area = side * side;
                Console.WriteLine("The area is: " + Math.Round(area, 3));
            }
            if (fig == "rectangle")
            {
                Console.Write("Enter first side of the rectangle: ");
                double side1 = double.Parse(Console.ReadLine());
                Console.Write("Enter second side of the rectangle: ");
                double side2 = double.Parse(Console.ReadLine());

                double area = side1 * side2;
                Console.WriteLine("The area is: " + Math.Round(area, 3));
            }
            if (fig == "circle")
            {
                Console.Write("Enter radius of the circle: ");
                double radius = double.Parse(Console.ReadLine());

                double area = Math.PI * radius * radius;
                Console.WriteLine("The area is: " + Math.Round(area, 3));
            }
            if (fig == "triangle")
            {
                Console.Write("Enter first side of the triangle: ");
                double side1 = double.Parse(Console.ReadLine());
                Console.Write("Enter first side of the triangle: ");
                double side2 = double.Parse(Console.ReadLine());

                double area = side1 * (side2 / 2);
                Console.WriteLine("The area is: " + Math.Round(area, 3));
            }
        }
    }
}
