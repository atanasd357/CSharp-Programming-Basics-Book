using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 6

namespace Letters_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter start letter: ");
            char startLetter = char.Parse(Console.ReadLine());
            Console.Write("Enter end letter: ");
            char endLetter = char.Parse(Console.ReadLine());
            Console.Write("Enter random letter between start and end letter: ");
            char letter = char.Parse(Console.ReadLine());

            int count = 0;

            for (char i = startLetter; i <= endLetter; i++)
            {
                if (i != letter)
                {
                    for (char j = startLetter; j <= endLetter; j++)
                    {
                        if (j != letter)
                        {
                            for (char b = startLetter; b <= endLetter; b++)
                            {
                                if (b != letter)
                                {
                                    Console.Write("{0}{1}{2} ", i, j, b);
                                    count++;                                    
                                }
                            }
                        }
                    }
                }
            }

            Console.Write("{0} ", count);
        }
    }
}
