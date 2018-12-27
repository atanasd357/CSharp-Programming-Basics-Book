using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 3

namespace Point_on_Segment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ente first point of the segment line: ");
            int firstPoint = int.Parse(Console.ReadLine());
            Console.Write("Ente second point of the segment line: ");
            int secondPoint = int.Parse(Console.ReadLine());
            Console.Write("Ente point location: ");
            int pointLoc = int.Parse(Console.ReadLine());

            int start = Math.Min(firstPoint, secondPoint);
            int end = Math.Max(firstPoint, secondPoint);
            int distanceStart = Math.Abs(start - pointLoc);
            int distanceEnd = Math.Abs(end - pointLoc);

            if (pointLoc >= start && pointLoc <= end)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
            Console.WriteLine(Math.Min(distanceStart, distanceEnd));
        }
    }
}
