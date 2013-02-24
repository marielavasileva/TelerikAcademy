using System;


class SelectionSort
{
    static void Main()
    {
        Console.Write("Enter the array length n= ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        int minIndex, tmp;

        for (int i = 0; i < n; i++)
        {
            Console.Write("[{0}] = ",i);
                arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arr.Length; i++)
        {
            minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                    minIndex = j;
            }
            if (minIndex != i)
            {
                tmp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = tmp;
                
            }
            Console.WriteLine(" {0}",arr[i]);
        }
    }
}


