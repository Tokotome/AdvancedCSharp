//Write a simple program that reads from the console a sequence of usernames and keeps a collection with only the unique ones.
//Print the collection on the console in order of insertion:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueUsernames
{
    class UniqueUsernames
    {
        static void Main(string[] args)
        {
            int n = int.Parse(System.Console.ReadLine());
            HashSet<string> totalNames = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string name = System.Console.ReadLine();
                totalNames.Add(name);
            }
            foreach (var name in totalNames)
            {
                System.Console.WriteLine(name);
            }
        }
    }
}
