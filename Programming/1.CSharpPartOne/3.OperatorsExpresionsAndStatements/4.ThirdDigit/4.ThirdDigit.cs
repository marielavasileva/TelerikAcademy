using System;



    class ThirdDigit
    {
        static void Main()
        {
            string s = Console.ReadLine();
            const int num = 7;
            int number = int.Parse(s);
            int div100 = number / 100;
            int div10 = div100 % 10;
            if (div10 == num)
            {
                Console.WriteLine("The third digit of the number {0} is 7", number);
            }
            else
            {
                Console.WriteLine("The third digit of the number {0} is not 7",number);
            }
        }
    }

