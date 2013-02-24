
using System;


class HexToUnicode
{
    static void Main()
    {
        char symbol = 'H';
        int firstNumber = 0x48;
        Console.WriteLine("The code of '{0}' is {1}", symbol, (int)symbol);
        Console.WriteLine("The number in decimal is  "+ firstNumber);

    }
}

