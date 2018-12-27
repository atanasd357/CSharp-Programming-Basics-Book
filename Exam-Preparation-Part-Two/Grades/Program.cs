using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 4

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());

            double topStud = 0;
            double between45 = 0;
            double between34 = 0;
            double fail = 0;
            double sumgrades = 0;

            Console.WriteLine("Enter grades:");
            for (int i = 1; i <= n; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 5.00)
                {
                    topStud += 1;
                }
                if (grade >= 4.00 && grade <= 4.99)
                {
                    between45 += 1;
                }
                if (grade >= 3.00 && grade <= 3.99)
                {
                    between34 += 1;
                }
                if (grade < 3.00)
                {
                    fail += 1;
                }
                sumgrades += grade;
            }

            Console.WriteLine("Top students: {0:f2}%", (topStud / n) * 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", (between45 / n) * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", (between34 / n) * 100);
            Console.WriteLine("Fail: {0:f2}%", (fail / n) * 100);
            Console.WriteLine("Average: {0:f2}", sumgrades / n);
        }
    }
}
