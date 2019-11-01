using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace k163680_Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            for(int i=0; i<100; i++)
                students.Add(new Student(RandomInfo.getName(), RandomInfo.GetDateOfBirth(), RandomInfo.getSemester(), RandomInfo.getGPA()));
            
            students.Sort();

            for (int i = 0; i < 100; i++)
                Console.WriteLine(students[i].display());

            Console.ReadLine();

        }
    }
}
