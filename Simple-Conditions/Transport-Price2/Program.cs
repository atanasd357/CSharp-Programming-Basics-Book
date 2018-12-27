using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exam task 1, variant 2

namespace Transport_Price2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter kilometers: ");
            int km = int.Parse(Console.ReadLine());
            Console.Write("Enter day or night: ");
            string period = Console.ReadLine().ToLower();

            double price = 0;
            double taxiPrice = 0;
            double busPrice = 0.09;
            double trainPrice = 0.06;

            if (period == "day") 
            {
                taxiPrice = 0.79;
            }
            else
            {
                taxiPrice = 0.9;
            }

            string transportType = null;
            if (km < 20)
            {
                price = 0.7 + km * taxiPrice;
                transportType = "taxi";
            }
            else if (km < 100) 
            {
                price = km * 0.09;
                transportType = "bus";
            }
            else
            {
                price = km * 0.06;
                transportType = "train";
            }
            Console.WriteLine("The cheapest transport is with {0}: " + price, transportType);
        }
    }
}
