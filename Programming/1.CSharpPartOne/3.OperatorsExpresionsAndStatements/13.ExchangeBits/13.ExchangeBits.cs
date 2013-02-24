using System;



    class ExchangeBits
    {
        static void Main(string[] args)
        {
            uint n;
            Console.Write("Enter number n:");
            bool isnInt = uint.TryParse(Console.ReadLine(), out n);
            if (isnInt)
            {
                Console.WriteLine("Enter binary initial n:");
                Console.WriteLine(Convert.ToString(n, 2));

                n = ((~(7u << 24 | 7u << 3)) & n) | (((n & (7u << 3)) << 21) | ((n & (7u << 24)) >> 21));

                Console.WriteLine("Enter binary new n:");
                Console.WriteLine(Convert.ToString(n, 2));
            }
            else
            {
                Console.WriteLine("Not a valid number !");
            }
        }
    }

