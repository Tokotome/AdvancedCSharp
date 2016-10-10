//Write a program that converts a string to a sequence of Unicode character literals.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            char slash = '\\';
            for (int i = 0; i < charArray.Length; i++)
            {
                Console.Write("\\"+"u"+((int)charArray[i]).ToString("X4").ToLower());
            }
        }
    }
}
