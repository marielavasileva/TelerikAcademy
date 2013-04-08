using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.School
{
    class Program
    {
        static void Main()
        {
            try
            {
                //Initialize some students
                Student studentFirst = new Student("Evgeni", 4085);
                Student studentSecond = new Student("Petar", 5216565);
                Student studentThird = new Student("Ivo", 32133);

                //...some disciplines
                Discipline disciplineFirst = new Discipline("Mathematic", 8, 5);
                Discipline disciplineSecond = new Discipline("Biology", 7, 3);

                // ... teacher
                Teacher teacherFirst = new Teacher("Petkov");
                //Adding some disciplines that he teaching
                teacherFirst.SetOfDisciplines.Add(disciplineFirst);
                teacherFirst.SetOfDisciplines.Add(disciplineSecond);


                //Make a class with students and teacher
                Class lastClass = new Class("The last one");
                lastClass.SetOfStudents.Add(studentFirst);
                lastClass.SetOfStudents.Add(studentSecond);
                lastClass.SetOfStudents.Add(studentThird);
                lastClass.SetOfTeachers.Add(teacherFirst);
                Console.WriteLine("Our class - \"{0}\" have {1} studets :\n{2}and {3} teacher(s) :\n{4}"
                    , lastClass.UniqueTextIdentifier, lastClass.SetOfStudents.Count, lastClass.Students()
                    , lastClass.SetOfTeachers.Count, lastClass.Teachers());


                studentFirst.AddComment("Evgeni is football player");
                teacherFirst.AddComment("Mr. Petkov do not like football players.");
                Console.WriteLine(studentFirst.ShowComment() + "," + teacherFirst.ShowComment());



            }
            catch (Exception ex)
            {

                Console.WriteLine("Error!" + ex.Message); ;
            }

        }
    }
}
