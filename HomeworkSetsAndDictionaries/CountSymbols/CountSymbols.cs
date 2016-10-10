//Write a program that reads some text from the console and counts the occurrences of 
//each character in it.Print the results in alphabetical(lexicographical) order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSymbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            string input = System.Console.ReadLine();
            char[] allChars = input.ToCharArray();
            SortedDictionary<char, int> data = new SortedDictionary<char, int>();

            for (int i = 0; i < allChars.Length; i++)
            {
                char currentSymbol = allChars[i];
                if (!data.ContainsKey(currentSymbol))
                {
                    data[currentSymbol] = 0;
                }
                data[currentSymbol]++;
            }
            foreach (var kvp in data)
            {
                Console.WriteLine(kvp.Key + ":" +" "+ kvp.Value +" "+ "time/s");
            }
            }
         }
     }

