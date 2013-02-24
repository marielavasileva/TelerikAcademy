using System;


    class GreaterNumbers

    {
        static void Main()
        {
            Console.Write("Enter first number : ");
            string s1 = Console.ReadLine();
            int firstNumber = int.Parse(s1);
            Console.Write("Enter second number : ");
            string s2 = Console.ReadLine();
            int secondNumber = int.Parse(s2);
            int biggerNumber = firstNumber;
            if ((firstNumber > secondNumber)&&(secondNumber!=0))
            {
                biggerNumber = secondNumber;

                Console.WriteLine("The greater number is : {0} " ,biggerNumber);                
            }
            else if ((secondNumber == 0)&&(secondNumber>firstNumber))
            {
                Console.WriteLine("The greater number is : {0} ", firstNumber);
            }
            else if (secondNumber==0)
            {
                Console.WriteLine("The greater number is : {0} ",firstNumber);
            }

            if (secondNumber > firstNumber)
            {
                Console.WriteLine("The greater number is : {0} ",secondNumber);
            }
            if (secondNumber == firstNumber)
            {
                Console.WriteLine("The numbers are equal {0} = {1}",firstNumber,secondNumber);
            }
        }
    }

