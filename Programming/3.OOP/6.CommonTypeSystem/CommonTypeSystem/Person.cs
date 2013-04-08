using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonTypeSystem
{
    class Person
    {
        
    public string name;
    public int? age;

    
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public int? Age
    {
        get { return this.age; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Tha age must be a positive number!");
            }
            this.age = value;
        }
    }

    
    public Person(string name, int? age = null)
    {
        this.Name = name;
        this.Age = age;
    }

    
    public override string ToString()
    {
        return string.Format("Name : {0}\nAge : {1}", this.Name,
            this.Age.ToString() != string.Empty ? this.Age.ToString() : "No entered age");
    }

    }
}
