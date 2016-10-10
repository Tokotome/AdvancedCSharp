//Write a program that reads a keyword and some text from the console and prints all sentences from the text, 
//containing that word.A sentence is any sequence of words ending with '.', '!' or '?'. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SentenseExtractor
{
    class SentenseExtractor
    {
        static void Main(string[] args)
        {
            string magicWord = Console.ReadLine();
            string input = Console.ReadLine();
            string[] sentences = Regex.Split(input, @"(?<=[\.!\?])\s+");
            bool containsWord = true;

            foreach (string sentence in sentences)
            {
                if (sentence.Contains(magicWord) == containsWord)
                {
                    string[] singleSentences = sentence.Split(' ');
                    foreach (var singleSentence in singleSentences)
                    {
                        if (singleSentence==magicWord)
                        {
                            Console.WriteLine(sentence);
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else
                {
                    continue;
                }
                
            }
        }
    }
}
