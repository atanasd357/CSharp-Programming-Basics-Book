using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 5

namespace Sequence_TwoK_Plus_One
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            int num = 1;

            while (num <= n) 
            {
                Console.WriteLine(num);
                num = 2 * num + 1;
            }
        }
    }
}
