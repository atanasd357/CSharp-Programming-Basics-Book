using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exam task 3

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num 1: ");
            decimal num1 = decimal.Parse(Console.ReadLine());
            Console.Write("Enter num 2: ");
            decimal num2 = decimal.Parse(Console.ReadLine());
            string operation= Console.ReadLine();

            decimal result = 0;

            if (operation == "+")
            {
                result = num1 + num2;
            }
            else if (operation == "-")
            {
                result = num1 - num2;
            }
            else if (operation == "*")
            {
                result = num1 * num2;
            }
            else if (operation == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", num1);
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine("{0} / {1} = {2:f2}", num1, num2, result);
                }               
            }
            else if (operation == "%")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", num1);
                }
                else
                {
                    result = num1 % num2;
                    Console.WriteLine("{0} % {1} = {2}", num1, num2, result);
                }
            }

            if (operation == "+" || operation == "-" || operation == "*")
            {
                decimal numor = result % 2;
                if (numor == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", num1, operation, num2, result);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", num1, operation, num2, result);
                }
            }          
        }
    }
}
