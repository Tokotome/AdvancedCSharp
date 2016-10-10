//Write a program to find how many times a given string appears in a given text as substring.The text is given at the first input line.
//The search string is given at the second input line. The output is an integer number.
//Please ignore the character casing.Overlapping between occurrences is allowed.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();
            int occurencesCounters = 0;
            int indexOfOccurence = input.IndexOf(pattern);
            while (indexOfOccurence != -1)
            {
                occurencesCounters++;
                indexOfOccurence = input.IndexOf(pattern, indexOfOccurence + 1);
            }
            Console.WriteLine(occurencesCounters);
        }
    }
}
