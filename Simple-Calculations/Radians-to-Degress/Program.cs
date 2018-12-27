using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 10

namespace Radians_to_Degress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Radians = ");
            var rad = double.Parse(Console.ReadLine());
            var deg = rad * (180 / Math.PI);
            Console.WriteLine("Degrees = " + Math.Round(deg));
        }
    }
}
