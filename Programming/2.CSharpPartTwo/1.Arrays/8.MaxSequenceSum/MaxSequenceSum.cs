using System;

class MaxSequenceSum
{
    static void Main()
    {
        Console.WriteLine("Enter arr length:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Array [{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        int sum = array[0], maxSum = array[0];
        int longSeq = 1, currentSeq = 1;
        int start = 0, startTemp = 0;

        
        for (int i = 1; i < array.Length; ++i)
        {
            if (array[i] + maxSum > array[i])
            {
                maxSum = array[i] + maxSum;
                currentSeq++;
            }

            else
            {
                maxSum = array[i];
                startTemp = i;
                currentSeq = 1;
            }
            if (maxSum > sum)
            {
                sum = maxSum;
                longSeq = currentSeq;
                start = startTemp;
            }
        }
        Console.WriteLine("The new array : ");
        
        for (int i = start; i < start + longSeq; ++i)
        {
            Console.Write("{0} ", array[i]);
        }
    }
}