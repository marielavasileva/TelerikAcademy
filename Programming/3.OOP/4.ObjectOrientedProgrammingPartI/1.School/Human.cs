﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.School
{
    public abstract class Human
    {
        //Fields
        private string name;

        //Properties
        public Human(string name)
        {
            this.Name = name;
        }

        //Constructor
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }
}
