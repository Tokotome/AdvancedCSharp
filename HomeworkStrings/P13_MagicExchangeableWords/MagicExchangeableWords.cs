//Write a method that takes as input two strings, and returns Boolean if they are exchangeable or not.Exchangeable are words 
//where the characters in the first string can be replaced to get the second string. Example: "egg" and "add" are exchangeable,
//but "aabbccbb" and "nnooppzz" are not. (First 'b' corresponds to 'o', but then it also corresponds to 'z').
//The two words may not have the same length, if such is the case they are exchangeable only if the longer one 
//doesn't have more types of characters then the shorter one ("Clint" and "Eastwaat" are exchangeable because 'a' and 't' 
//are already mapped as 'l' and 'n', but "Clint" and "Eastwood" aren't exchangeable because 'o' and 'd' are not contained in "Clint").

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicExchangeableWords
{
    class MagicExchangeableWords
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Dictionary<char, char> mapChars = new Dictionary<char, char>();
            string shorterString = input[0];
            string longerString = input[1];
            if (shorterString.Length>longerString.Length)
            {
                var temp = longerString;
                longerString = shorterString;
                shorterString = temp;
            }
            bool magic = true;
            for (int i = 0; i < shorterString.Length; i++)
            {
                if (!mapChars.ContainsKey(longerString[i]))
                {
                    mapChars.Add(longerString[i], shorterString[i]);
                }
                else if (mapChars[longerString[i]] != shorterString[i])
                {
                    magic = false;
                    break;
                }
            }
            if (magic)
            {
                for (int i = shorterString.Length; i < longerString.Length; i++)
                {
                    if (!mapChars.ContainsKey(longerString[i]))
                    {
                        magic = false;
                        break;
                    }
                }
            }
            Console.WriteLine(magic.ToString().ToLower());
        }
    }
}
