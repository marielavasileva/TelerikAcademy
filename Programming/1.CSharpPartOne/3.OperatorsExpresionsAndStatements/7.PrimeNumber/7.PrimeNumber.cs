using System;



class PrimeNumber
{
    static void Main()
    {
        Console.WriteLine("Enter number between 1 and 100 !");
        string s = Console.ReadLine();
        int number = int.Parse(s);

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine("Your number is not prime");
                return;

            }
        }

        Console.WriteLine("Your number is prime");
    }
}


