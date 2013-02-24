using System;



    class ShortToBinaryNumber
    {
        static void Main()
        {
            Console.Write("Enter decimal number to convert: ");
            short number = short.Parse(Console.ReadLine());
            int bases = 2;
            string binary = Convert.ToString(number, bases);
            Console.WriteLine("Binary number : " + binary);
        }
    }

