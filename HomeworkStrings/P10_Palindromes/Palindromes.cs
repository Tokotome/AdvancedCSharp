//Write a program that extracts from a given text all palindromes, e.g.ABBA, lamal, exe and prints them on the console on 
//a single line, separated by comma and space.Use spaces, commas, dots, question marks and exclamation marks as word delimiters.
//Print only unique palindromes, sorted lexicographically (small letters are before big ones).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = input.Split(new char[] { ' ', '?', '!', '.', ',' });

            SortedSet<string> allPalindromes = new SortedSet<string>();

            foreach (var word in words)
            {
                if (word.Length%2==0)
                {
                    string a = word.Substring(0, (word.Length/ 2));
                    string b = word.Substring(word.Length/2, (word.Length/ 2));
                    char[] bToArray = b.ToCharArray();
                    Array.Reverse(bToArray);
                    string c = new string(bToArray);
                    if (c.Equals(a))
                    {
                        allPalindromes.Add(word);
                    }
                }
                else if(word.Length%2==1)
                {
                    string a = word.Substring(0, (word.Length-1) / 2);
                    string b = word.Substring((word.Length+1)/2, (word.Length - 1) / 2);
                    char[] bToArray = b.ToCharArray();
                    Array.Reverse(bToArray);
                    string c = new string(bToArray);
                    if (c.Equals(a))
                    {
                        allPalindromes.Add(word);
                    }
                }
            }
            string join = string.Join(",", allPalindromes.ToArray());
            join = join.Remove(0, 1);
            Console.WriteLine("[" + " "+join +" " + "]");

        }
    }
}

