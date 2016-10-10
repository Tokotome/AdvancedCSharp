//Print all students that have at least one mark Excellent(6). Use LINQ.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcellentStudents
{
    class ExcellentStudents
    {
        static void Main()
        {
            List<string> students = new List<string>();
            string input = Console.ReadLine();
            while (input != "END")
            {
                students.Add(input);
                input = Console.ReadLine();
            }
            var sorted = students
            .Select(x => x.Split())
            .Where(x => x.Contains("6"))
            .ToList();

            foreach (var student in sorted)
            {
                Console.WriteLine(string.Join(" ", student[0], student[1]));
            }
        }
    }
}