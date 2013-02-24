using System;


    class BitNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter the number : ");

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the position : ");

            int p = int.Parse(Console.ReadLine());

            Console.WriteLine("(1 or 0)");

            int v = int.Parse(Console.ReadLine());

            int digit = (((1 << p) & n) >> p);

            if (digit == v)
            {
                Console.WriteLine("The new digit is at {0}", v);
            }

            else if (digit == 0)
            {
                n = (n | (1 << p));
            }

            else if (digit == 1)
            {
                n = ((~(1 << p) & n));
            }

            Console.WriteLine(n);
        }
    }

