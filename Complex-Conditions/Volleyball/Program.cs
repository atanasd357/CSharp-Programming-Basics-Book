using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 12

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter year (leap or normal): ");
            string year = Console.ReadLine().ToLower();
            Console.Write("Enter holidays: ");
            short holidays = short.Parse(Console.ReadLine());
            Console.Write("Enter number of weekends: ");
            short weekends = short.Parse(Console.ReadLine());

            int sofiaWeek = 48 - weekends;
            double playInSofia = (3.0 * sofiaWeek) / 4 + (2.0 * holidays) / 3;
            double all = 0;

            switch (year)
            {
                case "leap":
                    all = ((playInSofia + weekends) + 0.15 * (playInSofia + weekends));
                    break;
                case "normal":
                    all = (playInSofia + weekends);
                    break;
            }

            Console.WriteLine(Math.Floor(all));
        }
    }
}
