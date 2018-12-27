using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 11

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter projection type: ");
            string projection = Console.ReadLine().ToLower();
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter number of cols: ");
            int cols = int.Parse(Console.ReadLine());

            double seats = rows * cols;
            double price = 0;

            switch (projection)
            {
                case "premiere":
                    price = 12.00 * seats;
                    break;
                case "normal":
                    price = 7.50 * seats;
                    break;
                case "discount":
                    price = 5.00 * seats;
                    break;      
            }

            Console.WriteLine($"{price:f2} leva");
        }
    }
}
