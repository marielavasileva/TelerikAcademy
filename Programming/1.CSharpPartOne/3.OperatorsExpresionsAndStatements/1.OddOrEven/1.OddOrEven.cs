using System;



    class OddOrEven
    {
        static void Main()
        {
            Console.WriteLine("Enter the number to check weather is odd or even: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }

            else
            {
                Console.WriteLine("The number is odd");
            }


        }
    }

