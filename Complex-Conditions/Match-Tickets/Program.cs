using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exam task 4

namespace Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter budget: ");
            double budget = double.Parse(Console.ReadLine());
            Console.Write("Enter category: ");
            string category = Console.ReadLine().ToLower();
            Console.Write("Enter number of tickets: ");
            int ticketsNum = int.Parse(Console.ReadLine());

            double transport = 0;

            if (ticketsNum >= 1 && ticketsNum <= 4)
            {
                transport = 0.75 * budget;
            }
            else if (ticketsNum >= 5 && ticketsNum <= 9)
            {
                transport = 0.6 * budget;
            }
            else if (ticketsNum >= 10 && ticketsNum <= 24)
            {
                transport = 0.5 * budget;
            }
            else if (ticketsNum >= 25 && ticketsNum <= 49)
            {
                transport = 0.4 * budget;
            }
            else if (ticketsNum >= 50)
            {
                transport = 0.25 * budget;
            }

            double allprice = 0;

            if (category == "vip")
            {
                allprice = (budget-transport) - (ticketsNum * 499.99);
                
            }
            else if (category == "normal")
            {
                allprice = (budget-transport) - (ticketsNum * 249.99);
            }
            if (allprice > 0)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", allprice);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(allprice));
            }
        }
    }
}
