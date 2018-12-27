using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Encryption
{
    class StringEncryption
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            string word = string.Empty;

            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                word += letter;
            }

            Encrypt(word);
        }
        
        static void Encrypt(string word)
        {
            string result = string.Empty;

            foreach (char letter in word)
            {
                string transitionalResult = string.Empty;
                int num = letter;
                int firstNum = 0;

                if (num >= 100) 
                {
                    firstNum = (letter / 100) % 10;
                }
                else
                {
                    firstNum = (letter / 10) % 10;                  
                }

                int lastNum = num % 10;
                transitionalResult += firstNum;
                transitionalResult += lastNum;

                int sbor = num + lastNum;
                transitionalResult = (char)sbor + transitionalResult;

                int razlika = num - firstNum;
                transitionalResult += (char)razlika;

                result += transitionalResult;
            }

            Console.WriteLine(result);
        }
    }
}
