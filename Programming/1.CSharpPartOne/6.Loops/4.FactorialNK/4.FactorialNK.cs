using System;



class FactorialNK
{
    static void Main()
    {
        Console.Write("N= ");
        string nStr = Console.ReadLine();
        int n = int.Parse(nStr);
        Console.Write("K= ");
        string kStr = Console.ReadLine();
        int k = int.Parse(kStr);
        decimal factorial = 1;
        if (n >= k)
        {
            for (int i = (k + 1); i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("N!/K! = {0}",factorial);
        }
        else
        {
            Console.WriteLine("N must be bigger than K !");
        }






    }
}

