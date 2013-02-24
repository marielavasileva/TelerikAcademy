using System;



    class NumberCheck
    {
        static void Main()
        {
            string s = Console.ReadLine();
            int number=int.Parse(s)  ;
            

            if ((number % 5 == 0) && (number % 7 == 0))
            {
                Console.WriteLine("The number can be divided by 7 and 5.");
            }

            else
            {
                Console.WriteLine("The number can not be divided by 7 and 5.");
            }
        }
    }

