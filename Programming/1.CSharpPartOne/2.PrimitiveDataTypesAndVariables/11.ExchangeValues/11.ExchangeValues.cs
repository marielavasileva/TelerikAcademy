using System;


    class ExchangeValues
    {
        static void Main()
        {
            int value1 = 5;
            int value2 = 10;
            int temp;
            Console.WriteLine("Before exchange "+value1+" "+value2);
            value1 = value2;
            value2 = temp=5;
            temp = value2;
            Console.WriteLine("After exchange "+value1+" "+ value2);
        }
    }

