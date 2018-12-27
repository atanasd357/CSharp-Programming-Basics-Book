using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exam task 5

namespace Daily_Earnings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of working days: ");
            int workDays = int.Parse(Console.ReadLine());
            Console.Write("Daily earn: ");
            double dailyEarn = double.Parse(Console.ReadLine());
            Console.Write("Dolar exchange rate: ");
            double dolarExch = double.Parse(Console.ReadLine());

            double monthlyEarn = workDays * dailyEarn;
            double yearEarn = monthlyEarn * 12 + monthlyEarn * 2.5;
            double netIncomeDol = yearEarn - (yearEarn * 0.25);
            double netIncomeLv = netIncomeDol * dolarExch;
            double averDailyEarn = netIncomeLv / 365;
            Console.WriteLine(Math.Round(averDailyEarn,2));
        }
    }
}
