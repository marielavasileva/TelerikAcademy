using System;



class GreatestOfFive
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

        if (a >= b)
        {
            if (a > c)
            {
                if (a > d)
                {
                    if (a > e)
                    {

                        Console.WriteLine("The greatest number is {0} : ", a);
                    }
                }
            }
        }


            if (c>=a)
            {
                if(c>b)
                {
                if (c > d)
                {
                    if (c > e)
                    {
                        Console.WriteLine(c);
                    }
                }
            }
        }
            if (b >= a)
            {
                if (b > c)
                {
                    if (b > d)
                    {
                        if (b > e)
                        {
                            Console.WriteLine(b);
                        }
                    }
                }
            }
            if (d >= a)
            {
                if (d > b)
                {
                    if (d > c)
                    {
                        if (d > e)
                        {
                            Console.WriteLine(d);
                        }
                    }
                }
            }
            if (e >= a)
            {
                if (e > b)
                {
                    if (e > c)
                    {
                        if (e > d)
                        {
                            Console.WriteLine(e);
                        }
                    }
                }
            }


    }
        


    }



