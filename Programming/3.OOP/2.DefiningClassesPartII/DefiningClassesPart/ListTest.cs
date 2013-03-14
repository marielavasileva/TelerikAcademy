using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClassesPartII
{
    class ListTest
    {
        static void Main(string[] args)
        {
            GenericList<int> myList = new GenericList<int>();

            
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            myList.Add(-7);
            Console.WriteLine(new string(' ', 80));
            Console.WriteLine("Test Adding elements");
            Console.WriteLine("This is my list: " + myList);

            //////////////////////////Inserting///////////////////////////////
            myList.InsertAt(2, 33);
            myList.InsertAt(0, 33);
            Console.WriteLine(new string(' ', 80));
            Console.WriteLine("Test Insert of elements");
            Console.WriteLine(myList);
        }
    }
}
