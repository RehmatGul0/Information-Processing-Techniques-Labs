using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace k163680_Q4
{
    public class Student : IComparable<Student>
    {
        String name;
        DateTime dateOfBirth;
        int semester;
        double gpa;

        public Student(string name, DateTime dateOfBirth, int semester, double gpa)
        {
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.semester = semester;
            this.gpa = gpa;
        }

        public int CompareTo(Student student)
        {
            return this.gpa.CompareTo(student.gpa);
        }

        public String display()
        {
            return $"Name: {this.name} Date Of Birth: {this.dateOfBirth.ToShortDateString()} Semester: {this.semester} GPA : {this.gpa} ";
        }
    }
}
