using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exam task 3

namespace Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            int stopHeight = 2 * n + 2;
            int stopWidth = 4 * n + 3;

            Console.WriteLine("{0}{1}{0}", new string('.', n + 1), new string('_', stopWidth - (2 * n + 2)));
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}", 
                    new string('.', ((n + 1) - i)), 
                    new string('_', (stopWidth - 4 - 2*((n + 1) - i))));
            }

            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', ((stopWidth - 9)/2)));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}",
                    new string('.', i),
                    new string('_', (stopWidth - 4 - 2 * i)));
            }
        }
    }
}
