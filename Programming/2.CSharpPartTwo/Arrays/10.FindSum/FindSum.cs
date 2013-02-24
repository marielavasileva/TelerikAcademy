

using System;

class FindSum
{
    static void Main()
    {
        int  SumNum = 0, tempSum = 0, start = 0, end = 0;

        Console.Write("Enter the length of the array N: ");        
        int length = int.Parse(Console.ReadLine());

        Console.Write("Enter the sum S: ");   
        int sum = int.Parse(Console.ReadLine());

        int[] array = new int[length];

        for (int i = 0; i < length;i++ )
        {
            Console.Write("{0} :  ", i);            
            array[i] = int.Parse(Console.ReadLine());
            
        }

        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                if (i + j < length)                 
                {
                    tempSum = tempSum + array[i + j];   

                    if (tempSum == sum)                
                    {
                        start = i;              
                        end = i + j;            
                        SumNum++;            

                        Console.Write("\n Sum elements are: ");
                        for (int k = start; k <= end; k++)
                        {
                            Console.Write("{0}; ", array[k]);
                        }
                    }
                }
            }
            tempSum = 0; 
        }
        Console.Write("\nS sum number is: {0}\n", SumNum);
    }
}