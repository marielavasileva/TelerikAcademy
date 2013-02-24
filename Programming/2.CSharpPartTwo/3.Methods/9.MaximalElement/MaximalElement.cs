using System;

class Program
{
    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++) 
            Console.Write(arr[i] + (i == arr.Length - 1 ? "\n" : " "));
    }

    static void Replace(int[] arr, int i, int j)
    {
        int t = arr[i];
        arr[i] = arr[j];
        arr[j] = t;
    }

    
    static int BestPosition(int[] arr, int i, bool descend)
    {
        int best = i;

        for (int j = i + 1; j < arr.Length; j++)
            if (descend ? arr[j] < arr[best] : arr[best] < arr[j])
                best = j;

        return best;
    }

    static void SelectionSort(int[] arr, bool descending = false)
    {
        for (int i = 0; i < arr.Length; i++)
            Replace(arr, i, BestPosition(arr, i, descending));
    }

    static void Main()
    {
        int lenght=int.Parse(Console.ReadLine());
        int[] array = new int[lenght];
        for (int i = 0; i < lenght; i++)
        {
            Console.Write("{0} : ",i);
            array[i] = int.Parse(Console.ReadLine());
        }

        
        SelectionSort(array);
        PrintArray(array);

        
        SelectionSort(array, descending: true);
        PrintArray(array);
    }
}