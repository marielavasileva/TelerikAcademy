using System;



    class BinaryToHexadecimalNumber
    {
        static void Main()
        {
            Console.Write("Enter a binary number to convert : ");
            string binaryNumber = Console.ReadLine();
            string hexNumber;
            hexNumber=Convert.ToString(Convert.ToInt32(binaryNumber,2),16);
            Console.WriteLine("The hexadecimal number "+hexNumber);
        }
    }

