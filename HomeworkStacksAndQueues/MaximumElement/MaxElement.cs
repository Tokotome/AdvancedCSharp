//You have an empty sequence, and you will be given N queries.Each query is one of these three types:
//1 x - Push the element x into the stack.
//2    - Delete the element present at the top of the stack.
//3    - Print the maximum element in the stack.
//Input Format: The first line of input contains an integer, N.The next N lines each contain an above mentioned query. (It is guaranteed that each query is valid.)
//Output Format: For each type 3 query, print the maximum element in the stack on a new line.
//Constraints:
//1 ≤ N ≤ 105 
//1 ≤ x ≤ 109
//1 ≤ type ≤ 3


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxElement
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            Stack<int> maxNumbers = new Stack<int>();
            int maxElement = int.MinValue;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine().Split();
                string command = commandArgs[0];

                if (command=="1")
                {
                    int numberToPush = int.Parse(commandArgs[1]);
                    myStack.Push(numberToPush);
                    if (maxNumbers.Count==0 || numberToPush >= maxNumbers.Peek())
                    {
                        maxNumbers.Push(numberToPush);
                    }
                    
                }
                else if (command=="2")
                {
                    int elementAtTop = myStack.Pop();
                    int currentMaxNumber = maxNumbers.Peek();
                    if (elementAtTop == currentMaxNumber)
                    {
                        maxNumbers.Pop();
                        if (maxNumbers.Count > 0)
                        {
                            maxElement = maxNumbers.Peek();
                        }
                    }
                }
                else
                {
                    Console.WriteLine(maxNumbers.Peek());
                }
            }
        }
    }
}
