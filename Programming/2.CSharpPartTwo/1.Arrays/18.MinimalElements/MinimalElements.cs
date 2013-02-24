


using System;
using System.Collections.Generic;

class RemainingIncreasingSortedArray
{
    static void Main()
    {
        int[] array = { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
        int length = (2 << array.Length - 1) - 1;
        List<int> sort = new List<int>();
        List<int> checker = new List<int>();
        int minValue;
        int counter = 0;
        int count = 0;

        for (int i = 0; i <= length; i++)
        {
            
            counter = 0;
            minValue = int.MinValue;
            for (int k = 0; k < array.Length; k++)
            {
                if ((((i >> k) & 1) == 1) && (minValue <= array[k]))
                {
                    minValue = array[k];
                    checker.Add(array[k]);
                    counter++;
                }
            }

            
            if (counter > count)
            {
                sort.Clear();
                count = counter;
                for (int k = 0; k < checker.Count; k++)
                {
                    sort.Add(checker[k]);
                }
            }
            checker.Clear();
        }

        
        for (int index = 0; index < sort.Count; index++)
        {
            Console.Write(sort[index] + " ");
        }
        Console.WriteLine();
    }
}