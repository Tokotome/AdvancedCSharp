//Using LINQ, extract and print the Marks of the students that enrolled in 2014 or 2015 
//(the students from 2014 have 14 as their 5-th and 6-th digit in the FacultyNumber, those from 2015 have 15).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsEnrolled
{
    class StudentsEnrolled
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
            .Where(x => x[0].EndsWith("14") || x[0].EndsWith("15"))
            .ToList()
            .ForEach(x => Console.WriteLine(string.Join(" ", x.Skip(1))));
        }
    }
}
