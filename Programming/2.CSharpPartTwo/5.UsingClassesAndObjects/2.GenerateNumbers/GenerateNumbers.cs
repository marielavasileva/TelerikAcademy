using System;


    class GenerateNumbers
    {
        static Random numberGenerator = new Random();
        static void Main()
        {
            for (int number = 1; number < 11; number++)
            {
                int randomNumber = numberGenerator.Next(100, 201);
                Console.WriteLine(" {0}  : {1} ",number,randomNumber);
            }
        }
    }

