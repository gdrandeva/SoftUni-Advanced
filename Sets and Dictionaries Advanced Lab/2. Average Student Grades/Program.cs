using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> avgGradeByStudent = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] studentsInfo = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

                if (!avgGradeByStudent.ContainsKey(studentsInfo[0]))
                {
                    avgGradeByStudent.Add(studentsInfo[0],new List<decimal>());
                }
                avgGradeByStudent[studentsInfo[0]].Add(decimal.Parse(studentsInfo[1]));
            }

            foreach (var student in avgGradeByStudent)
            {
                Console.Write($"{student.Key} -> ");
                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {student.Value.Average():f2})");
            }
        }
        
      
    }
}
