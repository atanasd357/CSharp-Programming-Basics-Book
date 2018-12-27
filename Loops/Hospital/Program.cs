using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exam task 4

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of periods: ");
            int period = int.Parse(Console.ReadLine());

            int doctors = 7;
            int treatedPatients = 0;
            int untreatedPatients = 0;

            Console.WriteLine("Enter how much pacients have in one day:");
            for (int i = 1; i <= period; i++)
            {
                int patientDay = int.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    if (untreatedPatients > treatedPatients)
                    {
                        doctors++;
                    }
                }

                if (doctors >= patientDay)
                {
                    treatedPatients = treatedPatients + patientDay;
                }
                else
                {
                    treatedPatients = treatedPatients + doctors;
                    untreatedPatients = untreatedPatients + (patientDay - doctors);
                }
            }
            Console.WriteLine("Treated patients: {0}", treatedPatients);
            Console.WriteLine("Untreated patients: {0}", untreatedPatients);
        }
    }
}
