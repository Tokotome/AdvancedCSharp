using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
            double result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string currentElement = input[i];
                char firtsCharacter = currentElement[0];
                char lastCharacter = currentElement[currentElement.Length - 1];
                double number = double.Parse(currentElement
                .Substring(1, currentElement.Length - 2));
                int alphabetPosition = firtsCharacter % 32;
                if (char.IsLower(firtsCharacter))
                {
                    number *= alphabetPosition;
                }
                else
                {
                    number /= alphabetPosition;
                }
                alphabetPosition = lastCharacter % 32;
                if (char.IsLower(lastCharacter))
                {
                    number += alphabetPosition;
                }
                else
                {
                    number -= alphabetPosition;
                }
                result += number;
            }
            Console.WriteLine("{0:F2}", result);
        }
    }
}
