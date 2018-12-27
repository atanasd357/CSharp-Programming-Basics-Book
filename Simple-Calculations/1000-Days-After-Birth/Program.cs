using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 13

namespace _1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter date: ");
            string input = Console.ReadLine();
            DateTime date = DateTime.ParseExact(input, "dd-MM-yyyy", null);
            DateTime d2 = date.AddDays(1000);
            Console.WriteLine("Date after 1000 days: " + d2.ToString("dd-MM-yyyy"));
        }
    }
}
