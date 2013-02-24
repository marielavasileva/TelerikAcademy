using System;


class SubsetSumsElements
{
    static void Main(string[] args)
    {
        long s = long.Parse(Console.ReadLine());
        byte n = byte.Parse(Console.ReadLine());
        byte k = byte.Parse(Console.ReadLine());

        int count = 0;
        long[] array = new long[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = long.Parse(Console.ReadLine());
        }

        for (int i = 1; i < Math.Pow(2, n); i++)
        {
            char[] binaryCharArray = Convert.ToString(i, 2).PadLeft(n).ToCharArray();
            long subsetSum = 0;
            count = 0;
            for (int j = 0; j < binaryCharArray.Length; j++)
            {
                if (binaryCharArray[j] == '1')
                {
                    subsetSum += array[j];
                    count++;
                }
            }
            if (subsetSum == s && count == k)
            {
                for (int j = 0; j < binaryCharArray.Length; j++)
                {
                    if (binaryCharArray[j] == '1')
                    {
                        Console.Write(array[j] + " ");
                    }
                }
                Console.Write("= {0} There is subset even to number \"s\" formed by \"k\"  elements.", s);
                Console.WriteLine();
            }

        }
    }

}