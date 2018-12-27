using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exam task 4

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitcoins: ");
            decimal bitcoin = int.Parse(Console.ReadLine());
            Console.Write("Yuans: ");
            decimal yuans = decimal.Parse(Console.ReadLine());
            Console.Write("Commision: ");
            decimal inputCommiss = decimal.Parse(Console.ReadLine());

            decimal commissPercent = inputCommiss / 100;
            decimal bitcLv = bitcoin * 1168;
            decimal yuansLv = (yuans * 0.15m) * 1.76m;
            decimal euro = (bitcLv + yuansLv) / 1.95m;
            decimal commission = euro * commissPercent;
            Console.WriteLine("The result from currency exchange" + (euro - commission));
        }
    }
}
