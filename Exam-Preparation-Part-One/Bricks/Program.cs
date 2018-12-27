using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 2

namespace Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of bricks: ");
            int bricks = int.Parse(Console.ReadLine());
            Console.Write("Number of workers: ");
            int workers = int.Parse(Console.ReadLine());
            Console.Write("Capacity of the trolley: ");
            int m = int.Parse(Console.ReadLine());

            int bricksCourse = workers * m;
            double courses = ((double) bricks / bricksCourse);
            Console.WriteLine("Minimal number of courses is: " + Math.Ceiling(courses));
        }
    }
}
