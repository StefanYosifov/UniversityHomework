using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Bonus_01
{
    public class Student
    {

        public Student(string name, string facultyNumber, string sin, string group,double avgGrade,bool hasExamsPassed)
        {
            this.Name = name;
            this.FacultyNumber = facultyNumber;
            this.SIN = sin;
            this.averageGrades = avgGrade;
            this.allExamsPassed = hasExamsPassed;
        }
        public Student()
        {

        }
        public string Name { get; set; }

        public string FacultyNumber { get; set; }

        public string SIN { get; set; }

        public string Group { get; set; }

        public bool allExamsPassed { get; set; }

        public double averageGrades { get; set; }

        private const int examsCount = 5;

        public bool hasPassed(double grade)
        {
            if (grade > 2)
            {
                return true;
            }
            return false;
        }

        public double averageGrade()
        {

            Console.WriteLine($"Enter your grades");
            double totalGrades=0;
            for (int i = 0; i < examsCount; i++)
            {
                double grades=double.Parse(Console.ReadLine());
                if (grades == 2)
                {
                    Console.WriteLine($"You seems to have failed an exam");
                }
                else if(grades<2 || grades > 6)
                {
                    Console.WriteLine($"Invalid grade,enter again");
                    i--;
                    continue;
                }
                totalGrades+=grades;
            }
            
            averageGrades = totalGrades / examsCount;
            return averageGrades;
            
        }
    }
}
