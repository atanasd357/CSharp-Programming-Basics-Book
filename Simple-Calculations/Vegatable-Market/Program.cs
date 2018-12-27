using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exam task 2

namespace Vegatable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter vegetables price per kg: ");
            var vegetPriceKg = double.Parse(Console.ReadLine());
            Console.Write("Enter fruits price per kg: ");
            var fruitPriceKg = double.Parse(Console.ReadLine());
            Console.Write("Enter vegetables amount in kg: ");
            var vegetWeight = int.Parse(Console.ReadLine());
            Console.Write("Enter fruits amount in kg: ");
            var fruitWeight = int.Parse(Console.ReadLine());

            double vegetPrice = vegetPriceKg * vegetWeight;
            double fruitPrice = fruitPriceKg * fruitWeight;
            Console.WriteLine("All fruits and vegetables price: " + ((vegetPrice + fruitPrice) / 1.94)); 
        }
    }
}
