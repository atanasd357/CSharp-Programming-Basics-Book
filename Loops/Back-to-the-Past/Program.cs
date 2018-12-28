using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exam task 3

namespace Back_to_the_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double inheritedMoney = double.Parse(Console.ReadLine());
            int yearOfLife = int.Parse(Console.ReadLine());

            int age = 0;
            double sum1 = 0;
            double sum2 = 0;

            for (int i = 1800; i <= yearOfLife; i++) 
            {
                if (i % 2 == 0) 
                {
                    sum1 += 12000;
                }
                else
                {
                    age = 18 + (i - 1800);
                    sum2 = sum2+(12000 + 50 *age);
                }
            }

            double allmoney = sum1 + sum2;

            if (inheritedMoney >= allmoney) 
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", inheritedMoney - allmoney);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", allmoney - inheritedMoney);
            }
        }
    }
}
