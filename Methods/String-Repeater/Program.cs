using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 10

namespace String_Repeater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some string: ");
            string str = Console.ReadLine();
            Console.Write("Enter number of repeats: ");
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(str, count));
        }

        static string RepeatString(string str, int count)
        {
            return String.Concat(Enumerable.Repeat(str, count));
        }
    }
}
