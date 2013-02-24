
using System;

    class CompareCharArrays
    {
        static void Main()
        {
            Console.Write("Enter the first char : ");
            string firstStr = Console.ReadLine();
            char[] first = firstStr.ToCharArray();

            Console.Write("Enter the second char : ");
            string secondStr = Console.ReadLine();
            char[] second = secondStr.ToCharArray();

            int firstLength = first.Length;
            int secondLength = second.Length;
            int minLength;
            int smallerArray = 0;

            if (first.Length <= second.Length)
            {
                minLength = first.Length;
            }

            else
            {
                minLength = second.Length;
            }

            for (int i = 0; i < minLength; i++)
            {
                if (first[i] < second[i])
                {
                    smallerArray = -1;
                    break;
                }

                else if (first[i] > second[i])
                {
                    smallerArray = 1;
                    break;
                }

            }

            if (smallerArray == -1)
            {
                Console.WriteLine("The first one is earlier.");
            }
            else if (smallerArray == 1)
            {
                Console.WriteLine("The second one is earlier.");
            }

            else
            {
                if (first.Length > second.Length)
                {
                    Console.WriteLine("The second array is earlier.");
                }
                else if (first.Length < second.Length)
                {
                    Console.WriteLine("The first array is earlier.");
                }
                else
                {
                    Console.WriteLine("The two arrays are the same.");
                }
            }


        }

        
    }

