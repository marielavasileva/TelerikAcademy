using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.SortStudentLambda
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

    class SortStudentLambda
    {
        static void Main(string[] args)
        {
            Student[] students = {
                                    new Student ("Ivan", "Vasilev"),
                                    new Student ("Ivan", "Ivanov" ),
                                    new Student ("Petar", "Ivanov" ),
                                    new Student ( "George", "Angelov" ),
                                 };

            var queryFirstName = from student in students //LINQ query for the first name of the student
                        orderby student.FirstName descending, student.LastName descending
                        select new { firstName = student.FirstName, lastName = student.LastName };

            var queryLastName = from student in students//LINQ query for the last name of the student
                        orderby student.LastName descending
                        select new { firstName = student.FirstName, lastName = student.LastName };


            var queryLambdaFirstName = students.OrderByDescending(student => student.FirstName).ThenByDescending(student=>student.LastName)//Lambda expression of the first name
                  .ThenByDescending(student => student.LastName)
                  .Select(student => student.FirstName);

            var queryLambdaLastName = students.OrderByDescending(student => student.LastName)//Lambda expression of the last name
                 .ThenByDescending(student => student.FirstName)
                 .Select(student => student.LastName);


            Console.WriteLine("Lambda expression for the first name of the student: \n");

            foreach (var student in queryLambdaFirstName)
            {
                Console.WriteLine("{0}", student);
            }

            Console.WriteLine("Lambda expression for the last name of the student: \n");
            foreach (var student in queryLambdaLastName)
            {
                Console.WriteLine("{0}", student);
            }


            Console.WriteLine("LINQ query for the first name of the student:\n");

            foreach (var student in queryFirstName)
            {
                Console.WriteLine("{0} {1}", student.firstName, student.lastName);
            }

            Console.WriteLine("LINQ query for the last name of the student:\n");

            foreach (var student in queryLastName)
            {
                Console.WriteLine("{0} {1}", student.firstName, student.lastName);
            }
        }
    }
}
