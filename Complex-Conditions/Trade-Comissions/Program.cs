using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 8

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter town: ");
            string town = Console.ReadLine().ToLower();
            Console.Write("Enter volume of trades: ");
            double volume = double.Parse(Console.ReadLine());

            double commision = 0;

            if (town=="sofia")
            {
                if (volume >= 0 && volume <= 500) commision = Math.Round((volume * 0.05), 2);
                else if (volume > 500 && volume <= 1000) commision = Math.Round((volume * 0.07), 2);
                else if (volume > 1000 && volume <= 10000) commision = Math.Round((volume * 0.08), 2);
                else if (volume > 10000) commision = Math.Round((volume * 0.12), 2);
                else if (volume < 0) Console.WriteLine("error");
                Console.WriteLine(commision.ToString("0.00"));
            }
            else if (town == "varna")
            {
                if (volume >= 0 && volume <= 500) commision = Math.Round((volume * 0.045), 2);
                else if (volume > 500 && volume <= 1000) commision = Math.Round((volume * 0.075), 2);
                else if (volume > 1000 && volume <= 10000) commision = Math.Round((volume * 0.10), 2);
                else if (volume > 10000) commision = Math.Round((volume * 0.13), 2);
                else if (volume < 0) Console.WriteLine("error");
                Console.WriteLine(commision.ToString("0.00"));
            }
            else if (town == "plovdiv")
            {
                if (volume >= 0 && volume <= 500) commision = Math.Round((volume * 0.055), 2);
                else if (volume > 500 && volume <= 1000) commision = Math.Round((volume * 0.08), 2);
                else if (volume > 1000 && volume <= 10000) commision = Math.Round((volume * 0.12), 2);
                else if (volume > 10000) commision = Math.Round((volume * 0.145), 2);
                else if (volume < 0) Console.WriteLine("error");
                Console.WriteLine(commision.ToString("0.00"));
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
