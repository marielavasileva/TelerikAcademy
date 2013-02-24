using System;



class BiggestNumber
{
    private static void BiggerNumberByIndex(int n, int[] array, int index)
    {

        if (array[index] > array[index - 1] && array[index] > array[index + 1])
        {
            Console.WriteLine(" {0} -> {1} ", array[index], index);
        }

        else
        {
            Console.WriteLine("-1");
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

        BiggerNumberByIndex(n, arrayEntered, indexEntered);
    }
}


