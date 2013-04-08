using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.School
{
   public class Student:Human,IOptionalComment
    {
        private int uniqueNumber;
        private string optionalComment;

        //Properties
        public int UniqueNumber
        {
            get { return this.uniqueNumber; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The number must be positive!");
                }
                this.uniqueNumber = value;
            }
        }


        //Constructor
        public Student(string name, int uniqueNumber)
            : base(name)
        {
            this.UniqueNumber = uniqueNumber;
        }

        public void AddComment(string comment)
        {
            this.optionalComment = comment;
        }
        public string ShowComment()
        {
            return this.optionalComment;
        }

    }
}
