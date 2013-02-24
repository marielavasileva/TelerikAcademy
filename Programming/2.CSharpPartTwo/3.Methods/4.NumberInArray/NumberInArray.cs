using System;



class NumberInArray
{
    static int ArrayNumber(int[] array, int frequentNumber)
    {

        int counter = 0;

        for (int i = 0; i < array.Length - 1; i++)
        {

            if (frequentNumber == array[i])
            {
                counter++;

            }
        }

        Console.WriteLine("The number = {0}", frequentNumber);
        Console.WriteLine("Count = {0} times", counter);


        return frequentNumber;
    }

    static void Main()
    {
        Console.Write("Enter array size:");
        int n = int.Parse(Console.ReadLine());
        int[] arrayEntered = new int[n];
        Console.Write("Enter number to check :");
        int numberEntered = int.Parse(Console.ReadLine());
        for (int i = 0; i < arrayEntered.Length; i++)
        {
            Console.Write("Element[{0}] = ", i);
            arrayEntered[i] = int.Parse(Console.ReadLine());
        }


        ArrayNumber(arrayEntered, numberEntered);
    }
}

