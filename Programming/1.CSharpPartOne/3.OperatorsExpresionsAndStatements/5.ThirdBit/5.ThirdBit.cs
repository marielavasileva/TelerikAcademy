using System;



    class ThirdBit
    {
        static void Main()
        {
            string s=Console.ReadLine();
            int number = int.Parse(s);
            int check = 8;
            if ((number & check) != 0)
            {
                Console.WriteLine("The third bit is 1.");
            }
            else
            {
                Console.WriteLine("The third bit is 0. ");
            }
        }
    }

