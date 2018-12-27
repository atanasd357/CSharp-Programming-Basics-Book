using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exam task 2

namespace Smart_Lilly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Lylly's age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter price of the wash machine: ");
            double priceWash = double.Parse(Console.ReadLine());
            Console.Write("Enter price of the toy: ");
            int priceToy = int.Parse(Console.ReadLine());

            int money = 0;
            int toy = 0;
            double summoney = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0) 
                {
                    money = (money + 10);
                    summoney = summoney + money;
                    summoney = summoney - 1;
                }
                else
                {
                    toy ++;
                }
            }

            double allmoney = summoney + (toy * priceToy);

            if (allmoney >= priceWash) 
            {
                Console.WriteLine("Yes! {0:f2}", (allmoney - priceWash));
            }
            else
            {
                Console.WriteLine("No! {0:f2}", (priceWash - allmoney));
            }
        }
    }
}
