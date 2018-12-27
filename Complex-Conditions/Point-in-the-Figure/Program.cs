using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 13

namespace Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num: ");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter point coordinates:");
            Console.Write("Enter x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter x: ");
            int y = int.Parse(Console.ReadLine());

            if ((x > 0 && x < 3 * h && y > 0 && y < h) || (x > h && x < 2 * h && y > h && y < 4 * h) || (y == h && x > h && x < 2 * h))
            {
                Console.WriteLine("inside");
            }
            else if ((x < 0 || x > 3 * h || y < 0 || y > h) && (x < h || x > 2 * h || y < h || y > 4 * h))
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine("border");
            }            
        }
    }
}
