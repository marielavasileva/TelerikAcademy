using System;



    class FactorialNMultyK
    {
        static void Main()
        {
            Console.Write("N= ");
            string nStr = Console.ReadLine();
            ulong n = ulong.Parse(nStr);
            Console.Write("K= ");
            string kStr = Console.ReadLine();
            ulong k = ulong.Parse(kStr);
            decimal factorialN = 1;
            decimal factorialKN = 1;

            if (k >= n)
            {
                for (ulong i = 1; i <= n; i++)
                {
                    factorialN *= i;
                }
                

                for (ulong i = (k - n) + 1; i <= k; i++)
                {
                    factorialKN *= i;
                }

                Console.WriteLine("N!*K!/(N-K)!= {0}",factorialN * factorialKN);
            }
            else
            {
                Console.WriteLine("K must be bigger than N !");
            }
        }
    }

