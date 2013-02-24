using System;



class HexadecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Enter a hexadecimal number to convert to binary number : ");
        string hexvalue = Console.ReadLine();
        string binaryval = Convert.ToString(Convert.ToInt32(hexvalue, 16), 2);
        Console.WriteLine("Binary number : "+binaryval);
    }
}

