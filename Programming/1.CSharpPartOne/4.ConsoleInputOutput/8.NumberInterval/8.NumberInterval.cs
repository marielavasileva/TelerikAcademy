using System;



    class NumberInterval
    {
        static void Main()
        {
            Console.Write("How many numbers want to print : ");
            string s = Console.ReadLine();
            int n = int.Parse(s);
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Number : {0} ",i);
            }
        }
    }

