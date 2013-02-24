﻿using System;

class QuickSort
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] unsorted = new string[n];

        
        for (int i = 0; i < unsorted.Length; i++)
        {
            string str = Console.ReadLine();
            Console.Write(unsorted[i] + " ");
        }

        Console.WriteLine();

        
        Quicksort(unsorted, 0, unsorted.Length - 1);

       
        for (int i = 0; i < unsorted.Length; i++)
        {
            Console.Write(unsorted[i] + " ");
        }

        Console.WriteLine();
    }

    public static void Quicksort(string[] elements, int left, int right)
    {
        int i = left, j = right;
        string middle = elements[(left + right) / 2];
        
        while (i <= j)
        {
            while (elements[i].CompareTo(middle) < 0)
            {
                i++;
            }

            while (elements[j].CompareTo(middle) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                
                string tmp = elements[i];
                elements[i] = elements[j];
                elements[j] = tmp;

                i++;
                j--;
            }
        }

       
        if (left < j)
        {
            Quicksort(elements, left, j);
        }

        if (i < right)
        {
            Quicksort(elements, i, right);
        }
    }
}