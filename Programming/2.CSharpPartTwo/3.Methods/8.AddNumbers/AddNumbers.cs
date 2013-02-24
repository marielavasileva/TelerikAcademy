using System;
using System.Collections.Generic;

class AddNumbers
{
    static void Main()
    {

        string oneStr = Console.ReadLine();
        string twoStr = Console.ReadLine();

        Console.Write(oneStr + " + " + twoStr);

        int[] arrayOne = new int[oneStr.Length];
        int[] arrayTwo = new int[twoStr.Length];

        arrayOne = ReverseArray(oneStr);
        arrayTwo = ReverseArray(twoStr);

        var resultString = SumOfArrays(arrayOne, arrayTwo);

        Console.Write(" = ");

        foreach (var result in resultString)
        {
            Console.Write(result);
        }
        Console.WriteLine();
    }

    static int[] ReverseArray(string numberStr)
    {
        string tempStr = numberStr;

        
        int[] massiv = new int[tempStr.Length];
        for (int i = 0; i < massiv.Length; i++)
        {
            massiv[i] = (byte)(tempStr[i] - 48);
        }

        Array.Reverse(massiv);

        return massiv;
    }

    static List<int> SumOfArrays(int[] massivOne, int[] massiveTwo)
    {
        List<int> result = new List<int>(Math.Max(massivOne.Length, massiveTwo.Length));

        int current = 0;

        for (int i = 0; i < result.Capacity; i++)
        {
            int currentDigit = (i < massivOne.Length ? massivOne[i] : 0) + (i < massiveTwo.Length ? massiveTwo[i] : 0) + current;
            current = currentDigit / 10;
            result.Add((currentDigit % 10));
        }

        if (current == 1)
        {
            result.Add(1);
        }
        result.Reverse();

        return result;
    }
}