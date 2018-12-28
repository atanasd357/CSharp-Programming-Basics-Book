using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 2

namespace X_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter expresson:");
            int symbol = 0;
            decimal result = 0;
            int expressionOperator = '+';
            while (symbol != '=')
            {
                symbol = Console.Read();
                if (symbol == '+' || symbol == '-' || symbol == '*' || symbol == '/')
                {
                    expressionOperator = symbol;
                }
                else if (0 <= symbol - '0' && symbol - '0' <= 9)
                {
                    switch(expressionOperator)
                    {
                        case '+':
                            result += symbol - '0';
                            break;
                        case '-':
                            result -= symbol - '0';
                            break;
                        case '*':
                            result *= symbol - '0';
                            break;
                        case '/':
                            result /= symbol - '0';
                            break;
                    }
                }
                else if (symbol == '(')
                {
                    decimal innerResult = 0;
                    int innerOperator = '+';
                    while (symbol != ')')
                    {
                        symbol = Console.Read();
                        if (symbol == '+' || symbol == '-' || symbol == '*' || symbol == '/')
                        {
                            innerOperator = symbol;
                        }
                        else if (0 <= symbol - '0' && symbol - '0' <= 9)
                        {
                            switch (innerOperator)
                            {
                                case '+':
                                    innerResult += symbol - '0';
                                    break;
                                case '-':
                                    innerResult -= symbol - '0';
                                    break;
                                case '*':
                                    innerResult *= symbol - '0';
                                    break;
                                case '/':
                                    innerResult /= symbol - '0';
                                    break;
                            }
                        }
                    }
                    switch (expressionOperator)
                    {
                        case '+':
                            result += innerResult;
                            break;
                        case '-':
                            result -= innerResult;
                            break;
                        case '*':
                            result *= innerResult;
                            break;
                        case '/':
                            result /= innerResult;
                            break;
                    }
                }
            }
            Console.WriteLine("{0:f2}", result);
        }
    }
}
