
using System;

class SortLengthElements
{
    public static int n, m;
    static void SortStrings(string[] array)
    {
        int[] stringLength = new int[n];
        for (m = 0; m < array.Length; m++)
        {
            stringLength[m] = array[m].Length;
        }
        Array.Sort(stringLength, array);
    }

    static void Main()
    {
        Console.Write("Enter the length n: ");

        n = int.Parse(Console.ReadLine());
        string[] array = new string[n];
        m = 0;
        Console.WriteLine("Enter the strings in the array:");
        while (m < n)
        {
            array[m] = Console.ReadLine();
            m++;
        }
        SortStrings(array);
        foreach (string item in array)
        {
            Console.WriteLine(item);
        }
    }
}