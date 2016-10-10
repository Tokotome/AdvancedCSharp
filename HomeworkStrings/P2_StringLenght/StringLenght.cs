//Write a program that reads from the console a string of maximum 20 characters.
//If the length of the string is less than 20, the rest of the characters should be filled with*. 
//Print the resulting string on the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLenght
{
    class StringLenght
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char star = '*';
            if (input.Length>20)
            {
                input = Console.ReadLine();
            }
            else
            {
                Console.WriteLine(input + new String(star, (20 - input.Length)));
            }
        }
    }
}
