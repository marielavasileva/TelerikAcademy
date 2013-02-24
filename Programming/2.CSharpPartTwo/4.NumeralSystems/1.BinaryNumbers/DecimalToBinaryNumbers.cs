using System;



class DecimalToBinaryNumbers
{
    static void Main()
    {


        Console.Write("Enter decimal number to convert: ");
        int number = int.Parse(Console.ReadLine());
        int bases = 2;
        string binary = Convert.ToString(number, bases);
        Console.WriteLine("Binary number : "+binary);
    }
}

