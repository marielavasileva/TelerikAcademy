using System;



    class DivisibleNumbers
    {
        static void Main()
        {
            string s=Console.ReadLine();
            int counter = int.Parse(s);
            for (int  number= 1; number <= counter; number++)
            {
                if ((number % 5 != 0) && (number % 7 != 0))
                {
                    Console.WriteLine("The number is : {0}",number);
                }
            }
        }
    }

