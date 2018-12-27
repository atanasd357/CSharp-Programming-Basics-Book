using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 2

namespace Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter budget: ");
            decimal money = decimal.Parse(Console.ReadLine());
            Console.Write("Enter floor width: ");
            decimal floorWidth = decimal.Parse(Console.ReadLine());
            Console.Write("Enter floor height: ");
            decimal floorHeight = decimal.Parse(Console.ReadLine());
            Console.Write("Enter triangle side: ");
            decimal triangleSide = decimal.Parse(Console.ReadLine());
            Console.Write("Enter triangle height: ");
            decimal triangleHeight = decimal.Parse(Console.ReadLine());
            Console.Write("Enter title price: ");
            decimal tilePrice = decimal.Parse(Console.ReadLine());
            Console.Write("Enter master price: ");
            decimal masterPrice = decimal.Parse(Console.ReadLine());

            decimal floorSquare = floorHeight * floorWidth;
            decimal tileSquare = triangleSide * (triangleHeight / 2);
            decimal tilesNeeded = Math.Ceiling(floorSquare/tileSquare) + 5;
            decimal moneyNeeded = (tilePrice * tilesNeeded) + masterPrice;

            if (moneyNeeded <= money)
            {
                Console.WriteLine("{0:f2} lv left.", money - moneyNeeded);
            }
            else if (moneyNeeded > money) 
            {
                Console.WriteLine("You'll need {0:f2} lv more.", moneyNeeded - money);
            }
        }
    }
}
