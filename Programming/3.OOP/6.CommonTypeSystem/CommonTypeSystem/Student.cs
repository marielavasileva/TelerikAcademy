using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonTypeSystem
{
    public class Student : ICloneable, IComparable<Student>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string EmailPhone { get; set; }
        public uint SSN { get; set; }
        public int Course { get; set; }
        public Universities University { get; set; }
        public Specialties Specialty { get; set; }
        public Faculties Faculty { get; set; }


        public Student(string firstName, string middleName, string lastName, string address, string emailPhone, uint SSD, int course,
            Universities university, Specialties specialty, Faculties faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Address = address;
            this.EmailPhone = emailPhone;
            this.SSN = SSD;
            this.Course = course;
            this.University = university;
            this.Specialty = specialty;
            this.Faculty = faculty;

        }

        public override bool Equals(object param)
        {
            Student student = param as Student;

            if (student == null)
            {
                return false;
            }

            if (!Object.Equals(this.FirstName, student.FirstName))
            {
                return false;
            }

            if (this.MiddleName != student.MiddleName)
            {
                return false;
            }

            if (this.LastName != student.LastName)
            {
                return false;
            }

            if (this.SSN != student.SSN)
            {
                return false;
            }



            return true;
        }


        public override string ToString()
        {
            return String.Format("{0} {1} {2} with SSN: {3}, Adress : {4},E-mail : {5}, student in : {6} {7}, specialty : {8}, course : {9}",
               this.FirstName,this.MiddleName,this.LastName,this.SSN,this.Address,this.EmailPhone ,this.University,this.Faculty,this.Specialty,this.Course);
        }

        public override int GetHashCode()
        {
            return LastName.GetHashCode() ^ SSN.GetHashCode();
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        public Student Clone()
        {
            Student newStudent = new Student
            (
            this.FirstName,
            this.MiddleName,
            this.LastName,
            this.Address,
            this.EmailPhone,
            this.SSN,
            this.Course,
            this.University,
            this.Specialty,
            this.Faculty
            );
            return newStudent;
        
        }

        object ICloneable.Clone()
        {
            return this.Clone();

        }


        public int CompareTo(Student anotherStudent)
        {
            if (this.FirstName != anotherStudent.FirstName)
            {
                return (string.Compare(this.FirstName, anotherStudent.FirstName));
            }

            if (this.MiddleName != anotherStudent.MiddleName)
            {
                return (string.Compare(this.MiddleName, anotherStudent.MiddleName));
            }

            if (this.LastName != anotherStudent.LastName)
            {
                return (string.Compare(this.LastName, anotherStudent.LastName));
            }
            if (this.SSN != anotherStudent.SSN)
            {
                return (int)(this.SSN - anotherStudent.SSN);
            }
            return 0;
        }

    }
}
