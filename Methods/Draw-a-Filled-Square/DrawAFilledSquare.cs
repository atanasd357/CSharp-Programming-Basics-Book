using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 4

namespace Draw_a_Filled_Square
{
    class DrawAFilledSquare
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            TopBottomSquare(n);

            for (int i = 1; i <= n-2; i++)
            {
                MiddleSquare(n);
                Console.WriteLine();
            }

            TopBottomSquare(n);
        }

        static void TopBottomSquare(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        static void MiddleSquare(int n)
        {
            Console.Write("-");
            for (int i = 1; i <= n-1; i++)
            {
                Console.Write("\\/");
            }
            Console.Write("-");
        }
    }
}
