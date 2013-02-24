using System;

class CompareArrays
{
    static void Main()
    {
        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());


        Console.Write("m=");
        int m = int.Parse(Console.ReadLine());
        int[] array1 = new int[m];
        int[] array = new int[n];


        for (int index = 0; index < n; index++)
        {
            Console.Write("First array n [{0}] = ", index);
            array[index] = int.Parse(Console.ReadLine());
        }


        for (int index1 = 0; index1 < m; index1++)
        {
            Console.Write("Second array m [{0}] = ", index1);
            array1[index1] = int.Parse(Console.ReadLine());
        }

        bool equal = array.Equals(array1);

        for (int index = 0; index < n; index++)
        {

            for (int index1 = 0; index1 < m; index1++)
            {
                if ((array[index]) == (array1[index1]))
                {
                    equal = true;
                    //Console.WriteLine(array[index]+" "+array1[index1]);
                }

                else
                {
                    equal = false;
                    //Console.WriteLine(array[index] + " " + array1[index1]);
                }
            }
        }
        Console.WriteLine("The arrays are equal : " + equal);
    }
}




