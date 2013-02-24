using System;



    class IncreasingSequence
    {
        static void Main()
        {
            Console.Write("Enter the array length n= ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int arrayLen = array.Length - 1;
            int start=0;
            int len=1;
            int  bestLen = 0;
            
            

            for (int i = 0; i < n; i++)
            {
                Console.Write("Array [{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < arrayLen; i++)
            {
                if (array[i+1] == (array[i]+1))
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

            int[] newArray = new int[bestLen];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = start - i;
            }

            for (int i = newArray.Length-1; i >=0 ; i--)
            {
                Console.Write(""+newArray[i] + " ");
            }
                }
            }
        
    

