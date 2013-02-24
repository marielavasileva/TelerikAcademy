using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main()
    {
        Console.Write("Enter the array dimention n= ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the number k= ");
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int minIndex, tmp;
        Console.WriteLine("Enter the elements of the array :");
        
        for (int i = 0; i < n; i++)
        {
            Console.Write("Array [{0}] = ", i);   
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {            
            Console.Write(" {0,3}  ", array[i]);
        }
        Console.WriteLine();
        Console.WriteLine("The sorted array is : ");

        for (int i = 0; i < array.Length; i++)
        {
            minIndex = i;

            for (int j = i + 1; j < n; j++)

                if (array[j] < array[minIndex])
                    minIndex = j;

            if (minIndex != i)
            {
                tmp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = tmp;

            }
            Console.Write(" {0,3} \n ", array[i]);
        }
        Console.WriteLine();

        int number = array[n - 1];

        int index = Array.BinarySearch(array, k);
        Console.WriteLine(number+"  "+index);

        if (number <= k)
        {
            Console.WriteLine("The maximal number is :" + number);
        }

        else 
        {
            Console.WriteLine("No such a number");
        }
               

        
    }
}

