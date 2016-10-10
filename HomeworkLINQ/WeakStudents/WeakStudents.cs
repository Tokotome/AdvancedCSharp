//Write a similar program to "Excellent students" one to extract the students with at least 2 marks under or equal to "3". Use LINQ.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeakStudents
{
    class WeakStudents
    {
        static void Main(string[] args)
        {
            List<string[]> students = new List<string[]>();
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] studentDetails = input.Split();
                students.Add(studentDetails);
                input = Console.ReadLine();
            }
            students
            .Where(x => x.Skip(2).Count(y => int.Parse(y) <= 3) >= 2)
            .ToList()
            .ForEach(x => Console.WriteLine("{0} {1}", x[0], x[1]));
        }
    }
}