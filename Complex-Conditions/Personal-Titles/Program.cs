using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 1

namespace Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter age: ");
            double age = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter gender (m or f): ");
            string gender=Console.ReadLine();

            if (gender == "m")
            {
                if (age >= 16)
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Master");
                }
            }

            if (gender == "f")
            {
                if (age >= 16)
                {
                    Console.WriteLine("Ms.");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }
        }
    }
}
