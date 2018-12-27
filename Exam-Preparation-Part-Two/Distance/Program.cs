using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 1

namespace Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter speed: ");
            int speed = int.Parse(Console.ReadLine());
            Console.Write("Enter first time: ");
            int time1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second time: ");
            int time2 = int.Parse(Console.ReadLine());
            Console.Write("Enter third time: ");
            int time3 = int.Parse(Console.ReadLine());

            double speed2 = speed * 1.1;
            double speed3 = speed2 * 0.95;

            double distance1 = (time1 * 0.0166666667) * speed;
            double distance2 = (time2 * 0.0166666667) * speed;
            double distance3 = (time3 * 0.0166666667) * speed;

            double sumDistance = distance1 + distance2 + distance3;
            Console.WriteLine("{0:f2}", sumDistance);
        }
    }
}
