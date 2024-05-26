using System;
using task3;

class Program
{
    public static void Main(string[] args)
    {
        Student student = new Student();

        student.AddGrade("nigar", new List<int> { 1, 2, 3, 4 });
        student.AddGrade("raksana", new List<int> { 3, 1, 5, 2, 5 });

        student.RemoveGrade("raksana");
        student.GetAvarageGrade("nigar");
        student.GetAllGradesByStudent("nigar");
        student.GetAllGradesByStudent("dhsj");
    }
}