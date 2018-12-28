using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exam task 1

namespace Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            int colSize = n / 2;                    
            int midSize = 2 * n - 2*colSize - 4;
            Console.WriteLine("/{0}\\{1}/{0}\\",
                new string('^', colSize),
                new string('_', midSize));

            int fortWidth = (2 * n) - 2;
            for (int i = 1; i <= n - 3; i++)
            {
                Console.WriteLine("|{0}|", new string(' ', fortWidth));
            }

            Console.WriteLine("|{0}{1}{0}|", new string(' ',colSize+1), new string ('_', midSize));
            Console.WriteLine("\\{0}/{1}\\{0}/",
                new string('_', colSize),
                new string(' ', midSize));
        }
    }
}
