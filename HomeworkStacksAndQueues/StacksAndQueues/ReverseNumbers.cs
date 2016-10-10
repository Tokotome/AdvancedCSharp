//Write a program that reads N integers from the console and reverses them using a stack. 
//Use the Stack<int> class from .NET Framework. Just put the input numbers in the stack and pop them. 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumbers
{
    class ReverseNumbers
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
            .Trim()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            Stack<int> numbersStack = new Stack<int>();
            foreach (var number in numbers)
            {
                numbersStack.Push(number);
            }
            while (numbersStack.Count !=0)
            {
                int current = numbersStack.Pop();
                Console.Write(current);
                if (numbersStack.Count != 0)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
