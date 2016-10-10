//You are given an n number of chemical compounds.You need to keep track of all chemical elements used 
//in the compounds and at the end print all unique ones in ascending order:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicTable
{
    class PeriodicTable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> allElements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string input = System.Console.ReadLine();
                string[] elements = input.Trim().Split(' ');
                foreach (var element in elements)
                {
                    allElements.Add(element);
                }
            }
            foreach (var item in allElements)
            {
                System.Console.Write(item + ' ');
            }
        }
    }
}
