using System;



    class PrintNumbers
    {
        static void Main()
        {
            string s = Console.ReadLine();
            int number = int.Parse(s);
            int i = 1;
            while (i<= number)
            {
                Console.WriteLine("Number : {0}",i);
                i++;
            }

        }
    }

