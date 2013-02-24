using System;



class DivisionByFive
{
    static void Main()
    {
        Console.Write("Enter the first number :");
        string s = Console.ReadLine();
        int firstNumber = int.Parse(s);
        Console.Write("Enter the second number : ");
        string s1 =Console.ReadLine();
        int secondNumber = int.Parse(s1);
        int counter = 0;
        int i;
        for (i = firstNumber; i <= secondNumber; i++)
        {
            if(i % 5 ==0)
            {
                counter++;
                Console.WriteLine("The numbers can be divided by 5 are : {0}",i);
            }
            
        }
        Console.WriteLine();
        Console.WriteLine("The count of the numbers are : {0}",counter);
    }


}


