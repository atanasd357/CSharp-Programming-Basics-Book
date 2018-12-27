using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 3
namespace Bulls_and_Cows
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter secret num: ");
            int secretNum = int.Parse(Console.ReadLine());
            Console.Write("Enter bulls num: ");
            int bullsNum = int.Parse(Console.ReadLine());
            Console.Write("Enter cows num: ");
            int cowsNum = int.Parse(Console.ReadLine());

            bool solutionFound = false;

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int l = 1; l <= 9; l++)
                        {
                            int secretDigit1 = (secretNum / 1000) % 10;
                            int secretDigit2 = (secretNum / 100) % 10;
                            int secretDigit3 = (secretNum / 10) % 10;
                            int secretDigit4 = (secretNum / 1) % 10;
                            int currentBulls = 0;
                            int currentCows = 0;
                            int numCheck1 = i;
                            int numCheck2 = j;
                            int numCheck3 = k;
                            int numCheck4 = l;

                            if (numCheck1 == secretDigit1)
                            {
                                currentBulls++;
                                secretDigit1 = -1;
                                numCheck1 = -2;
                            }
                            if (numCheck2 == secretDigit2)
                            {
                                currentBulls++;
                                secretDigit2 = -1;
                                numCheck2 = -2;
                            }
                            if (numCheck3 == secretDigit3)
                            {
                                currentBulls++;
                                secretDigit3 = -1;
                                numCheck3 = -2;
                            }
                            if (numCheck4 == secretDigit4)
                            {
                                currentBulls++;
                                secretDigit4 = -1;
                                numCheck4 = -2;
                            }

                            if (numCheck1 == secretDigit2)
                            {
                                currentCows++;
                                secretDigit2 = -1;
                            }
                            else if (numCheck1 == secretDigit3)
                            {
                                currentCows++;
                                secretDigit3 = -1;
                            }
                            else if (numCheck1 == secretDigit4)
                            {
                                currentCows++;
                                secretDigit4 = -1;
                            }

                            if (numCheck2 == secretDigit1)
                            {
                                currentCows++;
                                secretDigit1 = -1;
                            }
                            else if (numCheck2 == secretDigit3)
                            {
                                currentCows++;
                                secretDigit3 = -1;
                            }
                            else if (numCheck2 == secretDigit4)
                            {
                                currentCows++;
                                secretDigit4 = -1;
                            }

                            if (numCheck3 == secretDigit1)
                            {
                                currentCows++;
                                secretDigit1 = -1;
                            }
                            else if (numCheck3 == secretDigit2)
                            {
                                currentCows++;
                                secretDigit2 = -1;
                            }
                            else if (numCheck3 == secretDigit4)
                            {
                                currentCows++;
                                secretDigit4 = -1;
                            }

                            if (numCheck4 == secretDigit1)
                            {
                                currentCows++;
                                secretDigit1 = -1;
                            }
                            else if (numCheck4 == secretDigit2)
                            {
                                currentCows++;
                                secretDigit2 = -1;
                            }
                            else if (numCheck4 == secretDigit3)
                            {
                                currentCows++;
                                secretDigit3 = -1;
                            }

                            if (currentBulls == bullsNum && currentCows == cowsNum)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                                solutionFound = true;
                            }
                        }
                    }
                }
            }
            if (!solutionFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}
