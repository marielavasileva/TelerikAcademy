using System;



    class BitPosition
    {
        static void Main(string[] args)
        {
            Console.Write("Number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Position of the bit: ");
            int p = int.Parse(Console.ReadLine());

            int mask = 1 << p;

            Console.WriteLine("The {0} bit in {1} is {2}", p, n, (n & mask) != 0 ? 1 : 0);
        }
    }

