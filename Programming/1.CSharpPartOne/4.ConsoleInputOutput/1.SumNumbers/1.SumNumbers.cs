using System;



    class SumNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter first number:");
            string number=Console.ReadLine();
            int number1 = int.Parse(number);
            Console.WriteLine("Enter second number:");
            number = Console.ReadLine();
            int number2 = int.Parse(number);
            Console.WriteLine("Enter third number:");
            number = Console.ReadLine();
            int number3 = int.Parse(number);
            Console.WriteLine("the sum is {0} + {1} + {2} = {3}", number1, number2, number3, number1 + number2 + number3);

        }
    }

