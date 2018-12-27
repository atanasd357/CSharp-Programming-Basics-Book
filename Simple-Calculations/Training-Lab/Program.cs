using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exam task 1

namespace Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length: ");
            var length = double.Parse(Console.ReadLine());
            Console.Write("Enter width: ");
            var width = double.Parse(Console.ReadLine());
            var lengthcm = length * 100;
            var widthcm = width * 100;
            int cols = ((int)widthcm - 100) / 70;
            int rows = (int)lengthcm / 120;
            var seats = (rows * cols) - 3;
            Console.WriteLine("Number of seats: " + seats);
        }
    }
}
