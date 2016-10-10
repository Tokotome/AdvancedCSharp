using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuesDemo
{
    class QueuesDemo
    {
        static void Main(string[] args)
        {
            Queue<char> firstChars = new Queue<char>();
            Queue<char> secondChars = new Queue<char>();

            firstChars.Enqueue('a');
            firstChars.Enqueue('b');
            firstChars.Enqueue('c');

            secondChars.Enqueue('a');
            secondChars.Enqueue('b');
            secondChars.Enqueue('d');
            

            while (firstChars.Count!=0 || secondChars.Count!=0)
            {
                if (firstChars.Dequeue()==secondChars.Dequeue())
                {
                    continue;
                }
                else
                {
                    firstChars.Enqueue('A');
                    secondChars.Enqueue('B');
                    break;
                }
            }
            if (firstChars.Count==0 && secondChars.Count==0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
