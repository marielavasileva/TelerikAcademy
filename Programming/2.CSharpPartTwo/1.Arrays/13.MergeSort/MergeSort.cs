using System;
using System.Collections.Generic;

class MergeSort
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        List<int> array = new List<int>();
        
        for (int i = 0; i < length; i++)
        {    
                Console.Write("[{0}]",i);
                array.Add(int.Parse(Console.ReadLine())); 
            
        }

        
        List<int> sortedArray = MakeSort(array);

        
        foreach (int element in sortedArray)
        {
            Console.WriteLine(element);
        }

    }
    static List<int> MakeSort(List<int> array)
    {
        List<int> firstHalf = new List<int>();
        List<int> secondHalf = new List<int>();
        List<int> mergeList = new List<int>();
        if (array.Count > 1)
        {
            foreach (int element in array)
            {
                if (firstHalf.Count < array.Count / 2)
                {
                    firstHalf.Add(element);
                }
                else
                {
                    secondHalf.Add(element);
                }
            }
            List<int> firstSorted = MakeSort(firstHalf);
            List<int> secondSorted = MakeSort(secondHalf);
            mergeList = MergeLists(firstSorted, secondSorted);
        }
        else
        {
            mergeList.Add(array[0]);
        }
        return mergeList;
    }
    static List<int> MergeLists(List<int> first, List<int> second)
    {
        List<int> combineList = new List<int>();
        while ((first.Count > 0) && (second.Count > 0))
        {
            if (first[0] < second[0])
            {
                combineList.Add(first[0]);
                first.RemoveAt(0);
            }
            else
            {
                combineList.Add(second[0]);
                second.RemoveAt(0);
            }
        }
        foreach (int item in first)
        {
            combineList.Add(item);
        }
        foreach (int item in second)
        {
            combineList.Add(item);
        }
        return combineList;
    }
}