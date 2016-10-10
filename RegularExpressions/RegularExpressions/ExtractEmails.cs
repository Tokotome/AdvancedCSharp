using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?:^|\s)((?:[a-zA-z0-9]+[.\-_])*[a-zA-z0-9]+@(?:[a-zA-z]+-?)+[a-zA-z](?:\.[a-zA-z]+)+)(?:\.\s)?";
            Regex matcher = new Regex(pattern);
            MatchCollection collection = matcher.Matches(input);

            foreach (Match match in collection)
            {
                Console.WriteLine(match.Groups[1].Value);
            }
        }
    }
}
