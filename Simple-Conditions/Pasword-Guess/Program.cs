using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 17

namespace Pasword_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter password: ");
            string pas = Console.ReadLine();

            if (pas == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
