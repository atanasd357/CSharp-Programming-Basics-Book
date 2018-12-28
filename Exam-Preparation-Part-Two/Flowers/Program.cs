using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 3

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of buyed chrysanthemums: ");
            int chrysanthemums = int.Parse(Console.ReadLine());
            Console.Write("Enter number of buyed roses: ");
            int roses = int.Parse(Console.ReadLine());
            Console.Write("Enter number of buyed tulips: ");
            int tulips = int.Parse(Console.ReadLine());
            Console.Write("Enter season: ");
            string season = Console.ReadLine().ToLower();
            Console.Write("Is day are holiday (y or n): ");
            string holiday = Console.ReadLine().ToLower();

            double chrysanthemPrice = 0;
            double rosesPrice = 0;
            double tulipPrice = 0;                      
            double priceBucket = 0;

            if (season == "spring" || season == "summer")
            {
                chrysanthemPrice = 2.00 * chrysanthemums;
                rosesPrice = 4.10 * roses;
                tulipPrice = 2.50 * tulips;
                priceBucket = chrysanthemPrice + rosesPrice + tulipPrice;

                if (holiday == "y")
                {
                    priceBucket *= 1.15;                    
                }
             
                if (season == "spring" && tulips > 7) 
                {
                    priceBucket *= 0.95;
                }           
            }

            else if (season == "autumn" || season == "winter")
            {
                chrysanthemPrice = 3.75 * chrysanthemums;
                rosesPrice = 4.50 * roses;
                tulipPrice = 4.15 * tulips;
                priceBucket = chrysanthemPrice + rosesPrice + tulipPrice;

                if (holiday == "y")
                {
                    priceBucket *= 1.15;            
                }
           
                if (season == "winter" && roses >= 10) 
                {
                    priceBucket *= 0.9;
                }
            }

            int sumFlowers = roses + chrysanthemums + tulips;
            if (sumFlowers > 20)
            {
                priceBucket *= 0.8;
            }

            Console.WriteLine("{0:f2}", priceBucket + 2);            
        }
    }
}
