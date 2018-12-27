using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 10

namespace Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two words: ");
            string word1 = Console.ReadLine().ToLower();
            string word2 = Console.ReadLine().ToLower();

            Console.WriteLine("Are they equal?");
            if (word1 == word2)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
