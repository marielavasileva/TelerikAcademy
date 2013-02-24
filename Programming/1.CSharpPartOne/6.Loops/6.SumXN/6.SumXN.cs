using System;



    class SumXN
    {
        static void Main()
        {
            Console.Write("n= ");
            string strN = Console.ReadLine();
            uint n = uint.Parse(strN);
            Console.Write("x= ");
            string strX = Console.ReadLine();
            uint x = uint.Parse(strX);
            
            decimal factorial = 1;
            decimal power = 1 ;
            decimal sum=0;
            for (int k = 1; k <= n; k++)
            {
                power = power * x;
                factorial *= k;
                sum = (factorial / power);
                sum += sum + 1;

            }
            Console.WriteLine("S = 1 + 1!/x + 2!/x^2 + ... + n!/x^n = {0}", sum); 
        }
    }

