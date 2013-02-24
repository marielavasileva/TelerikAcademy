using System;



    class ArrayIntegers
    {
        static void Main()
        {

            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            int [] array= new int[n];

            for (int i = 0; i < n; i++)
            {
                
                Console.Write("Array [{0}] = ",i);
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                array[i] = 5*array[i];
                Console.WriteLine("New array [{0}] = {1}  ",i, array[i]);
                
            }
            


        }
    }

