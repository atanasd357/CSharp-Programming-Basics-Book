using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 1

namespace Passion_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Money for shopping: ");
            decimal shopingMoney = decimal.Parse(Console.ReadLine());
            Console.Write("Enter command: ");
            string command = Console.ReadLine();

            int purchases = 0;
            decimal price = 0;

            command = Console.ReadLine();
            while (command != "mall.Exit")
            { 
                foreach (char action in command)
                {                 
                    if (action >= 'A' && action <= 'Z')
                    {
                        price = action * 0.5m;
                        if (shopingMoney >= price)
                        {
                            shopingMoney -= price;
                            purchases++;
                        }                 
                    }
                    else if (action >= 'a' && action <= 'z')
                    {
                        price = action * 0.3m;
                        if (shopingMoney >= price)
                        {
                            shopingMoney -= price;
                            purchases++;
                        }                 
                    }
                    else if (action == '%')
                    {
                        price = shopingMoney * 0.5m;
                        if (shopingMoney >= price)
                        {
                            shopingMoney -= price;
                            purchases++;                          
                        }                   
                    }
                    else if (action == '*')
                    {
                        shopingMoney += 10;
                    }
                    else
                    {
                        price = action;
                        if (shopingMoney >= price)
                        {
                            shopingMoney -= price;
                            purchases++;
                        }
                    }
                }
                command = Console.ReadLine();
            }
           
            if (purchases == 0)
            {
                Console.WriteLine("No purchases. Money left: {0:f2} lv.", shopingMoney);
            }
            else
            {
                Console.WriteLine("{0} purchases. Money left: {1:f2} lv.", purchases, shopingMoney);
            }
        }
    }
}
