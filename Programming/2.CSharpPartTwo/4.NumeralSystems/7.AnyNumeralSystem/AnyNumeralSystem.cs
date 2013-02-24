using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter numeral system for the base :");
        int FROM_s = int.Parse(Console.ReadLine());
        Console.Write("Enter numeral system to be convertet into :");
        int TO_d = int.Parse(Console.ReadLine());
        Console.Write("Enter number :");
        string number = Console.ReadLine();
        StringBuilder destination = new StringBuilder();
        long dec = 0;
        int i, k = 0;
        for (i = number.Length - 1; i >= 0; i--)
        {
            if (number[i] >= '0' && number[i] <= '9')
            {
                dec += int.Parse(number[i].ToString()) * (int)Math.Pow(FROM_s, k);
                k++;
            }
            else
            {
                dec += (10 + number[i] - 'A') * (int)Math.Pow(FROM_s, k);
                k++;
            }
        }
        while (dec != 0)
        {
            if (dec % TO_d >= 0 && dec % TO_d <= 9)
            {
                destination.Append((dec % TO_d).ToString());
            }
            else
            {
                destination.Append((char)(dec % TO_d - 10 + 'A'));
            }
            dec /= TO_d;
        }
        char[] result = destination.ToString().ToArray();
        Array.Reverse(result);
        Console.Write("Result: ");
        foreach (var letter in result)
        {
            Console.Write(letter);
        }
        Console.WriteLine();

    }
}

