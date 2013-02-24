using System;



class BinaryToDecimalNumbers
{
    static void Main()
    {
        Console.Write("Enter a binary number to convert : ");
        string binary = Console.ReadLine();
        int bases = 2;
        int integer = Convert.ToInt32(binary, bases);
        Console.WriteLine("Integer number " + integer);
    }
}

