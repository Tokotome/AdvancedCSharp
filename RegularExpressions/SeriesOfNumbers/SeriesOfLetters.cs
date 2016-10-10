//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SeriesOfNumbers
{
    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> allMatches = new List<string>();
            string pattern = @"((A+|a+)|(B+|b+)|(C+|c+)|(D+|d+)|(E+|e+)|(F+|f+)|(G+|g+)|(H+|h+)|(I+|i+)|(J+|j+)|(K+|k+)|(L+|l+)|(M+|m+)|(N+|n+)|(O+|o+)|(P+|p+)|(Q+|q+)|(R+|r+)|(S+|s+)|(T+|t+)|(U+|u+)|(V+|v+)|(W+|w+)|(X+|x+)|(Y+|y+)|(Z+|z+))";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);
            MatchCollection collection = regex.Matches(input);
            foreach (Match element in collection)
            {
                string putInAllMatches = element.ToString();
                string a = putInAllMatches.Substring(0, 1);
                allMatches.Add(a);
            }
            foreach (var a in allMatches)
            {
                Console.Write(a);
            }
        }
    }
}
