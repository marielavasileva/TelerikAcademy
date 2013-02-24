using System;


class MaximumSum
{
    static void Main()
    {
        Console.Write("Enter the array's lenght N= ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("K < N");
        Console.Write("Enter the number fo elements K= ");
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int last = 0;
        int bestSum = 0;
        int sum = 0;



        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Array [{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length -k+1; i++)
        {
            for (int j = i; j <k+i; j++)
            {
                sum = sum + array[j];

            }

            if (sum >= bestSum)
            {
                bestSum = sum;
                last = i;
                

            }
            sum = 0;
            
        }        

        for (int i = last ; i < last+k; i++)
        {
            Console.WriteLine("Array[{0}] = {1}", i, array[i]);
            }
            Console.WriteLine("Best sum : {0}", bestSum);
    

        

    }

}


