using System;



class BiggerNumbers
{
    private static void BiggerNumberByIndex(int n, int[] array, int index)
    {
        if (index == 0 || index == n)
        {
            Console.WriteLine(" {0} -> {1} -> has one neighbor!", array[index], index);
        }
        else if (array[index] > array[index - 1] && array[index] > array[index + 1])
        {
            Console.WriteLine(" {0} -> {1} is the biggest of its neighbors", array[index], index);
        }
        else if (array[index] < array[index - 1] || array[index] < array[index + 1])
        {
            Console.WriteLine(" {0} -> {1} is smaller than one of its two neighbors", array[index], index);
        }
                 
        else
        {
            Console.WriteLine(" {0} -> {1} is equal to its two neighbors", array[index], index);
        }
    }
    static void Main()
    {
        Console.Write("Enter array size:");
        int n = int.Parse(Console.ReadLine());
        int[] arrayEntered = new int[n];

        Console.Write("Enter index to check :");
        int indexEntered = int.Parse(Console.ReadLine());

        for (int i = 0; i < arrayEntered.Length; i++)
        {
            Console.Write("Element[{0}] = ", i);
            arrayEntered[i] = int.Parse(Console.ReadLine());
        }

            BiggerNumberByIndex(n,arrayEntered,indexEntered);
    }
}

