using System;
using System.Linq;

namespace StudentsNames
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

    }

    class LINQStudentLastName
    {
        static void Main()
        {
            Student[] students = {
                                    new Student ("Ivan", "Vasilev"),
                                    new Student ("Ivan", "Ivanov" ),
                                    new Student ("Petar", "Ivanov" ),
                                    new Student ( "George", "Angelov" ),
                                 };

            var resultStudents = from student in students
                                 where student.FirstName.CompareTo(student.LastName) < 0
                                 select new { firstName = student.FirstName, lastName = student.LastName };

            foreach (var student in resultStudents)
            {
                Console.WriteLine("{0} {1}", student.firstName, student.lastName);
            }
        }
    }
}