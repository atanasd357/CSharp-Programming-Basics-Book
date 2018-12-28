using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 3

namespace Five_Special_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter start num: ");
            int startNum = int.Parse(Console.ReadLine());
            Console.Write("Enter end num: ");
            int endNum = int.Parse(Console.ReadLine());

            int weight = 0;
            int multiplier = 1;
            int aValue = 5;
            int bValue = -12;
            int cValue = 47;
            int dValue = 7;
            int eValue = -32;
            int counter = 0;

            for (char i = 'a'; i <='e'; i++)
            {
                for (char k = 'a'; k <= 'e'; k++)
                {
                    for (char j = 'a'; j <= 'e'; j++)
                    {
                        for (char p = 'a'; p <= 'e'; p++)
                        {
                            for (char t = 'a'; t <= 'e'; t++)
                            {
                                string word = "" + i + k + j + p + t;
                                string finalWord = "" + i;
          
                                if (k != i) 
                                {
                                    finalWord += k;
                                }
                                if (j != i && j != k) 
                                {
                                    finalWord += j;
                                }
                                if (p != i && p != k && p != j) 
                                {
                                    finalWord += p;
                                }
                                if (t != i && t != k && t != j && t != p) 
                                {
                                    finalWord += t;
                                }

                                for (int n = 0; n < finalWord.Length; n++)
                                {
                                    switch (finalWord[n])
                                    {
                                        case 'a': weight += multiplier * aValue; break;
                                        case 'b': weight += multiplier * bValue; break;
                                        case 'c': weight += multiplier * cValue; break;
                                        case 'd': weight += multiplier * dValue; break;
                                        case 'e': weight += multiplier * eValue; break;
                                    }
                                    multiplier++;
                                }

                                if (weight >= startNum && weight <= endNum)
                                {
                                    Console.Write(word + " ");
                                    counter++;
                                }
                                multiplier = 1;
                                weight = 0;
                            }
                        }
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
