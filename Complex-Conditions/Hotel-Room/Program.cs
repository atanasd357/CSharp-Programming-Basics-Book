using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exam task 5

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter month: ");
            string month = Console.ReadLine().ToLower();
            Console.Write("Number of nights: ");
            int nights = int.Parse(Console.ReadLine());

            double priceStudio = 0;
            double priceApartment = 0;

            if (month == "may" || month == "october")
            {
                priceApartment = 65 * nights;
                if (nights <= 7)
                {
                    priceStudio = 50 * nights;
                }
                else if (nights > 7 && nights <= 14)
                {
                    priceStudio = 0.95 * (50 * nights);
                }
                else if (nights > 14)
                {
                    priceStudio = 0.7 * (50 * nights);
                }
                
            }
            else if (month == "june" || month == "september")
            {
                priceApartment = 68.70 * nights;
                if (nights <= 14)
                {
                    priceStudio = 75.20 * nights;
                }
                else if (nights > 14)
                {
                    priceStudio = 0.8 * (75.20 * nights);
                }
            }
            else if (month == "july" || month == "august")
            {
                priceStudio = 76 * nights;
                priceApartment = 77 * nights;
            }

            if (nights > 14) 
            {
                Console.WriteLine("Apartment: {0:f2} lv.", (priceApartment * 0.9));
            }
            else
            {
                Console.WriteLine("Apartment: {0:f2} lv.", priceApartment);
            }

            Console.WriteLine("Studio: {0:f2} lv.", priceStudio);
        }
    }
}
