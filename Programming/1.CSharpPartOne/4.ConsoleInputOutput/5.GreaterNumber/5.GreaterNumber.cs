using System;



class GreaterNumber
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers to compare which one is the greater : ");
        string s = Console.ReadLine();
        int a = int.Parse(s);
        string s1 = Console.ReadLine();
        int b = int.Parse(s1);
        int c = Math.Max(a, b);


        Console.WriteLine("The greater number is : {0} ", c);

    }
}

