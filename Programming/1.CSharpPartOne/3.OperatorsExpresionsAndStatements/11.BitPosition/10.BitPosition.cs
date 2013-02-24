using System;



    class BitPosition
    {
        static void Main()
        {
           
        Console.Write("Please enter intiger number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the position of the bit p to check if it's value is 1: ");
        int p = int.Parse(Console.ReadLine());
        int i = 1;
        int mask = i << p;
        Console.WriteLine((n & mask) != 0 ? "The bit at postion {0} is 1" : "The bit at position {0} is 0", p);
 
    
        }
    }


