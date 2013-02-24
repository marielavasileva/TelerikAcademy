using System;



    class ChangeBits
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            uint number = UInt32.Parse(Console.ReadLine());
            Console.Write("Enter starting bit postition (p, p < q) for first bit set: ");
            byte p = Byte.Parse(Console.ReadLine());
            Console.Write("Enter starting bit position (q) for second bit set: ");
            byte q = Byte.Parse(Console.ReadLine());
            Console.Write("Enter number of bits to swap: ");
            byte k = Byte.Parse(Console.ReadLine());

            

            uint bitsMask = (uint)(Math.Pow(2, k) - 1);

            Console.WriteLine(((~(bitsMask << q) & ~(bitsMask << p)) & number) | (((number & (bitsMask << q)) >> (q - p)) | ((number & (bitsMask << p)) << (q - p))));

            
        }
    }

