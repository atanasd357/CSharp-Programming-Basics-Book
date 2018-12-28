using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 5

namespace Date_After_Five_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter day: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Enter month: ");
            int month = int.Parse(Console.ReadLine());

            int daysMonth = 31;

            if (month == 2) 
            {
                daysMonth = 28;
            }

            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                daysMonth = 30;
            }
            day += 5;

            if (day > daysMonth) 
            {
                day -= daysMonth;
                month++;
                if(month>12)
                {
                    month = 1;
                }
            }
            Console.WriteLine("{0}.{1:d2}", day, month);
        }
    }
}
