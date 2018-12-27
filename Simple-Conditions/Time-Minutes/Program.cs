using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 13

namespace Time_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter hour: ");
            int hour = int.Parse(Console.ReadLine());
            Console.Write("Enter minutes: ");
            int minutes = int.Parse(Console.ReadLine());

            TimeSpan span = new TimeSpan(hour, minutes, 0);
            TimeSpan span2 = new TimeSpan(0, 15, 0);
            TimeSpan total = span + span2;
            Console.WriteLine("Time after 15 minutes is: {0:h\\:mm}", total);
        }
    }
}
