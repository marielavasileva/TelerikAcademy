using System;


  class PointCheck
    {
        static void Main()
        {
            Console.Write("Enter a value for x: ");
            string s = Console.ReadLine();
            int x = int.Parse(s);
            Console.Write("Enter a value for y: ");
            string s1 = Console.ReadLine();
            int y = int.Parse(s1);
            const int radius = 3;
            bool inCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= Math.Pow(radius,2);
            bool inRectangle = ((-1 <= x) && (x <= 5)) && ((-1 <= y) && (y <= 1));

            if (inCircle)
            {
                Console.WriteLine("The point is the circle.");
            }
            else 
            {
                Console.WriteLine("The point is not in the circle.");
            }

            if (inRectangle)
            {
                Console.WriteLine("The point is the rectangle.");
            }
            else
            {
                Console.WriteLine("The point is not in the rectangle.");
            }
            
        }
    }

