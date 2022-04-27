using System;
using System.Linq;
using System.Collections.Generic;

namespace OOP_Bonus_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents=int.Parse(Console.ReadLine());
            List<Student> students=new List<Student>();
            Student s = new Student();
            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] studentInfo = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                string studentName = studentInfo[0];
                string studentNumber=studentInfo[1];
                string studentSIN=studentInfo[2];
                string studentGroup=studentInfo[3];
                
                double avgGrade=s.averageGrade();
                bool hasPassedExam=s.hasPassed(avgGrade);
                Student finalStudent=new Student(studentName,studentNumber,studentSIN,studentGroup,avgGrade,hasPassedExam);
                students.Add(finalStudent);
            }

            students.OrderBy(x=>x.averageGrades).ToList();


            foreach(var stud in students)
            {
                if (stud.allExamsPassed)
                {
                    Console.WriteLine($"{stud.Name} {stud.FacultyNumber} {stud.SIN} {stud.Group} {s.averageGrades:F2}");
                }
            }

        }
    }
}
