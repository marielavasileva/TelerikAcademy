using System;


class MaximalSequence
{
    static void Main()
    {
        Console.Write("Enter the array length n= ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        int start = 0;
        int len = 1;
        int arrayLen = array.Length-1;
        int bestLen = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Array [{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());

        }

        for (int i = 0; i < arrayLen; i++)
        {
            if (array[i] == array[i + 1])
            {
                len++;
            }

            else
            {
                if (len > bestLen)
                {
                    bestLen = len;
                    start = array[i];

                }
                len = 1;

            }
        }

        if (len > bestLen)
        {
            bestLen = len;
            start = array[arrayLen];

        }

        Console.WriteLine("The most frequent element is {0} -> {1} times ", start, bestLen);

    }
}

