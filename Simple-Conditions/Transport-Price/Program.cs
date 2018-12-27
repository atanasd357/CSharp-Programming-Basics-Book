using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exam task 1, variant 1

namespace Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter kilometers: ");
            int km = int.Parse(Console.ReadLine());
            Console.Write("Enter day or night: ");
            string period = Console.ReadLine().ToLower();

            double taxiDay = 0.7 + (0.79 * km);
            double taxiNight = 0.7 + (0.9 * km);
            double busDay = 0.09 * km;
            double busNight = busDay;
            double trainDay = 0.06 * km;
            double trainNight = trainDay;

            if (km < 20)
            {
                if (period == "day")
                {
                    Console.WriteLine(taxiDay);
                }
                else if (period == "night")
                {
                    Console.WriteLine(taxiNight);
                }
            }

            else if (km >= 20 && km < 100)
            {
                if (period == "day")
                {
                    if (taxiDay < busDay)
                    {
                        Console.WriteLine(taxiDay);
                    }
                    else
                    {
                        Console.WriteLine(busDay);
                    }
                }
                else if (period == "night")
                {
                    if (taxiNight < busNight)
                    {
                        Console.WriteLine(taxiNight);
                    }
                    else
                    {
                        Console.WriteLine(busNight);
                    }
                }
            }

            else if (km >= 100)
            {
                if (period == "day")
                {
                    if (taxiDay < busDay && taxiDay < trainDay)
                    {
                        Console.WriteLine(taxiDay);
                    }
                    else if (busDay < taxiDay && busDay < trainDay)
                    {
                        Console.WriteLine(busDay);
                    }
                    else if (trainDay < taxiDay && trainDay < busDay)
                    {
                        Console.WriteLine(trainDay);
                    }
                }
                else if (period == "night")
                {
                    if (taxiNight < busNight && taxiNight < trainNight)
                    {
                        Console.WriteLine("The cheapest transport is with taxi: " + taxiNight);
                    }
                    else if (busNight < taxiNight && busNight < trainNight)
                    {
                        Console.WriteLine("The cheapest transport is with bus: " + busNight);
                    }
                    else if (trainNight < taxiNight && trainNight < busNight)
                    {
                        Console.WriteLine("The cheapest transport is with train: " + trainNight);
                    }
                }
            }
        }
    }
}
