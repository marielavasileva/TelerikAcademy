using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class SieveEratosthenes
{
    static void Main(string[] args)
    {
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];


        int random = 0;
        for (int index = 0, number = 1; index < arr.Length; index++, number++)
        {
            arr[index] = number;
        }
        for (int i = 2; i <= 7; )
        {
            random = i;
            while (random < length)
            {
                if (arr[random] % i == 0)
                {
                    arr[random] = 0;
                }
                random++;
            }
            if (i == 2)
            {
                i++;
            }
            else
            {
                i += 2;
            }
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                Console.Write("{0} ", arr[i]);
            }
        }

    }
}
