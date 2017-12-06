using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AverageStudentGrades
{
    class AverageStudentGrades
    {
        static void Main(string[] args)
        {
            var schoolGrade = new Dictionary<string, List<double>>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var nameAndGrade = Console.ReadLine().Split(' ').ToList();
                var name = nameAndGrade[0];
                var grade = double.Parse(nameAndGrade[1]);

                if (!schoolGrade.ContainsKey(name))
                {
                    schoolGrade[name] = new List<double>();
                    schoolGrade[name].Add(grade); 
                }
                else
                {
                    schoolGrade[name].Add(grade);
                }
            }
            foreach (var student in schoolGrade)
            {
                var name = student.Key;
                var grade = student.Value;
                var average = grade.Average();

                Console.Write($"{name:f2} -> ");

                foreach (var value in grade)
                {
                    Console.Write($"{value:f2} ");
                }
                Console.WriteLine($"(avg: {average:f2})");
            }
        }
    }
}
