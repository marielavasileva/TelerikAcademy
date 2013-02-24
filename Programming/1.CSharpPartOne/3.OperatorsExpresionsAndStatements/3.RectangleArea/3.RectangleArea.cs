using System;




    class RectangleArea

    {
        static void Main()
        {
            Console.WriteLine("Enter the width of the rectangle : ");
            string s = Console.ReadLine();
            int width = int.Parse(s);
            Console.WriteLine("Enter the height of the rectangle : ");
            string s1 = Console.ReadLine();
            int height = int.Parse(s1);
            int area = (width * height) / 2;
            Console.WriteLine("The area of the rectangle is : "+area);
        }
    }

