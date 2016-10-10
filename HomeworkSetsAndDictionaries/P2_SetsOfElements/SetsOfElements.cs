//On the first line you are given the length of two sets n and m.On the next n + m lines there are 
//n numbers that are in the first set and m numbers that are in the second one.
//Find all non-repeating element that appears in both of them, and print them at the console:
//Set with length n = 4: {1, 3, 5, 7}
//Set with length m = 3: {3, 4, 5}
//Set that contains all repeating elements -> {3, 5}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetsOfElements
{
    class SetsOfElements
    {
        static void Main(string[] args)
        {
            string input = System.Console.ReadLine();
            string[] sizes = input.Split(' ');
            int firstSize = int.Parse(sizes[0]);
            int secondSize = int.Parse(sizes[1]);
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();
            List<int> allData = new List<int>();

            for (int i = 0; i < firstSize; i++)
            {
                int number = int.Parse(System.Console.ReadLine());
                firstSet.Add(number);
                
            }
            for (int i = 0; i < secondSize; i++)
            {
                int secondNumber = int.Parse(System.Console.ReadLine());
                secondSet.Add(secondNumber);
                
            }

            firstSet.IntersectWith(secondSet);
            foreach (var item in firstSet)
            {
                System.Console.Write(item+" ");
            }
        }
    }
}
