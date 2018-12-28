using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 13

namespace Notifications
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                ReadAndProcessMessage();
                Console.WriteLine();
            }       
        }

        static void ShowSuccessMessage(string operation, string message)
        {          
            Console.WriteLine("Successfully executed {0}.", operation);
            int lenght = ("Successfully executed .".Length) + operation.Length;
            Console.WriteLine(new string('=', lenght));
            Console.WriteLine("{0}.", message);
        }

        static void ShowWarningMessage(string message)
        {
            Console.WriteLine("Warning: {0}.", message);
            int lenght = ("Warning: .".Length) + message.Length;
            Console.WriteLine(new string('=', lenght));
        }

        static void ShowErrorMessage(string operation, string message, int errorCode)
        {
            Console.WriteLine("Error: Failed to execute {0}.", operation);
            int lenght = ("Error: Failed to execute .".Length) + operation.Length;
            Console.WriteLine(new string('=', lenght));
            Console.WriteLine("Reason: {0}.", message);
            Console.WriteLine("Error code: {0}.", errorCode);
        }

        static void ReadAndProcessMessage()
        {
            string word = Console.ReadLine();        

            if (word == "success")
            {
                string operation = Console.ReadLine();
                string message = Console.ReadLine();
                ShowSuccessMessage(operation, message);
            }
            else if (word == "warning")
            {
                string message = Console.ReadLine();
                ShowWarningMessage(message);
            }
            else if (word == "error")
            {
                string operation = Console.ReadLine();
                string message = Console.ReadLine();
                int errorCode = int.Parse(Console.ReadLine());
                ShowErrorMessage(operation, message, errorCode);
            }
        }
    }
}
