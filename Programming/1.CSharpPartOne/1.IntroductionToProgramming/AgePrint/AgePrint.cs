using System;



class AgePrint

{
    static void Main()
    {
        Console.Write("Enter your age : ");
        int age = int.Parse(Console.ReadLine());
        int newAge;
        newAge = age + 10;
        Console.WriteLine("Your age after 10 years is : " + newAge);
    }
}

