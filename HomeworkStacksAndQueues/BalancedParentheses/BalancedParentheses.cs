//Given a sequence consisting of parentheses, determine whether the expression is balanced.A sequence of parentheses is 
//balanced if every open parenthesis can be paired uniquely with a closed parenthesis that occurs after the former. 
//Also, the interval between them must be balanced.You will be given three types of parentheses: (, {, and[.
//{[()]} - This is a balanced parenthesis.
//{[(])} - This is not a balanced parenthesis.
//Input Format: Each input consists of a single line, S, the sequence of parentheses.
//Constraints: 
//1 ≤ lens ≤ 1000, where lens is the length of the sequence.
//Each character of the sequence will be one of {, }, (, ), [,].
//Output Format: For each test case, print on a new line "YES" if the parentheses are balanced.Otherwise, print "NO". Do not print the quotes.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Trim();
            char[] splittedInput = input.ToCharArray();
            int j = splittedInput.Length - 1;
            string message = "NO";

            if (splittedInput.Length <= 1 || splittedInput.Length >= 1000 || string.IsNullOrEmpty(input))
            {
                return;
            }

            if (splittedInput.Length % 2 != 0)
            {
                Console.WriteLine(message);
                return;
            }

            else
            {
                for (int i = 0; i <= (splittedInput.Length / 2) - 1; i++, j--)
                {
                    if (splittedInput[i] == '{' && splittedInput[j] != '}')
                    {
                        message = "NO";
                        break;
                    }
                    if (splittedInput[i] == '(' && splittedInput[j] != ')')
                    {
                        message = "NO";
                        break;
                    }
                    if (splittedInput[i] == '[' && splittedInput[j] != ']')
                    {
                        message = "NO";
                        break;
                    }
                    if (splittedInput[i] == '{' && splittedInput[j] == '}')
                    {
                        message = "YES";
                    }

                    if (splittedInput[i] == '(' && splittedInput[j] == ')')
                    {
                        message = "YES";
                    }

                    if (splittedInput[i] == '[' && splittedInput[j] == ']')
                    {
                        message = "YES";
                    }
                }
            }
            Console.WriteLine(message);
            return;

        }
    }
}