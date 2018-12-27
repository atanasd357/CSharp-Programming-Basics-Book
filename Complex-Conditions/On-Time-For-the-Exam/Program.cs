using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exam task 1

namespace On_Time_For_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter exam hour: ");
            int examHour = int.Parse(Console.ReadLine());
            Console.Write("Enter exam minutes: ");
            int examMin = int.Parse(Console.ReadLine());
            Console.Write("Enter arrive hour: ");
            int arriveHour = int.Parse(Console.ReadLine());
            Console.Write("Enter arrive minutes: ");
            int arriveMin = int.Parse(Console.ReadLine());

            int resultMin = (examMin + examHour * 60) - (arriveMin + arriveHour * 60);

            if (resultMin < 0)
            {
                Console.WriteLine("Late");
            }
            else if (resultMin >= 0 && resultMin <= 30)
            {
                Console.WriteLine("On time");
            }
            else
            {
                Console.WriteLine("Early");
            }

            if (resultMin < 0)
            {
                resultMin = Math.Abs(resultMin);

                if (resultMin > 0 && resultMin <= 59)
                {
                    Console.WriteLine("{0:0} minutes after the start", resultMin);
                }
                else if (resultMin >= 60)
                {
                    double h = Math.Floor((double)resultMin / 60);
                    double m = resultMin % 60;
                    Console.WriteLine("{0:0}:{1:00} hours after the start", h, m);

                }
            }
            else if (resultMin > 0)
            {
                if (resultMin > 0 && resultMin <= 59)
                {
                    Console.WriteLine("{0:0} minutes before the start", resultMin);
                }
                else if (resultMin >= 60)
                {
                    double h = resultMin / 60;
                    double m = resultMin % 60;
                    Console.WriteLine("{0:0}:{1:00} hours before the start", h, m);
                }
            }
        }
    }
}
