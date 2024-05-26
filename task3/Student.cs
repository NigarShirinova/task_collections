using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace task3
{
    internal class Student
    {
        public Dictionary<string, List<int>> Grades { get; set; }
        public Student()
        {
            Grades = new Dictionary<string, List<int>>();
        }
        public void AddGrade(string name, List<int> studentsGrades)
        {
            if (!Grades.ContainsKey(name))
                Grades[name] = studentsGrades;
            else
                Grades[name].AddRange(studentsGrades);
        }

        public void RemoveGrade(string name)
        {
            Grades.Remove(name);
        }

        public void GetAvarageGrade(string name)
        {
            foreach (var studentName in Grades.Keys)
            {
                if(studentName == name)
                {
                    int sum = 0;
                    int count = 0;
                    foreach (var grade in Grades[name])
                    {
                        sum += grade;
                        count++;
                    }
                    Console.WriteLine(sum/count);
                }
                else
                    Console.WriteLine("This student doesn't include to there");
            }
        }

        public void GetAllGradesByStudent(string studentName)
        {
            if (Grades.ContainsKey(studentName))
            {
                foreach (var grade in Grades[studentName])
                {
                    Console.Write(grade + " ");
                }
            }
            else
            {
                Console.WriteLine("This student doesn't include to there");
            }
        }
    }
}
