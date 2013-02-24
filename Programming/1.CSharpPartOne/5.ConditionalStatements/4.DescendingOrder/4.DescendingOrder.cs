using System;


class DescendingOrder
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


        if (a >= b)
        {
            if ((a >= c) && (b > c))
            {

                Console.WriteLine(a + " " + b + " " + c);
            }
            if ((a > c) && (b <= c))
            {

                Console.WriteLine(a + " " + c + " " + b + "");
            }
        }


        if ((a < b))
        {
            if ((b >= c) && (a >= c))
            {
                Console.WriteLine(b + " " + a + " " + c);
            }

            if ((b > c) && (a <= c))
            {
                Console.WriteLine(b + " " + " " + c + " " + a);
            }
        }



        if (c >= a)
        {
            if ((c > b) && (a >= b))
            {
                Console.WriteLine(c+" "+a+" "+b+" ");
            }


            if ((c >= b) && (a <= b))
            {
                Console.WriteLine(c + " " + b + " " + a);
            }
        }



    }
}

