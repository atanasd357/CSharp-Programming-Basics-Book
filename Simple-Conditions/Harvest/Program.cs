using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exam task 4

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter vineyard area: ");
            int vineyard = int.Parse(Console.ReadLine());
            Console.Write("Enter grapes per square: ");
            double grapesPerSquare = double.Parse(Console.ReadLine());
            Console.Write("Enter vine liters needed: ");
            int vineLiters = int.Parse(Console.ReadLine());
            Console.Write("Enter number of workers: ");
            int workers = int.Parse(Console.ReadLine());

            double allGrape = (vineyard * grapesPerSquare) * 0.4;
            double vineProduced = allGrape / 2.5;
            if (vineProduced < vineLiters)
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(vineLiters - vineProduced));
            }
            else
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(vineProduced));
                Console.WriteLine("{0} liters left -> {1} liters per person.", 
                    Math.Ceiling(vineProduced - vineLiters), Math.Ceiling((vineProduced - vineLiters) / workers));
            }
        }
    }
}
