using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exam task 5

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter hours needs for the project: ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Enter the days available for the project: ");
            int firmDays = int.Parse(Console.ReadLine());
            Console.Write("Enter number of employees: ");
            int employees = int.Parse(Console.ReadLine());

            double totalHours = Math.Floor((0.9 * firmDays) * 10 * employees);
            if (totalHours < hours)
            {
                Console.WriteLine("Not enough time! {0} hours needed.", Math.Floor(hours - totalHours));
            }
            else
            {
                Console.WriteLine("Yes! {0} hours left.", Math.Floor(totalHours - hours));
            }
        }
    }
}
