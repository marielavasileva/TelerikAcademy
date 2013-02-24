using System;



    class GreaterThreeNumbers
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
            
            if(a >= b)
            {
                if (a >= c)
                {
                    Console.WriteLine("The greatest number is {0} : ",a);
                }

                if (a <= c)
                {
                    Console.WriteLine("The greatest number is {0} : ",c);
                }


               
            }

            else if(a <= b)
            {
                if (b >= c)
                {
                    Console.WriteLine("The greatest number is {0} : ",b);
                }

                if (c >= b)
                {
                    Console.WriteLine("The greatest number is {0} : ",c); 
                }

            }

            
        }
    }

