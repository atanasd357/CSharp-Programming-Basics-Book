using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exam task 3

namespace Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rest days: ");
            int days = int.Parse(Console.ReadLine());

            int playTime = ((365 - days) * 63) + (days * 127);
            int difference = 0;
            int hours = 0;
            int minutes = 0;

            if (playTime > 30000) 
            {
                Console.WriteLine("Tom will run away");
                difference = playTime - 30000;
                hours = difference / 60;
                minutes = difference % 60;
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                difference = 30000 - playTime;
                hours = difference / 60;
                minutes = difference % 60;
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }
        }
    }
}
