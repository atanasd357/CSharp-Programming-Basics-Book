using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 4

namespace Even_Powers_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            int num = 1;

            for (int i = 0; i <= n; i+=2)
            {
                Console.WriteLine(num);
                num = num * 2 * 2;
            }
        }
    }
}
