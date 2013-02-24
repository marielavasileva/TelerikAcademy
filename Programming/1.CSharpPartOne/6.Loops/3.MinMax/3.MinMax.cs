using System;

class MinMax
{
    static void Main()
    {
        Console.Write("Enter the count of the numbers : ");
        string str = Console.ReadLine();
        int n = int.Parse(str);
        int max=int.MinValue;
        int min=int.MaxValue;
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Number {0} : ",i);
            int number = int.Parse(Console.ReadLine());
            if (number > max)
            {
                max = number;
            }
            if (number < min)
            {
                min = number;
            }
        }
        Console.Write("The min value is : {0} \n",min);
        Console.Write("The max value is : {0} \n",max);
    }
}