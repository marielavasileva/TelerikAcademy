using System;



class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter a hexadecimal number to convert : ");
        string number = Console.ReadLine();
        int decimalNumber = Convert.ToInt32(number, 16);
        Console.WriteLine("Decimal number "+decimalNumber);
    }
}

