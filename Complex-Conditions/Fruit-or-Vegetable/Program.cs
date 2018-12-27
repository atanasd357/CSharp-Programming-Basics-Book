using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 4

namespace Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first product: ");
            string product1 = Console.ReadLine();
            Console.Write("Enter second product: ");
            string product2 = Console.ReadLine();
            Console.Write("Enter third product: ");
            string product3 = Console.ReadLine();

            if (product1 == "banana" || product1 == "apple" || product1 == "kiwi"
                || product1 == "cherry" || product1 == "lemon" || product1 == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (product1 == "tomato" || product1 == "cucumber" || product1 == "pepper"
                || product1 == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }

            if (product2 == "banana" || product2 == "apple" || product2 == "kiwi"
                    || product2 == "cherry" || product2 == "lemon" || product2 == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (product2 == "tomato" || product2 == "cucumber" || product2 == "pepper"
                || product2 == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }

            if (product3 == "banana" || product3 == "apple" || product3 == "kiwi"
                || product3 == "cherry" || product3 == "lemon" || product3 == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (product3 == "tomato" || product3 == "cucumber" || product3 == "pepper"
                || product3 == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
