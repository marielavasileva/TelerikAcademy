using System;



class FiveSum
{
    static void Main()
    {
        Console.Write("Enter the first number : ");
        string s = Console.ReadLine();
        int a = int.Parse(s);
        Console.Write("Enter the second number : ");
        string s1 = Console.ReadLine();
        int b = int.Parse(s1);
        Console.Write("Enter the third number : ");
        string s2 = Console.ReadLine();
        int c = int.Parse(s2);
        Console.Write("Enter the forth number : ");
        string s3 = Console.ReadLine();
        int d = int.Parse(s3);
        Console.Write("Enter the fifth number : ");
        string s4 = Console.ReadLine();
        int e = int.Parse(s4);



        if (((a + b + c + d + e) == 0) && (a != 0) && (b != 0) && (c != 0) && (d != 0) && (e != 0))
        {
            Console.WriteLine("a+b+c+d+e " + (a + b + c + d + e));
        }

        else if ((e == 0) || (a + b + c + d == 0))
        {
            Console.WriteLine("a+b+c+d " + (a + b + c + d));
        }

        else if ((d == 0) || (a + b + c + e == 0))
        {
            Console.WriteLine("a+b+c+e " + (a + b + c + e));
        }

        else if ((c == 0) || (a + b + d + e == 0))
        {
            Console.WriteLine("a+b+d+e " + (a + b + d + e));
        }

        else if ((b == 0) || (a + c + d + e == 0))
        {
            Console.WriteLine("a+c+d+e " + (a + c + d + e));
        }

        else if ((a == 0) || (b + c + d + e == 0))
        {
            Console.WriteLine("b+c+d+e " + (b + c + d + e));
        }
        else if ((d == 0) || (e == 0) || (a + b + c == 0))
        {
            Console.WriteLine("a+b+c " + (a + b + c));
        }

        else if ((c == 0) || (e == 0) || (a + b + d == 0))
        {
            Console.WriteLine("a+b+d " + (a + b + d));
        }

        else if ((c == 0) || (d == 0) || (a + b + e == 0))
        {
            Console.WriteLine("a+b+e " + (a + b + e));
        }

        else if ((b == 0) || (e == 0) || (a + c + d == 0))
        {
            Console.WriteLine("a+c+d " + (a + c + d));
        }

        else if ((b == 0) || (d == 0) || (a + c + e == 0))
        {
            Console.WriteLine("a+c+e " + (a + c + e));
        }

        else if ((b == 0) || (c == 0) || (a + d + e == 0))
        {
            Console.WriteLine("a+d+e " + (a + d + e));
        }

        else if ((a == 0) || (e == 0) || (b + c + e == 0))
        {
            Console.WriteLine("b+c+e " + (b + c + d));
        }

        else if ((a == 0) || (d == 0) || (b + c + e == 0))
        {
            Console.WriteLine("b+c+e " + (b + c + e));
        }

        else if ((a == 0) || (c == 0) || (b + d + e == 0))
        {
            Console.WriteLine("b+d+e " + (b + d + e));
        }

        else if ((a == 0) || (b == 0) || (c + d + e == 0))
        {
            Console.WriteLine("c+d+e " + (c + d + e));
        }
        else if ((c == 0) || (d == 0) || (e == 0) || (a + b == 0))
        {
            Console.WriteLine("a+b " + (a + b));
        }

        else if ((b == 0) || (d == 0) || (e == 0) || (a + c == 0))
        {
            Console.WriteLine("a+c " + (a + c));
        }

        else if ((b == 0) || (c == 0) || (e == 0) || (a + d == 0))
        {
            Console.WriteLine("a+d " + (a + d));
        }

        else if ((b == 0) || (c == 0) || (d == 0) || (a + e == 0))
        {
            Console.WriteLine("a+e " + (a + e));
        }

        else if ((a == 0) || (d == 0) || (e == 0) || (b + c == 0))
        {
            Console.WriteLine("b+c " + (b + c));
        }
        else if ((a == 0) || (c == 0) || (e == 0) || (b + d == 0))
        {
            Console.WriteLine("b+d " + (b + d));
        }
        else if ((a == 0) || (c == 0) || (d == 0) || (b + e == 0))
        {
            Console.WriteLine("b+e " + (b + e));
        }

        else if ((a == 0) || (b == 0) || (e == 0) || (c + d == 0))
        {
            Console.WriteLine("c+d " + (c + d));
        }

        else if ((a == 0) || (b == 0) || (d == 0) || (c + e == 0))
        {
            Console.WriteLine("c+e " + (c + e));
        }

        else if ((a == 0) || (b == 0) || (c == 0) || (d + e == 0))
        {
            Console.WriteLine("d+e " + (d + e));
        }

        else
        {
            Console.WriteLine("There is no subsets with sum zero!");
        }
    }



}

