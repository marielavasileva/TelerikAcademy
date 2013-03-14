using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.LINQStudentAge
{

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Student(string firstName, string lastName,int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;

        }

    }
    class LINQStudentAge
    {
        static void Main(string[] args)
        {
            Student[] students = {
                                    new Student ("Ivan", "Vasilev",24),
                                    new Student ("Ivan", "Ivanov",21 ),
                                    new Student ("Petar", "Ivanov",18 ),
                                    new Student ( "George", "Angelov" ,15),
                                 };

            var resultStudents = from student in students
                                 where ((student.Age>=18) & (student.Age<=24))
                                 select new { firstName = student.FirstName, lastName = student.LastName };

            foreach (var student in resultStudents)
            {
                Console.WriteLine("{0} {1}", student.firstName, student.lastName);
            }
        }
    }
}
