//Write a program that takes a text and a string of banned words.All words included in the ban list 
//should be replaced with asterisks "*", equal to the word's length. The entries in the ban list will be 
//separated by a comma and space ", ".The ban list should be entered on the first input line and the text on the second input line.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string secondInput = Console.ReadLine();

            string[] wordsToReplace = input.Split(new char[] { ' ', ',' }, 
            StringSplitOptions.RemoveEmptyEntries);

            string firstWord = wordsToReplace[0];
            string secondWord = wordsToReplace[1];

            
            char[] firstArray = firstWord.ToCharArray();
            char[] secondArray = new char[firstArray.Length];

            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = '*';
            }

            string replaceFirstWord = new string(secondArray);

            char[] thirdArray = secondWord.ToCharArray();
            char[] fourthArray = new char[thirdArray.Length];

            for (int i = 0; i < fourthArray.Length; i++)
            {
                fourthArray[i] = '*';
            }

            string replaceSecondWord = new string(fourthArray);

            if (secondInput.Contains(firstWord) || secondInput.Contains(secondWord))
            {
                secondInput = secondInput.Replace(firstWord, replaceFirstWord);
                secondInput = secondInput.Replace(secondWord, replaceSecondWord);
                Console.WriteLine(secondInput);
            }
            
            else
	        {
                Console.WriteLine(secondInput);
            }
        }
    }
}
