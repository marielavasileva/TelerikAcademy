

using System;

class BinarySearch
{
    static void Main()
    {
        int number;
        Console.Write(" Enter a number : ");
        number = int.Parse(Console.ReadLine());

        
        Console.Write("Enter array lenght: ");
        int length = int.Parse(Console.ReadLine());

        int[] arr = new int[length];
        

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0} :  ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        int min = 0;
        int max = arr.Length - 1;
        int middle = 0;

        while (min <= max)
        {
            middle = (max + min) / 2;

            if (arr[middle] < number)
            {
                min = middle + 1;
            }
            else if (arr[middle] > number)
            {
                max = middle - 1;
            }
            else
            {
                break;
            }
        }

        if (arr[middle] == number)
        {
            Console.WriteLine("The number {0} is found at index {1}", number, middle);
        }
        else
        {
            Console.WriteLine("The number {0} is not found in the array.", number);
        }
    }
}