using System;



class QuadraticEquation
{
    static void Main()
    {
        Console.Write("a = ");
        string coef1 = Console.ReadLine();
        int a = int.Parse(coef1);
        Console.Write("b = ");
        string coef2 = Console.ReadLine();
        int b = int.Parse(coef2);
        Console.Write("c = ");
        string coef3 = Console.ReadLine();
        int c = int.Parse(coef3);
        int D;
        double x1;
        double x2;
        D = (b * b) - (4 * a * c);
        Console.WriteLine("D = {0} ", D);

        if ((D == 0) & (a != 0))
        {
            {
                x1 = x2 = -(b / 2 * a);
                Console.WriteLine("x1 = x2 = {0:0.000} ", x1);
            }
            if ((D > 0) & (a != 0))
            {
                
                x1 = (-b - Math.Sqrt(D)) / (2 * a);
                x2 = (-b + Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1 = {0:0.000} ", x1);
                Console.WriteLine("x2 = {0:0.000}", x2);
            }
        }
            if ((D < 0)||(a==0))
            {
                Console.WriteLine("There is no real roots!");
            }
        
        

    }
}

