using System;



    class NumberProduct
    {
        static void Main()
        {
            Console.Write("Enter the first number : ");
            string s = Console.ReadLine();
            int a = int.Parse(s);
            Console.Write("Enter the sexond number : ");
            string s1 = Console.ReadLine();
            int b = int.Parse(s1);
            Console.Write("Enter the third number : ");
            string s2 = Console.ReadLine();
            int c = int.Parse(s2);
            char ch1 = '-';
            char ch2 = '+';
            

            if (a > 0)
            {
                if (b > 0)
                {
                    if (c > 0)
                    {
                        Console.WriteLine("The sum of the numbers is {0}",ch2);
                    }
                    
                }

                if (b > 0)
                {
                    if (c < 0)
                    {
                        Console.WriteLine("The sum of the numbers is {0}", ch1);
                    }
                }

                if (b < 0)
                {
                    if (c > 0)
                    {
                        Console.WriteLine("The sum of the numbers is {0}", ch1);

                    }

                }

                if (b < 0)
                {
                    if (c < 0)
                    {
                        Console.WriteLine("The sum of the numbers is {0}", ch2);
                    }
                }
            }


                else if(a<0)
                {
                    if (b > 0)
                    {
                        if (c < 0)
                        {
                            Console.WriteLine("The sum of the numbers is {0}", ch2);
                        }
                    }

                    if (b > 0)
                    {
                        if (c > 0)
                        {
                            Console.WriteLine("The sum of the numbers is {0}", ch1);
                        }
                    }

                    if (b < 0)
                    {
                        if (c > 0)
                        {
                            Console.WriteLine("The sum of the numbers is {0}", ch2);
                        }
                    }

                    if (b < 0)
                    {
                        if(c<0)
                        {
                            Console.WriteLine("The sum of the numbers is {0}", ch1);
                        }
                    }

                }
            }

        }
    

