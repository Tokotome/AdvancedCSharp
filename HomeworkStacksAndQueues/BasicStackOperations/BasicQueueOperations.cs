//Play around with a stack.You will be given an integer N representing the amount of elements to push onto the stack, 
//an integer S representing the amount of elements to pop from the stack and finally an integer X, 
//an element that you should check whether is present in the stack.If it is print true on the console, 
//if it’s not print the smallest element currently present in the stack.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStackOperations
{
    class BasicQueueOperations
    {
        static void Main(string[] args)
        {
            string firstData = System.Console.ReadLine();
            string secondData = System.Console.ReadLine();
            Queue<int> numbersInside = new Queue<int>();
            bool contains = true;

            string[] firstNumbers = firstData.Trim().Split(' ');
            string[] secondNumbers = secondData.Trim().Split(' ');
            int countToEqueue = int.Parse(firstNumbers[0]);
            int countToDequeue = int.Parse(firstNumbers[1]);
            int existingElement = int.Parse(firstNumbers[2]);
            foreach (var number in secondNumbers)
            {
                int secondNumber = int.Parse(number);
                numbersInside.Enqueue(secondNumber);
            }
            for (int i = 0; i < countToDequeue; i++)
            {
                numbersInside.Dequeue();
            }
            if (numbersInside.Count==0)
            {
                System.Console.Write("0");
            }
            else if (numbersInside.Contains(existingElement))
            {
                System.Console.Write("true");
            }
            else
            {
                System.Console.Write(numbersInside.Min());
            }
        }
    }
}
