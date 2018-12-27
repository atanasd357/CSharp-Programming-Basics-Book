using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exam task 2

namespace Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter budget: ");
            double budget = double.Parse(Console.ReadLine());
            Console.Write("Enter season: ");
            string season=Console.ReadLine();

            string accommodation = string.Empty;
            double sum = 0;

            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");

                if (season == "summer")
                {
                    sum = 0.3 * budget;
                    accommodation = "Camp";
                }
                else if (season == "winter")
                {
                    sum = 0.7 * budget;
                    accommodation = "Hotel";
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer")
                {
                    sum = 0.4 * budget;
                    accommodation = "Camp";
                }
                else if (season == "winter")
                {
                    sum = 0.8 * budget;
                    accommodation = "Hotel";
                }
            }
            else
            {
                Console.WriteLine("Somewhere in Europe");
                sum = 0.9 * budget;
                accommodation = "Hotel";
            }

            Console.WriteLine("{0} - {1:0.00}", accommodation, Math.Round(sum, 2));
        }
    }
}
