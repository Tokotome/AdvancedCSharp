﻿//Print all students from group number 2. Use LINQ.Order the students by FirstName.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional
{
    class StudentsByGroup
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<int, List<string>> studentsByGroup = new Dictionary<int, List<string>>();
            while (input != "END")
            {
                string[] studentInfo = input.Split();
                int studentGroup = int.Parse(studentInfo[2]);
                string studentName = studentInfo[0] + " " + studentInfo[1];
                if (!studentsByGroup.ContainsKey(studentGroup))
                {
                    studentsByGroup.Add(studentGroup, new List<string>());
                }
                studentsByGroup[studentGroup].Add(studentName);
                input = Console.ReadLine();
            }
            var sorted = studentsByGroup[2].OrderBy(x => x.Split()[0]).ToList();


            foreach (var student in sorted)
            {
                Console.WriteLine(student);
            }
        }
    }
}
