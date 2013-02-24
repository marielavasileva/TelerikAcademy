using System;
using System.Numerics;


    class CatalanNumbers
    {
        static void Main()
        {
            Console.Write("n= ");
            string strN = Console.ReadLine();
            int n =int.Parse(strN);

            BigInteger catalanN = 1;

            if (n > 0)
            {
                for (BigInteger i = 0; i < n; i++)
                {
                    catalanN = (2 * (2 * i + 1) * catalanN) / (i + 2);
                }
            }
            Console.WriteLine("Catalan number = {0}",catalanN);
        }
    }

