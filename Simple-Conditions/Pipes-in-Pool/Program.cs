using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exam task 2

namespace Pipes_in_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter volume of pool: ");
            int volume = int.Parse(Console.ReadLine());
            Console.Write("Enter first pipe debit: ");
            int pipe1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second pipe debit: ");
            int pipe2 = int.Parse(Console.ReadLine());
            Console.Write("enter the hours in which the worker is absent: ");
            double hours = double.Parse(Console.ReadLine());

            double water = pipe1 * hours + pipe2 * hours;
            if (water <= volume)
            {
                double underfull = Math.Truncate((water / volume) * 100);
                double pipe1Flow = Math.Truncate(((pipe1 * hours) / water) * 100);
                double pipe2Flow = Math.Truncate(((pipe2 * hours) / water) * 100);
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", underfull, pipe1Flow, pipe2Flow);
            }
            else
            {
                double overfull = water - volume;
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hours, overfull);
            }
        }
    }
}
