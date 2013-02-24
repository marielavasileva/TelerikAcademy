using System;
using System.Linq;

class MultriFunctionWithArrays
{
    static decimal[] EnteredIndexInArr(decimal[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {

            decimal num = decimal.Parse(Console.ReadLine());
            arr[i] = num;
        }
        Array.Reverse(arr);
        return arr;
    }

    static decimal[] SumTwoArrays(decimal[] arr1, decimal[] arr2)
    {

        int biggerLength = arr1.Length;
        int smallerLength = arr2.Length;

        if (arr2.Length > arr1.Length)
        {
            biggerLength = arr2.Length;
            smallerLength = arr1.Length;
        }

        decimal[] sumArr = new decimal[biggerLength];

        for (int i = 0; i < biggerLength; i++)
        {
            if (i > smallerLength - 1)
            {
                sumArr[i] = arr1.Length > arr2.Length ? arr1[i] : arr2[i];
            }
            else
            {
                sumArr[i] = arr1[i] + arr2[i];
            }

        }
        return sumArr;
    }
      

    static string ReturnPositiveSign(decimal[] arr, int i)
    {
        if (arr[i] > 0 && arr.Length - 1 != i)
        {
            string signPlus = "+";
            return signPlus;
        }
        else
        {
            return string.Empty;
        }
    }

    static void PrintPolynom(decimal[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] != 0)
            {
                if (i != 0 && i != 1)
                {
                    Console.Write(" {2}{0:F1}x^{1}", arr[i], i, ReturnPositiveSign(arr, i));
                }
                else if (i == 1)
                {
                    Console.Write(" {1}{0:F1}x", arr[i], ReturnPositiveSign(arr, i));

                }
                else if (i == 0)
                {
                    Console.Write(" {1}{0:F1}", arr[i], ReturnPositiveSign(arr, i));
                }
            }
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Enter rank of your 1 polynom:");
        int rank = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient from higest to smallest [x^2 => x^0]:");
        decimal[] arr1 = new decimal[rank + 1];
        EnteredIndexInArr(arr1);

        Console.Write("Enter rank of your 2 polynom:");
        rank = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient from higest to smallest [x^2 => x^0]:");
        decimal[] arr2 = new decimal[rank + 1];
        EnteredIndexInArr(arr2);
        Console.WriteLine();
        Console.WriteLine();

        Console.Write("Array 1: ");
        PrintPolynom(arr1);
        Console.Write("Array 2: ");
        PrintPolynom(arr2);
        Console.WriteLine();

        Console.Write("Sum:                     ");
        PrintPolynom(SumTwoArrays(arr1, arr2));


        

       
        Console.WriteLine();
        Console.WriteLine();
    }
}