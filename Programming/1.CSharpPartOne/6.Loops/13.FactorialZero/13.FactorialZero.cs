using System;



    class FactorialZero
    {
        static void Main()
        {
            Console.Write("n= ");
            string strN = Console.ReadLine();
            int n = int.Parse(strN);
            int facResult = 0;
            for (int i = 5; i <= n; i *= 5)
            {
                facResult = facResult + (n / i);
            }
            Console.WriteLine(facResult);

        }
    }

