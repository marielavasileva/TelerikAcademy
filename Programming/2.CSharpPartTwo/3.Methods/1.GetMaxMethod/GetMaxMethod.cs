using System;


    class GetMaxMethod
    {
        static int GetMax(int firstNamber , int secondNumber)
        {
           int number= Math.Max(firstNamber, secondNumber);
           return number;
        }

        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int max;
            GetMax(a, b);

            max=Math.Max(a,b);
            max = Math.Max(max, c);
            Console.WriteLine(max);


        }
    }

