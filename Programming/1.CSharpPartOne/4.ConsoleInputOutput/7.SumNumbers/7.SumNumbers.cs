using System;



class SumNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter how many numbers do you want to sum");
        Console.Write("n=");
        string s = Console.ReadLine();
        uint n = uint.Parse(s);
        int sum = 0;
        for (uint i = 1; i <= n; i++)
        {
            Console.Write("Number {0} : ",i);
            int number = int.Parse(Console.ReadLine());
            sum += number;
            
        }
        Console.Write("The sum of the numbers is : {0}  ",sum);
    }

}

