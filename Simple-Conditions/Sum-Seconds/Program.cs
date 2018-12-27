using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 2

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first competitor seconds: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter second competitor seconds: ");
            int second = int.Parse(Console.ReadLine());
            Console.Write("Enter third competitor seconds: ");
            int third = int.Parse(Console.ReadLine());

            int seconds = first + second + third;
            int minutes = 0;

            if (seconds > 0 && seconds <= 59)
            {
                minutes = 0;
                seconds = seconds;
            }
            if (seconds > 59 && seconds <= 119) 
            {
                minutes = 1; 
                seconds = seconds - 60;
            }
            if (seconds > 119 && seconds <= 179) 
            {
                minutes = 2;
                seconds = seconds - 120;
            }

            if (seconds < 10) 
            {
                Console.WriteLine(minutes + ":" + "0" + seconds);
            }
            else
            {
                Console.WriteLine(minutes + ":" + seconds);
            }
        }
    }
}
