using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using System.Text;


class Factorial
{

    public static void CalculateFactorial(ref BigInteger[] facArray, int number)
    {
        facArray[number] = facArray[number - 1] * (number + 1);
    }

    static void Main()
    {
        Console.Write("Enter a number to calculate factorial : ");
        int length = int.Parse(Console.ReadLine());
        BigInteger[] factorialNum = new BigInteger[length];
        factorialNum[0] = 1;
        for (int i = 1; i < length; i++)
        {
            CalculateFactorial(ref factorialNum, i);
        }

        for (int i = 0; i < factorialNum.Length; i++)
        {
            Console.Write("Factorial of {0} is {1}", i + 1, factorialNum[i]);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}


