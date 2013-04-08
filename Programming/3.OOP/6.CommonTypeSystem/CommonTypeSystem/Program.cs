using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonTypeSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Student FirstStudent = new Student("Peter", "Ivanov", "Vasilev", "Sofia,Ovcha kupel",
            "email@gmail.bg", 131311,2, Universities.SofiaUniversity,  Specialties.ComputerSystems,Faculties.InformaticsFaculty);
        Console.WriteLine(FirstStudent);
        Console.WriteLine();


            Student SecondStudent = FirstStudent.Clone();
        Console.WriteLine(SecondStudent);
        SecondStudent.FirstName = "Joro";
        Console.WriteLine(SecondStudent.FirstName);
        Console.WriteLine(FirstStudent.FirstName);
        Console.WriteLine();

        //Testing override method CompareTo
        Console.WriteLine(FirstStudent.CompareTo(SecondStudent));
        SecondStudent.FirstName = "Peter";
        Console.WriteLine(FirstStudent.CompareTo(SecondStudent));
        Console.WriteLine();

        Person firstPerson = new Person("Filip", 27);
        Person secondPerson = new Person("Ivan");
        Console.WriteLine(secondPerson);
        Console.WriteLine();
        Console.WriteLine(firstPerson);
        }


    }
}






    

