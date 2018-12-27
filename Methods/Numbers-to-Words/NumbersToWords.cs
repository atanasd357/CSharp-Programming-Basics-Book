using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 14

namespace Numbers_to_Words
{
    class NumbersToWords
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                Letterize(number);
            }
        }

        static void Letterize(int number)
        {
            int hndr = Math.Abs((number / 100) % 10);
            int tns = Math.Abs((number / 10) % 10);
            int unt = Math.Abs((number / 1) % 10);
           
            if (number < -999)
            {
                
                Console.WriteLine("too small");
            }
            else if (number > 999)
            {
                Console.WriteLine("too large");
            }
            else if (number <= -100 && number >= -999)
            {
                Console.Write("minus ");
                FindHundrTensUnits(hndr, tns, unt);
            }
            else if (number >= 100 && number <= 999)
            {
                FindHundrTensUnits(hndr, tns, unt);
            }
        }

        static void FindHundrTensUnits(int hndr, int tns, int unt)
        {
            string hundrets = "";
            string tens = "";
            string units = "";
            string result = "";
            bool resultString = false;

            switch (hndr)
            {
                case 1:
                    hundrets = "one-hundred";
                    break;
                case 2:
                    hundrets = "two-hundred";
                    break;
                case 3:
                    hundrets = "three-hundred";
                    break;
                case 4:
                    hundrets = "four-hundred";
                    break;
                case 5:
                    hundrets = "five-hundred";
                    break;
                case 6:
                    hundrets = "six-hundred";
                    break;
                case 7:
                    hundrets = "seven-hundred";
                    break;
                case 8:
                    hundrets = "eight-hundred";
                    break;
                case 9:
                    hundrets = "nine-hundred";
                    break;
            }

            if (tns == 0 && unt == 0)
            {
                resultString = false;
            }

            else if (tns == 0)
            {
                switch (unt)
                {
                    case 1:
                        units = "one";
                        break;
                    case 2:
                        units = "two";
                        break;
                    case 3:
                        units = "three";
                        break;
                    case 4:
                        units = "four";
                        break;
                    case 5:
                        units = "five";
                        break;
                    case 6:
                        units = "six";
                        break;
                    case 7:
                        units = "seven";
                        break;
                    case 8:
                        units = "eight";
                        break;
                    case 9:
                        units = "nine";
                        break;
                }

                result += units;
                resultString = true;
            }

            else if (tns == 1 && unt >= 1 && unt <= 9)
            {
                switch (unt)
                {
                    case 1:
                        tens = "eleven";
                        break;
                    case 2:
                        tens = "twelve";
                        break;
                    case 3:
                        tens = "thirteen";
                        break;
                    case 4:
                        tens = "fourteen";
                        break;
                    case 5:
                        tens = "fifteen";
                        break;
                    case 6:
                        tens = "sixteen";
                        break;
                    case 7:
                        tens = "seventeen";
                        break;
                    case 8:
                        tens = "eighteen";
                        break;
                    case 9:
                        tens = "nineteen";
                        break;
                }

                result += tens;
                resultString = true;
            }

            else if (tns == 1 || tns >= 2 && tns <= 9)
            {
                switch (tns)
                {
                    case 1:
                        tens = "ten";
                        break;
                    case 2:
                        tens = "twenty";
                        break;
                    case 3:
                        tens = "thirty";
                        break;
                    case 4:
                        tens = "forty";
                        break;
                    case 5:
                        tens = "fifty";
                        break;
                    case 6:
                        tens = "sixty";
                        break;
                    case 7:
                        tens = "seventy";
                        break;
                    case 8:
                        tens = "eighty";
                        break;
                    case 9:
                        tens = "ninety";
                        break;
                }

                result += tens;
                resultString = true;

                if (unt >= 1 && unt <= 9)
                {
                    switch (unt)
                    {
                        case 1:
                            units = "one";
                            break;
                        case 2:
                            units = "two";
                            break;
                        case 3:
                            units = "three";
                            break;
                        case 4:
                            units = "four";
                            break;
                        case 5:
                            units = "five";
                            break;
                        case 6:
                            units = "six";
                            break;
                        case 7:
                            units = "seven";
                            break;
                        case 8:
                            units = "eight";
                            break;
                        case 9:
                            units = "nine";
                            break;
                    }

                    result += " " + units;
                }
            }

            if (resultString == false) 
            {
                Console.WriteLine(hundrets);
            }
            else
            {
                Console.WriteLine("{0} and {1}", hundrets, result);
            }
        }
    }
}
