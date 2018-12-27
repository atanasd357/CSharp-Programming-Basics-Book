using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 1

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score= ");
            int num = int.Parse(Console.ReadLine());
            var bonusScore = 0.0;
            if (num <= 100)
            {
                bonusScore = 5;
            }
            if (num > 100)
            {
                bonusScore = 0.2 * num;
            }
            if (num > 1000)
            {
                bonusScore = 0.1 * num;
            }
          
            if (num % 2 == 0)
            {
                bonusScore += 1;
            }
            else if (num % 10 == 5)
            {
                bonusScore += 2;
            }

            Console.WriteLine("Bonus score= " + bonusScore);
            Console.WriteLine("Totatl score= " + (num + bonusScore));
        }
    }
}
