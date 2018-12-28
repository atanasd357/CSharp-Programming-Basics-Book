using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 9

namespace Min_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first num: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second num: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter third num: ");
            int c = int.Parse(Console.ReadLine());

            int result = GetMin(a, GetMin(b, c));

            Console.WriteLine(result);
        }
        
        static int GetMin(int a, int b)
        {
            return Math.Min(a, b);
        }
    }
}
