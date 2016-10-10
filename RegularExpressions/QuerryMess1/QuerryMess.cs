//This problem is originally from the JavaScript Basics Exam(22 November 2014). You may check your solution here.
//Ivancho participates in a team project with colleagues at SoftUni.They have to develop an application, 
//but something mysterious happened – at the last moment all team members… disappeared!  And guess what? 
//He is left alone to finish the project.  All that is left to do is to parse the input data and store it in a special 
//way, but Ivancho has no idea how to do that! Can you help him?


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace QuerryMess
{
    class QuerryMess
    {
        static Dictionary<string, List<string>> keyValuePairs =
        new Dictionary<string, List<string>>();
        static void Main(string[] args)
        {
            string whiteSpacePatternOne = @"(?:\+|%20)";
            string whiteSpacePatternTwo = @"\s+";
            string input = Console.ReadLine();
            while (input != "END")
            {
                input = Regex.Replace(input, whiteSpacePatternOne, " ");
                input = Regex.Replace(input, whiteSpacePatternTwo, " ");
                string[] pairs = input.Split('&');
                DecodePairs(pairs);
                foreach (var keyValuePair in keyValuePairs)
                {
                    Console.Write("{0}=[{1}]",
                        keyValuePair.Key, string.Join(", ", keyValuePair.Value));
                }
                Console.WriteLine();
                keyValuePairs.Clear();
                input = Console.ReadLine();
            }
        }
        private static void DecodePairs(string[] pairs)
        {
            foreach (var pair in pairs)
            {
                string properString = pair;
                int indexOfSeparator = pair.IndexOf('?');
                if (indexOfSeparator != -1)
                {
                    properString = properString.Substring(indexOfSeparator + 1);
                }
                string[] splitPair = properString.Split('=');
                string key = splitPair[0].Trim();
                string value = splitPair[1].Trim();
                if (!keyValuePairs.ContainsKey(key))
                {
                    keyValuePairs.Add(key, new List<string>());
                }
                keyValuePairs[key].Add(value);
            }
        }
    }
}