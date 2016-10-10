//We are given the following sequence of numbers:
//•	S1 = N
//•	S2 = S1 + 1
//•	S3 = 2* S1 + 1
//•	S4 = S1 + 2
//•	S5 = S2 + 1
//•	S6 = 2* S2 + 1
//•	S7 = S2 + 2
//•	…
//Using the ArrayDeque<E> class, write a program to print its first 50 members for given N.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSequenceWithQue
{
    class CalculateSequenceWithQueue
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Queue < long > elemntsInSequence = new Queue<long>();
            elemntsInSequence.Enqueue(n);
            List<long> result = new List<long>();
            result.Add(n);
            while (result.Count < 50)
            {
                long currentElement = elemntsInSequence.Dequeue();
                long firstNumber = currentElement + 1;
                long secondNumber = (currentElement * 2) + 1;
                long thirdNumber = currentElement + 2;

                elemntsInSequence.Enqueue(firstNumber);
                elemntsInSequence.Enqueue(secondNumber);
                elemntsInSequence.Enqueue(thirdNumber);

                result.Add(firstNumber);
                result.Add(secondNumber);
                result.Add(thirdNumber);
            }
            for (int i = 0; i < 50; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
    }
}
