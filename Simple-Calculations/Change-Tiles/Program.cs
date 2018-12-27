using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exam task 3

namespace Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length of landing side: ");
            int landingSide = int.Parse(Console.ReadLine());
            Console.Write("Enter tile width: ");
            double tileWidth = double.Parse(Console.ReadLine());
            Console.Write("Enter tile length: ");
            double tileLength = double.Parse(Console.ReadLine());
            Console.Write("Enter bench width: ");
            int benchWidth = int.Parse(Console.ReadLine());
            Console.Write("Enter bench length: ");
            int benchLength = int.Parse(Console.ReadLine());

            int benchArea = benchWidth * benchLength;
            int areaForCover = (landingSide * landingSide) - benchArea;
            double tileNeeds = areaForCover / (tileWidth * tileLength);
            double timeNeeds = tileNeeds * 0.2;
            Console.WriteLine("Tiles needed: " + tileNeeds);
            Console.WriteLine("Time for laying the tiles: " + timeNeeds + " minutes");
        }
    }
}
