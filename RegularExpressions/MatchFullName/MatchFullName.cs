//Write a regular expression to match a valid full name.A valid full name consists of two words, each word starts with a capital 
//letter and contains only lowercase letters afterwards; each word should be at least two letters long; the two words should be separated by a single space.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class MatchFullName
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> allNames = new List<string>();
            allNames.Add(input);
            while (input!="end")
            {
                input = Console.ReadLine();
                allNames.Add(input);
            }
            foreach (string name in allNames)
            {
                string pattern = @"(^[A-Z][a-z]+)\s*([A-Z][a-z]+$)";
                Regex regex = new Regex(pattern);
                Match match = regex.Match(name);
                if (match.Groups.Count==3)
                {
                    Console.WriteLine(name);
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
