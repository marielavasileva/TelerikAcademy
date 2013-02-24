using System;



    class TrapezoidArea
    {
        static void Main()
        {
            Console.WriteLine("Enter a value for 'a': ");
            string s = Console.ReadLine();
            float a = float.Parse(s);
            Console.WriteLine("Enter a value for 'b':");
            string s1 = Console.ReadLine();
            float b = float.Parse(s1);
            Console.WriteLine("Enter a value for heigh:");
            string s2 = Console.ReadLine();
            float h = float.Parse(s2);
            float area = ((a + b) * h) / 2;
            Console.WriteLine("The area is : {0}", area);
        }
    }

