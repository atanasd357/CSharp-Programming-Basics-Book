using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 9

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            int stars = 1;
            if (n % 2 == 0)
            {
                stars++;
            }
            int roofLength = (int)Math.Ceiling(n / 2f);

            for (int i = 0; i < roofLength; i++)
            {
                int padding = (n - stars) / 2;
                string line = new string('-', padding)
                + new string('*', stars)
                + new string('-', padding);
                Console.WriteLine(line);
                stars += 2;
            }

            for (int i = 0; i < n/2; i++)
            {
                string line = "|" + new string('*', n - 2) + "|";
                Console.WriteLine(line);
            }
        }
    }
}
