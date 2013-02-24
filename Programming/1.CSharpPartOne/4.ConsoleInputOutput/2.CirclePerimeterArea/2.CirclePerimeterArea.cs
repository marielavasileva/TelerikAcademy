using System;



class CirclePerimeterArea
{
    static void Main()
    {
        Console.WriteLine("Enter the radius:");
        string radiusStr = Console.ReadLine();
        int radius = int.Parse(radiusStr);
        double pi = Math.PI;
        Console.WriteLine("The perimeter of the circle is {0:0.00}", pi * radius);
        Console.WriteLine("The area of the circle is {0:0.00}", pi * (Math.Pow(radius, 2)));
    }
}
