using System;



    class CircleCheck
    {
        static void Main()
        {
            Console.WriteLine("Enter first point : ");
            string s = Console.ReadLine();
            int x =int.Parse(s);
            Console.WriteLine("Enter the second point");
            string s1 = Console.ReadLine();
            int y = int.Parse(s1);
            const int radius = 5;
            bool check = x*x+y*y<=Math.Pow(radius,2);
            if (check)
            {
                Console.WriteLine("The given points are within the circle.");
            }
            else
            {
                Console.WriteLine("The given pointss are not in the circle");
            }

        }
    }

