using System;



    class FibonacciSequence
    {
        static void Main()
        {
            Console.Write("N = ");
            string s = Console.ReadLine();
            int number = int.Parse(s);
            int n = 0;
            int n1 = 1;
            Console.WriteLine("The Fibonacci sequence for {0} members is : ", number);
            Console.Write(" " + n+",");
            Console.Write(" " + n1+" ");
            for (int i = 2; i < number; i++)
            {

                int fib = n;
                n = n1;
                n1 = fib + n1;
                Console.Write("," + n1 + " ");
            }
        }
    }

