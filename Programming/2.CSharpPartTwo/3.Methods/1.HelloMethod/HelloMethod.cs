using System;



    class HelloMethod
    {
        static string HelloName(string name)
        {
            Console.WriteLine("Hello {0}",name);
            return name;

        }

        static void Main()
        {
            string nameEntered;
            
            nameEntered = Console.ReadLine();
            HelloName(nameEntered);
        }
    }

